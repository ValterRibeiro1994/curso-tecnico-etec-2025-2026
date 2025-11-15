using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exe16_PRL_12112025
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double nota; // variavel real
            string status = ""; // variavel string para saida
            string mensagem = "Digite a nota: "; // variavel string para armazenar a interface

            try
            {
                Console.Clear(); // limpa a tela
                Console.WriteLine(mensagem); // interface 1
                Console.SetCursorPosition(mensagem.Length, 0); // determina a posição
                nota = double.Parse(Console.ReadLine()); // coleta entrada

                // se nota maior que 7 imprime aprovado
                if (nota >= 7)
                {
                    status = "Aprovado";
                }
                // se nota nota maior ou igual a 5 imprime exame
                else if (nota >= 5)
                {
                    status = "exame";
                }
                // se não reprovado
                else
                {
                    status = "Reprovado";
                }

                Console.WriteLine("Nota: " + nota + " Classificação: " + status); // saida

            }
            catch (Exception ex) { 
                Console.Write("Erro: Informe apenas números !!! " + ex.ToString() ); // saida de erro
                Console.ReadLine();
            } finally
            {
                Console.WriteLine("Até a proxima !!!"); // saida 
                Console.ReadLine();
            }
        }
    }
}
