USE [JulianHernandoDavid_NotasDB]
GO

/****** Object:  StoredProcedure [dbo].[SP_CRUD_ACUDIENTES]    Script Date: 11/06/2024 21:34:05 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

-- ==============================================================================================================================
-- Author:						JULIAN ARIAS
-- Create date:					11-06-2024
-- Description:					Permite hacer las operaciones básicas sobre la tabla Acudientes
-- ==============================================================================================================================
CREATE PROCEDURE [dbo].[SP_CRUD_ACUDIENTES]
(
	@intProceso				        INT,
	@idAcudiente					INT = NULL,
	@primerNombre_A					NVARCHAR(15) = NULL,
	@segundoNombre_A				NVARCHAR(15) = NULL,
	@primerApellido_A				NVARCHAR(15) = NULL,
	@segundoApellido_A				NVARCHAR(15) = NULL,
	@identificacion_A				NVARCHAR(12) = NULL,
	@fechaNacimiento_A				DATE = NULL,
	@email_A						NVARCHAR(70) = NULL,
	@direccion						NVARCHAR(70) = NULL,
	@telefono_A						NVARCHAR(15) = NULL
)
AS
BEGIN
    SET NOCOUNT ON;
    DECLARE @intRegistros INT

	--1 - SELECT PARA BUSQUEDA POR ACUDIENTE    
	IF @intProceso = 1
	BEGIN
		SELECT
			A.[IDENTIFICACION],
			A.[PRIMERNOMBRE],
			A.[SEGUNDONOMBRE] AS SEGUNDONOMBRE,
			A.[PRIMERAPELLIDO],
			A.[SEGUNDOAPELLIDO],
			A.[TELEFONO],
			A.[EMAIL],
			A.[FECHANACIMIENTO],
			A.[DIRECCION]
		FROM
			[JulianHernandoDavid_NotasDB].[dbo].[ACUDIENTES] A WITH (NOLOCK)
		WHERE
			A.[IDENTIFICACION] = @identificacion_A;
	END
	
	--2 - INSERT PARA REGISTRAR UN ACUDIENTE
    IF @intProceso = 2
    BEGIN 
		--Antes del insert, hacemos un select para validar que el acudiente no haya sido registrado previamente, si @intRegistros
		--es igual a 1, es porque ya se había registrado y se devuelve un error 
        SELECT TOP 1 @intRegistros = 1
        FROM [JulianHernandoDavid_NotasDB].[dbo].[ACUDIENTES] WITH(NOLOCK)
        WHERE ([IDENTIFICACION] = @identificacion_A);

        IF @@ROWCOUNT = 1
        BEGIN
            SELECT 300 AS error
			 RETURN
        END

       BEGIN TRANSACTION
			--Se insertan los datos del nuevo acudiente en la base de datos
			INSERT INTO [JulianHernandoDavid_NotasDB].[dbo].[ACUDIENTES]
					([PRIMERNOMBRE]
					,[SEGUDONOMBRE]
					,[PRIMERAPELLIDO]
					,[SEGUNDOAPELLIDO]
					,[IDENTIFICACION]
					,[FECHANACIMIENTO]
					,[DIRECCION]
					,[TELEFONO]
					,[EMAIL])
				VALUES
					(@primerNombre_A
					,@segundoNombre_A
					,@primerApellido_A
					,@segundoApellido_A
					,@identificacion_A
					,@fechaNacimiento_A
					,@direccion
					,@telefono_A
					,@email_A)

       COMMIT TRANSACTION 
    END
	
	--3 - UPDATE
    IF @intProceso = 3
    BEGIN
		
		--Antes del update, hacemos un select para validar que el acudiente haya sido registrado previamente, si @intRegistros
		--es igual a 0 o null, es porque no se había registrado y se devuelve un error 
		SELECT TOP 1 @intRegistros = 1
        FROM [JulianHernandoDavid_NotasDB].[dbo].[ACUDIENTES] WITH(NOLOCK)
        WHERE ([IDENTIFICACION] = @identificacion_A);

        IF @@ROWCOUNT = 0
        BEGIN
            SELECT 235 AS error
            RETURN
        END

		BEGIN TRANSACTION
		-- Actualizar los datos del acudiente
			UPDATE [JulianHernandoDavid_NotasDB].[dbo].[ACUDIENTES]
			SET 
				[PRIMERNOMBRE] = @primerNombre_A,
				[SEGUNDONOMBRE] = @segundoNombre_A,
				[PRIMERAPELLIDO] = @primerApellido_A,
				[SEGUNDOAPELLIDO] = @segundoApellido_A,
				[FECHANACIMIENTO] = @fechaNacimiento_A,
				[DIRECCION] = @direccion,
				[TELEFONO] = @telefono_A,
				[EMAIL] = @email_A
			WHERE 
				IDACUDIENTE = @idAcudiente;
		
		COMMIT TRANSACTION;

    END
	
	--4 - DELETE
	IF @intProceso = 4
    BEGIN
		DELETE FROM [JulianHernandoDavid_NotasDB].[dbo].[ACUDIENTES]
        WHERE (IDACUDIENTE = @idAcudiente);
    END
END
GO
