/* Desafio
Crie um programa que leia 6 valores, os quais poderão ser negativos e/ou positivos. Em seguida, apresente a quantidade de valores positivos digitados.

Entrada
Você receberá seis valores, negativos e/ou positivos.

Saída
Exiba uma mensagem dizendo quantos valores positivos foram lidos. assim como é exibido abaixo no exemplo de saída. 
Não se esqueça de incluir na mensagem de saída o sufixo " valores positivos", conforme o exemplo abaixo:
 
Exemplo de Entrada	Exemplo de Saída
7
-5
6
-3.4
4.6
12
 */


using System;

public class Program
{
  public static void Main(string[] args)
  {
    int quantidadePositivos = 0;
    for (int i = 0; i < 6; i++)
    {
      double valorInformadoPeloUsuario = double.Parse(Console.ReadLine());

      if (valorInformadoPeloUsuario % 1 == 0) quantidadePositivos++;
      // TODO Incrementar a "quantidadePositivos" somente SE o "valorInformadoPeloUsuario" for positivo.
    }
    Console.WriteLine(quantidadePositivos + " valores positivos");
  }
}
