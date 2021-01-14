/* Duas motos (X e Y) partem em uma mesma direção. A moto X sai com velocidade constante de 60 Km/h e a moto Y sai com velocidade constante de 90 Km/h.

Em uma hora (60 minutos) a moto Y consegue se distanciar 30 quilômetros da moto X, ou seja, consegue se afastar um quilômetro a cada 2 minutos.

O seu desafio é ler a distância (em Km) e calcular quanto tempo leva (em minutos) para a moto Y tomar essa distância da outra moto. */

using System;

class Desafio
{
    static void Main()
    {
        int limit = Int32.Parse(Console.ReadLine());
        for (int i = 0; i < limit; i++)
        {
            string[] line = Console.ReadLine().Split(" ");
            double X = double.Parse(line[0]);
            double Y = double.Parse(line[1]);
            if (Y == 0)
            {
                Console.WriteLine("divisao impossivel");
            }
            else
            {
                double divisao = X / Y; // Digite aqui o calculo da divisao
                if (divisao < 0 && (divisao.ToString("N1") == "0.0"))
                    Console.WriteLine("-0.0");
                else
                    Console.WriteLine(divisao.ToString("N1"));
            }
        }
    }
}