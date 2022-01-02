/* A fórmula para calcular a área de uma circunferência é: area = π . raio2. Considerando para este problema que π = 3.14159:

- Efetue o cálculo da área, elevando o valor de raio ao quadrado e multiplicando por π.

Entrada
A entrada contém um valor de ponto flutuante (dupla precisão), no caso, a variável raio.

Saída
Apresentar a mensagem "A=" seguido pelo valor da variável area, conforme exemplo abaixo, com 4 casas após o ponto decimal. Utilize variáveis de dupla precisão (double). Como todos os problemas, não esqueça de imprimir o fim de linha após o resultado, caso contrário, você receberá "Presentation Error".



Exemplos de Entrada    	Exemplos de Saída
2.00                        A=12.5664

100.64                      A=31819.3103

150.00                      A=70685.7750 */

//  using System;

// class Program {

//   static void Main(string[] args) {

//     double pi = 3.14159; 
//           double raio = double.Parse(Console.ReadLine());

//          double area =pi* (raio*raio);

//         Console.WriteLine($"A={area.ToString("F4")}");


//   }
// }

using System;

class DIO
{

  public void OrdenarBurbleSort(ref int[] array)
    {
      int temp = 0;
      for (int i = 0; i < array.Length; i++)
      {
        for (int j = 0; j < array.Length - 1; j++)
        {
          if (array[j] > array[j + 1])
          {
            temp = array[j + 1];
            array[j + 1] = array[j];
            array[j] = temp;
          }
        }
      }
    }
    public void ImprimirArray(int[] array)
    {
      var linha = string.Join(",", array);
      System.Console.WriteLine(linha);

    }
}