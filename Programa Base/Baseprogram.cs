using System;

namespace Aula1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}

//TESTANDO TIPOS DE DADOS

using System;

namespace Aula1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            int valor = 1987;
            float valorfloat = 3.14f;
            double valordouble = 3.14159265;
            string nome = "Mateus";
            char Letra = 'M';
            long valorlong = 123123123L;

            Console.WriteLine(valor);
            Console.WriteLine(nome);
            Console.WriteLine(Letra);
            Console.WriteLine(valorlong);
            Console.WriteLine(valorfloat);
            Console.WriteLine(valordouble);
        }
    }
}

//EXEMPLO BÁSICO 

using System;

namespace ExemploSimples
{
    class Program
    {
        static void Main(string[] args)
        {
            // Exibe uma mensagem na tela perguntando o nome
            Console.WriteLine("Olá! Qual é o seu nome?");
            
            // Lê o que o usuário digita e guarda na variável 'nome'
            string nome = Console.ReadLine();

            // Usa interpolação de string ($"...") para juntar o texto com a variável
            Console.WriteLine($"Muito prazer em te conhecer, {nome}!");
            
            // Pausa o programa para que a janela não feche imediatamente
            Console.WriteLine("\nPressione qualquer tecla para sair...");
            Console.ReadKey();
        }
    }
}
