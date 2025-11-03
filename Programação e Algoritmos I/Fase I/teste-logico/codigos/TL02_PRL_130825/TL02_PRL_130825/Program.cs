using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TL02_PRL_130825
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double Conta; // Variavel Real Entrada
            int Clientes; // Variavel Inteira Entrada

            double Valor; // Variavel Real Saida;

            Console.Clear(); // Limpa Tela
            Console.WriteLine("Digite o valor da conta R$: "); // Interface 1
            Console.SetCursorPosition(27, 0); // Posição
            Conta = double.Parse(Console.ReadLine());// Entrada 1

            Console.WriteLine("Digite o número de clientes: "); // Interface 2
            Console.SetCursorPosition(28, 1); // Posição 2
            Clientes = int.Parse(Console.ReadLine());// Entrada 2

            Valor = Conta / Clientes; // Processo 1

            Console.WriteLine("Valor a pagar por cliente R$: " + Valor);
            // Saida 1 - Concatena o valor da variavel com texto

            Console.ReadLine();
        }
    }
}
