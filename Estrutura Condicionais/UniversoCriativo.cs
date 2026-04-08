using System;
using System.Threading;

namespace UniversoCriativo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Configura o título e esconde o cursor piscando
            Console.Title = "🌌 Universo em Expansão 🌌";
            Console.CursorVisible = false;
            Console.Clear();

            Console.WriteLine("Preparando o motor de dobra espacial...");
            Console.WriteLine("Pressione QUALQUER TECLA a qualquer momento para voltar à Terra.");
            Thread.Sleep(3000); // Pausa por 3 segundos antes de começar
            Console.Clear();

            Random geradorAleatorio = new Random();

            // Arrays com os tipos de estrelas e cores que vamos usar
            string[] estrelas = { ".", "*", "+", "o", "°", "✧", "★", "✨" };
            ConsoleColor[] cores = { ConsoleColor.DarkGray, ConsoleColor.Gray, ConsoleColor.White, ConsoleColor.Cyan, ConsoleColor.Blue, ConsoleColor.DarkBlue };

            // Pega o tamanho atual da janela do console
            int largura = Console.WindowWidth;
            int altura = Console.WindowHeight;

            // O loop continua rodando ENQUANTO nenhuma tecla for pressionada
            while (!Console.KeyAvailable)
            {
                // Escolhe uma posição X e Y aleatória na tela
                int x = geradorAleatorio.Next(0, largura);
                int y = geradorAleatorio.Next(0, altura);

                // Sorteia o formato e a cor da estrela
                string formatoEstrela = estrelas[geradorAleatorio.Next(estrelas.Length)];
                Console.ForegroundColor = cores[geradorAleatorio.Next(cores.Length)];

                try
                {
                    // Move o "lápis" (cursor) para a posição sorteada e desenha a estrela
                    Console.SetCursorPosition(x, y);
                    Console.Write(formatoEstrela);
                }
                catch (ArgumentOutOfRangeException)
                {
                    // Esse try/catch impede que o programa quebre se você redimensionar a janela enquanto ele roda
                }

                // Uma pequena pausa de 10 milissegundos para criar um efeito suave de "surgimento"
                Thread.Sleep(10);
            }

            // Quando o usuário apertar alguma
