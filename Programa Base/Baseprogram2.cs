using System;

namespace Aula1
{
    internal class Program
    {
        private static void Main(string[]args)
        {
            decimal var1 = 12.5m;
            double var2 = 127.8;

            var1 = Convert.ToDecimal(var2);
            int var3 = Convert.ToInt32(var2);
            Console.WriteLine(var3);
            Console.WriteLine(var1);

            //OUTRO EXEMPLO

            string nome = "Mateus";
            int idade = 19;
            double altura = 1.62;

            Console.Write("Meu nome é: ");
            Console.Write(nome);
            Console.Write("Eu tenho:");
            Console.Write(idade);
            Console.Write("anos e minha altura é:");
            Console.Write(altura);

            Console.WriteLine("Meu nome é {0}, eu tenho {1} anos e minha altura é {2}", nome, idade, altura);

            Console.WriteLine("Digite seu nome: ");
            string nome2 = Console.ReadLine();
            Console.WriteLine("Digite sua idade: ");
            int idade2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(idade);

            Console.Write(nome2);
        }
    }
}
