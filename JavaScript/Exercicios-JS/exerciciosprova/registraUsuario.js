$(document).ready(function(){
    $("submit").click(function(){
        let primeiroNome = document.getElementById('primeiroNome').value
        let ultimoNome = document.getElementById('ultimoNome').value

        document.getElementById('labelResposta').innerHTML = primeiroNome + '' + ultimoNome
    });
});