// pessoa -> 123 -> {...}

const pessoa = {nome: 'Joao'}
pessoa.nome = 'Pedro'
console.log(pessoa)

//pessoa -> 456 -> {...}
//pessoa = {nome: 'Ana'}
//console.log(pessoa)

Object.freeze(pessoa)

pessoa.nome = 'Maria'
pessoa.end = 'Rua Abc do B'
delete pessoa.nome
//O freeze permite congelar qualquer mudança que ocorra no objeto
console.log(pessoa.nome)
console.log(pessoa)

//Setando a const como um objeto constante utilizando freeze
const pessoaConstante = Object.freeze({nome: 'João'})
pessoaConstante.nome = 'Maria'
console.log(pessoaConstante)

