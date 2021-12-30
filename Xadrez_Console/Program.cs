using System;
using TABULEIRO;

namespace Xadrez_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            Posicao P = new(3, 4);

            Console.WriteLine("Posicao: " + P.ToString());
            Console.ReadLine();
        }
    }
}
