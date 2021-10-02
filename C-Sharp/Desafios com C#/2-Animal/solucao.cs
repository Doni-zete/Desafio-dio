/* Neste problema, você deverá ler 3 palavras que definem o tipo de animal possível segundo o esquema abaixo, da esquerda para a direita.  Em seguida conclua qual dos animais seguintes foi escolhido, através das três palavras fornecidas. 
Entrada
A entrada contém 3 palavras, uma em cada linha, necessárias para identificar o animal segundo a figura acima, com todas as letras minúsculas.

Saída
Imprima o nome do animal correspondente à entrada fornecida.

Exemplos de Entrada     	Exemplos de Saída
vertebrado
mamifero                      homem
onivoro

vertebrado
ave                           aguia
carnivoro

invertebrado
anelideo                      minhoca
onivoro

*/


using System;
using System.Text;

class MainClass
{
  public static void Main(string[] args)
  {
    String palavra1;
    String palavra2;
    String palavra3;
    palavra1 = Console.ReadLine();
    palavra2 = Console.ReadLine();
    palavra3 = Console.ReadLine();


    if (palavra1 == "vertebrado")
    {
      if (palavra2 == "ave")
      {
        if (palavra3 == "carnivoro")
        {
          Console.WriteLine("aguia");
        }
        else if (palavra3 == "onivoro")
        {
          Console.WriteLine("pomba");
        }
      }
      else if (palavra2 == "mamifero")
      {
        if (palavra3 == "onivoro")
        {
          Console.WriteLine("homem");
        }
        else if (palavra3 == "herbivoro")
        {
          Console.WriteLine("vaca");
        }
      }
    }

    if (palavra1 == "invertebrado")
    {
      if (palavra2 == "inseto")
      {
        if (palavra3 == "hematofago")
        {
          Console.WriteLine("pulga");
        }
        else if (palavra3 == "herbivoro")
        {
          Console.WriteLine("lagarta");
        }
      }
      else if (palavra2 == "anelideo")
      {
        if (palavra3 == "hematofago")
        {
          Console.WriteLine("sanguessuga");
        }
        else if (palavra3 == "onivoro")
        {
          Console.WriteLine("minhoca");
        }
      }
    }
  }
}