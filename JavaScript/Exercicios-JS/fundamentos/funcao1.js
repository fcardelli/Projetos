//Função sem retorno
function imprimirSoma(a, b) {
    console.log(a + b);
}

imprimirSoma(2, 3)
/*No javascript é possivel adicionar mais/menos 
parametros para um função.*/
imprimirSoma(2)
imprimirSoma(2, 3, 4, 5, 6, 7, 8)
imprimirSoma() //Mesmo sem parametros ele analise os valores de a + b e retorna NaN

//Função sem retorno
function soma (a, b = 1) {
    return a + b
}

console.log(soma(2, 3))
console.log(soma(2))