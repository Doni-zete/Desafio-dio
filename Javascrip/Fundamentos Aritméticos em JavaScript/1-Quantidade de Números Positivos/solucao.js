/* Desafio
Crie um programa que leia 6 valores.Você poderá receber valores negativos e / ou positivos como entrada, devendo desconsiderar os valores nulos.Em seguida, apresente a quantidade de valores positivos digitados.

    Entrada
Você receberá seis valores, negativos e / ou positivos.

    Saída
Exiba uma mensagem dizendo quantos valores positivos foram lidos assim como é exibido abaixo no exemplo de saída.Não esqueça da mensagem "valores positivos" ao final.
 */


let total = 0;

let i = 0;

let valor;

while (i < 6) {

    valor = parseFloat(gets());

    if (valor > 0) {

        total = total + 1;

    }

    i = i + 1;

}

print(total + " valores positivos");