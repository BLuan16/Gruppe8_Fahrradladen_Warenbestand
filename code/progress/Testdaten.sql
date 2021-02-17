use Fahrradladen
go

insert into ProduktKategorie(Bezeichnung)
values	('Fahrrad'),('Ersatzteil'),('Zubehör')

insert into Produkt(Bezeichnung,Preis,ID_ProduktKategorie)
values	('Nimbus-2000',169,1),
		('Nimbus-7',120,1),
		('Chill-Wheel',139,1),
		('Affentempo',320,1),
		('Heavy-Metal',219,1),
		('Barely-One-Wheel',65,1),
		('Dynamo',14,2),
		('Bremslicht',14,2),
		('Klingel',14,2),
		('Schlauch',14,2),
		('Frontlicht',14,2),
		('Helm',11,3),
		('Poncho',19,3),
		('Flasche',9,3),
		('Handschuhe',9,3),
		('Kindersitz',32,3),
		('Sattel-Fritz',89,2),
		('SpeedoMacFly',796,1),
		('FastAndCurious',25,3),
		('Lenkerband Pretty Pink',42,3),
		('Bremsscheibe 20xS',85,2),
		('GoodGrib-SafeTrip',25,3)

insert into Bestellung(Datum, Summe)
values	('02-01-2020',148),
		('02-03-2020',320),
		('02-07-2020',169),
		('02-07-2020',92),
		('15-09-2020',84),
		('18-09-2020',458)

insert into Posten(ID_Produkt,Anzahl, Preis)
values	(2,1,120),
		(4,1,320),
		(1,1,169),
		(7,2,28),
		(8,4,56),
		(9,2,28),
		(14,3,27),
		(15,1,9),
		(16,1,32),
		(6,1,65),
		(3,3,417)

insert into BestellPosten(ID_Bestellung,ID_Posten)
values	(1,1),
		(1,6),
		(2,2),
		(3,3),
		(4,7),
		(4,10),
		(5,4),
		(5,5),
		(6,8),
		(6,9),
		(6,11)		
