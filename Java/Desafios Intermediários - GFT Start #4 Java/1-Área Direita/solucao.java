/* Desafio
Leia um caractere maiúsculo, que indica uma operação 
que deve ser realizada e uma matriz M[12][12]. 
Em seguida, calcule e mostre a soma ou a média considerando
 somente aqueles elementos que estão na área direita da matriz,
  conforme ilustrado abaixo (área verde).

Entrada
A primeira linha de entrada contem um único caractere Maiúsculo 
O ('S' ou 'M'), indicando a operação (Soma ou Média) que deverá 
ser realizada com os elementos da matriz. 
Seguem os 144 valores de ponto flutuante que compõem a matriz.

Saída
Imprima o resultado solicitado (a soma ou média), com 1 casa
 após o ponto decimal.

 
Exemplo de Entrada	Exemplo de Saída
S                        111.4        
1.0
330.0
-3.5
2.5
4.1
...
*/

import java.util.Scanner;

public class RightArea {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        double[][] M = new double[12][12];
        double sum = 0;
        int count = 0;
        char operation = sc.next().toUpperCase().charAt(0);

        for (int i = 0; i < M.length; i++) {
            for (int j = 0; j < M.length; j++) {
                M[i][j] = sc.nextDouble();
                if ((i < j) && ((i + j) >= (M.length))) {
                    sum += M[i][j];
                    count++;
                }
            }
        }

        if (operation == 'M') sum /= count;
        System.out.printf("%.1f%n", sum);
    }
}