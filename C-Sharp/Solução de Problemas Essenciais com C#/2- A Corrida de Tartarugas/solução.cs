/* 
Desafio

A corrida de tartarugas é um esporte que cresceu muito nos últimos anos, fazendo com que vários competidores se dediquem a capturar tartarugas rápidas, e treina-las para faturar milhões em corridas pelo mundo. Porém a tarefa de capturar tartarugas não é uma tarefa muito fácil, pois quase todos esses répteis são bem lentos. Cada tartaruga é classificada em um nível dependendo de sua velocidade:


Nível 1: Se a velocidade é menor que 10 cm/h .
Nível 2: Se a velocidade é maior ou igual a 10 cm/h e menor que 20 cm/h .
Nível 3: Se a velocidade é maior ou igual a 20 cm/h .

Sua tarefa é identificar qual o nível de velocidade da tartaruga mais veloz de um grupo.
Entrada

A entrada consiste de múltiplos casos de teste, e cada um consiste em duas linhas: A primeira linha contém um inteiro L (1 ≤ L ≤ 500) representando o número de tartarugas do grupo, e a segunda linha contém L inteiros Vi (1 ≤ Vi ≤ 50) representando as velocidades de cada tartaruga do grupo.
Saída

Para cada caso de teste, imprima uma única linha indicando o nível de velocidade da tartaruga mais veloz do grupo.
 */


using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
class Desafio
{
    static void Main()
    {



        for (int i = 0; i < 3; i++)
        {

            int limit = Int32.Parse(Console.ReadLine());
            var listavelocidade = Console.ReadLine().Split(" ");

            int nivel = 0;

            int MaiorVelocidade = 0;
            for (int ind = 0; ind < limit; ind++)
            {
                int velocidade = 0;
                try
                {
                    velocidade = Int32.Parse(listavelocidade[ind]);
                }
                catch (Exception e)
                {
                    velocidade = 0;
                }

                if (velocidade > MaiorVelocidade)
                    MaiorVelocidade = velocidade;
            }


            if (MaiorVelocidade < 10)
            {
                nivel = 1;
            }
            if ((MaiorVelocidade >= 10) && (MaiorVelocidade < 20))
            {
                nivel = 2;
            }
            if (MaiorVelocidade >= 20)
            {
                nivel = 3;
            }

            Console.WriteLine(nivel.ToString());
        }


    }


}