use master;
go
drop database if exists nogometniklub;
go
create database nogometniklub;
go
use nogometniklub;


CREATE TABLE klub(
sifra INT NOT NULL PRIMARY KEY IDENTITY(1,1),
naziv VARCHAR(30) NOT NULL,
osnovan INT,
stadion VARCHAR(40),
predsjednik VARCHAR(50),
drzava VARCHAR(30),
liga VARCHAR(40)
);

CREATE TABLE igrac(
sifra INT NOT NULL PRIMARY KEY IDENTITY(1,1),
ime VARCHAR(30),
prezime VARCHAR(30),
datum_ro?enja DATETIME,
pozicija VARCHAR(30),
broj_dresa INT,
klub INT
);

CREATE TABLE utakmica(
sifra INT NOT NULL PRIMARY KEY IDENTITY(1,1),
datum DATETIME,
vrijeme TIME,
lokacija VARCHAR(30),
stadion VARCHAR(30),
domaci_klub INT,
gostujuci_klub INT,
);

CREATE TABLE trener(
sifra INT NOT NULL PRIMARY KEY IDENTITY(1,1),
ime VARCHAR(30),
prezime VARCHAR(30),
klub INT,
nacionalnost VARCHAR(30),
iskustvo VARCHAR(30),
);

alter table igrac add foreign key (klub) references klub(sifra);
alter table utakmica add foreign key (domaci_klub) references klub(sifra);
alter table utakmica add foreign key (gostujuci_klub) references klub(sifra);
alter table trener add foreign key (klub) references klub(sifra);

