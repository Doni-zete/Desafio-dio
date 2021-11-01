/* Desafio
Faça um programa que leia um valor qualquer e 
apresente uma mensagem dizendo em qual dos seguintes intervalos 
([0,25], (25,50], (50,75], (75,100]) este valor se encontra. 
Caso o valor não esteja em nenhum destes intervalos, 
deverá ser impressa a mensagem: “Fora de intervalo”.

O símbolo ( representa "maior que". Por exemplo:
[0,25]  indica valores entre 0 e 25.0000, inclusive eles.
(25,50] indica valores maiores que 25 Ex: 25.00001 até o valor 50.0000000

Entrada
O arquivo de entrada contém um número com ponto flutuante qualquer.

Saída
A saída deve ser uma mensagem conforme exemplo abaixo. */

let input = require("fs").readFileSync("stdin", "utf8");

let X = parseInt(input);

if (X >= 0 && X <= 25) {
  console.log("Intervalo [0,25]");

} else if (X > 25 && X <= 50) {
  console.log("Intervalo (25,50]");

} else if (X > 50 && X <= 75) {
  console.log("Intervalo (50,75]");

} else if (75 < 100) {
  console.log("Intervalo (75,100]");//complete o código nos espaços em branco

} else {
  console.log("Fora de intervalo");

}