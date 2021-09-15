/* Paulinho tem em suas mãos um novo problema. Agora a sua professora lhe pediu que construísse um programa para verificar, à partir de dois valores muito grandes A e B, se B corresponde aos últimos dígitos de A.

Entrada
A entrada consiste de vários casos de teste. A primeira linha de entrada contém um inteiro N que indica a quantidade de casos de teste. Cada caso de teste consiste de dois valores A e B maiores que zero, cada um deles podendo ter até 1000 dígitos.

Saída
Para cada caso de entrada imprima uma mensagem indicando se o segundo valor encaixa no primeiro valor, confome exemplo abaixo.
 */


using System;
using System.IO;
using System.Linq;

namespace desafioOne3

{

class Program

{

static void Main(string[] args)

{

int qt = int.Parse(Console.ReadLine());

for(int i=1; i<=qt; i++)

{

string[] v = Console.ReadLine().Split(' ');

string a = v[0];

string b = v[1];


if (!a.EndsWith(b) )

{

Console.WriteLine("nao encaixa");

}

else if(a.EndsWith(b))

{

Console.WriteLine("encaixa");

}

else{

Console.WriteLine("não encaixa");

}

}

}

}

} 