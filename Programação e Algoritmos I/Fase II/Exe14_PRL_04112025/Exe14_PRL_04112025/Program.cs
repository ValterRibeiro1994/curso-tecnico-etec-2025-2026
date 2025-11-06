using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exe14_PRL_04112025
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Numero; // Integer Input Variable
            string Status = " "; // Text Output Variable

            Console.Clear(); // Clear console
            Console.WriteLine("Digite um numero: "); // Interface 1
            Console.SetCursorPosition(17, 0); // Position 1
            Numero = int.Parse(Console.ReadLine()); // Input 1

            if (Numero != 0) // Conditional 1
                if (Numero > 0) // Conditional 2
                    Status = "Positivo"; // Process 1
                else // Negation - Conditional 2
                    Status = "Negativo"; // Process 2
            else // Negation - Conditional 1
                Status = "Neutro"; // Process 3

            Console.WriteLine("Resultado: " + Status); // Output 1
            Console.ReadLine();

        }
    }
}
