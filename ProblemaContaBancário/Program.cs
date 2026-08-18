namespace ProblemaContaBancariaPoo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Criando os objetos
            Conta c1 = new Conta("Lucas Teodoro", "380.047.889-87", 2500);
            Conta c2 = new Conta("Maria Carolina Alves", "789.047.889-78", 5200);

            c1.SetNomeTitular("Mateus Vinicius");
            Console.WriteLine(c1.GetNomeTitular());

            //c1._idade = -5;

            Console.WriteLine(_idade);
            // Se eu não tivesse um construtor inicializando meus atributos, eu poderia inicializá-los dessa maneira "nomeDoObjeto.atributo"
            /*c1.NomeTitular = "Lucas Teodoro";
            c1.Cpf = "380.047.897-87";
            c1.Saldo= 2500.00;*/

            // Realizando as operações de deposito e saque na conta 1
            c1.Depositar(300);
            c1.Depositar(300);
            c1.Sacar(500);

            // Realizando as operações de deposito e saque na conta 2
            c2.Depositar(100);
            c2.Depositar(10);
            c2.Sacar(2300);

            // Imprimindo os dados da conta e valor de saldo atualizado
            Console.WriteLine($"Dados da Conta 1: {c1._nomeTitular}, CPF: {c1._Cpf}, Saldo: {c1.Saldo}.");
            Console.WriteLine($"Dados da Conta 2: {c2._nomeTitular}, CPF: {c2._cpf}, Saldo: {c2.Saldo}.");

        }
    }
}

