ALTER TABLE [dbo].[Venta]
	ADD CONSTRAINT [FK_Venta_Cliente]
	FOREIGN KEY (IdCliente)
	REFERENCES [Cliente] (Id)