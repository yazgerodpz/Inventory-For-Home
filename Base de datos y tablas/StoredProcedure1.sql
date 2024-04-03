USE [InventoryForHome]
GO

/****** Object:  StoredProcedure [dbo].[OptionMenu]    Script Date: 18/03/2024 12:18:37 a. m. ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		Yazbeth Gerardo Rodríguez Pérez
-- Create date: 13/03/24
-- Description:	Crear un listado de artículos para tener un control de ellos
-- =============================================
CREATE PROCEDURE [dbo].[OptionMenu] 
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
		Select 'Opción default'
	END

	If @OptionMenu = 1
	Begin
		Insert Into Item Values (@Variable_InsertarItemName, @Variable_InsertarStock, @Variable_InsertarIdTypePrioritary, @Variable_InsertarIdTypeStock, @Variable_InsertarPurchesDate, @Variable_InsertarExpirationDate, @Variable_InsertarActive) 
	END

	If @OptionMenu = 2
	Begin
		Select 
			--A.[IdItem]
			 A.[ItemName]
			,A.[Stock]
			--,A.[IdTypePrioritary]
			,B.[TypePrioritaryName] AS Type_Prioritary
			--,A.[IdTypeStock]
			,C.[TypeStockName] AS Type_Stock
			,A.[PurchesDate]
			,A.[ExpirationDate]
			--,A.[Active]
		FROM [dbo].[Item] A
		INNER JOIN [dbo].[CatTypePrioritary] B
		ON A.[IdTypePrioritary] = B.[IdTypePrioritary]
		INNER JOIN [dbo].[CatTypeStock] C
		ON A.[IdTypeStock] = C.[IdTypeStock]
		WHERE A.[Active] = 1
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
END
GO

Exec OptionMenu 1
Exec OptionMenu 2
Exec OptionMenu 3
Exec OptionMenu 4