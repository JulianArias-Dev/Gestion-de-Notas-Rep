USE [JulianHernandoDavid_NotasDB]
GO

/****** Object:  StoredProcedure [dbo].[SP_CRUD_ESTUDIANTES]    Script Date: 04/06/2024 10:24:05 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


-- ==============================================================================================================================
-- Author:						JULIAN ARIAS
-- Create date:					04-06-2024
-- Description:					Permite hacer las operaciones básicas sobre la tabla Estudiantes
-- ==============================================================================================================================
CREATE OR ALTER PROCEDURE [dbo].[SP_CRUD_ESTUDIANTES]
(
    @intProceso                     INT,
    @idEstudiante                   INT = NULL,
    @primerNombre_E                 NVARCHAR(15) = NULL,
    @segundoNombre_E                NVARCHAR(15) = NULL,
    @primerApellido_E               NVARCHAR(15) = NULL,
    @segundoApellido_E              NVARCHAR(15) = NULL,
    @identificacion_E               NVARCHAR(12) = NULL,
    @fechaNacimiento_E              DATE = NULL,
    @email_E                        NVARCHAR(70) = NULL,
    @direccion                      NVARCHAR(70) = NULL,
    @telefono_E                     NVARCHAR(15) = NULL,
    @acudiente                      INT = NULL,
    @curso                          INT = NULL,
	@estado							NVARCHAR(10) = NULL,
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

    --1 - SELECT PARA BUSQUEDA POR ESTUDIANTE    
    IF @intProceso = 1
    BEGIN
        SELECT
            E.[IDESTUDIANTE],
            E.[IDENTIFICACION],
            E.[PRIMERNOMBRE],
            E.[SEGUNDONOMBRE] AS SEGUNDONOMBRE,
            E.[PRIMERAPELLIDO],
            E.[SEGUNDOAPELLIDO],
            E.[TELEFONO],
            E.[EMAIL],
            E.[FECHANACIMIENTO],
            E.[DIRECCION],
            E.[ACUDIENTE],
			A.[PRIMERNOMBRE] AS NOMBREACUDIENTE,
			A.[PRIMERAPELLIDO] AS APELLIDOACUDIENTE,
			E.[CURSO],
			E.[ESTADO],
			CONCAT(G.NOMBRE,'°-',C.[CODIGO]) AS COURSE,
            DATEDIFF(YEAR, E.[FECHANACIMIENTO], GETDATE()) - 
                CASE 
                    WHEN MONTH(GETDATE()) < MONTH(E.[FECHANACIMIENTO]) OR 
                         (MONTH(GETDATE()) = MONTH(E.[FECHANACIMIENTO]) AND DAY(GETDATE()) < DAY(E.[FECHANACIMIENTO]))
                    THEN 1 
                    ELSE 0 
                END AS EDAD
        FROM
            [JulianHernandoDavid_NotasDB].[dbo].[ESTUDIANTES] E WITH (NOLOCK)
		INNER JOIN ACUDIENTES A ON A.IDACUDIENTE =  E.[ACUDIENTE]
		INNER JOIN CURSOS C ON C.IDCURSO =  E.[CURSO]
		INNER JOIN GRADOS G ON G.IDGRADO =  C.[GRADO]
        WHERE
            E.[IDENTIFICACION] = @identificacion_E
		;
    END
    
    --2 - INSERT PARA REGISTRAR UN ESTUDIANTE
    IF @intProceso = 2
    BEGIN 
        -- Validar duplicación de identificación
        SELECT TOP 1 @intRegistros = 1
        FROM [JulianHernandoDavid_NotasDB].[dbo].[ESTUDIANTES] WITH(NOLOCK)
        WHERE [IDENTIFICACION] = @identificacion_E;

		SELECT TOP 1 @intRegistros = 1
        FROM [JulianHernandoDavid_NotasDB].[dbo].[ACUDIENTES] WITH(NOLOCK)
        WHERE [IDENTIFICACION] = @identificacion_E;

		SELECT TOP 1 @intRegistros = 1
        FROM [JulianHernandoDavid_NotasDB].[dbo].[DOCENTES] WITH(NOLOCK)
        WHERE [IDENTIFICACION] = @identificacion_E;

        IF @intRegistros = 1
        BEGIN
            SET @codigoError = 301 -- Código de error para identificación duplicada
            RETURN
        END

        -- Validar duplicación de correo electrónico
        SELECT TOP 1 @intRegistros = 1
        FROM [JulianHernandoDavid_NotasDB].[dbo].[ESTUDIANTES] WITH(NOLOCK)
        WHERE [EMAIL] = @email_E;

		SELECT TOP 1 @intRegistros = 1
        FROM [JulianHernandoDavid_NotasDB].[dbo].[DOCENTES] WITH(NOLOCK)
        WHERE [EMAIL] = @email_E;

        IF @intRegistros = 1
        BEGIN
            SET @codigoError = 302 -- Código de error para correo electrónico duplicado
            RETURN
        END

        -- Validar duplicación de teléfono
        SELECT TOP 1 @intRegistros = 1
        FROM [JulianHernandoDavid_NotasDB].[dbo].[ESTUDIANTES] WITH(NOLOCK)
        WHERE [TELEFONO] = @telefono_E;

		 SELECT TOP 1 @intRegistros = 1
        FROM [JulianHernandoDavid_NotasDB].[dbo].[DOCENTES] WITH(NOLOCK)
        WHERE [TELEFONO] = @telefono_E;

        IF @intRegistros = 1
        BEGIN
            SET @codigoError = 303 -- Código de error para teléfono duplicado
            RETURN
        END

        -- Validar existencia del acudiente
        IF NOT EXISTS (SELECT 1 FROM [JulianHernandoDavid_NotasDB].[dbo].[ACUDIENTES] WHERE IDACUDIENTE = @acudiente)
        BEGIN
            SET @codigoError = 304 -- Código de error si el acudiente no existe
            RETURN
        END

        -- Validar existencia del curso
        IF NOT EXISTS (SELECT 1 FROM [JulianHernandoDavid_NotasDB].[dbo].[CURSOS] WHERE IDCURSO = @curso)
        BEGIN
            SET @codigoError = 305 -- Código de error si el curso no existe
            RETURN
        END

        BEGIN TRANSACTION
            -- Se insertan los datos del nuevo estudiante en la base de datos
            INSERT INTO [JulianHernandoDavid_NotasDB].[dbo].[ESTUDIANTES]
                    ([PRIMERNOMBRE]
                    ,[SEGUNDONOMBRE]
                    ,[PRIMERAPELLIDO]
                    ,[SEGUNDOAPELLIDO]
                    ,[IDENTIFICACION]
                    ,[FECHANACIMIENTO]
                    ,[DIRECCION]
                    ,[TELEFONO]
                    ,[EMAIL]
                    ,[ACUDIENTE]
                    ,[CURSO]
					,[ESTADO])
                VALUES
                    (@primerNombre_E
                    ,@segundoNombre_E
                    ,@primerApellido_E
                    ,@segundoApellido_E
                    ,@identificacion_E
                    ,@fechaNacimiento_E
                    ,@direccion
                    ,@telefono_E
                    ,@email_E
                    ,@acudiente
                    ,@curso
					,@estado)

        COMMIT TRANSACTION;
    
        SET @idResultado = 201-- Código de confirmación para inserción exitosa
        RETURN
    END
    
    --3 - UPDATE
    IF @intProceso = 3
    BEGIN
        -- Validar que el estudiante exista
        SELECT TOP 1 @intRegistros = 1
        FROM [JulianHernandoDavid_NotasDB].[dbo].[ESTUDIANTES] WITH(NOLOCK)
        WHERE [IDESTUDIANTE] = @idEstudiante;

        IF @intRegistros = 0
        BEGIN
            SET @codigoError = 235 -- Código de error si el estudiante no está registrado
            RETURN
        END
        SET  @intRegistros=0 
        -- Validar duplicación de identificación
        SELECT TOP 1 @intRegistros = 1
        FROM [JulianHernandoDavid_NotasDB].[dbo].[ESTUDIANTES] WITH(NOLOCK)
        WHERE [IDENTIFICACION] = @identificacion_E AND [IDESTUDIANTE] != @idEstudiante;
		
		SELECT TOP 1 @intRegistros = 1
        FROM [JulianHernandoDavid_NotasDB].[dbo].[ACUDIENTES] WITH(NOLOCK)
        WHERE [IDENTIFICACION] = @identificacion_E;

		SELECT TOP 1 @intRegistros = 1
        FROM [JulianHernandoDavid_NotasDB].[dbo].[DOCENTES] WITH(NOLOCK)
        WHERE [IDENTIFICACION] = @identificacion_E;

        IF @intRegistros = 1
        BEGIN
            SET @codigoError = 301 -- Código de error para identificación duplicada
            RETURN
        END

        -- Validar duplicación de correo electrónico
        SELECT TOP 1 @intRegistros = 1
        FROM [JulianHernandoDavid_NotasDB].[dbo].[ESTUDIANTES] WITH(NOLOCK)
        WHERE [EMAIL] = @email_E AND [IDESTUDIANTE] != @idEstudiante;

		SELECT TOP 1 @intRegistros = 1
        FROM [JulianHernandoDavid_NotasDB].[dbo].[DOCENTES] WITH(NOLOCK)
        WHERE [EMAIL] = @email_E;

        IF @intRegistros = 1
        BEGIN
            SET @codigoError = 302 -- Código de error para correo electrónico duplicado
            RETURN
        END

        -- Validar duplicación de teléfono
        SELECT TOP 1 @intRegistros = 1
        FROM [JulianHernandoDavid_NotasDB].[dbo].[ESTUDIANTES] WITH(NOLOCK)
        WHERE [TELEFONO] = @telefono_E AND [IDESTUDIANTE] != @idEstudiante;

		SELECT TOP 1 @intRegistros = 1
        FROM [JulianHernandoDavid_NotasDB].[dbo].[DOCENTES] WITH(NOLOCK)
        WHERE [TELEFONO] = @telefono_E;

        IF @intRegistros = 1
        BEGIN
            SET @codigoError = 303 -- Código de error para teléfono duplicado
            RETURN
        END

        -- Validar existencia del acudiente
        IF NOT EXISTS (SELECT 1 FROM [JulianHernandoDavid_NotasDB].[dbo].[ACUDIENTES] WHERE IDACUDIENTE = @acudiente)
        BEGIN
            SET @codigoError = 304 -- Código de error si el acudiente no existe
            RETURN
        END

        -- Validar existencia del curso
        IF NOT EXISTS (SELECT 1 FROM [JulianHernandoDavid_NotasDB].[dbo].[CURSOS] WHERE IDCURSO = @curso)
        BEGIN
            SET @codigoError = 305 -- Código de error si el curso no existe
            RETURN
        END

        BEGIN TRANSACTION
            -- Actualizar los datos del estudiante
            UPDATE [JulianHernandoDavid_NotasDB].[dbo].[ESTUDIANTES]
            SET 
                [PRIMERNOMBRE] = @primerNombre_E,
                [IDENTIFICACION] = @identificacion_E,
                [SEGUNDONOMBRE] = @segundoNombre_E,
                [PRIMERAPELLIDO] = @primerApellido_E,
                [SEGUNDOAPELLIDO] = @segundoApellido_E,
                [FECHANACIMIENTO] = @fechaNacimiento_E,
                [DIRECCION] = @direccion,
                [TELEFONO] = @telefono_E,
                [EMAIL] = @email_E,
                [ACUDIENTE] = @acudiente,
                [CURSO] = @curso,
				[ESTADO] = @estado
            WHERE 
                [IDESTUDIANTE] = @idEstudiante;
        COMMIT TRANSACTION;
    
        SET @idResultado = 202 -- Código de confirmación para actualización exitosa
        RETURN
    END

    
    -- Proceso 4: Eliminar estudiante
    IF @intProceso = 4
    BEGIN
        -- Validar que el estudiante exista
        IF NOT EXISTS (SELECT 1 FROM [JulianHernandoDavid_NotasDB].[dbo].[ESTUDIANTES] WHERE IDESTUDIANTE = @idEstudiante)
        BEGIN
           SET @codigoError = 235 -- Código de error si el estudiante no está registrado
            RETURN;
        END

		 -- Validar que el campo del curso sea NULL
		IF EXISTS (SELECT 1 FROM [JulianHernandoDavid_NotasDB].[dbo].[ESTUDIANTES] WHERE IDESTUDIANTE = @idEstudiante AND CURSO IS NOT NULL)
		BEGIN
			SET @codigoError = 306 -- Código de error si el estudiante está asociado a un curso
			RETURN;
		END

        BEGIN TRANSACTION
            -- Eliminar el estudiante
            DELETE FROM [JulianHernandoDavid_NotasDB].[dbo].[ESTUDIANTES]
            WHERE IDESTUDIANTE = @idEstudiante;
        COMMIT TRANSACTION;
    
        SET @idResultado = 203; -- Código de confirmación para eliminación exitosa
        RETURN;
    END
END
GO
