USE master;
GO

IF DB_ID(N'Fahrradladen') IS NULL
  CREATE DATABASE Fahrradladen;
GO

USE Fahrradladen;
GO 

IF OBJECT_ID('Bestellung') IS NOT NULL
  DROP TABLE Bestellung;
GO

IF OBJECT_ID('Produkt') IS NOT NULL
  DROP TABLE Produkt;
GO

IF OBJECT_ID('ProduktKategorie') IS NOT NULL
  DROP TABLE ProduktKategorie;
GO


create table ProduktKategorie(
	ID_ProduktKategorie int identity primary key,
	Bezeichnung nvarchar(50)
);

CREATE TABLE Produkt (
  ID_Produkt INT IDENTITY PRIMARY KEY,
  Bezeichnung nvarchar(50), 
  Preis decimal,
  ID_ProduktKategorie int,
  constraint fk_Kategorie foreign key (ID_ProduktKategorie) 
  references ProduktKategorie (ID_ProduktKategorie)
);

CREATE TABLE Bestellung (
  ID_Bestellung INT IDENTITY PRIMARY KEY,
  ID_Produkt int, 
  Anzahl int,
  Preis decimal,
  Datum date,
  constraint fk_Produkt foreign key (ID_Produkt) 
  references Produkt (ID_Produkt)
);




