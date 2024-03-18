USE [InventoryForHome]
GO

/****** Object:  StoredProcedure [dbo].[EjemploStoredProcedure]    Script Date: 12/03/2024 11:12:32 p. m. ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		<vapr>
-- Create date: <12/03/24>
-- Description:	<Ejemplo de StoredProcedure>
-- =============================================
CREATE PROCEDURE [dbo].[EjemploStoredProcedure] 
	-- Add the parameters for the stored procedure here
	@opcionMenu int = 0,
	@variableEjemplo int = 1
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	-- Aqui Creamos un menu con la sentencia de seleccion if
	If @opcionMenu = 0
	Begin
		SELECT 'Opción default'
	End

	If @opcionMenu = 1
	Begin
		Select 'En esta opcion debe ir un Create (Crear Registro)'
	End

	If @opcionMenu = 2
	Begin
		Select 'En esta opcion debe ir un  Read (Leer/Consultar Registro)'
	End

	IF @opcionMenu = 3
	Begin
		Select 'En esta opcion debe ir un  Update (Actualizar Registro)'
	End

	IF @opcionMenu = 4
	Begin
		Select 'En esta opcion debe ir un  Delete (Elimianr/Desactivar Registro)'
	End

END
GO


