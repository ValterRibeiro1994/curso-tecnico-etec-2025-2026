using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TL04_PRL_130825
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double Notal; // Variavel real Entrada
            double Nota2; // Variavel real Entrada

            double Media; // Variavel real Saida

            Console.Clear(); // Limpar tela
            Console.WriteLine("Digite a 1° Nota: ");// Interface 1
            Console.SetCursorPosition(18, 0); //Posição 1
            Nota1 = double.Parse(Console.ReadLine()); // Entrada 1

            Console.WriteLine("Digite a 2° Nota: ");// Interface 2
            Console.SetCursorPosition(18, 1); //Posiçao 2
            Nota2 = double.Parse(Console.ReadLine()); // Entrada 2

            Media = (Notal + Nota2) / 2; // Processo 1

            Console.WriteLine("Média: " + Media);// Saida 1
            Console.ReadLine();
        }
    }
}
