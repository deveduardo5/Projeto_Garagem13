create database garagem13;

USE garagem13;

CREATE TABLE cliente (
    id INT PRIMARY KEY AUTO_INCREMENT,
    nome VARCHAR(50) NOT NULL,
    idade VARCHAR(3) NOT NULL,
    email VARCHAR(50) NOT NULL UNIQUE,
    telefone VARCHAR(15) NOT NULL,
    logradouro VARCHAR(100) NOT NULL,
    numero VARCHAR(10) NOT NULL,
    complemento VARCHAR(50),
    bairro VARCHAR(50) NOT NULL,
    municipio VARCHAR(50) NOT NULL,
    estado VARCHAR(2) NOT NULL,
    cep VARCHAR(8) NOT NULL
);


CREATE TABLE aro (
    id INT PRIMARY KEY AUTO_INCREMENT,
    marca VARCHAR(50),
    tamanho_em_polegadas INT NOT NULL,
    modelo VARCHAR(50) NOT NULL,
    preco DECIMAL(10,2)
);


CREATE TABLE quadro (
    id INT PRIMARY KEY AUTO_INCREMENT,
    marca VARCHAR(50),
    tamanho_em_polegadas INT NOT NULL,
    modelo VARCHAR(50) NOT NULL,
    preco DECIMAL(10,2)
);


CREATE TABLE motorizacao (
    id INT PRIMARY KEY AUTO_INCREMENT,
    marca VARCHAR(50),
    potencia INT NOT NULL,
    modelo VARCHAR(50) NOT NULL,
    preco DECIMAL(10,2)
);


CREATE TABLE cor (
    id INT PRIMARY KEY AUTO_INCREMENT,
    marca VARCHAR(50),
    tipo_de_tinta VARCHAR(30) NOT NULL,
    preco DECIMAL(10,2)
);


CREATE TABLE customizacao (
    id INT PRIMARY KEY AUTO_INCREMENT,
    aro_id INT NOT NULL,
    quadro_id INT NOT NULL,
    cor_id INT NOT NULL,
    motorizacao_id INT NOT NULL,
    cliente_id INT NOT NULL,
    FOREIGN KEY (aro_id) REFERENCES aro(id),
    FOREIGN KEY (quadro_id) REFERENCES quadro(id),
    FOREIGN KEY (cor_id) REFERENCES cor(id),
    FOREIGN KEY (motorizacao_id) REFERENCES motorizacao(id),
    FOREIGN KEY (cliente_id) REFERENCES cliente(id)
);


CREATE TABLE funcionario (
    id INT PRIMARY KEY AUTO_INCREMENT,
    nome VARCHAR(50) NOT NULL,
    email VARCHAR(50) NOT NULL UNIQUE,
    senha VARCHAR(14) NOT NULL
);



INSERT INTO cliente (nome, idade, email, telefone, logradouro, numero, complemento, bairro, municipio, estado, cep)
VALUES 
('João Silva', 30, 'joao.silva@email.com', '123456789', 'Rua das Flores', '123', 'Apartamento 101', 'Centro', 'São Paulo', 'SP', '01001000'),
('Maria Oliveira', 25, 'maria.oliveira@email.com', '987654321', 'Avenida Paulista', '456', 'Condomínio Central', 'Bela Vista', 'São Paulo', 'SP', '01310000'),
('Carlos Souza', 40, 'carlos.souza@email.com', '112233445', 'Rua da Paz', '789', NULL, 'Jardim América', 'São Paulo', 'SP', '01435000');


INSERT INTO aro (marca, tamanho_em_polegadas, modelo, preco) 
VALUES 
('Shimano', 26, 'WH-MT500', 150.50),
('Mavic', 28, 'Aksium', 180.75),
('Fulcrum', 29, 'Red Power XL', 200.00);


INSERT INTO quadro (marca, tamanho_em_polegadas, modelo, preco) 
VALUES 
('Trek', 17, 'Emonda SL 6', 3500.00),
('Specialized', 19, 'Roubaix Sport', 4000.00),
('Canyon', 21, 'Ultimate CF SLX', 4500.00);


INSERT INTO motorizacao (marca, potencia, modelo, preco) 
VALUES 
('Bosch', 250, 'Performance Line', 2500.00),
('Shimano', 500, 'Steps E6100', 3000.00),
('Brose', 250, 'Drive S Mag', 3500.00);


INSERT INTO cor (marca, tipo_de_tinta, preco) 
VALUES 
('PPG', 'Metalizada', 50.00),
('DuPont', 'Fosca', 60.00),
('Spray.Bike', 'Brilhante', 70.00);


INSERT INTO customizacao (aro_id, quadro_id, cor_id, motorizacao_id, cliente_id)
VALUES 
(1, 1, 1, 1, 1),
(2, 2, 2, 2, 2),
(3, 3, 3, 3, 3);


INSERT INTO funcionario (nome, email, senha)
VALUES 
('Matheus Selpa', 'mselpa@garagem13.com', '24681012'),
('Gabriel Gomes', 'ggomes@garagem13.com', '12345678'),
('Daniel Silva', 'dsilva@garagem13.com', '36912157');



-- Select ClienteRepositorio
SELECT 
    c.*
FROM
    cliente c;


-- Select CustomizacaoRepositorio

SELECT * FROM aro ORDER BY id;

SELECT * FROM quadro ORDER BY id;

SELECT * FROM cor ORDER BY id;

SELECT * FROM motorizacao ORDER BY id;

SELECT 
    c.id AS customizacao_id,
    c.cliente_id,
    cl.nome,
    cl.email,
    cl.telefone,
    a.marca AS marca_aro,
    a.tamanho_em_polegadas,
    a.modelo AS modelo_aro,
    a.preco AS preco_aro,
    q.marca AS marca_quadro,
    q.modelo AS modelo_quadro,
    q.preco AS preco_quadro,
    co.marca AS marca_tinta,
    co.tipo_de_tinta,
    co.preco AS preco_tinta,
    m.marca AS marca_motor,
    m.potencia AS potencia_motor,
    m.modelo AS modelo_motor,
    m.preco AS preco_motor
FROM
    customizacao c
        INNER JOIN
    cliente cl ON c.cliente_id = cl.id
        INNER JOIN
    aro a ON c.aro_id = a.id
        INNER JOIN
    quadro q ON c.quadro_id = q.id
        INNER JOIN
    cor co ON c.cor_id = co.id
        INNER JOIN
    motorizacao m ON c.motorizacao_id = m.id;


-- Select Teste
SELECT
    c.id AS customizacao_id,
    c.cliente_id,
    cl.nome,
    cl.idade,
    cl.email,
    cl.telefone,
    cl.logradouro,
    cl.numero,
    cl.complemento,
    cl.bairro,
    cl.municipio,
    cl.estado,
    cl.cep,
    a.marca AS marca_aro,
    a.tamanho_em_polegadas,
    a.modelo AS modelo_aro,
    a.preco AS preco_aro,
    q.marca AS marca_quadro,
    q.modelo AS modelo_quadro,
    q.preco AS preco_quadro,
    co.marca AS marca_tinta,
    co.tipo_de_tinta,
    co.preco AS preco_tinta,
    m.marca AS marca_motor,
    m.potencia AS potencia_motor,
    m.modelo AS modelo_motor,
    m.preco AS preco_motor
FROM 
    customizacao c
INNER JOIN cliente cl ON c.cliente_id = cl.id
-- INNER JOIN endereco e ON cl.id_endereco = e.id
INNER JOIN aro a ON c.aro_id = a.id
INNER JOIN quadro q ON c.quadro_id = q.id
INNER JOIN cor co ON c.cor_id = co.id
INNER JOIN motorizacao m ON c.motorizacao_id = m.id;