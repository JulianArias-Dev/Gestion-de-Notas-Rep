USE JulianHernandoDavid_NotasDB
INSERT INTO GRADOS (NOMBRE) 
VALUES 
(6),
(7),
(8),
(9),
(10),
(11);

GO

USE [JulianHernandoDavid_NotasDB]
SELECT IDGRADO AS ID, CONCAT(NOMBRE,'°') AS GRADO FROM GRADOS;

GO


USE [JulianHernandoDavid_NotasDB]
/****** Object:  StoredProcedure [dbo].[SP_CRUD_CURSOS]    Script Date: 18/06/2024 13:37:00 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

-- ==============================================================================================================================
-- Author:						JULIAN ARIAS
-- Create date:					18-06-2024
-- Description:					Permite hacer las operaciones básicas sobre la tabla Cursos
-- ==============================================================================================================================
CREATE OR ALTER PROCEDURE [dbo].[SP_CRUD_CURSOS]
(
    @intProceso                     INT,
    @idCurso						INT = NULL,
    @Codigo							NVARCHAR(2) = NULL,
    @grado							INT = NULL,
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

	--1 - SELECT para cargar los cursos    
	IF @intProceso = 1
	BEGIN
		SELECT A.IDCURSO, A.GRADO, A.CODIGO, G.NOMBRE  
		FROM [JulianHernandoDavid_NotasDB].[dbo].[CURSOS] A WITH (NOLOCK)
		INNER JOIN GRADOS G ON G.IDGRADO= A.GRADO;
	END

	--2 - INSERT PARA REGISTRAR UN CURSO
	IF @intProceso = 2
	BEGIN 
		-- Validar duplicación del codigo
		SELECT TOP 1 @intRegistros = 1
		FROM [JulianHernandoDavid_NotasDB].[dbo].[CURSOS] WITH(NOLOCK)
		WHERE [CODIGO] = @Codigo AND [GRADO] = @grado;

		IF @intRegistros = 1
		BEGIN
			SET @codigoError = 301 -- Código de error para codigo de curso duplicado
			RETURN
		END

		BEGIN TRANSACTION
			-- Se insertan los datos del nuevo curso en la base de datos
			INSERT INTO [JulianHernandoDavid_NotasDB].[dbo].[CURSOS]
					([CODIGO]
					,[GRADO])
				VALUES
					(@Codigo
					,@grado);
		COMMIT TRANSACTION;
    
		SET @idResultado = 201-- Código de confirmación para inserción exitosa
		RETURN
	END

	--3 - UPDATE
	IF @intProceso = 3
	BEGIN
		-- Validar que el curso exista
		SELECT TOP 1 @intRegistros = 1
		FROM [JulianHernandoDavid_NotasDB].[dbo].[CURSOS] WITH(NOLOCK)
		WHERE [IDCURSO] = @idCurso;

		IF @intRegistros = 0
		BEGIN
			SET @codigoError = 235 -- Código de error si el curso no está registrado
			RETURN
		END
		SET  @intRegistros=0 
		
		-- Validar duplicación del codigo
		SELECT TOP 1 @intRegistros = 1
		FROM [JulianHernandoDavid_NotasDB].[dbo].[CURSOS] WITH(NOLOCK)
		WHERE [CODIGO] = @Codigo AND [GRADO] = @grado;

		IF @intRegistros = 1
		BEGIN
			SET @codigoError = 301 -- Código de error para codigo de curso duplicado
			RETURN
		END

		BEGIN TRANSACTION
			-- Actualizar los datos del acudiente
			UPDATE [JulianHernandoDavid_NotasDB].[dbo].[CURSOS]
			SET 
				[CODIGO] = @Codigo,
				[GRADO] = @grado
			WHERE 
				[IDCURSO] = @idCurso;
		COMMIT TRANSACTION;
    
		SET @idResultado = 202 -- Código de confirmación para actualización exitosa
		RETURN
	END

	-- Proceso 4: Eliminar acudiente
    IF @intProceso = 4
    BEGIN
        -- Validar que el curso exista
		SELECT TOP 1 @intRegistros = 1
		FROM [JulianHernandoDavid_NotasDB].[dbo].[CURSOS] WITH(NOLOCK)
		WHERE [IDCURSO] = @idCurso;

		IF @intRegistros = 0
		BEGIN
			SET @codigoError = 235 -- Código de error si el curso no está registrado
			RETURN
		END
		SET  @intRegistros=0 

        -- Validar que no haya estudiantes asociados al curso
        IF EXISTS (SELECT 1 FROM [JulianHernandoDavid_NotasDB].[dbo].[ESTUDIANTES] WHERE CURSO = @idCurso)
        BEGIN
           SET @codigoError = 236; -- Código de error si hay estudiantes asociados al curso
            RETURN;
        END

        BEGIN TRANSACTION
            -- Eliminar el acudiente
            DELETE FROM [JulianHernandoDavid_NotasDB].[dbo].[CURSOS]
            WHERE IDCURSO = @idCurso;
        COMMIT TRANSACTION;
    
        SET @idResultado = 203; -- Código de confirmación para eliminación exitosa
        RETURN;
    END

END



SELECT * FROM CURSOS;