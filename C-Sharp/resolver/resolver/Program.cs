using System;

class Program
{

  static void Main(string[] args)
  {

    string[] selections = Console.ReadLine().Split(' ');
    int a = int.Parse(selections[0]);
    int b = int.Parse(selections[1]);
    int c = int.Parse(selections[2]);
    int d = int.Parse(selections[3]);

    // Implemente a condição abaixo para ter o resultado esperado
    if ((b>c)&&(d>a))                             
    {
      
      Console.WriteLine("Valores aceitos");
    }

    
    else
    {
      Console.WriteLine("Valores nao aceitos");
    }
  }

}