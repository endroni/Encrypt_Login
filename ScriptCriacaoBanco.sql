CREATE DATABASE db_encrypt_login;

GO

USE db_encrypt_login; 

GO

CREATE TABLE tb_usuario ( 
	id INT NOT NULL PRIMARY KEY IDENTITY(1,1),
	nome NVARCHAR(60),
	email NVARCHAR(70),
	senha NVARCHAR(150));

GO
