create database garagem13;

use garagem13;

CREATE TABLE cliente (
    id INT PRIMARY KEY AUTO_INCREMENT,
    nome VARCHAR(50) NOT NULL,
    idade INT NOT NULL,
    id_endereco INT NOT NULL,
    email VARCHAR(50) NOT NULL UNIQUE,
    telefone INT NOT NULL,
    FOREIGN KEY (id_endereco)
        REFERENCES endereco (id)
);
INSERT INTO cliente (nome, idade, id_endereco, email, telefone)
 VALUES (@nome, @idade, @id_endereco, @email, @telefone);
 
CREATE TABLE endereco (
    id INT PRIMARY KEY AUTO_INCREMENT,
    logradouro VARCHAR(100) NOT NULL,
    numero VARCHAR(10) NOT NULL,
    complemento VARCHAR(50) NULL,
    bairro VARCHAR(50) NOT NULL,
    municipio VARCHAR(50) NOT NULL,
    estado VARCHAR(2) NOT NULL,
    cep VARCHAR(8) NOT NULL
);
insert into endereco (logradouro, numero, complemento, bairro, municipio, estado, cep)
 VALUES (@logradouro, @numero, @complemento, @bairro, @municipio, @estado, @cep);
 
CREATE TABLE customizacao (
    id INT PRIMARY KEY AUTO_INCREMENT,
    aro VARCHAR(50) NOT NULL,
    quadro VARCHAR(50) NOT NULL,
    cor VARCHAR(50) NOT NULL,
    tipo VARCHAR(50) NOT NULL,
    motorizacao VARCHAR(50) NOT NULL,
    cliente_id INT NOT NULL,
    FOREIGN KEY (cliente_id)
        REFERENCES cliente (id)
);
INSERT INTO customizacao (aro, quadro, cor, tipo, motorizacao, cliente_id)
VALUES (@aro, @quadro, @cor, @tipo, @motorizacao, @cliente_id);

CREATE TABLE funcionario (
    id INT PRIMARY KEY AUTO_INCREMENT,
    nome VARCHAR(50) NOT NULL,
    email VARCHAR(50) NOT NULL UNIQUE,
    senha VARCHAR(8) NOT NULL
);

insert into funcionario (nome, email, senha) values ('Matheus Selpa', 'mselpa@garagem13.com', '24681012'), ('Gabriel Gomes', 'ggomes@garagem13.com', '12345678'), ('Daniel Silva', 'dsilva@garagem13.com', '36912157');

select * from funcionario;

INSERT INTO funcionario (nome, email, senha)
VALUES (@nome, @email, @senha);