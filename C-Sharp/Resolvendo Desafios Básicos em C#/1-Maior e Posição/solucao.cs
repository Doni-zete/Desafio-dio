/* Desafio
Você recebeu o desafio de ler 100 valores inteiros. Apresente então o maior valor lido e a posição dentre os 100 valores lidos.

Entrada
O arquivo de entrada contém 100 números inteiros, positivos e distintos.

Saída
Apresente o maior valor lido e a posição de entrada, conforme exemplo abaixo.

Exemplo de Entrada	Exemplo de Saída
2                         34565
113                        4   
45
34565
6
...
8
 
 */

using System; 

class TESTE {

    static void Main(string[] args) { 
            int numero;
            int maior = 0;
            int posicao = 0;
            for(int i = 1; i <= 100 ; i++)
            {
                numero = Convert.ToInt32(Console.ReadLine());
                if(numero > maior)
                {
                    maior = numero          ;
                    posicao = i      ;     //Complete o código nos espaços em branco
                } 
            }
            Console.WriteLine(maior);
            Console.WriteLine(posicao);

    }

}