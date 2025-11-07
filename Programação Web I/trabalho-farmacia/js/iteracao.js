// agora precisa de uma função que seja capaz de criar as div de sessoes
// secoes de produtos vendidos, produtos em promoção, remedios, ou sei lá o que vier


function criar_card_produto(nome_produto, descricao_produto, link_img_produto, preco_produto, link_compra){
    let section = document.createElement("section");
    let h3 = document.createElement("h3");
    let img = document.createElement("img");
    let p = document.createElement("p");
    let h4 = document.createElement("h4");
    let button = document.createElement("button");
    let a = document.createElement("a");

    h3.innerText = nome_produto;
    img.src = link_img_produto;
    p.innerText = descricao_produto;
    h4.innerText = preco_produto;
    a.innerText = "Comprar";
    a.href = link_compra;

    section.classList.add("section-card");
    h3.classList.add("text-center", "text-white");
    img.classList.add("section-img");
    p.classList.add("text-center", "text-white");
    h4.classList.add("text-center", "text-white");
    button.classList.add("meu-botao");
    a.classList.add("text-center", "text-link");

    button.appendChild(a);
    let tags_internas = [h3, img, p, h4, button];
    for (let i = 0; i < tags_internas.length; i++){
        section.appendChild(tags_internas[i]);
    }

    let div_interna = document.getElementById("section-id");
    div_interna.appendChild(section);
    console.log("Processo concluido");
}

// Chama a função quando a página terminar de carregar
window.onload = function() {
    criar_card_produto(
        "Arroz Ouro Fino 5kg",
        "Arroz branco tipo 1, embalagem de 5 kg.",
        "img/remedio.png",
        "R$ 16,54",
        "https://www.google.com.br"
    );
    criar_card_produto(
        "Arroz Ouro Fino 5kg",
        "Arroz branco tipo 1, embalagem de 5 kg.",
        "img/remedio.png",
        "R$ 16,54",
        "https://www.google.com.br"
    );
    criar_card_produto(
        "Arroz Ouro Fino 5kg",
        "Arroz branco tipo 1, embalagem de 5 kg.",
        "img/remedio.png",
        "R$ 16,54",
        "https://www.google.com.br"
    );
    criar_card_produto(
        "Arroz Ouro Fino 5kg",
        "Arroz branco tipo 1, embalagem de 5 kg.",
        "img/remedio.png",
        "R$ 16,54",
        "https://www.google.com.br"
    );
    criar_card_produto(
        "Arroz Ouro Fino 5kg",
        "Arroz branco tipo 1, embalagem de 5 kg.",
        "img/remedio.png",
        "R$ 16,54",
        "https://www.google.com.br"
    );

};
