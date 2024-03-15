-- ================================================
-- Template generated from Template Explorer using:
-- Create Procedure (New Menu).SQL
--
-- Use the Specify Values for Template Parameters 
-- command (Ctrl-Shift-M) to fill in the parameter 
-- values below.
--
-- This block of comments will not be included in
-- the definition of the procedure.
-- ================================================
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Yazbeth Gerardo Rodr�guez P�rez
-- Create date: 13/03/24
-- Description:	Crear un listado de art�culos para tener un control de ellos
-- =============================================
CREATE PROCEDURE OptionMenu 
	-- Add the parameters for the stored procedure here
	@OptionMenu Int = 0, 
	@Variable_InsertarItemName Nvarchar(MAX) = Null,
	@Variable_InsertarStock Int = Null,
	@Variable_InsertarIdTypePrioritary Nvarchar (MAX) = Null,
	@Variable_InsertarIdTypeStock Nvarchar (Max) = Null,
	@Variable_InsertarPurchesDate Nvarchar (Max) = Null,
	@Variable_InsertarExpirationDate Nvarchar (Max) = Null,
	@Variable_InsertarActive Bit = 0,
	@Variable_InsertarId Int = 0
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	If @OptionMenu = 0
	Begin 
		Select 'Opci�n default'
END

	If @OptionMenu = 1
	Begin
		Insert Into Item Values (@Variable_InsertarItemName, @Variable_InsertarStock, @Variable_InsertarIdTypePrioritary, @Variable_InsertarIdTypeStock, @Variable_InsertarPurchesDate, @Variable_InsertarExpirationDate, @Variable_InsertarActive) 
END

	If @OptionMenu = 2
	Begin
		Select * From Item Where Active = 1
END

	If @OptionMenu = 3
	Begin
		Update
		Item
		Set ItemName = @Variable_InsertarItemName,
			Stock = @Variable_InsertarStock,
			IdTypePrioritary = @Variable_InsertarIdTypePrioritary,
			IdTypeStock = @Variable_InsertarIdTypeStock,
			PurchesDate = @Variable_InsertarPurchesDate,
			ExpirationDate = @Variable_InsertarExpirationDate,
			Active = @Variable_InsertarActive
		Where IdItem = @Variable_InsertarId
END

	If @OptionMenu = 4
	Begin
		Delete From Item
		Where IdItem = @Variable_InsertarId
END
GO
