const _ = require('lodash')//Não precisa de ./, o node procura direto em node_modules
setInterval(() => console.log(_.random(1,100)), 2000)


