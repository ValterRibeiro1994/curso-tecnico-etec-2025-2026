using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exe13_PRL_05112025
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double SBase; // Real variable Input - Output
            double GRAF; // Real variable Input

            double SB; // Real variable Output
            double IR; // Real variable Output
            double SL; // Real variable Output

            Console.Clear(); // Clear console

            Console.WriteLine("Digite o Salario Base:"); // Interface 1
            Console.SetCursorPosition(23, 0); // Position cursor 1
            SBase = double.Parse(Console.ReadLine()); // Input 1

            Console.WriteLine("Digite a Gratificação:"); // Interface 2
            Console.SetCursorPosition(23, 1); // Position cursor 2
            GRAF = double.Parse(Console.ReadLine()); // Input 2

            SB = GRAF + SBase; // Process 1

            if (SB > 3800) // Conditional 1
                IR = SB * 0.15; // Process 2
            else // Negation of Conditional 1
                IR = SB * 0.11; // Process 3

            SL = SB - IR; // Process 4

            Console.WriteLine("Salario Base: " + SBase); // Output 1
            Console.WriteLine("Salario Bruto: " + SB); // Output 2
            Console.WriteLine("Imposto de Renda: " + IR); // Output 3
            Console.WriteLine("Salario Liquido: " + SL); // Output 4

            Console.ReadLine();

        }
    }
}
