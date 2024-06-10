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
drzava varchar(30),
liga varchar(40)
);

create table igrac(
sifra int not null primary key identity(1,1),
ime varchar(30) not null,
prezime varchar(30) not null,
datum_ro?enja datetime not null,
pozicija varchar(30),
broj_dresa int,
klub int not null
);

create table utakmica(
sifra int not null primary key identity(1,1),
datum datetime not null,
vrijeme time not null,
lokacija varchar(30),
stadion varchar(30),
domaci_klub int not null,
gostujuci_klub int not null,
);

create table trener(
sifra int not null primary key identity(1,1),
ime varchar(30) not null,
prezime varchar(30) not null,
klub int not null,
nacionalnost varchar(30),
iskustvo varchar(30),
);

alter table igrac add foreign key (klub) references klub(sifra);
alter table utakmica add foreign key (domaci_klub) references klub(sifra);
alter table utakmica add foreign key (gostujuci_klub) references klub(sifra);
alter table trener add foreign key (klub) references klub(sifra);

