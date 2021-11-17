/* Leia 2 valores inteiros X e Y. A seguir, calcule e mostre a soma
 dos números impares entre eles.

Entrada
O arquivo de entrada contém dois valores inteiros.

Saída
O programa deve imprimir um valor inteiro. Este valor é a soma dos 
valores ímpares que estão entre os valores fornecidos na entrada que deverá caber em um inteiro.

 
Exemplo de Entrada	Exemplo de Saída
6                           5
-5

15                          13
12

12                           0 
12



 */


using System;

namespace TESTE
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y, min, max, soma;

            x = int.Parse(Console.ReadLine());
            y = int.Parse(Console.ReadLine());

            if (x < y)
            {
                min = x;
                max = y;
            }
            else
            {
                min = y;
                max = x;
            }
            soma = 0;
            for (int i = min+1; i < max; i++)
            {
                 if (i % 2 != 0)
                {
                    soma = soma + i;
                }
            }
            Console.WriteLine(soma);

        }
    }
}