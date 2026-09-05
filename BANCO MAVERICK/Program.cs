using System;
using System.Collections.Generic;
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
            MenuInicial();
        }

        public void MenuInicial()
        {
            Console.WriteLine("   _____      _________   _________________________.____________  ____  __.  TM\r\n  /     \\    /  _  \\   \\ /   /\\_   _____/\\______   \\   \\_   ___ \\|    |/ _|\r\n /  \\ /  \\  /  /_\\  \\   Y   /  |    __)_  |       _/   /    \\  \\/|      <  \r\n/    Y    \\/    |    \\     /   |        \\ |    |   \\   \\     \\___|    |  \\ \r\n\\____|__  /\\____|__  /\\___/   /_______  / |____|_  /___|\\______  /____|__ \\\r\n        \\/         \\/                 \\/         \\/            \\/        \\/\r\n");
            Console.WriteLine($"Como podemos ajudá-lo?\r\nCONTA ATUAL: {contaatual}\r\n");
            Console.WriteLine("1 - Trocar conta");
        }
    }
}