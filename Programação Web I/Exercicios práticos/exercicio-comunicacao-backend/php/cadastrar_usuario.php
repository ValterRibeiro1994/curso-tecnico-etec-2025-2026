<?php

$method = $_SERVER['REQUEST_METHOD'];

switch ($method){
    case 'POST':
        $resposta_json = file_get_contents('php://input');
        $resposta = json_decode($resposta_json);

        $acao = $resposta->acao ?? 'desconhecida';
        if ($acao === 'desconhecida'){
            echo json_encode(['resposta' => false, 'msg' => 'Solicitação Desconhecido']);
        } elseif ($acao === 'cadastrar_usuario'){
            echo json_encode(['resposta' => true, 'msg' => 'Cadastro realizado com sucesso']);
        } else {
            echo json_encode(['resposta' => false, 'msg' => 'Método solicitado desconhecido']);
        }
        break;
    case 'GET':
        echo json_encode(['resposta' => false, 'msg' => 'Método Get em desenvolvimento !!!']);
        break;
    default:

        echo json_encode(['resposta' => false, 'msg' => 'Método inválido']);
        break;
    }
