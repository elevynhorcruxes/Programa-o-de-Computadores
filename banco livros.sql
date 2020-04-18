CREATE DATABASE livros;

USE livros;

CREATE TABLE usuario (
id INT NOT NULL PRIMARY KEY,
login VARCHAR(10) NOT NULL,
senha VARCHAR(10) NOT NULL);

CREATE TABLE livros (
codLivro INT NOT NULL PRIMARY KEY,
tituloLivro VARCHAR(100) NOT NULL,
autorLivro VARCHAR(50) NOT NULL,
editoraLivro VARCHAR(70) NOT NULL,
sinopseLivro VARCHAR(300) NOT NULL,
precoLivro INT(6) NOT NULL);


CREATE TABLE livraria (
codLivraria INT NOT NULL PRIMARY KEY,
nomeLivraria VARCHAR(100) NOT NULL,
ruaLivraria VARCHAR(50) NOT NULL,
numLivraria INT(5) NOT NULL,
bairroLivraria VARCHAR(50) NOT NULL,
cidadeLivraria VARCHAR(50) NOT NULL,
estadoLivraria VARCHAR(2) NOT NULL,
siteLivraria VARCHAR(70) NOT NULL,
telefone INT(14) NOT NULL);

INSERT INTO usuario
(id,login,senha)
VALUES
(1,'adm',1234);