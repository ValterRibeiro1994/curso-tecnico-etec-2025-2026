using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exe_PRL_04112025
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number; //Variable integer I/O

            // get input
            Console.Clear(); // Clear console
            Console.WriteLine("Digite um número: "); // Interface 1
            Console.SetCursorPosition(19, 0); // Cursor position line one
            number = int.Parse(Console.ReadLine()); // Input user

            if (number > 100) // Condition
            {
                Console.WriteLine("Número: " + number); // output 1
            }
            Console.ReadLine(); // End
        }
    }
}
