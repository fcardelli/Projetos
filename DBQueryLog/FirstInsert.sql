use EspacoViviTantraDB;

INSERT INTO Bairros
	(Nome)
VALUES
	('Vila Nilo');
INSERT INTO Cidades
	(Nome)
VALUES
	('São Paulo');
INSERT INTO Estados
	(Nome)
VALUES
	('SP');
INSERT INTO TiposEnderecos
	(Descricao)
VALUES
	('Residencial');

INSERT INTO TiposEnderecos
	(Descricao)
VALUES
	('Comercial');
    
INSERT INTO Enderecos
	(BairroId,Cep,CidadeId,Complemento,EstadoId, Logradouro, Numero, TipoId)
VALUES
	(1,'02278030',1,'Casa',1,'Rua Admin','100',1);

INSERT INTO TiposTelefones
	(Descricao)
VALUES
	('Celular');
INSERT INTO TiposTelefones
	(Descricao)
VALUES
	('Residencial');
    
INSERT INTO Telefones
	(Numero, TipoId)
VALUES
	('999999999', 1);

INSERT INTO Pessoas
	(Cpf,DataNascimento,Email,EnderecoId,Nome,Rg,Sobrenome,TelefoneId)
VALUES
	('99999999999','1991-09-27 00:00:00', 'felipecardelli@gmail.com',1, 'Felipe', '999999999', 'Cardelli de Camargo',1);

INSERT INTO TiposUsuarios
	(Descricao)
VALUES
	('Administrador');
INSERT INTO TiposUsuarios
	(Descricao)
VALUES
	('Operador');
INSERT INTO TiposUsuarios
	(Descricao)
VALUES
	('Cliente');
    
INSERT INTO UsuarioStatus
	(Descricao)
VALUES
	('Ativo');
INSERT INTO UsuarioStatus
	(Descricao)
VALUES
	('Inativo');

INSERT INTO Usuarios 
	(DataCadastro, Login, Password, PessoaId, StatusId, TipoId)
VALUES
	(current_date(), 'admin', 'FB07052017!', 2,1,1);
    
SELECT * FROM Usuarios;
SELECT * FROM Enderecos;
SELECT * FROM Pessoas;