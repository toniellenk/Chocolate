CREATE TABLE Produtos
	(
		IdProduto int identity not null,
		Descricao varchar(500) not null,
		Preco decimal(18,2),
		EstoqueDisponivel int
	)
