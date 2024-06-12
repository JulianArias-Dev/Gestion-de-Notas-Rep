USE [JulianHernandoDavid_NotasDB];
Go

CREATE TABLE ROLES(
	IDCARGO INT IDENTITY(1,1) PRIMARY KEY,
	NOMBRE NVARCHAR(25) NOT NULL UNIQUE
);

CREATE TABLE MODULOS(
	IDMODULO INT IDENTITY(1,1) PRIMARY KEY,
	NOMBRE NVARCHAR(25) NOT NULL UNIQUE
);

CREATE TABLE PERMISOS(
	IDPERMISO INT IDENTITY (1,1) PRIMARY KEY, 
	CARGO INT NOT NULL,
	MODULO INT NOT NULL,
	CONSTRAINT FK_CARGOPERMISO FOREIGN KEY (CARGO) REFERENCES ROLES(IDCARGO),
	CONSTRAINT FK_MODULOPERMISO FOREIGN KEY (MODULO) REFERENCES MODULOS(IDMODULO),
	CONSTRAINT PK_PERMISOS UNIQUE (CARGO,MODULO)
);

CREATE TABLE ESPECIALIDADES(
	IDESPECIALIDAD INT IDENTITY(1,1) PRIMARY KEY,
	NOMBRE NVARCHAR(50) NOT NULL UNIQUE
);

CREATE TABLE USUARIOS(
	IDUSUARIO INT IDENTITY(1,1) PRIMARY KEY,
	NOMBREDEUSUARIO NVARCHAR(12) NOT NULL UNIQUE,
	CONTRASE�A NVARCHAR(15) NOT NULL,
	CARGO INT NOT NULL,
	CONSTRAINT FK_CARGO FOREIGN KEY (CARGO) REFERENCES ROLES(IDCARGO)
);

CREATE TABLE DOCENTES(
	IDDOCENTE INT IDENTITY(1,1) PRIMARY KEY,
	PRIMERNOMBRE NVARCHAR(15) NOT NULL,
	SEGUDONOMBRE NVARCHAR(15),
	PRIMERAPELLIDO NVARCHAR(15) NOT NULL,
	SEGUNDOAPELLIDO NVARCHAR(15) NOT NULL,
	IDENTIFICACION NVARCHAR(12) NOT NULL UNIQUE,
	FECHANACIMIENTO DATE NOT NULL,
	DIRECCION NVARCHAR(70) NOT NULL,
	TELEFONO NVARCHAR(15) NOT NULL UNIQUE,
	USUARIO INT NOT NULL,
	CONSTRAINT FK_USER FOREIGN KEY (USUARIO) REFERENCES USUARIOS(IDUSUARIO)
);

CREATE TABLE ESPECIALIZACIONES(
	ESPECIALIDAD INT NOT NULL,
	DOCENTE INT NOT NULL,
	CONSTRAINT FK_ESP_DOC FOREIGN KEY (ESPECIALIDAD) REFERENCES ESPECIALIDADES(IDESPECIALIDAD),
	CONSTRAINT FK_DOC FOREIGN KEY (DOCENTE) REFERENCES DOCENTES(IDDOCENTE),
	CONSTRAINT UNQ_ESP UNIQUE (ESPECIALIDAD,DOCENTE)
);

CREATE TABLE GRADOS(
	IDGRADO INT IDENTITY(1,1) PRIMARY KEY,
	NOMBRE INT NOT NULL UNIQUE
);

CREATE TABLE MATERIAS(
	IDMATERIA INT IDENTITY(1,1) PRIMARY KEY,
	NOMBRE NVARCHAR(25) NOT NULL UNIQUE,
	ESPECIALIDAD INT NOT NULL, 
	GRADO INT NOT NULL,
	DOCENTE INT NOT NULL,
	CONSTRAINT FK_ESP_DOCENTE FOREIGN KEY (ESPECIALIDAD) REFERENCES ESPECIALIDADES(IDESPECIALIDAD),
	CONSTRAINT FK_GRADO_MAT FOREIGN KEY (GRADO) REFERENCES GRADOS(IDGRADO),
	CONSTRAINT FK_DOC_MAT FOREIGN KEY (DOCENTE) REFERENCES DOCENTES(IDDOCENTE)
);

CREATE TABLE CURSOS(
	IDCURSO INT IDENTITY(1,1) PRIMARY KEY,
	CODIGO NVARCHAR(2) NOT NULL,
	GRADO INT NOT NULL,
	CONSTRAINT FK_GRADO FOREIGN KEY (GRADO) REFERENCES GRADOS(IDGRADO), 
	CONSTRAINT PK_CURSOS UNIQUE (GRADO,CODIGO)
);

CREATE TABLE ACUDIENTES(
	IDACUDIENTE INT IDENTITY(1,1) PRIMARY KEY,
	PRIMERNOMBRE NVARCHAR(15) NOT NULL,
	SEGUDONOMBRE NVARCHAR(15),
	PRIMERAPELLIDO NVARCHAR(15) NOT NULL,
	SEGUNDOAPELLIDO NVARCHAR(15) NOT NULL,
	IDENTIFICACION NVARCHAR(12) NOT NULL UNIQUE,
	TELEFONO NVARCHAR(15) NOT NULL UNIQUE,
	EMAIL NVARCHAR(70) NOT NULL,
	FECHANACIMIENTO DATE NOT NULL,
	DIRECCION NVARCHAR(70) NOT NULL,
);

CREATE TABLE ESTUDIANTES(	
	IDESTUDIANTE INT IDENTITY(1,1) PRIMARY KEY,
	PRIMERNOMBRE NVARCHAR(15) NOT NULL,
	SEGUDONOMBRE NVARCHAR(15),
	PRIMERAPELLIDO NVARCHAR(15) NOT NULL,
	SEGUNDOAPELLIDO NVARCHAR(15) NOT NULL,
	IDENTIFICACION NVARCHAR(12) NOT NULL UNIQUE,
	FECHANACIMIENTO DATE NOT NULL,
	DIRECCION NVARCHAR(70) NOT NULL,
	TELEFONO NVARCHAR(15) NOT NULL UNIQUE,
	CURSO INT NOT NULL,
	CONSTRAINT FK_CURSO FOREIGN KEY (CURSO) REFERENCES CURSOS(IDCURSO),
	EMAIL NVARCHAR(70) NOT NULL UNIQUE,
	ACUDIENTE INT NOT NULL,
	CONSTRAINT FK_ACUDIENTE_STD FOREIGN KEY (ACUDIENTE)REFERENCES ACUDIENTES(IDACUDIENTE)
);

CREATE TABLE PERIODOS_ACADEMICOS(
	IDPERIODO INT IDENTITY(1,1) PRIMARY KEY,
	FECHAINICIO DATE NOT NULL UNIQUE,
	FECHAFINALIZACION DATE NOT NULL UNIQUE,
	NOMBRE NVARCHAR(15) NOT NULL,
	A�O NVARCHAR(5) NOT NULL
);

CREATE TABLE NOTAS(
	ESTUDIANTE INT NOT NULL,
	MATERIA INT NOT NULL,
	NOTA DECIMAL NOT NULL,
	OBSERVACION NVARCHAR NOT NULL,
	PERIODO INT NOT NULL,
	CONSTRAINT FK_ESTUDIANTE FOREIGN KEY (ESTUDIANTE) REFERENCES ESTUDIANTES(IDESTUDIANTE),
	CONSTRAINT FK_MATERIA FOREIGN KEY (MATERIA) REFERENCES MATERIAS(IDMATERIA),
	CONSTRAINT FK_PERIODO FOREIGN KEY (PERIODO) REFERENCES PERIODOS_ACADEMICOS(IDPERIODO),
	CONSTRAINT UNQ_ESTMAT UNIQUE (ESTUDIANTE,MATERIA,PERIODO)
);

