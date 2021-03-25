/* let lista =['maça','pera','laranja'];
lista.push("uva");
/* lista.pop(); */
/* console.log(lista);
console.log(lista.toString());
console.log(lista.join(" - "));
 */


/* let frutas = [{ nome: 'maça', cor: 'vermelha' }, { nome: 'uva', cor: "roxo" }]
console.log(frutas);
alert(frutas[1].nome);
 */

/* let idade = prompt("Qual e a idade");

if (idade > 18) {
    alert("maior de idade");
} else {
    alert("menor de idade");

}; */


/* let count = 0;
while (count <=5 ){
    console.log(count);
    alert(count);
    count ++;
}; */

/* let count;
for (count = 0; count <= 5; count++) {
   alert(count);
}; */

/* let d =new Date();
alert(d.getHours());
alert(d.getHours()); */

/* function soma(n1,n2){
    return n1+n2;
}
let validar=0;

function validaIdade(idade){
    let validar;
    if(idade >=18){
        validar =true
    }else{
        validar =false
    }
    return validar;
}

let idade = prompt("Qual e sua idade");
validaIdade(idade)
console.log(validar);
 */


/* alert(setReplace("vai japão", "Japão","Brasil"));

BUTTOM */
function botao() {
    document.getElementById("agradecimento").innerHTML = "<b>Obrigado por clicar<b>";


    //alert ("Voce Clicou! Obrigado por clicar");

}

function redirecionar() {
    //window.open("https://github.com/Doni-zete");
    window.location.href = "https://github.com/Doni-zete";

}

function trocar(elemento) {
    //document.getElementById("mousemove").innerHTML ="Obrigado por passar o mouse";
    elemento.innerHTML = "Obrigado por passar o mouse";

}


function voltar(elemento) {
    //document.getElementById("mousemove").innerHTML ="Passe o mouse aqui";
    elemento.innerHTML = "Passe o mouse aqui";

}   
function load(){
alert("Pagina carregada");
}
function funcaoChange(elemento){
    console.log(elemento.value);
}