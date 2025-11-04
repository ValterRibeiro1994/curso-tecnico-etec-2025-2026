<?php

$method = $_SERVER['REQUEST_METHOD'];

switch ($method) {
    case 'POST':
        $json_string = file_get_contents("php://input");
        $data = json_decode($json_string);

        $acao = $data->acao ?? 'desconhecida';

        if ($acao ===  'gravar') {
            echo json_encode(['Resposta' => true, 'msg' => ' Dados gravados com sucesso']);
        } elseif ($acao === 'calcular_media') {
            
            $n1 = $data->nota1;
            $n2 = $data->nota2;
            $n3 = $data->nota3;

            $media = ($n1 + $n2 + $n3) / 3;

            if ($media >= 0 && $media < 7) {
                $resultado = "Reprovado";
            } else {
                $resultado = "Aprovado";
            }

            echo json_encode(['Resposta' => true, "media" => $media, "Resultado" => $resultado]);
        }
        break;
    
    default:
        # code...
        echo $acao;
        break;
}