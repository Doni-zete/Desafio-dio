/* using System;

class Desafio
{

  public static void Main()
  {

    int tc, x;
    tc = int.Parse(Console.ReadLine());
    for (int i = 0; i <= 5; i++)
    {
      x = int.Parse(Console.ReadLine());
      if (x == 0)
      {
        Console.WriteLine("NULL");
      }
      else if (x % 2 == 0)
      {
        if (   )
        {
          Console.WriteLine("EVEN POSITIVE");
        }
        else
        {
          Console.WriteLine("EVEN NEGATIVE");
        }

      }
      else
      {
        if (   )
        {
          Console.WriteLine("ODD POSITIVE");
        }
        else
        {
          Console.WriteLine("ODD NEGATIVE");
        }
      }

    }

    Console.ReadLine();
  }

} */


using System;

class MinhaClasse
{

  static void Main(string[] args)
  {

    string[] selections = Console.ReadLine().Split(' ');
    int a = int.Parse(selections[0]);
    int b = int.Parse(selections[1]);
    int c = int.Parse(selections[2]);
    int d = int.Parse(selections[3]);

    // Implemente a condição abaixo para ter o resultado esperado

    if (b > c && d > a && c + d > a + b && c > 0 && d > 0 && (a % 2 == 0))
    {

      Console.WriteLine("Valores aceitos");
    }
    else
    {
      Console.WriteLine("Valores nao aceitos");
    }
  }
}
