using System;

namespace SistemaAvaliacao
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. DECLARAÇÃO DE VARIÁVEIS
            // Usamos 'string' para texto (nome) e 'double' para números que podem ter casas decimais (notas e frequência)
            string nome;
            double nota1, nota2, media, frequencia;

            // 2. ENTRADA DE DADOS
            // Solicita o nome do aluno e lê o que o usuário digitar
            Console.Write("Digite o nome do aluno: ");
            nome = Console.ReadLine();

            // Solicita a primeira nota. 
            // Como Console.ReadLine() lê como texto (string), usamos Convert.ToDouble() para transformar em número
            Console.Write("Digite a primeira nota: ");
            nota1 = Convert.ToDouble(Console.ReadLine());

            // Solicita a segunda nota e converte para double
            Console.Write("Digite a segunda nota: ");
            nota2 = Convert.ToDouble(Console.ReadLine());

            // Solicita o percentual de frequência
            Console.Write("Digite o percentual de frequência (ex: 80 para 80%): ");
            frequencia = Convert.ToDouble(Console.ReadLine());

            // 3. PROCESSAMENTO (CÁLCULOS)
            // Calcula a média somando as duas notas e dividindo por 2.
            // Os parênteses garantem que a soma seja feita antes da divisão.
            media = (nota1 + nota2) / 2;

            // 4. SAÍDA DE DADOS INICIAIS
            // \n pula uma linha para deixar a exibição mais limpa no console
            Console.WriteLine($"\n--- Resultados do Aluno: {nome} ---");
            // Exibe a média formatada com duas casas decimais usando :F2
            Console.WriteLine($"Média Final: {media:F2}");
            Console.WriteLine($"Frequência: {frequencia}%");

            // 5. ESTRUTURA CONDICIONAL (REGRAS DE NEGÓCIO)
            // Primeiro, verificamos a regra mais eliminatória: a frequência.
            if (frequencia < 75)
            {
                // Se a frequência for menor que 75%, reprova direto, independente da nota.
                Console.WriteLine("Situação Final: Reprovado por falta.");
            }
            else 
            {
                // Se o aluno tem frequência suficiente, vamos analisar a nota.
                if (media >= 7.0)
                {
                    // Média 7 ou mais = Aprovado
                    Console.WriteLine("Situação Final: Aprovado!");
                }
                else if (media >= 5.0)
                {
                    // Média entre 5.0 e 6.9 = Recuperação
                    Console.WriteLine("Situação Final: Em Recuperação.");
                }
                else
                {
                    // Média menor que 5.0 = Reprovado por nota
                    Console.WriteLine("Situação Final: Reprovado por nota.");
                }
            }
            
            // Pausa o programa para que a tela não feche imediatamente (útil em algumas IDEs)
            Console.ReadKey();
        }
    }
}
