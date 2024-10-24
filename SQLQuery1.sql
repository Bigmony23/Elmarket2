CREATE TABLE [dbo].[Tovars] (
    [Id_Product]         INT          IDENTITY (1, 1) NOT NULL,
    [Product_name]       VARCHAR (50) NOT NULL,
     product_description TEXT,
    unit_price DECIMAL(10, 2) NOT NULL,
    PRIMARY KEY CLUSTERED ([Id_Product] ASC)
);


CREATE TABLE [dbo].[Vid_tovara] (
    [Id_Vid_tovara] INT IDENTITY (1, 1) NOT NULL,
    [Id_Product]    INT NOT NULL,
    PRIMARY KEY CLUSTERED ([Id_Vid_tovara] ASC),
    FOREIGN KEY ([Id_Product]) REFERENCES [dbo].[Tovars] ([Id_Product])
);

CREATE TABLE [dbo].[Fakt_Ostatki] (
    [Id_Fakt_Ostatki] INT        IDENTITY (1, 1) NOT NULL,
    [Datanum]        DATE       DEFAULT (getdate()) NOT NULL,
    [Id_Product]     INT        NOT NULL,
    [Sena_prodaji]   decimal(10,2) NOT NULL,
    PRIMARY KEY CLUSTERED ([Id_Fakt_Ostatki] ASC),
    FOREIGN KEY ([Id_Product]) REFERENCES [dbo].[Tovars] ([Id_Product])
);

CREATE TABLE [dbo].[Tek_Ostatki] (
    [Id_Fakt_Ostatki] INT        IDENTITY (1, 1) NOT NULL,
    [Datanum]        DATE       DEFAULT (getdate()) NOT NULL,
    [Id_Product]     INT        NOT NULL,
    [Sena_prodaji]   decimal(10,2) NOT NULL,
    PRIMARY KEY CLUSTERED ([Id_Fakt_Ostatki] ASC),
    FOREIGN KEY ([Id_Product]) REFERENCES [dbo].[Tovars] ([Id_Product])
);

alter table Tek_ostatki
add Sena_prodaji decimal(10,2)

alter table Fakt_ostatki
add Sena_prodaji decimal(10,2)


CREATE TABLE [dbo].[Tek_Ostatki] (
    [Id_Tek_Ostatki] INT        IDENTITY (1, 1) NOT NULL,
    [Datanum]        DATE       DEFAULT (getdate()) NOT NULL,
    [Id_Product]     INT        NOT NULL,
    kolichestvo int not null,
    [Sena_prodaji]   decimal (10,2) NOT NULL,
    
    PRIMARY KEY CLUSTERED ([Id_Tek_Ostatki] ASC),
    FOREIGN KEY ([Id_Product]) REFERENCES [dbo].[Tovars] ([Id_Product])
);

CREATE TABLE [dbo].[Rasxod1] (
    [Id_Rasxod]     INT           IDENTITY (1, 1) NOT NULL,
    [Data_Prixoda]  DATE          DEFAULT getdate() NOT NULL,
    [Id_Product]    INT           NOT NULL,
    [Postavshik]    VARCHAR (50)  NOT NULL,
    [Moddel_tovara] NVARCHAR (50) NOT NULL,
    [Sena_prodaji]  Decimal (10,2)    NOT NULL,
    [Kolichestvo]   INT           NOT NULL,
    PRIMARY KEY CLUSTERED ([Id_Rasxod] ASC),
    FOREIGN KEY ([Id_Product]) REFERENCES [dbo].[Tovars] ([Id_Product])
);
CREATE TABLE [dbo].[Prixod] (
    [Id_Prixod]     INT           IDENTITY (1, 1) NOT NULL,
    [Data_Prixoda]  DATE          DEFAULT (getdate()) NOT NULL,
    [Id_Product]    INT           NOT NULL,
    [Postavshik]    VARCHAR (50)  NOT NULL,
    [Id_Vid_Tovara] NVARCHAR (50) NOT NULL,
    [sena_zakupki]  Decimal (10,2)    NOT NULL,
    [kolichestvo]   INT           NOT NULL,
    PRIMARY KEY CLUSTERED ([Id_Prixod] ASC),
    FOREIGN KEY ([Id_Product]) REFERENCES [dbo].[Tovars] ([Id_Product])
);

 CREATE TABLE [dbo].[Proizvoditel] (
    [Id_Proizvoditel] INT          IDENTITY (1, 1) NOT NULL,
    [Proizvoditel]    VARCHAR (50) NOT NULL,
    Id_Product int not null,
    PRIMARY KEY CLUSTERED ([Id_Proizvoditel] ASC)
    );
CREATE TABLE [dbo].[Mesto_xraneniya] (
    [Id_Mesto_xraneniya] INT           IDENTITY (1, 1) NOT NULL,
    [Sklad_name]         VARCHAR (50)  NOT NULL,
    [Id_Product]         INT           NOT NULL,
    [moddel_tovara]      NVARCHAR (50) NOT NULL,
    [kolichestvo]        INT           NOT NULL,
    PRIMARY KEY CLUSTERED ([Id_Mesto_xraneniya] ASC),
    FOREIGN KEY ([Id_Product]) REFERENCES [dbo].[Tovars] ([Id_Product])
);




ALTER TABLE Tek_Ostatki
ADD FOREIGN KEY (Id_Product) REFERENCES Tovars(Id_Product);


ALTER TABLE Fakt_Ostatki
ADD FOREIGN KEY (Id_Product) REFERENCES Tovars(Id_Product);

ALTER TABLE Mesto_xraneniya
ADD FOREIGN KEY (Id_Product) REFERENCES Tovars(Id_Product);

ALTER TABLE Prixod
ADD FOREIGN KEY (Id_Product) REFERENCES Tovars(Id_Product);


ALTER TABLE Rasxod1
ADD FOREIGN KEY (Id_Product) REFERENCES Tovars(Id_Product);


ALTER TABLE Vid_tovara
ADD FOREIGN KEY (Id_Product) REFERENCES Tovars(Id_Product);
ALTER TABLE Proizvoditel
ADD FOREIGN KEY (Id_Product) REFERENCES Tovars(Id_Product);

/*ALTER TABLE Tovars DROP CONSTRAINT Id_Mesto_xraneniya;

ALTER TABLE Tovars
DROP COLUMN [Id_Vid_tovara], [Id_Mesto_xraneniya],[Id_Tek_ostatki],[Id_Fakt_ostatki],[Id_Proizvoditel],[Id_Prixod],[Id_Rasxod]*/

insert into [Tovars]
values
( 'SDD','SDD',23.10),
( 'HDD','Hard drive',24.10),
( 'Video card','AMD',25.10),
( 'Video card','Nvidea',26.10),
( 'CPU','Intel',17.10),
( 'RAM','16',68.10),
( 'RAM','32',34.10)


CREATE TABLE [dbo].[Rasxod1] (
    [Id_Rasxod]     INT           IDENTITY (1, 1) NOT NULL,
    [Data_Prixoda]  DATE          DEFAULT getdate() NOT NULL,
    [Id_Product]    INT           NOT NULL,
    [Postavshik]    VARCHAR (50)  NOT NULL,
    [Moddel_tovara] NVARCHAR (50) NOT NULL,
    [Sena_prodaji]  Decimal (10,2)    NOT NULL,
    [Kolichestvo]   INT           NOT NULL,
    PRIMARY KEY CLUSTERED ([Id_Rasxod] ASC),
    FOREIGN KEY ([Id_Product]) REFERENCES [dbo].[Tovars] ([Id_Product])
);
alter table Rasxod1
drop column Postavshik

insert into [Rasxod1]
values
/*(GETDATE(),1,'Puma',3,23.500),*/
('30.06.2024',3,'HDD',5,23.509),
('1.07.2024',3,'HDD',5,23.509),
('2.07.2024',3,'HDD',5,23.509),
('3.07.2024',3,'HDD',5,23.509)
(GETDATE(),4,'HDD',6,23.56),
(GETDATE(),5,'SDD',7,23.502),
(GETDATE(),6,'AMD',8,23.505),
(GETDATE(),7,'RAM',9,23.504)
alter table Prixod
drop column Postavshik
insert into Prixod
values
/*(GETDATE(),1,'Puma',3,23.500),*/
(GETDATE(),3,'HDD',5,23.509),
(GETDATE(),4,'HDD',6,23.56),
(GETDATE(),5,'SDD',7,23.502),
(GETDATE(),6,'AMD',8,23.505),
(GETDATE(),7,'RAM',9,23.504)

insert into Mesto_xraneniya
values
/*(GETDATE(),1,'Puma',3,23.500),*/
('First',3,'HDD',5),
('First',4,'HDD',6),
('First',5,'SDD',7),
('First',6,'AMD',8),
('First',7,'RAM',9)

insert into Vid_tovara
values
(1),
(3),
(4),
(5),
(6),
(7)
(8)

insert into Proizvoditel
values
('Nvidea',1),
('Nvidea',3),
('Nvidea',4),
('Nvidea',5),
('Nvidea',6),
('Nvidea',7)
('Nvidea',8)
SET IDENTITY_INSERT Tek_Ostatki On;
insert into Tek_ostatki
values
/*(GETDATE(),5,23.56),*/
(GETDATE(),6,23.34),
(GETDATE(),3,23.67),
(GETDATE(),4,23.45),
(GETDATE(),5,23.87),
(GETDATE(),6,23.34),
(GETDATE(),7,23.34)


/*CREATE TRIGGER trgAfterInsertRasxod ON dbo.Rasxod1
AFTER INSERT
AS
BEGIN
    SET NOCOUNT ON;

    -- Update the Tek_Ostatki table by subtracting the quantity from Rasxod1
    UPDATE Tek_Ostatki
    SET kolichestvo = kolichestvo - i.Kolichestvo
    FROM Tek_Ostatki tk
    INNER JOIN inserted i ON tk.Id_Product = i.Id_Product
    WHERE tk.Id_Product = i.Id_Product;
END;*/
/*

CREATE TRIGGER trgAfterInsertRasxod ON dbo.Rasxod1
AFTER INSERT
AS
BEGIN
    SET NOCOUNT ON;

    -- Update the Tek_Ostatki table by subtracting the quantity from Rasxod1
    UPDATE Tek_Ostatki
    SET kolichestvo = Tek_Ostatki.kolichestvo - i.Kolichestvo
    FROM Tek_Ostatki
    INNER JOIN inserted i ON Tek_Ostatki.Id_Product = i.Id_Product;
END;

*/


UPDATE Tek_Ostatki
SET kolichestvo = kolichestvo - i.Kolichestvo
FROM Tek_Ostatki tk
INNER JOIN inserted i ON tk.Id_Product = i.Id_Product
WHERE tk.Id_Product = i.Id_Product;




-- Вставить данные из таблиц Rasxod1 и Tek_Ostatki в таблицу Fakt_Ostatki
INSERT INTO Fakt_Ostatki (
    Id_Product,
    kolichestvo,
    Sena_prodaji
)
SELECT
    r.Id_Product,
    r.Sena_prodaji,
    t.kolichestvo - r.Kolichestvo
FROM
    Rasxod1 AS r
INNER JOIN
    Tek_Ostatki AS t
ON
    r.Id_Product = t.Id_Product;



   




INSERT INTO Fakt_Ostatki (
    Id_Product,
    kolichestvo,
    Sena_prodaji
)
SELECT
    r.Id_Product,
    CASE
        WHEN t.kolichestvo - r.Kolichestvo >= 0
        THEN t.kolichestvo - r.Kolichestvo
        ELSE 0
    END AS kolichestvo,
    r.Sena_prodaji
FROM
    Rasxod1 AS r
INNER JOIN
    Tek_Ostatki AS t
ON
    r.Id_Product = t.Id_Product;


SELECT *
from Rasxod1

SELECT * FROM Elmarket33 WHERE name = 'Rasxod1';

    