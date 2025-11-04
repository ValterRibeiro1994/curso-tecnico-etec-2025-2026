async function funcao_gravar(){
    const responseServer = document.getElementById("responseServer");
    const formularioAluno = document.getElementById("CadastroAlunos");
    const dadosFormulario = new FormData(formularioAluno);

    const dados = Object.fromEntries(dadosFormulario.entries());
    dados.acao = "gravar";

    try {
        const response = await fetch("controle_aluno.php", {
            method: 'POST',
            headers: {'Content-Type': 'application/json',},
            body: JSON.stringify(dados)
        });

        const resultado = await response.json();
        alert("Mensagem do Servidor: " + resultado.msg);
        responseServer.textContent = resultado.msg;
    } catch (error){
        console.error("Erro na gravação: ", error);
    }
}

async function calcular_media() {
    const responseServer = document.getElementById("responseServer");
    const nota1 = Number(document.getElementById("nota1").value);    
    const nota2 = Number(document.getElementById("nota2").value);    
    const nota3 = Number(document.getElementById("nota3").value);

    const dadosObjeto = {
        nota1,
        nota2,
        nota3,
        acao: "calcular_media"
    };
    try {
        const response = await fetch("controle_aluno.php", {
            method: 'POST',
            headers: {'Content-Type': 'application/json',},
            body: JSON.stringify(dadosObjeto)
        });

        const Resultado = await response.json();

        const texto = `Média Aluno: ${Resultado.media}, Resultado Final: ${Resultado.Resultado}`;
        alert(texto);
        responseServer.textContent = texto;
    } catch (error) {
        alert("Erro no calculo: " + error);
    }
}