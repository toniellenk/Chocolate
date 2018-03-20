CREATE TABLE Clientes
	(
		IdCliente int identity not null,
		Login varchar(500) not null,
		Password decimal(18,2),
		Cpf varchar(20),
		Nome varchar(200),
		Telefone varchar(30),
		Endereco varchar(200)
	)
