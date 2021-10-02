/* Desafio
Leia a hora inicial, minuto inicial, hora final e minuto final de um jogo. A seguir calcule a duração do jogo.

Obs: O jogo tem duração mínima de um (1) minuto e duração máxima de 24 horas.

Entrada
Quatro números inteiros representando a hora de início e fim do jogo.

Saída
Mostre a seguinte mensagem: “O JOGO DUROU XXX HORA(S) E YYY MINUTO(S)” . 


Exemplo de Entrada	Exemplo de Saída
7 8 9 10

O JOGO DUROU 2 HORA(S) E 2 MINUTO(S)

7 7 7 7

O JOGO DUROU 24 HORA(S) E 0 MINUTO(S)

7 10 8 9

O JOGO DUROU 0 HORA(S) E 59 MINUTO(S)


*/


using System; 


class Programa {

        public static void Main()
        {
            
            int a, b, x, y;
            string[] s = Console.ReadLine().Split(' ');
            a = int.Parse(s[0]); //hora inicial
            x = int.Parse(s[1]); // minuto inicial
            b = int.Parse(s[2]); // hora final
            y = int.Parse(s[3]); // minuto final
            int day = 0;
            TimeSpan ini = new TimeSpan(a, x, 0);
        	TimeSpan fim = new TimeSpan(b, y, 0);
        	double MockMins = fim.Subtract(ini).TotalMinutes;
        	if (MockMins <= 0) { day = 1; }
        	TimeSpan TSini = new TimeSpan(0, a, x, 0, 0);
        	TimeSpan TSfim = new TimeSpan(day, b, y, 0, 0);
        		
        	TimeSpan spanT = TSfim.Subtract(TSini);
        		
        	double TotalMin = spanT.TotalMinutes;
        		
        	int H = (int)TotalMin / 60;
        	int M = (int)TotalMin % 60;
      		Console.WriteLine("O JOGO DUROU {0} HORA(S) E {1} MINUTO(S)", H, M);
        }
}