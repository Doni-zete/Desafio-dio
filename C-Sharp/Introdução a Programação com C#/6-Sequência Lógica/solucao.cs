// Detalhe
// Desenvolva um programa capaz de ler um valor inteiro N. N * 2 linhas de saída vão ser apresentadas na execução do programa, seguindo a lógica do exemplo mais abaixo. Para os valores com mais de seis dígitos, todos os dígitos devem ser apresentados.

// Entrada
// O arquivo de entrada contém um número inteiro positivo N (1 < N < 1000).

// Saída
// Imprima a saída conforme o exemplo fornecido.




using System;

class Program
{
  static void Main(string[] args)
  {


    int n = int.Parse(Console.ReadLine());
    for (int i = 1; i <= n; i++)
    {
      Console.WriteLine(i + " " + (i * i) + " " + (i * i * i));
      Console.WriteLine(i + " " + ((i * i) + 1) + " " + ((i * i * i) + 1));
    }
  }

}