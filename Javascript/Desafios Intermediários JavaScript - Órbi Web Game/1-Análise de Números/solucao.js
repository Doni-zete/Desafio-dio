/* Você deve fazer a leitura de 5 valores inteiros.
Em seguida mostre quantos valores informados são pares,
 quantos valores informados são ímpares, quantos valores 
 informados são positivos e quantos valores informados 
 são negativos.Considere que o número zero é positivo, 
 mas não pode ser considerado como positivo ou negativo.

  Entrada
Você receberá 5 valores inteiros.

  Saída
Exiba a mensagem conforme o exemplo de saída abaixo,
 sendo uma mensagem por linha e não esquecendo o final de linha após cada uma.

 
Exemplo de Entrada	Exemplo de Saída
  - 5                 3 par(es)
    0                 2 impar(es)
  - 3                 1 positivo(s)
  - 4                 3 negativo(s)
    12
 */
    numero = Array(5);

    numero[0] = gets();
    numero[1] = gets();
    numero[2] = gets();
    numero[3] = gets();
    numero[4] = gets();
    
    pares = numero.filter(value => value % 2 == 0);
    impares = numero.filter(value => value % 2 != 0);
    positivos = numero.filter(value => value > 0);
    negativos = numero.filter(value => value < 0);
    
    console.log(pares.length + " par(es)");
    console.log(impares.length + " impar(es)");
    console.log(positivos.length + " positivo(s)");