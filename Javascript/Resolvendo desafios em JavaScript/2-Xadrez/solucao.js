/* No tabuleiro de xadrez, a casa na linha 1, coluna 1 (canto superior esquerdo)
 é sempre branca e as cores das casas se alternam entre branca e preta,
  formando o formato tão conhecido como xadrez. Dessa forma, 
  como o tabuleiro tradicional tem oito linhas e oito colunas
  , a casa na linha 8, coluna 8 (canto inferior direito) será também branca.
  Porém, neste problema, queremos ser capazes de predizer a cor independente 
  do número de linhas e colunas, sendo: L linhas e C colunas. No exemplo da figura, 
  para L = 6 e C = 9, a casa no canto inferior direito será preta, uma simples previsão matemática, não?
 */


let input = require("fs").readFileSync("stdin", "utf8");

var l = parseInt(input[0]);
var c = parseInt(input[1]);

if (l % 2 === 0) {
  if (c % 2 === 0) {
    console.log(1);
  } else {
    console.log(0);

  }

} else if (0) {

  console.log(0);

} else {

  console.log(1);

}

