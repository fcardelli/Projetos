const escola = "Cod3r"

//Letra na posição 4
console.log(escola.charAt(4))
//console.log(escola.chatAt(5))
//Código do caractere na posição 3
console.log(escola.charCodeAt(3))
console.log(escola.indexOf('3'))

//Remove um caractere conforme a posição
console.log(escola.substring(1))
console.log(escola.substring(0, 3))

//Concatena strings
console.log('Escola'.concat(escola).concat("!"))
console.log('Escola' + escola + "!")

//Substitui caracteres
console.log(escola.replace(3, 'e'))


console.log('Ana,Maria,Pedro'.split(','))