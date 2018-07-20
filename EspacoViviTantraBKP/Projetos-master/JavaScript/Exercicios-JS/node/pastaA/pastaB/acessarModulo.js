const modulaA = require('../../moduloA')
console.log(modulaA.ola)

const saudacao = require('saudacao')
console.log(saudacao.ola)

const c = require('./pastaC/index')

const http = require('http')
http.createServer((req, res) => {
    res.write('Bom dia!')    
    res.end()
}).listen(8080)