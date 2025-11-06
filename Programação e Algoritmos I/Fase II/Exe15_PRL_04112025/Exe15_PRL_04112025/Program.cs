using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exe15_PRL_04112025
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Numero; // Variavel inteira - Entrada

            Console.Clear(); // LImpa Tela
            Console.WriteLine("Digite um numero: "); // Interface 1
            Console.SetCursorPosition(18, 0); //Posição 1
            Numero = int.Parse(Console.ReadLine()); // Entrada 1

            if (Numero > 50) // Condicional 1

                if (Numero <= 90) // Condicional 2

                    Console.WriteLine("Numero: " + Numero); // Saida 1

            Console.ReadLine();
        }
    }
}
