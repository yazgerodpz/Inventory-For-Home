USE [InventoryForHome]
GO

/****** Object:  StoredProcedure [dbo].[CatalogoStock]    Script Date: 18/03/2024 12:20:08 a. m. ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		Yazbeth Gerardo Rodríguez Pérez
-- Create date: 15/30/2024
-- Description:	Catalogo 2
-- =============================================
CREATE PROCEDURE [dbo].[CatalogoStock]
	-- Add the parameters for the stored procedure here
	@CS Int = 0,
	@Var_Identidad Int = 0,
	@Var_TSName Nvarchar (MAX) = Null,
	@Var_Activo Bit = 0
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	If @CS = 0
	Begin 
		Select 'Opción Default'
	END

	If @CS = 1
	Begin
		Insert Into CatTypeStock Values ( @Var_TSName, @Var_Activo)
	END

	If @CS = 2
	Begin
		SELECT 
			 --[IdTypeStock]
			   [TypeStockName]
			--,[Active]
		FROM [InventoryForHome].[dbo].[CatTypeStock]
	END

	If @CS = 3
	Begin
		Update
		CatTypeStock
		SET TypeStockName = @Var_TSName,
			Active = @Var_Activo
		Where IdTypeStock = @Var_Identidad
	END

	If @CS = 4
	Begin
		Delete From CatTypeStock
		Where IdTypeStock = @Var_Identidad
	END
END
GO

Exec CatalogoStock 1
Exec CatalogoStock 2
Exec CatalogoStock 3
Exec CatalogoStock 4