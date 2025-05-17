CREATE DATABASE db_SegundaEntregaCinema;
GO

USE db_SegundaEntregaCinema;
GO

CREATE TABLE [Peliculas](
[Id] INT NOT NULL IDENTITY (1,1)PRIMARY KEY,
[Nombre] NVARCHAR (150) NOT NULL, 
[Tipo] NVARCHAR (150) NOT NULL,
);

INSERT INTO [Peliculas]([Nombre],[Tipo]) VALUES ('Interestelar', 'Sci-fi');
INSERT INTO [Peliculas]([Nombre],[Tipo]) VALUES ('Rey león', 'Infantil');
INSERT INTO [Peliculas]([Nombre],[Tipo]) VALUES ('La sustancia', 'Terror corporal');
INSERT INTO [Peliculas]([Nombre],[Tipo]) VALUES ('Capitán America', 'Superheroes');
INSERT INTO [Peliculas]([Nombre],[Tipo]) VALUES ('Moana', 'Infantil');
SELECT * FROM [Peliculas];
