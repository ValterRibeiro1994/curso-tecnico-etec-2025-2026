function imprimir_resposta(id_tag, resposta){
    document.getElementById(id_tag).textContent = resposta;
}

function converter_formulario(id_form, acao_executada){
    // armazena os dados do formulario
    let formulario = document.getElementById(id_form);

    // converte para um objeto
    let formulario_objeto = new FormData(formulario);

    // converte para um objeto simples JavaScript
    let dados_formulario = Object.fromEntries(formulario_objeto.entries());
    
    // define a ação a ser executada
    dados_formulario.acao = acao_executada;

    // retorna o objeto pronto para ser convertido em json
    return dados_formulario;
}
 
async function cadastrar_usuario(){
    try {
        // envia o formulario para o servidor, e fica escutando a resposta
        // body é onde deve ser enviada a respota
        let resposta_php = await fetch("http://localhost/trabalho-farmacia1/js/server/cadastro_usuario.php", {
            method: 'POST',
            headers: {"Content-Type": 'application/json',},
            body: JSON.stringify(converter_formulario("formulario_cadastro", "cadastrar"))
        })

        // armazena a resposta do php
        let resultado = await resposta_php.json();
        imprimir_resposta("resposta_formulario", resultado.msg);
    } catch (erro){
        imprimir_resposta("resposta_formulario", "Erro de cadastro: " + erro);
    }
}