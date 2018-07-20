const notas = [7.7, 6.5, 5.2, 8.9, 3.6, 7.1, 9.0]

//Sem Callback
let notasBaixas1 = []
for(let i in notas){
    if(notas[i] < 7){
        notasBaixas1.push(notas[i])
    }
}

console.log(notasBaixas1)

// Com Callback
notasBaixas2 = notas.filter(function (nota){
    return nota < 7
})

console.log(notasBaixas2)

//Forma elegante
//notasMenosQue7 = nota => nota < 7
//const notasBaixas3 = notas.filter(notasMenosQue7)
const notasBaixas3 = notas.filter(nota => nota < 7)
console.log(notasBaixas3)
