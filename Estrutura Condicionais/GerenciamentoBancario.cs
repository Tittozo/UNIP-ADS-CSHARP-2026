using System;
using System.Collections.Generic;

namespace GerenciamentoBancario
{
    // Classe que representa o molde de uma conta
    class ContaBancaria
    {
        public int Numero { get; set; }
        public string Titular { get; set; }
        public double Saldo { get; private set; } // Saldo só pode ser alterado por métodos internos

        public ContaBancaria(int numero, string titular)
        {
            Numero = numero;
            Titular = titular;
            Saldo = 0.0;
        }

        public void Depositar(double valor)
        {
            if (valor > 0)
            {
                Saldo += valor;
                Console.WriteLine($"Depósito de R$ {valor:F2} realizado com sucesso!");
            }
            else
            {
                Console.WriteLine("Valor de depósito inválido.");
            }
        }

        public void Sacar(double valor)
        {
            if (valor > 0 && Saldo >= valor)
            {
                Saldo -= valor;
                Console.WriteLine($"Saque de R$ {valor:F2} realizado com sucesso!");
            }
            else
            {
                Console.WriteLine("Saldo insuficiente ou valor inválido.");
            }
        }
    }

    // Programa principal
    class Program
    {
        static void Main(string[] args)
        {
            List<ContaBancaria> contas = new List<ContaBancaria>();
            bool executando = true;

            while (executando)
            {
                Console.WriteLine("\n=== Banco C# ===");
                Console.WriteLine("1 - Cadastrar Conta");
                Console.WriteLine("2 - Listar Contas");
                Console.WriteLine("3 - Realizar Depósito");
                Console.WriteLine("4 - Realizar Saque");
                Console.WriteLine("5 - Sair");
                Console.Write("Escolha uma opção: ");
                
                string opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                        if (contas.Count >= 3)
                        {
                            Console.WriteLine("Limite de 3 contas atingido!");
                        }
                        else
                        {
                            Console.Write("Número da conta: ");
                            int numero = Convert.ToInt32(Console.ReadLine());
                            Console.Write("Nome do titular: ");
                            string titular = Console.ReadLine();
                            
                            contas.Add(new ContaBancaria(numero, titular));
                            Console.WriteLine("Conta cadastrada com sucesso!");
                        }
                        break;

                    case "2":
                        Console.WriteLine("\n--- Contas Cadastradas ---");
                        if (contas.Count == 0) Console.WriteLine("Nenhuma conta cadastrada.");
                        foreach (var conta in contas)
                        {
                            Console.WriteLine($"Conta: {conta.Numero} | Titular: {conta.Titular} | Saldo: R$ {conta.Saldo:F2}");
                        }
                        break;

                    case "3":
                        Console.Write("Digite o número da conta para depósito: ");
                        int numDep = Convert.ToInt32(Console.ReadLine());
                        ContaBancaria contaDep = contas.Find(c => c.Numero == numDep);
                        
                        if (contaDep != null)
                        {
                            Console.Write("Valor a depositar: R$ ");
                            double valorDep = Convert.ToDouble(Console.ReadLine());
                            contaDep.Depositar(valorDep);
                        }
                        else
                        {
                            Console.WriteLine("Conta não encontrada.");
                        }
                        break;

                    case "4":
                        Console.Write("Digite o número da conta para saque: ");
                        int numSaq = Convert.ToInt32(Console.ReadLine());
                        ContaBancaria contaSaq = contas.Find(c => c.Numero == numSaq);
                        
                        if (contaSaq != null)
                        {
                            Console.Write("Valor a sacar: R$ ");
                            double valorSaq = Convert.ToDouble(Console.ReadLine());
                            contaSaq.Sacar(valorSaq);
                        }
                        else
                        {
                            Console.WriteLine("Conta não encontrada.");
                        }
                        break;

                    case "5":
                        executando = false;
                        Console.WriteLine("Encerrando o sistema...");
                        break;

                    default:
                        Console.WriteLine("Opção inválida!");
                        break;
                }
            }
        }
    }
}
