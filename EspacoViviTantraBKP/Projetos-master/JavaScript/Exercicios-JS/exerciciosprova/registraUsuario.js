$(document).ready(function(){
    $("button").click(function(){
        let primeiroNome = document.getElementById("primeiroNome").value
        let ultimoNome = document.getElementById("ultimoNome").value
        
        $("#labelResposta").value = primeiroNome + '' + ultimoNome
    });
});