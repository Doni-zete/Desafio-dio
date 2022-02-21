/* Leia um valor de ponto flutuante com duas casas decimais.
 Este valor representa um valor monetário. A seguir, 
 calcule o menor número de notas e moedas possíveis no qual 
 o valor pode ser decomposto. As notas consideradas são de
  100, 50, 20, 10, 5, 2. As moedas possíveis são de 
  1, 0.50, 0.25, 0.10, 0.05 e 0.01. 
  A seguir mostre a relação de notas necessárias.

Entrada
O arquivo de entrada contém um valor de ponto flutuante
 N (0 ≤ N ≤ 1000000.00).

Saída
Imprima a quantidade mínima de notas e moedas necessárias
 para trocar o valor inicial, conforme exemplo fornecido.

Obs: Utilize ponto (.) para separar a parte decimal.

 
Exemplo de Entrada	      Exemplo de Saída
576.73                     NOTAS:
                            5 nota(s) de R$ 100.00
                            1 nota(s) de R$ 50.00
                            1 nota(s) de R$ 20.00
                            0 nota(s) de R$ 10.00
                            1 nota(s) de R$ 5.00
                            0 nota(s) de R$ 2.00
                            MOEDAS:
                            1 moeda(s) de R$ 1.00
                            1 moeda(s) de R$ 0.50
                            0 moeda(s) de R$ 0.25
                            2 moeda(s) de R$ 0.10
                            0 moeda(s) de R$ 0.05
                            3 moeda(s) de R$ 0.01



4.00                        NOTAS:
                            0 nota(s) de R$ 100.00
                            0 nota(s) de R$ 50.00
                            0 nota(s) de R$ 20.00
                            0 nota(s) de R$ 10.00
                            0 nota(s) de R$ 5.00
                            2 nota(s) de R$ 2.00
                            MOEDAS:
                            0 moeda(s) de R$ 1.00
                            0 moeda(s) de R$ 0.50
                            0 moeda(s) de R$ 0.25
                            0 moeda(s) de R$ 0.10
                            0 moeda(s) de R$ 0.05
                            0 moeda(s) de R$ 0.01



91.01                         NOTAS:
                              0 nota(s) de R$ 100.00
                              1 nota(s) de R$ 50.00
                              2 nota(s) de R$ 20.00
                              0 nota(s) de R$ 10.00
                              0 nota(s) de R$ 5.00
                              0 nota(s) de R$ 2.00
                              MOEDAS:
                              1 moeda(s) de R$ 1.00
                              0 moeda(s) de R$ 0.50
                              0 moeda(s) de R$ 0.25
                              0 moeda(s) de R$ 0.10
                              0 moeda(s) de R$ 0.05
                              1 moeda(s) de R$ 0.01                             */

import java.io.IOException;
import java.util.Scanner;

public class solucao {

  public static <Double> void main(String[] args) throws IOException {

    // criar matrizes com notas ; moedas disponiveis
    // alterando-se estas disponibilidades , altera-se as notas

    // matrizes com as notas disponiveis
    int[] notas = { 100, 50, 20, 10, 5, 2 };
    // matrizes das moedas disponiveis ( valor * 100 )
    int[] moedas = { 100, 50, 25, 10, 5, 1 };

    Scanner sc = new Scanner(System.in);

    int quociente, resto;

    // valor monetario a ser analisado
    // quanto a numero de notas necessarias
    double valor;

    valor = sc.nextDouble();

    // transformar o valor recebido em um numero inteiro
    // recebi 100,10
    // a contas com as notas serão feitas com 10010
    resto = (int) (valor * 100.0 + 0.5);

    // apresentando notas
    System.out.println("NOTAS:");

    // laço passando por cada valor da matriz notas
    // definindo notas
    for (int nota : notas) {
      quociente = resto / (nota * 100);
      System.out.println(quociente + " nota(s) de R$ " + nota + ".00");
      resto = resto % (nota * 100);
    }

    System.out.println("MOEDAS:");
    // laço passando por cada valor da matriz moedas
    // definindo moedas
    for (int moeda : moedas) {
      quociente = resto / moeda;

      // valor temporario para ajustar a apresentação da moeda
      double tmp = moeda;
      tmp /= 100;
      System.out.printf(quociente + " moeda(s) de R$ %.2f\n", tmp);
      resto = resto % moeda;
    }
  }
}