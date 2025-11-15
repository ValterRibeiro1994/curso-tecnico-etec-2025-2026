using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exe17_PRL_12112025
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float[] numeros = new float[3]; // vetor para guardar 3 numeros reais
            short cont = 2; //variavel short (Inteiro)
            float n; // variavel real entrada

            try
            {
                while (cont >= 0)
                {
                    n = obterNumeroReal("Digite um número: ");
                    // verifica se o numero existe no vetor
                    if (ExisteNoVetor(numeros, n))
                    {
                        // Se for true o numero repetiu
                        // notifica o usuario, e retorna o loop
                        Console.WriteLine("Erro: Esse Número já foi informado anteriormente, tente novamente !");
                        continue;
                    }
                    else
                    {
                        // ok, podemos guardar a resposta do usuario no vetor
                        numeros[cont] = n;

                        // verifica se o comprimento é maior que 2
                        if (numeros.Length >= 2)
                        {
                            // se sim o elemento da direita no vetor já foi definido
                            if (numeros[cont] > numeros[cont - 1])
                            {
                                // se o numero atual do usuario for menor que
                                // que o ultimo numero que ele digitou
                                // troca os elementos
                                float temp = numeros[cont];
                                numeros[cont] = numeros[cont + 1];
                                numeros[cont + 1] = temp;
                            }
                        }

                        cont--;
                    }
                }

                // exibir números ordenados
                for (int i = 0; i < numeros.Length; i++) {
                    Console.WriteLine("Número Digitado: " + numeros[i]);
                }

            }
            catch (Exception e)
            {
                Console.WriteLine("ERRO: " + e.ToString());
                Console.ReadLine();

            }
        }

        static float obterNumeroReal(string msg)
        {
            Console.Clear();
            Console.WriteLine(msg); // exibe interface
            Console.SetCursorPosition(msg.Length, 0);
            try
            {
                // Se der algum erro catch captura, e finally exibe a respost
                return float.Parse(Console.ReadLine());
            }
            catch (Exception e)
            {
                Console.WriteLine("Erro: Informe apenas números reais !!!.\t" + e.ToString());
                Console.ReadLine();
                return 0;
            }
            finally {
                Console.WriteLine("Até a proxima !!!");
                Console.ReadLine();
            }
            
        }
    
        static bool ExisteNoVetor(float[] vetor, float alvo)
        {
            for (int i = 0; i < vetor.Length; i++)
            {
                if (vetor[i] == alvo)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
