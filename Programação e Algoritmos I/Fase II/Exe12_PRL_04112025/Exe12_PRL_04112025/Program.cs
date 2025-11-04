using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exe12_PRL_04112025
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero1; // Variavel Inteira Entrada
            int numero2; // Variavel Inteira Entrada

            int Maior; // Variavel Inteira Saida

            Console.Clear(); // Limpa tela
            Console.WriteLine("Digite o 1° número: "); // Interface 1
            Console.SetCursorPosition(20, 0); // Posição 1
            numero1 = int.Parse(Console.ReadLine()); // Entrada 1

            Console.WriteLine("Digite o 2° número: "); // Interface 2
            Console.SetCursorPosition(20, 1); // Posição 2
            numero2 = int.Parse(Console.ReadLine()); // Entrada 2

            if (numero1 > numero2) // Condicional 1

                Maior = numero1; // Processo 1

            else // Negacao Condicional 1

                Maior = numero2; // Processo 2

            Console.WriteLine("Maior: " + Maior); // Saida 1
            Console.ReadLine();
        }
    }
}
