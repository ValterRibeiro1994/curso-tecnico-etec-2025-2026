async function cadastrar_usuario(){
    // informar a resposta do servidor
    let enviar_resposta = document.getElementById("resposta_servidor"); // div para informar o resultado
    
    // Converter os dados do formulario para um objeto {chave: valor}
    let formulario_cadastro = document.getElementById("formulario_cadastro"); // formulario
    let dados_formulario = new FormData(formulario_cadastro); // converte para um objeto

    // Converte o formulario para om objeto simples javascript
    let dados = Object.fromEntries(dados_formulario.entries());

    // Define a ação a ser executada pelo servidor
    dados.acao = "cadastrar_usuario";
    
    // Usa uma thread para se comunicar com o lado servidor e manter o estado
    // da pagina web enquanto aguarda a resposta do servidor
    try {
        let resposta_servidor = await fetch("./php/cadastrar_usuario.php", {
            // Define o metódo get/post
            method: 'POST',
            
            // Envia o cabeçalho informando o tipo de conteudo (aplicação json)
            headers: {"Content-Type": 'application/json',},

            // Corpo da mensagem -> O objeto convertido para json (stringify)
            body: JSON.stringify(dados)
        });

        let resultado = await resposta_servidor.json();
        enviar_resposta.textContent = resultado.msg;
    } catch (error){
        enviar_resposta.textContent = "Erro de cadastro: " + error;
    }

}