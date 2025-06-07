drop database db_sistemahotel;
create database db_sistemahotel;
use db_sistemahotel;


CREATE TABLE tbl_login (
id_login int primary key NOT NULL AUTO_INCREMENT,
usuario varchar(50) NOT NULL unique,
senha varchar(20) NOT NULL
);


CREATE TABLE tbl_hospede (
id_hospede int primary key NOT NULL auto_increment,
nome varchar(100) NOT NULL,
cpf varchar(20) NOT NULL unique,
endereço varchar(200),
email varchar(100) NOT NULL
);


CREATE TABLE tbl_checkin (
id_checkin int primary key NOT NULL AUTO_INCREMENT,
entrada date,
saida date,
pagamento varchar(10),
quarto varchar(4),
id_hospede int NOT NULL UNIQUE
);



ALTER TABLE tbl_checkin ADD CONSTRAINT fk_id_hospede FOREIGN KEY (id_hospede) REFERENCES tbl_hospede(id_hospede) ON DELETE CASCADE;


/----------------------------------------------------------------------------------------------------------------------------------------
drop table tbl_checkin;

select * from tbl_login;
select * from tbl_hospede;
select * from tbl_checkin;

DELETE FROM tbl_hospede WHERE id_hospede = 1;

INSERT INTO tbl_hospede (nome, cpf, endereço, email) 
VALUES ('João Silva', '12345678901', 'Rua A, 123', 'joao@email.com');

INSERT INTO tbl_checkin (entrada, saida, quarto, id_hospede) 
VALUES ('2025-06-01', '2025-06-05', '101', 1);



SELECT c.id_checkin, c.entrada, c.saida, c.quarto, h.id_hospede, h.nome, h.cpf, h.endereço, h.email FROM tbl_checkin c JOIN tbl_hospede h ON c.id_hospede = h.id_hospede;

INSERT INTO tbl_hospede (nome, cpf, endereço, email) VALUES ("nome", "123", "asdasd", "asdasdasd");

DELETE FROM tbl_hospede WHERE id_hospede (1);