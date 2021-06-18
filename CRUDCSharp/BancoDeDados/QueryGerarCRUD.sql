CREATE TABLE Usuarios (
	UsuarioID int IDENTITY(1,1) PRIMARY KEY,
	Nome varchar(40) NOT NULL,
	LoginUsuario varchar(10) UNIQUE NOT NULL,
	Senha varchar(20) NOT NULL,
	isAdmin bit NOT NULL
);

CREATE TABLE Estados (
	EstadoID int IDENTITY(1,1) PRIMARY KEY,
	Nome varchar(20) NOT NULL,
	UF varchar(2) NOT NULL
);

CREATE TABLE Cidades (
	CidadeID int IDENTITY(1,1) PRIMARY KEY,
	Nome varchar(60) NOT NULL,
	EstadoKey int FOREIGN KEY REFERENCES Estados(EstadoID)
);

CREATE TABLE Clientes (
	ClienteID int IDENTITY(1,1) PRIMARY KEY,
	Nome varchar(60) NOT NULL,
	CPF_CNPJ numeric(14) NOT NULL,
	IE numeric(14) NOT NULL,
	CEP numeric(8) NOT NULL,
	Logradouro varchar(60) NOT NULL,
	Numero numeric(6) NOT NULL,
	Bairro varchar(60) NOT NULL,
	CidadeKey int FOREIGN KEY REFERENCES Cidades(CidadeID),
	Complemento varchar(60)
);

CREATE TABLE Produtos (
	ProdutoID int IDENTITY(1,1) PRIMARY KEY,
	Nome varchar(60) NOT NULL,
	Val_Custo numeric(14,4) NOT NULL,
	Val_Venda numeric(14,4) NOT NULL
);

CREATE TABLE PedidosVenda (
	PedidoID int IDENTITY(1,1) PRIMARY KEY,
	ClienteKey int FOREIGN KEY REFERENCES Clientes(ClienteID) NOT NULL,
	Acrescimo numeric(14,4),
	Desconto numeric(14,4),
	ValorTotal numeric(14,4) NOT NULL
);

CREATE TABLE PedidosVendaItens (
	PedidoKey int FOREIGN KEY REFERENCES PedidosVenda(PedidoID) NOT NULL,
	ProdutoKey int FOREIGN KEY REFERENCES Produtos(ProdutoID) NOT NULL,
	Quantidade numeric(14,4) NOT NULL,
	ValorProduto numeric(14,4) NOT NULL
);