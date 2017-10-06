create database dbagenda;

use dbagenda;

create table categorias(
	id_categoria integer auto_increment not null primary key,
    nome_categoria varchar(100)
);

create table contatos(
	id_contato integer auto_increment not null primary key,
    nome_contato varchar(100),
    email_contato varchar(200),
    dt_nasc_contato date,
    id_categoria integer,
    foreign key (id_categoria) references categorias (id_categoria)
);

grant all privileges on *.* to 'root'@'192.168.1.0/255.255.255.0';