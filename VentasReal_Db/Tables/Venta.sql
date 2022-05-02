CREATE TABLE [dbo].[Venta]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Fecha] DATETIME NOT NULL, 
    [Total] DECIMAL(16, 2) NULL, 
    [IdCliente] INT NULL
)
