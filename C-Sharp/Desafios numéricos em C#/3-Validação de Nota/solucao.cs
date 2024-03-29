/* Desafio
Para ajudar a calcular as notas referentes às duas avaliações dos alunos, uma professora pediu para que você desenvolva um programa que calcule e imprima a média semestral. Faça com que o algoritmo só aceite notas válidas (uma nota válida deve pertencer ao intervalo [0,10]). Cada nota deve ser validada separadamente.

Entrada
A entrada contém vários valores reais, positivos ou negativos. O programa deve ser encerrado quando forem lidas duas notas válidas.

Saída
Se uma nota inválida  for lida, deve ser impressa a mensagem "nota invalida".
Quando duas notas válidas forem lidas, deve ser impressa a mensagem "media = " seguido do valor do cálculo. O valor deve ser apresentado com duas casas após o ponto decimal. */




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program {
  
  static void Main(string[] args) {
    
    int duasNotas = 0;
    double media = 0;

    
        do
        {
          double nota = double.Parse(Console.ReadLine());
          
          if (nota < 0 || nota > 10)
          {
          Console.WriteLine("nota invalida");
          }
          else if (nota >= 0 && nota <= 10)
          {
            media += nota / 2;
            duasNotas++;
          }

        } while (duasNotas < 2);
        
        Console.WriteLine($"media = {media.ToString("N2")}");

  }
}