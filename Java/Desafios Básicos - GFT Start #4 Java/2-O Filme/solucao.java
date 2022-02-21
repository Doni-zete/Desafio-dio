/* A única linha da entrada consiste de dois valores
 A e B (0.00 < A ≤ B ≤ 1000.00), os quais, fornecidos
com exatos dois dígitos após o ponto separador decimal,
representam respectivamente o valor antigo e o valor
novo do ingresso do cinema.

Saída
A única linha da saída deve consistir unicamente de um valor, 
que represente como uma porcentagem o aumento do valor do ingresso.
 O valor deve ser acompanhado do símbolo % e conter exatos 
 dois dígitos após o ponto separador decimal.

 
Exemplos de Entrada	      Exemplos de Saída
20.00 30.00                 50.00%

 
50.00 100.00                100.00%

10.00 10.00                 0.00% */

import java.io.IOException;
import java.util.Scanner;

public class solucao {

  public static void main(String[] args) throws IOException {
    Scanner leitor = new Scanner(System.in);
    double A = leitor.nextDouble();
    double B = leitor.nextDouble();

    double C = (B * 100.0 / A) - 100.0;
    {
      System.out.println(String.format("%.2f%%", C));
    }
    // Escreva aqui a sua lógica
  }

}