using System;

class Program
{
    static void Main()
    {
        // 1. Entrada de dados
        Console.WriteLine("--- Sistema de Compras ---");
        Console.Write("Digite o valor da sua compra: R$ ");
        
        // Lê o que o usuário digitou e converte para decimal
        double valorCompra = double.Parse(Console.ReadLine());

        double valorFinal;
        string mensagem;

        // 2. Estrutura Condicional
        if (valorCompra >= 500)
        {
            // 20% de desconto para compras acima de 500
            valorFinal = valorCompra * 0.80;
            mensagem = "Parabéns! Você ganhou 20% de desconto.";
        }
        else if (valorCompra >= 200)
        {
            // 10% de desconto para compras entre 200 e 499
            valorFinal = valorCompra * 0.90;
            mensagem = "Muito bem! Você ganhou 10% de desconto.";
        }
        else
        {
            // Sem desconto para valores menores
            valorFinal = valorCompra;
            mensagem = "Compras abaixo de R$ 200 não possuem desconto no momento.";
        }

        // 3. Saída de resultados
        Console.WriteLine("--------------------------");
        Console.WriteLine(mensagem);
        Console.WriteLine($"Valor original: R$ {valorCompra:F2}");
        Console.WriteLine($"Valor a pagar: R$ {valorFinal:F2}");
        Console.WriteLine("--------------------------");
        
        // Mantém o console aberto até você pressionar uma tecla
        Console.WriteLine("Pressione qualquer tecla para sair...");
        Console.ReadKey();
    }
}
