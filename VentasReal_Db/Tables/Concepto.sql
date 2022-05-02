CREATE TABLE [dbo].[Concepto]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [IdVenta] INT NOT NULL, 
    [Cantidad] INT NOT NULL, 
    [PrecioUnitario] DECIMAL(16, 2) NOT NULL, 
    [Importe] DECIMAL(16, 2) NOT NULL, 
    [IdProducto] INT NOT NULL
)
