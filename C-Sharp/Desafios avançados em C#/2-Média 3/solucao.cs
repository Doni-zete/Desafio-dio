/* Leia quatro números (N1, N2, N3, N4), cada um deles 
com uma casa decimal, correspondente às quatro notas de um aluno. 
Calcule a média com pesos 2, 3, 4 e 1, respectivamente,
 para cada uma destas notas e mostre esta média acompanhada
  pela mensagem "Media: ".
   Se esta média for maior ou igual a 7.0, imprima a mensagem 
   "Aluno aprovado.". Se a média calculada for inferior 
   a 5.0, imprima a mensagem "Aluno reprovado.". 
   Se a média calculada for um valor entre 5.0 e 6.9,
    inclusive estas, o programa deve imprimir a mensagem "Aluno em exame.".

No caso do aluno estar em exame, leia um valor correspondente
 à nota do exame obtida pelo aluno. 
 Imprima então a mensagem 
 "Nota do exame: " acompanhada pela nota digitada. 
 Recalcule a média (some a pontuação do exame 
 com a média anteriormente calculada e divida por 2).
  e imprima a mensagem "Aluno aprovado."
   (caso a média final seja 5.0 ou mais ) 
   ou "Aluno reprovado.", (caso a média tenha ficado 4.9 ou menos).
    Para estes dois casos (aprovado ou reprovado após ter pego exame)
     apresente na última linha uma mensagem "Media final: 
     " seguido da média final para esse aluno.

Entrada
A entrada contém quatro números de ponto flutuante 
correspendentes as notas dos alunos.

Saída
Todas as respostas devem ser apresentadas com uma casa decimal.
 As mensagens devem ser impressas conforme a descrição do problema. 
 Não esqueça de imprimir o enter após o final
  de cada linha, caso contrário obterá "Presentation Error".
 */

using System;


namespace Start
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, d,avg;
            string[] v = Console.ReadLine().Split(' ');
            a = double.Parse(v[0]);
            b = double.Parse(v[1]);
            c = double.Parse(v[2]);
            d = double.Parse(v[3]);
            
            avg = ((2*a+3*b+4*c+d)/10);
            Console.WriteLine("Media: " +avg.ToString("0.0"));
            if (avg >= 6.97)
            {
                if (!(avg > 6.96 && avg < 6.98)) {
                  Console.WriteLine("Aluno aprovado.");
                }
            }
            else if (avg<5.0)
              {
                  Console.WriteLine("Aluno reprovado.");
              }
              else
                {
                    Console.WriteLine("Aluno em exame.");
                    Console.Write("Nota do exame: ");
                    double e = double.Parse(Console.ReadLine());
                    Console.WriteLine(e.ToString("0.0"));
                    avg = (avg+e) / 2;
                    if (avg >= 5.0)
                    {
                        Console.WriteLine("Aluno aprovado.");
                    }
                    else
                    {
                        Console.WriteLine("Aluno reprovado");
                    }
                    Console.WriteLine("Media final: " +avg.ToString("0.0"));
                }


            Console.ReadKey();
        }
    }
}