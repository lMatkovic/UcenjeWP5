use master;
go
drop database if exists fakultet;
go
create database fakultet;
go
use fakultet;


create table ispitnirok(
sifra int,
predmet varchar(50),
vrstaispita varchar(50),
datum datetime,
pristupio bit
);


create table pristupnici(
ispitnirok datetime,
student varchar(50),
brojbodova varchar(3),
ocjena int
);

create table profesori(
sifra int,
Ime varchar(50),
prezime varchar(50),
kolegij varchar(50)
);
