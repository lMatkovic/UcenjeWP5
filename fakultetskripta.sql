--create database fakultet;

--use fakultet;

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