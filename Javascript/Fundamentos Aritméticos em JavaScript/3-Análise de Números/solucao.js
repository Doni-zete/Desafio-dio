/*Desafio
Você deve fazer a leitura de 5 valores inteiros. Em seguida mostre quantos valores informados são pares, quantos valores informados são ímpares, quantos valores informados são positivos e quantos valores informados são negativos*/



numero = Array(5);

numero[0] = -5;
numero[1] = 0;
numero[2] = -3;
numero[3] = -4;
numero[4] = 12;

pares = numero.filter((v) => Math.abs(v) % 2 ===0);
impares = numero.filter((v) => Math.abs(v)  % 2 === 1);

positivos = numero.filter((v) => v  > 0 );
negativos = numero.filter((v) => v  <0 );

console.log(pares.length + " valor(es) par(es)");
console.log(impares.length + " valor(es) impar(es)");

console.log(positivos.length + " valor(es) positivo(s)");
console.log(negativos.length + " valor(es) negativo(s)");