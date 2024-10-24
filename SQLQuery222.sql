alter table Proizvoditel
add Id_Product int
Alter table Prixod 
drop column Id_Vid_tovara

Alter table Prixod 
drop column sena_zakupki

Alter table Prixod 
add sena_zakupki decimal(10,2)

Alter table Rasxod1
drop column Moddel_tovara

Alter table Rasxod1
drop column Sena_prodaji


Alter table Rasxod1
add  Sena_prodaji decimal(10,2)