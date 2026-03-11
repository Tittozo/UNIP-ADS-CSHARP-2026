using System.Reflection.Metadata.Ecma335;

namespace ContaBancária
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nomeTitularC1 = "Mateus Antunes";
            string cpfC1 = "123.456.789-78";
            double saldoC1 = 2500;

            string nomeTitularC2 = "Paloma Da Silva";
            string cpfC2 = "987.654.321-12";
            double saldoC2 = 3400;

            saldoC1 = Depósito(saldoC1, 500);

            Console.WriteLine(saldoC1);


        }

        static double Depósito(double saldo, double valor)
        {
            return saldo += valor;

        }

        static double Saque(double saldo, double valor)
        {
            if (saldo > valor)
            {
                return saldo -= valor;
            }
            else
            {
                return saldo;
            }

        }
    }
}
