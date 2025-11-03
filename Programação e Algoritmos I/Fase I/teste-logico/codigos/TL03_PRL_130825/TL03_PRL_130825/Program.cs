using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TL03_PRL_130825
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double Produto; // Varivel Real Entrada

            double Avista; // Variavel Real Saida
            double Parcela; // Variavel Real Saida

            Console.Clear(); // Limpar Tela
            Console.WriteLine("Digite o valor do produto R$: "); // Interface 1
            Console.SetCursorPosition(29, 0); // Posição 1
            Produto = double.Parse(Console.ReadLine()); // Entrada 1

            Avista = Produto * 0.9; // Processo 1
            Parcela = Produto / 3; // Processo 2

            Console.WriteLine("Valor avista do produto R$:" + Avista); //Saida 1
            Console.WriteLine("Valor parcelado em 3x do produto R$:" + Parcela); // Saida 2
            Console.ReadLine();
        }
    }
}
