// agora precisa de uma função que seja capaz de criar as div de sessoes
// secoes de produtos vendidos, produtos em promoção, remedios, ou sei lá o que vier

// Essa função cria um card representando um produto e o adicona dentro
// do container "div-secoes", observe que esse container tem um h2 que representa
// o nome da seção, e uma div "section-id" que armazena os cards
function criar_card_produto(nome_secao, nome_produto, descricao_produto, link_img_produto, preco_produto, link_compra){
    // a variavel nome_secao deve receber o id da div de seção
    // isso vai permitir mais flexidade permitindo gerar os card em qualquer 
    // outra seção

    // Cria os elementos necessario para criar a seção com os card's
    let section = document.createElement("section"); // cria seção
    let h3 = document.createElement("h3"); 
    let img = document.createElement("img");
    let p = document.createElement("p");
    let h4 = document.createElement("h4");
    let button = document.createElement("button");
    let a = document.createElement("a");

    // Insere os valores recebidos por parametros nos elementos
    h3.innerText = nome_produto;
    img.src = link_img_produto;
    p.innerText = descricao_produto;
    h4.innerText = preco_produto;
    a.innerText = "Comprar";
    a.href = link_compra;

    // Estiliza os elementos com classes bootstrap 5 e classes css proprias
    section.classList.add("section-card", "sombra-elementos");
    h3.classList.add("text-center", "text-white");
    img.classList.add("section-img", "sombra-elementos");
    p.classList.add("text-center", "text-white");
    h4.classList.add("text-center", "text-white");
    button.classList.add("meu-botao");
    a.classList.add("text-center", "text-link");

    // adiciona o link (tag <a>) no botão de compra do card
    button.appendChild(a);

    // adiciona as tags filhas do elemento section
    let tags_internas = [h3, img, p, h4, button]; // usa um array para agrupar elementos
    for (let i = 0; i < tags_internas.length; i++){
        // loop para percorrer os elementos do array 
        section.appendChild(tags_internas[i]); // adiciona os elementos dentro da seção
    }

    // captura a div de armazenamento dos card's
    let div_container = document.getElementById(nome_secao);
    // adiciona a sombra ao container principal
    div_container.classList.add("sombra-elementos")
    let div_interna = div_container.getElementsByTagName("div")[0]; // ele retorna um objeto, só existe uma div nessa seção
    
    // adiciona a seção dentro da div
    div_interna.appendChild(section);

    // avisa no console (terminal) que o processo foi concluido
    console.log("Processo concluido para o card do produto: " + nome_produto);
    return null; // apenas para encerrar

}

// função de teste para criar_card_produto
function testar_funcao_criar_card_produto(nome_secao){

   criar_card_produto(
            nome_secao,
            "Arroz Ouro Fino 5kg",
            "Arroz branco tipo 1, embalagem de 5 kg.",
            "img/remedio.png",
            "R$ 16,54",
            "https://www.google.com.br"
        );
        criar_card_produto(
            nome_secao,
            "Arroz Ouro Fino 5kg",
            "Arroz branco tipo 1, embalagem de 5 kg.",
            "img/remedio.png",
            "R$ 16,54",
            "https://www.google.com.br"
        );
        criar_card_produto(
            nome_secao,
            "Arroz Ouro Fino 5kg",
            "Arroz branco tipo 1, embalagem de 5 kg.",
            "img/remedio.png",
            "R$ 16,54",
            "https://www.google.com.br"
        );
        criar_card_produto(
            nome_secao,
            "Arroz Ouro Fino 5kg",
            "Arroz branco tipo 1, embalagem de 5 kg.",
            "img/remedio.png",
            "R$ 16,54",
            "https://www.google.com.br"
        );
        criar_card_produto(
            nome_secao,
            "Arroz Ouro Fino 5kg",
            "Arroz branco tipo 1, embalagem de 5 kg.",
            "img/remedio.png",
            "R$ 16,54",
            "https://www.google.com.br"
        );
}

// testar_funcao_criar_card_produto("div-secao-mais-vendidos");
// testar_funcao_criar_card_produto("div-secao-promocao");
// testar_funcao_criar_card_produto("section-promocao");