const pessoa = {
    saudacao: 'Bom dia!',
    falar(){
        console.log(this.saudacao)
    }
}

pessoa.falar()
const falar = pessoa.falar
falar() // conflito entre paradigmas: Funcional e o OO

const falarDePessoa = pessoa.falar.bind(pessoa)
/*
Função Bind garante que o this selecione o 
componente correto no escopo da função
*/
falarDePessoa()
