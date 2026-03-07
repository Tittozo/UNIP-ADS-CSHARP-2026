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

using System;

namespace MeuPrimeiroPrograma
{
    class Program
    {
        static void Main(string[] args)
        {
            // Mostra uma mensagem na tela
            Console.WriteLine("Olá! Bem-vindo ao mundo do C#.");

            // Pede para o usuário digitar algo
            Console.Write("Qual é o seu nome? ");
            
            // Lê o que o usuário digitou e guarda na variável 'nome'
            string nome = Console.ReadLine();

            // Usa a variável para dar um cumprimento personalizado
            Console.WriteLine($"Prazer em conhecer você, {nome}!");
        }
    }
}


using System; // Importa as ferramentas básicas do sistema

namespace MeuPrimeiroProjeto
{
    class Program
    {
        // O "Main" é o ponto de entrada. Tudo começa por aqui!
        static void Main(string[] args)
        {
            // 1. O computador exibe uma mensagem
            Console.WriteLine("Olá! Eu sou o seu computador. Qual é o seu nome?");

            // 2. O computador cria uma "caixa" (variável) para guardar o que você digitar
            string nomeUsuario = Console.ReadLine();

            // 3. O computador processa e responde usando o que guardou
            Console.WriteLine("É um prazer te conhecer, " + nomeUsuario + "!");

            // 4. Um pequeno cálculo para mostrar a lógica
            Console.WriteLine("Em que ano você nasceu?");
            int anoNascimento = int.Parse(Console.ReadLine());
            int idade = 2026 - anoNascimento;

            Console.WriteLine("Entendi! Então você tem (ou vai fazer) " + idade + " anos.");

            // 5. Evita que o programa feche sozinho imediatamente
            Console.WriteLine("\nPressione qualquer tecla para sair...");
            Console.ReadKey();
        }
    }
}
