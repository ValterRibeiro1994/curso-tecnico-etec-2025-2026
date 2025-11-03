using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TL01_PRL_130825
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Numero; // Variavel Inteira Entrada

            int Anterior; // Variavel inteira Saida
            int Posterior; // Variavel inteira Saida

            Console.Clear(); // Limpa Tela
            Console.WriteLine("Digite um numero: "); // Interface 1
            Console.SetCursorPosition(18, 0); // Posição 1
            Numero = int.Parse(Console.ReadLine()); // Entrada 1

            Anterior = Numero - 1; // Processo 1
            Posterior = Numero + 1; // Processo 2

            Console.WriteLine("Vizinhos : " + Anterior + " e " + Posterior);
            // Saida 1 - Valor concatenado
            Console.ReadLine();
        }
    }
}
