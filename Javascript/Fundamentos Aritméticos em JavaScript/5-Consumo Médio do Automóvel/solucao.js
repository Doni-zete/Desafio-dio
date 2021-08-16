let input = require("fs").readFileSync("stdin", "utf8");


let [distancia,combustivelConsumido] = input.split("\n");

let consumoMedio = distancia/combustivelConsumido;

console.log(`${consumoMedio.toFixed(3)} km`);