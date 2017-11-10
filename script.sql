create database dbagenda;

use dbagenda;

create table categorias(
	codigo_categoria integer auto_increment not null primary key,
    nome_categoria varchar(100)
);

create table contatos(
	id_codigo integer auto_increment not null primary key,
    nome_contato varchar(100),
    email_contato varchar(200),
    codigo_cidade integer,
    codigo_categoria integer,
    foreign key (codigo_categoria) references categorias (codigo_categoria),
    foreign key (codigo_cidade) references cidade (codigo_cidade)
);

create table cidade(
codigo_cidade integer auto_increment not null primary key,
nome_cidade varchar (100),
codigo_uf varchar(2)
);

grant all privileges on *.* to 'root'@'192.168.1.0/255.255.255.0';