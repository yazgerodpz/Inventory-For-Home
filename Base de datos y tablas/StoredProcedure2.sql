USE [InventoryForHome]
GO

/****** Object:  StoredProcedure [dbo].[CatalogoPrioridad]    Script Date: 18/03/2024 12:19:57 a. m. ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		Yazbeth Gerardo Rodríguez Pérez
-- Create date: 15/03/2024
-- Description:	Catalogo 1
-- =============================================
CREATE PROCEDURE [dbo].[CatalogoPrioridad] 
	-- Add the parameters for the stored procedure here
	@CP Int = 0, 
	@Var_Identidad Int = 0,
	@Var_TPNAME Nvarchar(MAX) = Null,
	@Var_Desc Nvarchar(MAX) = Null,
	@Var_Activo Bit = 0
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	If @CP = 0
	Begin
		Select 'Opción default'
	END

	If @CP = 1
	Begin
		Insert Into CatTypePrioritary Values (@Var_TPNAME, @Var_Desc, @Var_Activo)
	END

	If @CP = 2
	Begin
		SELECT --[IdTypePrioritary]
				 [TypePrioritaryName]
				,[_Description]
			   --,[Active]
		FROM [InventoryForHome].[dbo].[CatTypePrioritary]
	END

	If @CP = 3
	Begin
		Update
		CatTypePrioritary
		SET TypePrioritaryName = @Var_TPNAME,
			_Description = @Var_Desc,
			Active = @Var_Activo
		Where IdTypePrioritary = @Var_Identidad
	END

	If @CP = 4
	Begin
		Delete From CatTypePrioritary
		Where IdTypePrioritary = @Var_Identidad
	END
END
GO

Exec CatalogoPrioridad 1
Exec CatalogoPrioridad 2
Exec CatalogoPrioridad 3
Exec CatalogoPrioridad 4
Exec OptionMenu 2