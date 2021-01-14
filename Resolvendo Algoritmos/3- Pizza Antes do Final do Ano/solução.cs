/* Está chegando o final de ano e as tradicionais celebrações de amigo secreto, você e seus N-1 amigos decidiram combinar algum dia para ir a uma pizzaria.

Neste momento está sendo escolhida a data do evento. Para que todas as pessoas possam participar, foi decidido que o encontro na pizzaria ocorrerá em um data tal que todas as N pessoas podem comparecer à pizzaria nesta data. Portanto, nem toda data pode ser escolhida, pois algumas pessoas podem ter outros compromissos já marcados em alguns dias.

Dada a lista de datas consideradas para o evento e a informações de quais pessoas podem comparecer em quais datas, determine se o evento poderá ocorrer e, em caso positivo, sua data. Caso mais de uma data seja possível, o evento deve ocorrer o mais cedo possível. */


using System;

namespace EstruturaDoPrograma
{
    class Program
    {

        static void Main(string[] args)
        {
            string[] tokens = Console.ReadLine().Split(" ");
            int[] convertedItems = Array.ConvertAll<string, int>(tokens, int.Parse);

            var numPessoas = convertedItems[0];
            var numDatas = convertedItems[1];


            string data = "Pizza antes de FdA";


            for (int i = 0; i < numDatas; i++)
            {
                tokens = Console.ReadLine().Split(" ");

                bool aconteceEncontro = true;
                for (int j = 1; j <= numPessoas; j++)
                {
                    if (int.Parse(tokens[j]) != 1)
                    {
                        aconteceEncontro = false;
                        break;
                    }
                }

                if (aconteceEncontro)
                {
                    if (data == "Pizza antes de FdA")
                        data = tokens[0];
                }
            }

            Console.WriteLine($"{data}");
        }
    }

}