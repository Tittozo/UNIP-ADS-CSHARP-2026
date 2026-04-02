namespace Fipe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=================== Cadastrar Veículo ===================");
            Console.WriteLine("Selecione o veículo desejado:");
            Console.WriteLine("1 - Carro");
            Console.WriteLine("2 - Moto");
            Console.WriteLine("3 - Caminhão");
            Console.ReadLine();
            int op = int.Parse(Console.ReadLine());
            if(op == 1)
            {
                Console.WriteLine("Qual a marca do carro: ");
                string marca = Console.ReadLine();
                Console.WriteLine("Qual o modelo do carro: ");
                string modelo = Console.ReadLine();
                Console.WriteLine("Qual a FIPE do carro: ");
                double preco = double.Parse(Console.ReadLine());
                Console.WriteLine("Qual o número de portas: ");
                int numero = int.Parse(Console.ReadLine());

                Carro c1 = new Carro(marca, modelo, preco, numero);
                
                Console.WriteLine("");
                Console.WriteLine("======== Dados Carro ========");
                c1.ExibirDados();
            }
            else if (op == 2)  
            {
                Console.WriteLine("Não implementado");
            }
            else if (op == 3)
            {
                Console.WriteLine("Não implementado");
            }
        }
    }
}

