using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex10_ATV01_100925
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double Moto; // Variavel de Entrada Real
            double Auto; // Variavel de Entrada Real
            double Bike; // Variavel de Entrada Real

            double Metros; // Variavel Real
            double KM; // Variavel Real Saida

            Console.Clear(); // Limpa tela
            Console.WriteLine("Digite o percurso da moto em metros: "); // Interface 1
            Console.SetCursorPosition(37, 0); // Posição 1
            Moto = double.Parse(Console.ReadLine()); // Entrada 1

            Console.WriteLine("Digite o percurso do automovel em metros: "); // Interface 2
            Console.SetCursorPosition(43, 1); // Posição 2
            Auto = double.Parse(Console.ReadLine()); // Entrada 2

            Console.WriteLine("Digite o percurso de bicicleta em metros: "); // Interface 3
            Console.SetCursorPosition(43, 2); // Posição 3
            Bike = double.Parse(Console.ReadLine()); // Entrada 3

            Metros = Moto + Auto + Bike; // Processo 1
            KM = Metros / 1000; // Processo 2

            Console.WriteLine("Total do percurso percorrido em quilomêtros: " + KM); // Saida 1
            Console.ReadLine();
        }
    }
}
