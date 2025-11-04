<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
</head>
<body>
    <div id="div_formulario">
        <form id="formulario_cadastro">
            <fieldset>
                <legend>Cadastro de usuário</legend>

                <label for="nome">Nome: </label>
                <input type="text" name="nome" id="id_nome" required> <br><br>

                <label for="ano_nascimento">Ano de Nascimento: </label>
                <input type="date" name="ano_nascimento" id="id_ano_nascimento" required> <br><br>

                <label for="cpf">CPF: </label>
                <input type="text" name="cpf" id="id_cpf" required> <br><br>

                <label for="email">E-mail: </label>
                <input type="email" name="email" id="id_email" pattern="@" required> <br><br>

                <label for="telefone">Telefone: </label>
                <input type="text" name="telefone" id="id_telefone" required> <br><br>

                <label for="senha1">Senha: </label>
                <input type="password" name="senha1" id="id_senha1" required> <br><br>

                <label for="confirmar_senha">Confirmar Senha: </label>
                <input type="password" name="confirmar_senha" id="id_confirmar_senha" required> <br><br>

                <input type="button" value="Cadastrar" onclick="cadastrar_usuario()">
            </fieldset>
            <div id="resposta_servidor">-> </div>                
        </form>
        <script src="js/cadastrar_usuario.js"></script>
    </div>
</body>
</html>