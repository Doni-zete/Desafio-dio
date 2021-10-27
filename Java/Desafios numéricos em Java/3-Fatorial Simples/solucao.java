/*
 
 QUESTÃO
 Ler um valor N. Calcular e escrever seu respectivo fatorial. 
 Fatorial de N = N * (N-1) * (N-2) * (N-3) * ... * 1.
 ENTRADA
 A entrada contém um valor inteiro N (0 < N < 13).
 SAÍDA
 A saída contém um valor inteiro, correspondente ao fatorial de N.
*/

import java.io.IOException;
import java.util.Scanner;

public class App {
	
    public static void main(String[] args) throws IOException {
        Scanner leitor = new Scanner(System.in);
        int Num = leitor.nextInt();
        int fatorial = 1;
        for (int i = 1; i <= Num; i++) {
        	fatorial *= i;
        }
        System.out.println(fatorial);
    }
	
}