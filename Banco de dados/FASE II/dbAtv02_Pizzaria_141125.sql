create database [dbAtv02_Pizzaria_141125];

use dbAtv02_Pizzaria_141125;

create table tb_cliente(
		id_cliente int NOT NULL PRIMARY KEY,
		nome_cliente varchar(60) not null,
		endereco_cliente varchar(120) not null,
		fone_cliente char(16) not null unique,
		--status_cliente varchar(40) not null,
		dta_cadastro_cliente datetime not null
);

create table tb_funcionario(
	id_funcionario int not null primary key,
	nome_funcionario varchar(60) not null,
	dta_nasc_funcionario date not null,
	fone_funcionario char(16) not null,
	funcao_funcionario varchar(40) not null,
	endereco_funcionario varchar(120) not null,
	dta_adm_funcionario date not null,
	--senha_funcionario varchar(20) not null,
	--cpf_funcionario char(14) not null unique,
	rg_funcionario char(12) not null unique,
	status_funcionario varchar(40),
);

create table tb_fornecedor(
	id_fornecedor int not null primary key,
	razao_fornecedor varchar(60) not null,
	nome_fantasia_fornecedor varchar(60) not null,
	endereco_fornecedor varchar(120) not null,
	--cnpj_fornecedor char(19) not null,
	--email_fornecedor varchar(80),
	fone_fornecedor char(16) not null,
	status_fornecedor varchar(40),
);

create table tb_produto(
	id_produto int not null primary key,
	nome_produto varchar(60) not null unique,
	valor_compra_produto numeric(6, 2) not null,
	valor_venda_produto numeric(6, 2) not null,
	qtd_produto numeric (4, 1) not null,
	status_produto varchar(40) not null,
	descricao_produto text,
);

create table tb_caixa(
	id_caixa int not null primary key,
	dta_caixa datetime not null,
	id_funcionario int not null,
	valor_inicio_caixa numeric (5, 2) not null,
	valor_fecha_caixa numeric (7, 2) not null,
	dinheiro_caixa numeric (7, 2) not null,
	debito_caixa numeric (7, 2) not null,
	credito_caixa numeric (7, 2) not null,
	foreign key (id_funcionario) references tb_funcionario (id_funcionario),
);

create table tb_pedido_compra(
	id_compra int not null primary key,
	id_funcionario int not null,
	--dta_compra datetime not null,
	valor_compra numeric (6,2) not null,
	status_compra varchar(40) not null,
	id_fornecedor int not null,
	foreign key (id_fornecedor) references tb_fornecedor (id_fornecedor),
	foreign key (id_funcionario) references tb_funcionario (id_funcionario)
);

create table tb_pedido_venda(
	id_venda int not null primary key,
	id_funcionario int not null,
	id_cliente int not null,
	dta_venda datetime not null,
	status_venda varchar(40) not null,
	cpf_venda char(14),
	foreign key (id_funcionario) references tb_funcionario (id_funcionario),
	foreign key (id_cliente) references tb_cliente (id_cliente),
);

create table tb_item_venda(
	id_item_venda int not null primary key,
	id_venda int not null,
	id_produto int not null,
	n_item_venda int not null,
	qtd_item_venda numeric(3,1) not null,
	valor_item_venda numeric(5,2) not null,
	foreign key (id_venda) references tb_pedido_venda (id_venda),
	foreign key (id_produto) references tb_produto (id_produto),
);

create table tb_compra(
	id_item_compra int not null primary key,
	id_produto int not null,
	id_compra int not null,
	valor_item_compra numeric(5,2) not null,
	lote_item_compra varchar(40) not null,
	validade_item_compra date,
	n_item_compra int not null,
	qtd_item_compra numeric(4,1) not null,
	foreign key (id_produto) references tb_produto (id_produto),
	foreign key (id_compra) references tb_pedido_compra (id_compra),
);