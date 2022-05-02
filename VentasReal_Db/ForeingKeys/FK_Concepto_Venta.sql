ALTER TABLE [dbo].[Concepto]
	ADD CONSTRAINT [FK_Concepto_Venta]
	FOREIGN KEY (IdVenta)
	REFERENCES [Venta] (Id)
