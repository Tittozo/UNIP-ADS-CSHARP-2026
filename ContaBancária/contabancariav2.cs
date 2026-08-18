using System;

namespace BancoIniciante
{
    class Program
    {
        static void Main(string[] args)
        {
            // Arrays para guardar as informações de até 3 contas
            int[] numeros = new int[3];
            string[] titulares = new string[3];
            double[] saldos = new double[3];

            int totalContas = 0; // Conta quantas contas já foram criadas
            int opcao = 0; // Guarda a opção do menu escolhida

            while (opcao != 5)
            {
                Console.Clear();
                Console.WriteLine("--- MENU DO BANCO ---");
                Console.WriteLine("1 - Cadastrar Conta");
                Console.WriteLine("2 - Listar Contas");
                Console.WriteLine("3 - Depositar");
                Console.WriteLine("4 - Sacar");
                Console.WriteLine("5 - Sair");
                Console.Write("Escolha uma opção: ");
                
                // Leitura simples da opção escolhida
                opcao = Convert.ToInt32(Console.ReadLine());

                if (opcao == 1) // OPÇÃO 1: CADASTRAR CONTA
                {
                    if (totalContas < 3)
                    {
                        Console.Write("Digite o número da conta: ");
                        numeros[totalContas] = Convert.ToInt32(Console.ReadLine());
                        
                        Console.Write("Digite o nome do titular: ");
                        titulares[totalContas] = Console.ReadLine();
                        
                        Console.Write("Digite o saldo inicial: ");
                        saldos[totalContas] = Convert.ToDouble(Console.ReadLine());

                        totalContas = totalContas + 1; // Aumenta o contador
                        Console.WriteLine("Conta cadastrada com sucesso!");
                    }
                    else
                    {
                        Console.WriteLine("Limite máximo de 3 contas atingido!");
                    }
                }
                else if (opcao == 2) // OPÇÃO 2: LISTAR CONTAS
                {
                    if (totalContas == 0)
                    {
                        Console.WriteLine("Nenhuma conta cadastrada ainda.");
                    }
                    else
                    {
                        Console.WriteLine("--- LISTA DE CONTAS ---");
                        // O laço 'for' passa por todas as contas cadastradas
                        for (int i = 0; i < totalContas; i++)
                        {
                            Console.WriteLine("Conta: " + numeros[i] + " | Titular: " + titulares[i] + " | Saldo: " + saldos[i]);
                        }
                    }
                }
                else if (opcao == 3) // OPÇÃO 3: DEPOSITAR
                {
                    Console.Write("Digite o número da conta para depósito: ");
                    int numConta = Convert.ToInt32(Console.ReadLine());
                    
                    int posicao = -1; // -1 significa que a conta não foi achada ainda

                    // Procura a conta nos arrays
                    for (int i = 0; i < totalContas; i++)
                    {
                        if (numeros[i] == numConta)
                        {
                            posicao = i; // Achou a conta! Guarda a posição dela.
                        }
                    }

                    if (posicao != -1) // Se a posição for diferente de -1, a conta existe
                    {
                        Console.Write("Digite o valor do depósito: ");
                        double valor = Convert.ToDouble(Console.ReadLine());
                        
                        saldos[posicao] = saldos[posicao] + valor; // Soma o valor ao saldo
                        Console.WriteLine("Depósito realizado com sucesso!");
                    }
                    else
                    {
                        Console.WriteLine("Conta não encontrada.");
                    }
                }
                else if (opcao == 4) // OPÇÃO 4: SACAR
                {
                    Console.Write("Digite o número da conta para saque: ");
                    int numConta = Convert.ToInt32(Console.ReadLine());
                    
                    int posicao = -1;

                    // Procura a conta
                    for (int i = 0; i < totalContas; i++)
                    {
                        if (numeros[i] == numConta)
                        {
                            posicao = i;
                        }
                    }

                    if (posicao != -1) // Se achou a conta
                    {
                        Console.Write("Digite o valor do saque: ");
                        double valor = Convert.ToDouble(Console.ReadLine());
                        
                        if (saldos[posicao] >= valor) // Verifica se tem dinheiro suficiente
                        {
                            saldos[posicao] = saldos[posicao] - valor; // Subtrai o valor
                            Console.WriteLine("Saque realizado com sucesso!");
                        }
                        else
                        {
                            Console.WriteLine("Saldo insuficiente para este saque.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Conta não encontrada.");
                    }
                }
                else if (opcao == 5) // OPÇÃO 5: SAIR
                {
                    Console.WriteLine("Saindo do programa...");
                }
                else // QUALQUER OUTRO NÚMERO
                {
                    Console.WriteLine("Opção inválida. Tente novamente.");
                }

                // Pausa simples antes de limpar a tela e voltar pro começo do 'while'
                Console.WriteLine("\nAperte ENTER para continuar...");
                Console.ReadLine();
            }
        }
    }
}
