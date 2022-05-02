ALTER TABLE [dbo].[Concepto]
	ADD CONSTRAINT [FK_Concepto_Producto]
	FOREIGN KEY (IdProducto)
	REFERENCES [Producto] (Id)
