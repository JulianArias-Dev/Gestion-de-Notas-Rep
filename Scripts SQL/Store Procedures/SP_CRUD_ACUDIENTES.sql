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
CREATE OR ALTER PROCEDURE [dbo].[SP_CRUD_ACUDIENTES]
(
    @intProceso                     INT,
    @idAcudiente                    INT = NULL,
    @primerNombre_A                 NVARCHAR(15) = NULL,
    @segundoNombre_A                NVARCHAR(15) = NULL,
    @primerApellido_A               NVARCHAR(15) = NULL,
    @segundoApellido_A              NVARCHAR(15) = NULL,
    @identificacion_A               NVARCHAR(12) = NULL,
    @fechaNacimiento_A              DATE = NULL,
    @email_A                        NVARCHAR(70) = NULL,
    @direccion                      NVARCHAR(70) = NULL,
    @telefono_A                     NVARCHAR(15) = NULL,
    @codigoError                    INT OUTPUT,
    @idResultado                    INT OUTPUT
)
AS
BEGIN
    SET NOCOUNT ON;
    DECLARE @intRegistros INT
	
	SET @intRegistros = 0
	SET @codigoError = 0
    SET @idResultado = 0

	--1 - SELECT PARA BUSQUEDA POR ACUDIENTE    
	IF @intProceso = 1
	BEGIN
		SELECT
			A.[IDACUDIENTE],
			A.[IDENTIFICACION],
			A.[PRIMERNOMBRE],
			A.[SEGUNDONOMBRE] AS SEGUNDONOMBRE,
			A.[PRIMERAPELLIDO],
			A.[SEGUNDOAPELLIDO],
			A.[TELEFONO],
			A.[EMAIL],
			A.[FECHANACIMIENTO],
			A.[DIRECCION],
			DATEDIFF(YEAR, A.[FECHANACIMIENTO], GETDATE()) - 
				CASE 
					WHEN MONTH(GETDATE()) < MONTH(A.[FECHANACIMIENTO]) OR 
						 (MONTH(GETDATE()) = MONTH(A.[FECHANACIMIENTO]) AND DAY(GETDATE()) < DAY(A.[FECHANACIMIENTO]))
					THEN 1 
					ELSE 0 
				END AS EDAD
		FROM
			[JulianHernandoDavid_NotasDB].[dbo].[ACUDIENTES] A WITH (NOLOCK)
		WHERE
			A.[IDENTIFICACION] = @identificacion_A;
	END
	
	--2 - INSERT PARA REGISTRAR UN ACUDIENTE
	IF @intProceso = 2
	BEGIN 
		-- Validar duplicación de identificación
		SELECT TOP 1 @intRegistros = 1
		FROM [JulianHernandoDavid_NotasDB].[dbo].[ACUDIENTES] WITH(NOLOCK)
		WHERE [IDENTIFICACION] = @identificacion_A;

		SELECT TOP 1 @intRegistros = 1
		FROM [JulianHernandoDavid_NotasDB].[dbo].[ESTUDIANTES] WITH(NOLOCK)
		WHERE [IDENTIFICACION] = @identificacion_A;

		SELECT TOP 1 @intRegistros = 1
		FROM [JulianHernandoDavid_NotasDB].[dbo].[DOCENTES] WITH(NOLOCK)
		WHERE [IDENTIFICACION] = @identificacion_A;

		IF @intRegistros = 1
		BEGIN
			SET @codigoError = 301 -- Código de error para identificación duplicada
			RETURN
		END

		-- Validar duplicación de correo electrónico
		SELECT TOP 1 @intRegistros = 1
		FROM [JulianHernandoDavid_NotasDB].[dbo].[ACUDIENTES] WITH(NOLOCK)
		WHERE [EMAIL] = @email_A;

		SELECT TOP 1 @intRegistros = 1
		FROM [JulianHernandoDavid_NotasDB].[dbo].[DOCENTES] WITH(NOLOCK)
		WHERE [EMAIL] = @email_A;

		IF @intRegistros = 1
		BEGIN
			SET @codigoError = 302 -- Código de error para correo electrónico duplicado
			RETURN
		END

		-- Validar duplicación de teléfono
		SELECT TOP 1 @intRegistros = 1
		FROM [JulianHernandoDavid_NotasDB].[dbo].[ACUDIENTES] WITH(NOLOCK)
		WHERE [TELEFONO] = @telefono_A;

		SELECT TOP 1 @intRegistros = 1
		FROM [JulianHernandoDavid_NotasDB].[dbo].[DOCENTES] WITH(NOLOCK)
		WHERE [TELEFONO] = @telefono_A;
		
		IF @intRegistros = 1
		BEGIN
            SET @codigoError = 303 -- Código de error para teléfono duplicado
            RETURN
        END

		BEGIN TRANSACTION
			-- Se insertan los datos del nuevo acudiente en la base de datos
			INSERT INTO [JulianHernandoDavid_NotasDB].[dbo].[ACUDIENTES]
					([PRIMERNOMBRE]
					,[SEGUNDONOMBRE]
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

		COMMIT TRANSACTION;
    
		SET @idResultado = 201-- Código de confirmación para inserción exitosa
		RETURN
	END
	
	--3 - UPDATE
	IF @intProceso = 3
	BEGIN
		-- Validar que el acudiente exista
		SELECT TOP 1 @intRegistros = 1
		FROM [JulianHernandoDavid_NotasDB].[dbo].[ACUDIENTES] WITH(NOLOCK)
		WHERE [IDACUDIENTE] = @idAcudiente;

		IF @intRegistros = 0
		BEGIN
			SET @codigoError = 235 -- Código de error si el acudiente no está registrado
			RETURN
		END
		SET  @intRegistros=0 
		-- Validar duplicación de identificación
		SELECT TOP 1 @intRegistros = 1
		FROM [JulianHernandoDavid_NotasDB].[dbo].[ACUDIENTES] WITH(NOLOCK)
		WHERE [IDENTIFICACION] = @identificacion_A AND [IDACUDIENTE] != @idAcudiente;

		SELECT TOP 1 @intRegistros = 1
		FROM [JulianHernandoDavid_NotasDB].[dbo].[ESTUDIANTES] WITH(NOLOCK)
		WHERE [IDENTIFICACION] = @identificacion_A;

		SELECT TOP 1 @intRegistros = 1
		FROM [JulianHernandoDavid_NotasDB].[dbo].[DOCENTES] WITH(NOLOCK)
		WHERE [IDENTIFICACION] = @identificacion_A;

		IF @intRegistros = 1
		BEGIN
			SET @codigoError = 301 -- Código de error para identificación duplicada
			RETURN
		END

		-- Validar duplicación de correo electrónico
		SELECT TOP 1 @intRegistros = 1
		FROM [JulianHernandoDavid_NotasDB].[dbo].[ACUDIENTES] WITH(NOLOCK)
		WHERE [EMAIL] = @email_A AND [IDACUDIENTE] != @idAcudiente;

		SELECT TOP 1 @intRegistros = 1
		FROM [JulianHernandoDavid_NotasDB].[dbo].[DOCENTES] WITH(NOLOCK)
		WHERE [EMAIL] = @email_A;

		IF @intRegistros = 1
		BEGIN
			SET @codigoError = 302 -- Código de error para correo electrónico duplicado
			RETURN
		END

		-- Validar duplicación de teléfono
		SELECT TOP 1 @intRegistros = 1
		FROM [JulianHernandoDavid_NotasDB].[dbo].[ACUDIENTES] WITH(NOLOCK)
		WHERE [TELEFONO] = @telefono_A AND [IDACUDIENTE] != @idAcudiente;

		SELECT TOP 1 @intRegistros = 1
		FROM [JulianHernandoDavid_NotasDB].[dbo].[DOCENTES] WITH(NOLOCK)
		WHERE [TELEFONO] = @telefono_A;

		IF @intRegistros = 1
		BEGIN
			SET @codigoError = 303 -- Código de error para teléfono duplicado
			RETURN
		END

		BEGIN TRANSACTION
			-- Actualizar los datos del acudiente
			UPDATE [JulianHernandoDavid_NotasDB].[dbo].[ACUDIENTES]
			SET 
				[PRIMERNOMBRE] = @primerNombre_A,
				[IDENTIFICACION] = @identificacion_A,
				[SEGUNDONOMBRE] = @segundoNombre_A,
				[PRIMERAPELLIDO] = @primerApellido_A,
				[SEGUNDOAPELLIDO] = @segundoApellido_A,
				[FECHANACIMIENTO] = @fechaNacimiento_A,
				[DIRECCION] = @direccion,
				[TELEFONO] = @telefono_A,
				[EMAIL] = @email_A
			WHERE 
				[IDACUDIENTE] = @idAcudiente;
		COMMIT TRANSACTION;
    
		SET @idResultado = 202 -- Código de confirmación para actualización exitosa
		RETURN
	END

	
	-- Proceso 4: Eliminar acudiente
    IF @intProceso = 4
    BEGIN
        -- Validar que el acudiente exista
        IF NOT EXISTS (SELECT 1 FROM [JulianHernandoDavid_NotasDB].[dbo].[ACUDIENTES] WHERE IDACUDIENTE = @idAcudiente)
        BEGIN
           SET @codigoError = 235 -- Código de error si el acudiente no está registrado
            RETURN;
        END

        -- Validar que no haya estudiantes asociados al acudiente
        IF EXISTS (SELECT 1 FROM [JulianHernandoDavid_NotasDB].[dbo].[ESTUDIANTES] WHERE ACUDIENTE = @idAcudiente)
        BEGIN
           SET @codigoError = 236; -- Código de error si hay estudiantes asociados al acudiente
            RETURN;
        END

        BEGIN TRANSACTION
            -- Eliminar el acudiente
            DELETE FROM [JulianHernandoDavid_NotasDB].[dbo].[ACUDIENTES]
            WHERE IDACUDIENTE = @idAcudiente;
        COMMIT TRANSACTION;
    
        SET @idResultado = 203; -- Código de confirmación para eliminación exitosa
        RETURN;
    END
END
GO

