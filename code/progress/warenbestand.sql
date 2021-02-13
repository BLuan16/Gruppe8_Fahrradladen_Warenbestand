USE master;
GO

IF DB_ID(N'Fahrradladen') IS NULL
  CREATE DATABASE Fahrradladen;
GO

USE Fahrradladen;
GO 

IF OBJECT_ID('Produkt') IS NOT NULL
  DROP TABLE Produkt;
go

IF OBJECT_ID('ProduktKategorie') IS NOT NULL
  DROP TABLE ProduktKategorie;
GO
IF OBJECT_ID('BestellPosten') IS NOT NULL
  DROP TABLE BestellPosten;
GO
GO
IF OBJECT_ID('Posten') IS NOT NULL
  DROP TABLE Posten;
GO

IF OBJECT_ID('Bestellung') IS NOT NULL
  DROP TABLE Bestellung;
GO








CREATE TABLE ProduktKategorie (
  ID_ProduktKategorie INT IDENTITY PRIMARY KEY,
  Bezeichnung nvarchar(50)
);

CREATE TABLE Produkt (
  ID_Produkt INT IDENTITY PRIMARY KEY, 
  Bezeichnung nvarchar(50),
  Preis decimal,
  ID_ProduktKategorie int,
  constraint fk_ProduktKategorie foreign key(ID_ProduktKategorie)
  references ProduktKategorie(ID_ProduktKategorie)
);

CREATE TABLE Posten ( 
  ID_Posten INT IDENTITY PRIMARY KEY, 
  ID_Produkt int,
  Anzahl int,
  Preis decimal,
  constraint fk_Produkt foreign key(ID_Produkt)
  references Produkt(ID_Produkt)
);

create table Bestellung(
	ID_Bestellung int identity primary key,
	Summe decimal,
	Datum date
	);

create table BestellPosten(
	ID_Bestellung int,
	ID_Posten int,
	CONSTRAINT pk_BestellPosten PRIMARY KEY (ID_Bestellung,ID_Posten),
	constraint fk_Bestellung foreign key(ID_Bestellung)
	references Bestellung(ID_Bestellung),
	constraint fk_Posten foreign key(ID_Posten)
	references Posten(ID_Posten)
	);