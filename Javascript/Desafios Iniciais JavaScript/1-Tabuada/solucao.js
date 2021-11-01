/* Leia 1 valor inteiro N (2 < N < 1000). 
A seguir, mostre a tabuada de N:      
1 x N = N      2 x N = 2N        ...       10 x N = 10N

Entrada
A entrada contém um valor inteiro N (2 < N < 1000).

Saída
Imprima a tabuada de N, conforme o exemplo fornecido. */


let input = require("fs").readFileSync("stdin", "utf8");

let N = parseInt(input);

console.log("1 x " + N + " = " + (N * 1));
console.log("2 x " + N + " = " + (N * 2));
console.log("3 x " + N + " = " + (N * 3));
console.log("4 x " + N + " = " + (N * 4));
console.log("5 x " + N + " = " + (N * 5));
console.log("6 x " + N + " = " + (N * 6));
console.log("7 x " + N + " = " + (N * 7));
console.log("8 x " + N + " = " + (N * 8));
console.log("9 x " + N + " = " + (N * 9));
console.log("10 x " + N + " = " + (N * 10));

