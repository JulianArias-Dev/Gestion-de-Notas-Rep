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
CREATE     PROCEDURE [dbo].[SP_CRUD_ESTUDIANTES]
(
	@intProceso				        INT,
	@idEstudiante					INT = NULL,
	@primerNombre_E					NVARCHAR(15) = NULL,
	@segundoNombre_E				NVARCHAR(15) = NULL,
	@primerApellido_E				NVARCHAR(15) = NULL,
	@segundoApellido_E				NVARCHAR(15) = NULL,
	@identificacion_E				NVARCHAR(12) = NULL,
	@fechaNacimiento_E				DATE = NULL,
	@email_E						NVARCHAR(70) = NULL,
	@direccion						NVARCHAR(70) = NULL,
	@telefono_E						NVARCHAR(15) = NULL,
	@acudiente						INT = NULL,
	@curso							INT NULL
)
	AS
BEGIN
    SET NOCOUNT ON;
    DECLARE @intRegistros INT

	--1 - SELECT PARA BUSQUEDA POR ALUMNO    
	IF @intProceso = 1
		BEGIN
			SELECT
				E.[IDENTIFICACION],
				E.[PRIMERNOMBRE],
				E.[SEGUDONOMBRE] AS SEGUNDONOMBRE,
				E.[PRIMERAPELLIDO],
				E.[SEGUNDOAPELLIDO],
				E.[TELEFONO],
				E.[EMAIL],
				E.[FECHANACIMIENTO],
				-- Se calcula la edad del estudiante, inicialmente se calcula la diferencia entre los años
				-- luego se verifica si el mes actual es menor al mes de nacimiento, en caso de que el mes sea el mismo
				-- se valida si el dia actual es menor que el dia del nacimiento; si se cumple una de esas dos condicione, se resta 1 a la diferencia inicial
				DATEDIFF(YEAR, E.[FECHANACIMIENTO], GETDATE()) - 
				CASE 
					WHEN MONTH(GETDATE()) < MONTH(E.[FECHANACIMIENTO]) OR 
						 (MONTH(GETDATE()) = MONTH(E.[FECHANACIMIENTO]) AND DAY(GETDATE()) < DAY(E.[FECHANACIMIENTO]))
					THEN 1 
					ELSE 0 
				END AS EDAD,
				CONCAT(G.NOMBRE, '-', C.CODIGO) AS GRUPO,
				A.[IDENTIFICACION]		AS A_identificacion,
				A.[IDACUDIENTE]
				FROM
				[JulianHernandoDavid_NotasDB].[dbo].[ESTUDIANTES] E WITH (NOLOCK)
				INNER JOIN CURSOS C ON C.IDCURSO = E.CURSO
				INNER JOIN GRADOS G ON G.IDGRADO = C.GRADO
				INNER JOIN ACUDIENTES A ON A.IDACUDIENTE =  E.ACUDIENTE
			WHERE
				E.[IDENTIFICACION] = @identificacion_E;
		END
	--2 - INSERT PARA REGISTRAR UN ALUMNO Y LOS DATOS DE SU ACUDIENTE
    IF @intProceso = 2
    BEGIN 
		--Antes del insert, hacemos un select para validar que el estudiante no haya sido registrado previamente, si @intRegistros
		--es igual a 1, es poruqe ya se había registrado y se devuelve un error 
        SELECT TOP 1 @intRegistros = 1
        FROM [JulianHernandoDavid_NotasDB].[dbo].[ESTUDIANTES] WITH(NOLOCK)
        WHERE ([IDENTIFICACION] = @identificacion_E);

        IF @@ROWCOUNT = 1
        BEGIN
            SELECT 300 AS error
			 RETURN
        END

       BEGIN TRANSACTION
			--Se insertan los datos del nuevo estudiante en la base de datos
			INSERT INTO [JulianHernandoDavid_NotasDB].[dbo].[ESTUDIANTES]
					([PRIMERNOMBRE]
					,[SEGUDONOMBRE]
					,[PRIMERAPELLIDO]
					,[SEGUNDOAPELLIDO]
					,[IDENTIFICACION]
					,[FECHANACIMIENTO]
					,[DIRECCION]
					,[TELEFONO]
					,[CURSO]
					,[EMAIL],
					[ACUDIENTE])
				VALUES
					(@primerNombre_E
					,@segundoNombre_E
					,@primerApellido_E
					,@segundoApellido_E
					,@identificacion_E
					,@fechaNacimiento_E
					,@direccion
					,@telefono_E
					,@curso
					,@email_E
					,@acudiente)

       COMMIT TRANSACTION 
    END
	--3 - UPDATE
    IF @intProceso = 3
    BEGIN
		
		--Antes del update, hacemos un select para validar que el estudiante haya sido registrado previamente, si @intRegistros
		--es igual a 0 o null, es poruqe no se había registrado y se devuelve un error 
		SELECT TOP 1 @intRegistros = 1
        FROM [JulianHernandoDavid_NotasDB].[dbo].[ESTUDIANTES] WITH(NOLOCK)
        WHERE ([IDENTIFICACION] = @identificacion_E);

        IF @@ROWCOUNT = 1
        BEGIN
            SELECT 301 AS error
            RETURN
        END

		BEGIN TRANSACTION
		-- Actualizar los datos del estudiante
			UPDATE [JulianHernandoDavid_NotasDB].[dbo].[ESTUDIANTES]
			SET 
				[PRIMERNOMBRE] = @primerNombre_E,
				[SEGUDONOMBRE] = @segundoNombre_E,
				[PRIMERAPELLIDO] = @primerApellido_E,
				[SEGUNDOAPELLIDO] = @segundoApellido_E,
				[FECHANACIMIENTO] = @fechaNacimiento_E,
				[DIRECCION] = @direccion,
				[TELEFONO] = @telefono_E,
				[CURSO] = @curso,
				[EMAIL] = @email_E
			WHERE 
				IDESTUDIANTE = @idEstudiante;
		
		COMMIT TRANSACTION;

    END
	--4 - DELETE
	IF @intProceso = 4
    BEGIN
		DELETE FROM [JulianHernandoDavid_NotasDB].[dbo].[ESTUDIANTES]
        WHERE (IDESTUDIANTE = @idEstudiante);
    END
END
GO

	