use Fahrradladen
go

insert into ProduktKategorie(Bezeichnung)
values	('Fahrrad'),('Ersatzteil'),('Zubehör')

insert into Produkt(Bezeichnung,Preis,ID_ProduktKategorie)
values	('Nimbus-2000',169.99,1),
		('Nimbus-7',120,1),
		('Chill-Wheel',139.99,1),
		('Affentempo',320,1),
		('Heavy-Metal',219.99,1),
		('Barely-One-Wheel',65,1),
		('Dynamo',14.49,2),
		('Bremslicht',14.49,2),
		('Klingel',14.49,2),
		('Schlauch',14.49,2),
		('Frontlicht',14.49,2),
		('Helm',11.99,3),
		('Poncho',19.99,3),
		('Flasche',9.99,3),
		('Handschuhe',9.99,3),
		('Kindersitz',32,3)

insert into Bestellung(Datum)
values	('02-01-2020'),
		('02-03-2020'),
		('02-07-2020'),
		('02-07-2020'),
		('15-09-2020')

insert into Posten(ID_Produkt,Anzahl)
values	(2,1),
		(4,1),
		(1,1),
		(7,2),
		(8,4),
		(9,2),
		(14,3),
		(15,1),
		(16,1),
		(6,1),
		(3,3),
		(1,1)

insert into BestellPosten(ID_Bestellung,ID_Posten)
values	(1,1),
		(1,6),
		(12,2),
		(13,3),
		(14,7),
		(14,10),
		(15,4),
		(15,5),
		(16,8),
		(16,9),
		(16,11),
		(16,12)		