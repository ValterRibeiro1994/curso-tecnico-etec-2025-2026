<?php

// Ative relatório de erros durante o desenvolvimento
ini_set('display_errors', 1);
error_reporting(E_ALL);

// Define o cabeçalho para resposta JSON
header('Content-Type: application/json; charset=utf-8');

// Verifica método HTTP
$method = $_SERVER['REQUEST_METHOD'];

function metodo_post() {
    // Obtém os dados do corpo da requisição
    $resposta_json = file_get_contents("php://input");
    $resposta = json_decode($resposta_json);

    // Validação: JSON válido?
    if (!$resposta || !isset($resposta->acao)) {
        echo json_encode(["msg" => "Erro: JSON inválido ou ação não informada."]);
        return;
    }

    // Processa a ação informada
    switch ($resposta->acao) {
        case 'cadastrar':
            $response = [
                "status" => "sucesso",
                "msg" => "Usuário cadastrado com sucesso!",
                "dados_recebidos" => $resposta
            ];
            echo json_encode($response);
            break;
        default:
            echo json_encode(["msg" => "Erro: Ação desconhecida."]);
    }
}

switch ($method) {
    case 'POST':
        metodo_post();
        break;
    case 'GET':
        echo json_encode(["msg" => "Método GET não suportado."]);
        break;
    default:
        echo json_encode(["msg" => "Método não suportado."]);
}
