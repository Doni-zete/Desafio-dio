/* Leia um valor inteiro X (1 <= X <= 1000). Em seguida mostre os ímpares de 1 até X, um valor por linha, inclusive o X, se for o caso.

Entrada
O arquivo de entrada contém 1 valor inteiro qualquer.

Saída
Imprima todos os valores ímpares de 1 até X, inclusive X, se for o caso. */


using System; 

class Program {

        public static void Main()
        {
            int n;
            n = int.Parse(Console.ReadLine());
            //complete seu codigo
            for (int i=1; i<=n; i++) //complete seu codigo
            {
              if(i %2 ==1)
                Console.WriteLine(i);
            }
            
            Console.ReadLine();
        }

}