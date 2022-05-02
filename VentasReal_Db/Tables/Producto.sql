CREATE TABLE [dbo].[Producto]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Nombre] VARCHAR(50) NOT NULL, 
    [PrecioUnitario] DECIMAL(16, 2) NOT NULL, 
    [Costo] DECIMAL(16) NOT NULL
)
