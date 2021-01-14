/* Para dar conta de toda a fabricação dos presentes de Natal, por várias vezes os elfos precisam ficar até tarde trabalhando para que tudo possa ser terminado a tempo.

Para melhor gerenciar seus cronogramas, os elfos estipularam quantos minutos são necessários para fabricar cada presente.

Já está quase no final do expediente, e um dos elfos pediu sua ajuda.

Faltam N minutos para a hora de ir embora, e restam dois presentes para o elfo Dobby fabricar. Ajude-o a descobrir se ele conseguirá fabricar os dois ainda hoje, ou se deve deixar o trabalho para amanhã. */

using System;

namespace Desafio
{
    class Program
    {
        static void Main(string[] args)
        {
            var minutosParaFinalExpediente = int.Parse(Console.ReadLine());

            string[] tokens = Console.ReadLine().Split(" ");

            int[] convertedItems = Array.ConvertAll<string, int>(tokens, int.Parse);

            int tempoNecessarioParaPresente1 = convertedItems[0];
            int tempoNecessarioParaPresente2 = convertedItems[1];
            int tempoNecessarioPara2Presentes = tempoNecessarioParaPresente1 + tempoNecessarioParaPresente2;

            if (tempoNecessarioPara2Presentes <= minutosPa/*  */raFinalExpediente) 
            {
                Console.WriteLine("Farei hoje!");
            }
            else
            {
                Console.WriteLine("Deixa para amanha!");
            }

        }
    }
}