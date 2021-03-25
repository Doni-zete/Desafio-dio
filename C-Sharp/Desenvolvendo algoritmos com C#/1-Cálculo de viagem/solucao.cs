using System;
using static System.Math;

class Program {
    static void Main(string[] args) {

        string[] km = Console.ReadLine().Split(" ");
        int hora = Int32.Parse(km[0]);
        int velocidade = Int32.Parse(km[1]);

        double numero = 12;
        double litro = (hora * velocidade);
        double total = litro/numero;

        Console.WriteLine(total.ToString("N3"));
    }
}