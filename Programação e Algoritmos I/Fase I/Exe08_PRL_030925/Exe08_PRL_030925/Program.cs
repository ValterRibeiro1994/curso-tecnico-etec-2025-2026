using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exe08_PRL_030911
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double HT; // Variavel Real Entrada

            double SB; // Variavel Real Saida
            double IMP; // Variavel Real Saida
            double SL; // Variavel Real Saida

            Console.Clear(); // Limpa Tela
            Console.WriteLine("Digite o n° de horas trabalhadas: "); // interface 1
            Console.SetCursorPosition(34, 0); // posicao 1
            HT = double.Parse(Console.ReadLine()); // Entrada 1

            SB = HT * 10.37; // Processo 1
            IMP = SB * 0.11; // Processo 2
            SL = SB - IMP; // Processo 3

            Console.WriteLine("Salario Liquido: " + SL); // Saida 1
            Console.WriteLine("Salario Bruto: " + SB); // Saida 2
            Console.WriteLine("Impostos: " + IMP); // Saida 3
            Console.ReadLine();
        }
    }
}
