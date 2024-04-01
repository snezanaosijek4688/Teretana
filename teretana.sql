use master;
go
drop database if exists
teretana;
go
--ovo je komentar
create database teretana collate Croatian_CI_AS;
go
--drop database teretana;
--use master
use teretana;



create table korisnici(
sifra int not null primary key identity(1,1),
ime varchar(50),
prezime varchar(50),
email varchar(50),

);


create table treneri(
sifra int not null primary key identity (1,1),
ime varchar(50),
prezime varchar(50),
specijalizacija varchar(50),
radnovrijeme varchar(30)
);



insert into treneri (ime,prezime,specijalizacija,radnovrijeme) values
--1
 ('Marko','Ilic','rad na gluteusu','08:00-22:00'),
 --2
 ('Luka','Tomic','rad na bicepsima','08:00-22:00');


 --od 1 do 10
 insert into korisnici (ime, prezime, email,trener_sifra) values

('Dragana','Jankovic','draganjankovica@gmail.com',1),
('Svetlana','Grkovic','svetlanagrkovic@gmail.com',2),
('Igor','Kos','igorkos@gmail.com',1),
('Bojan','Markovic','bojanmarkovic@gmail.com',2),







alter table korisnici add foreign key (trener_sifra) references treneri(sifra);