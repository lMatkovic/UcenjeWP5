use master;
go
drop database if exists nogometniklub;
go
create database nogometniklub;
go
use nogometniklub;


create table klub(
sifra int not null primary key identity(1,1),
naziv varchar(30) not null,
osnovan int,
stadion varchar(40),
predsjednik varchar(50),
drzava varchar (30),
liga varchar (40),
);