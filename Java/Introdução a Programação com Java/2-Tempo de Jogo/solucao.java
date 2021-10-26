/* Desafio
Tento como base a hora inicial e final de um jogo, calcule a duração do dele, sabendo que o mesmo pode começar em um dia e terminar em outro, tendo uma duração mínima de, 60 minutos e máxima de 24 horas.

Entrada
A entrada contém dois valores inteiros representando a hora de início e a hora de fim do jogo.

Saída
Apresente a duração do jogo conforme exemplo abaixo.

 
Exemplo de Entrada	Exemplo de Saída
16 2                O JOGO DUROU 10 HORA(S)



0 0                 O JOGO DUROU 24 HORA(S)



2 16                O JOGO DUROU 14 HORA(S) */



import java.io.IOException;
import java.util.Scanner;

public class App {
    
    public static void main(String[] args) throws IOException {
        Scanner leitor = new Scanner(System.in);
		
int hInicial = leitor.nextInt();
int hFinal = leitor.nextInt();

if (hInicial > hFinal) { 
	System.out.println("O JOGO DUROU " + (24 - (hInicial - hFinal)) + " HORA(S)");
} else if (hFinal > hInicial) {
	System.out.println("O JOGO DUROU " + (hFinal - hInicial) + " HORA(S)");
} else {
	System.out.println("O JOGO DUROU 24 HORA(S)");
}

    }
    
}