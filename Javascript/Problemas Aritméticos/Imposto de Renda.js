
/*Há um país denominado Lilipute, todos os habitantes ficam felizes em pagar seus impostos, pois sabem que nele não existem políticos corruptos e os recursos arrecadados são utilizados em benefício da população, sem qualquer desvio. A moeda deste país é o Libs, cujo símbolo é o R$.

Você terá desafio de ler um valor com duas casas decimais, equivalente ao salário de uma pessoa de Libs. Em seguida, calcule e mostre o valor que esta pessoa deve pagar de Imposto de Renda, segundo a tabela abaixo.

Lembre que, se o salário for R$ 3002.00, a taxa que incide é de 8% apenas sobre R$ 1000.00, pois a faixa de salário que fica de R$ 0.00 até R$ 2000.00 é isenta de Imposto de Renda. No exemplo fornecido (abaixo), a taxa é de 8% sobre R$ 1000.00 + 18% sobre R$ 2.00, o que resulta em R$ 80.36 no total. O valor deve ser impresso com duas casas decimais.

Entrada
A entrada contém apenas um valor de ponto flutuante, com duas casas decimais.

Saída
Imprima o texto "R$" seguido de um espaço e do valor total devido de Imposto de Renda, com duas casas após o ponto. Se o valor de entrada for menor ou igual a 2000, deverá ser impressa a mensagem "Isento".

*/


var calc = gets();
calc = parseFloat(calc);

if (calc<=2000){
  console.log('Isento');
} else if (calc<=3000) {
  segundaFaixa = (calc - 2000)*0.08;
  result = parseFloat(segundaFaixa);
  result = result.toFixed(2);
  console.log('R$ ' + result);
} else if (calc<=4500) {
    flag1 = calc - 2000;
    flag2 = calc - 3000;
    flag2 = flag2>=0 ? flag2 : 0;
    segundaFaixa = ((calc - 2000)-flag2)* 0.08;
    terceiraFaixa = (calc - 3000) * 0.18;
    result = parseFloat(segundaFaixa+terceiraFaixa);
    result = result.toFixed(2);
      console.log('R$ ' + result);
} else {
    flag1 = calc - 2000;
    flag2 = calc - 3000;
    flag3 = calc - 4500;
    flag2 = flag2>=0 ? flag2 : 0;
    flag3 = flag3>=0 ? flag3 : 0;
    segundaFaixa = ((calc - 2000)-flag2)* 0.08;
    terceiraFaixa = ((calc - 3000)-flag3) * 0.18;
    quartaFaixa =  (calc-4500) * 0.28;
    result = parseFloat(segundaFaixa+terceiraFaixa+quartaFaixa);
    result = result.toFixed(2);
   console.log('R$ ' + result);
}