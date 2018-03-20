CREATE TABLE Carrinho
	(
		IdCarrinho int identity not null,
		IdCliente int not null,
		IdProduto int not null   
	)

ALTER TABLE Clientes
ADD CONSTRAINT PK_Clientes
PRIMARY KEY (IdCliente)

ALTER TABLE Carrinho
ADD CONSTRAINT FK_IdCliente
FOREIGN KEY (IdCliente)
REFERENCES Clientes(IdCliente)

ALTER TABLE Produtos
ADD CONSTRAINT PK_Produtos
PRIMARY KEY (IdProduto)

ALTER TABLE Carrinho
ADD CONSTRAINT FK_IdProduto
FOREIGN KEY (IdProduto)
REFERENCES Produtos(IdProduto)