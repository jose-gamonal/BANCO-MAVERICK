using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace BANCO_MAVERICK
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int quantascontas = 1;
            string contaatual = "C1";
            Dictionary<string, Conta> dictionary = new Dictionary<string, Conta>();
            dictionary.Add("C1", new Conta(0));

            void MenuInicial()
            {
                double saldoatual = dictionary[contaatual].saldoatualassociado;
                Console.WriteLine("   _____      _________   _________________________ ____________  ____  __   TM\r\n  /     \\    /  _  \\   \\ /   /\\_   _____/\\______   \\   \\_   ___ \\|    |/ _|\r\n /  \\ /  \\  /  /_\\  \\   Y   /  |    __)_  |       _/   /    \\  \\/|      |  \r\n/    Y    \\/    |    \\     /   |        \\ |    |   \\   \\     \\___|    |  \\ \r\n\\____|__  /\\____|__  /\\___/   /_______  / |____|_  /___|\\______  /____|__ \\\r\n        \\/         \\/                 \\/         \\/            \\/        \\/\r\n");
                Console.WriteLine($"Como podemos ajudá-lo?\r\nSALDO NA CONTA ATUAL {contaatual}: {saldoatual}\r\n");
                Console.WriteLine("1 - Depositar\r\n2 - Sacar\r\n3 - Transferir\r\n4 - Trocar de conta\r\n5 - Criar nova conta\r\n6 - Checar Saldo de todas as contas\r\n");
                Console.WriteLine("Pressione Enter sem nenhum comando para finalizar o programa.");
            }


            MenuInicial();
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "1")
                {
                    Console.Clear();
                    MenuInicial();
                }
                else if (input == "2")
                {
                    Console.Clear();
                    MenuInicial();
                }
                else if (input == "3")
                {
                    Console.Clear();
                    MenuInicial();
                }
                else if (input == "4")
                {
                    Console.WriteLine($"Você tem {quantascontas} contas.");
                    Console.WriteLine("Deseja trocar para qual conta?");
                    int input2 = Convert.ToInt32(Console.ReadLine());

                    if (input2 > quantascontas || input2 < 1)
                    {
                        Console.Clear();
                        Console.WriteLine("\r\n⚠️ CONTA INEXISTENTE. VOCÊ PERMANECERÁ NA CONTA ATUAL.\r\n");
                        MenuInicial();
                    }
                    else
                    {
                        contaatual = "C" + input2;
                        Console.Clear();
                        MenuInicial();
                    }

                }
                else if (input == "5")
                {
                    quantascontas++;

                    dictionary["C" + Convert.ToString(quantascontas)] = new Conta(0);
                    Console.WriteLine($"CONTA C{quantascontas} CRIADA");
                }
                else if (input == "6")
                {
                    Console.WriteLine();
                    for(int i = 1; i <= quantascontas; i++)
                    {
                        Console.WriteLine($"C{i}:{dictionary["C" + i].saldoatualassociado}");
                    }
                }
                else Environment.Exit(0);
            }
        }
    }

    class Conta
    {
        public double saldoatualassociado;
        public Conta(double saldoatualrecebido)
        {
            saldoatualassociado = saldoatualrecebido;
        }
    }
}