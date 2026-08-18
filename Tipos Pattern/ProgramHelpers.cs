namespace TypePatternV2
{
    internal static class ProgramHelpers
    {
        static void Main(string[] args)
        {
            //Type Pattern - V2
            Desenvolvedor dev = new Desenvolvedor("Joao", 30, "C#", 3);
            Estagiario est = new Estagiario("Maria", 22, 40);
            Gerente gen = new Gerente("Gabriel", 40, 10);


            Console.WriteLine(VerificarStatus(404));

            Console.WriteLine(VerficarAnosDeExperiencia(dev.AnosExperiencia));

            Console.WriteLine(ClassificarExperiencia(dev.AnosExperiencia));

            Console.WriteLine(ClassificacaoFuncionario(gen));

            Console.WriteLine(ClassificacaoFuncionario(dev));

            Console.WriteLine(ClassificarFuncionarioPropriedade(dev));

            Console.WriteLine(Processar("maiusculo", "mateus")); 
        }
        //Constant Pattern
        static string VerificarStatus(int status)
        {
            string resultado = status switch
            {
                0 => "Status Nulo",
                1 => "Operacao Pendente",
                2 => "Operacao Cancelada",
                200 => "Operacao Concluida com Sucesso",
                404 => "Página não encontrada",
                _ => "Status não Reconhecido"
            };



            return resultado;
        }

        //Relational Pattern
        static string VerficarAnosDeExperiencia(int anos)
        {
            return anos switch
            {

                < 2 => "Desenvolvedor Iniciante",
                < 5 => "Desenvolvedor Intermediário",
                >= 5 => "Desenvolvedor Experiente"
                

            };
        }

        //Logical Pattern
        static string ClassificarExperiencia(int anos)
        {
            return anos switch
            {
                < 0 or > 10 => "Valor Fora da Faixa Esperado",
                >= 0 and < 2 => "Desenvolvedor Iniciante",
                >= 2 and < 5 => "Desenvolvedor Intermediário",
                >= 5 and < 10 => "Desenvolvedor Experiente"


            };
        }
        //Guarda When
        static string ClassificacaoFuncionario(object obj)
        {
            return obj switch
            {
                Desenvolvedor dev when dev.AnosExperiencia is > 0 and < 3 => $"{dev.Nome} é um desenvolvedor(a) Iniciante",
                Desenvolvedor dev when dev.AnosExperiencia is >= 3 and < 5 => $"{dev.Nome} é um desenvolvedor(a) Intermediário",
                Desenvolvedor dev when dev.AnosExperiencia is >= 5 and < 10 => $"{dev.Nome} é um desenvolvedor(a) Experiente",
                Gerente gen when gen.TamanhoEquipe is > 10 => $"{gen.Nome} é um gerente(a) de Grande Equipe",
                _ => "Funcionário não classificado"

            };
        }

        //Property Pattern

        static string ClassificarFuncionarioPropriedade(Funcionario fun)
        {
            return fun switch
            {
                Desenvolvedor { Linguagem: "C#", AnosExperiencia: >= 5} =>
                $"Desenvolvedor experiente em C#",
                _ => "Objeto Não Classificado"
                   
            };
        }
        //Positional Pattern

        static string Processar (object operacao, object valor)
        {
            return (operacao, valor) switch
            {
                ("Dobrar", int numero) => $"Dobro = {numero * 2}",
                ("Maiusculo", string palavra) => $"{palavra.ToUpper()}",
                _=> "TuplaNãoReconhecida"
            };
        }
    }
}
