### PROGAMAS UTILIZADOS 
 Visual Studio
 MySql Workbench

 ### INSTRU�OES

 Para execu��o do progama � necess�rio informar os sequintes dados 
 do MySql Workbench na classe banco: servidor,
 banco de dados, usu�rio e senha.

 E tamb�m criar o banco de dados e tabela informados a baixo no MySql Workbench .


### CRIANDO O BANCO DE DADOS MYSQL WORKBENCH

create database dbProdutos
default character set utf8mb4
default collate utf8mb4_general_ci;

### COMANDO PARA UTLIZAR O BANCO DE DADOS DESEJADO

use dbProdutos;

### CRIANDO A TABELA PRODUTOS

create table if not exists produtos(
 id int not null auto_increment primary key,
 nome varchar(100)not null 
)default char set utf8mb4