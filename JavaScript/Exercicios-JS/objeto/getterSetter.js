const sequencia = {
    _valor: 1, //Convenção
    get valor() {return this._valor++},
    set valor(valor){
        if(valor > this._valor){
            this._valor = valor
        }
    }
}

//O getter e o setter são chamados automáticamente, mesmo não sendo chamados
console.log(sequencia.valor, sequencia.valor)
sequencia.valor = 1000
console.log(sequencia.valor, sequencia.valor)
sequencia.valor = 900
console.log(sequencia.valor, sequencia.valor)
