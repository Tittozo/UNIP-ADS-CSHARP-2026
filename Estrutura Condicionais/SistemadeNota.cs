using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("--- Portal do Aluno ---");
        Console.Write("Digite a nota final (0 a 10): ");
        
        // Convertendo a entrada do usuário para double
        double nota = Convert.ToDouble(Console.ReadLine());

        // Estrutura Condicional
        if (nota >= 7.0)
        {
            Console.WriteLine("Status: Aprovado! Parabéns pelo esforço.");
        }
        else if (nota >= 5.0 && nota < 7.0)
        {
            Console.WriteLine("Status: Recuperação. Ainda há uma chance!");
        }
        else if (nota < 0 || nota > 10)
        {
            Console.WriteLine("Erro: Nota inválida. Digite um valor entre 0 e 10.");
        }
        else
        {
            Console.WriteLine("Status: Reprovado. Vamos estudar mais no próximo semestre.");
        }

        Console.WriteLine("-----------------------");
    }
}
