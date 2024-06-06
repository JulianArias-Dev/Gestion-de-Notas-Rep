<div aling-items="spacebetween">
  <img src="https://cdn.jsdelivr.net/gh/devicons/devicon/icons/csharp/csharp-original.svg" alt="C# Icon" width="50" height="50">
  <img src="https://cdn.jsdelivr.net/gh/devicons/devicon/icons/microsoftsqlserver/microsoftsqlserver-plain-wordmark.svg" alt="T-SQL Icon" width="50" height="50">
</div>

## Gestion-de-Notas-Rep 

# Intelligent Score Management for Institutes (ISMI)
A grandes rasgos, el objetivo de este proyecto es desarrollar una aplicación de escritorio que permita registrar y gestionar los estudiantes, los grados, las materias, los docentes y las notas de un colegio para mejorar el seguimiento académico de los estudiantes.

## Requerimientos: 

### Gestión de Estudiantes
- **RF1:** Registro de estudiantes con los siguientes datos:
  - Nombre completo
  - Identificación (ID)
  - Fecha de nacimiento
  - Dirección
  - Teléfono de contacto
- **RF2:** Modificación de los datos de estudiantes.
- **RF3:** Eliminación de estudiantes del sistema.
- **RF4:** Búsqueda de estudiantes por nombre y/o ID.

### Gestión de Grados
- **RF5:** Registro de grados escolares (Sexto, Séptimo, Octavo, Noveno, Décimo, Once).
- **RF6:** Asignación de estudiantes a grados específicos.
- **RF7:** Visualización de la lista de estudiantes por grado.

### Gestión de Materias y Docentes
- **RF8:** Registro de materias con los siguientes datos:
  - Nombre de la materia
  - Docente encargado (Filtrar por el tipo de materia y su especialidad)
- **RF9:** Asociación de materias a un grado específico.
- **RF10:** Modificación y eliminación de materias.

### Registro de Notas
- **RF11:** Ingreso de notas por materia para cada estudiante (Cada nota debe obtener una observación para el estudiante, esta debe ser tenida en cuenta al momento de imprimir el boletín).
- **RF12:** Modificación y eliminación de notas (Solo aplica si NO se ha registrado un periodo después, es decir, si no se ha registrado nota del PERIODO 2 se puede modificar el PERIODO 1, una vez se registre nota en el PERIODO 2 ya no se puede modificar la nota del PERIODO 1, si quiere hacerlo solo lo puede hacer el superusuario).
- **RF13:** Consulta de notas por estudiante y materia.

### Reportes
- **RF14:** Generación de reportes de notas por estudiante, materia y grado.
- **RF15:** Reportes de rendimiento por grado y materia (En gráficas y en PDF debe decir el mejor estudiante por salón y ordenarlos del mejor promedio al peor para seleccionar los puestos).

### Gestión de Usuarios
- **RF16:** Registro de usuarios para docentes con capacidad de ingresar y modificar notas de las materias que imparten.
- **RF17:** Registro de un superusuario (directivos) con permisos para administrar todo el sistema y acceso a todos los reportes y funcionalidades.
- **RF18:** Login seguro para docentes y directivos (Deseable utilizar JWT para encriptar el inicio, si no es posible hacerlo normal).

### Generación de Boletines
- **RF19:** Los estudiantes pueden ingresar al sistema utilizando su cédula para generar un PDF de su boletín académico, el PDF debe ser enviado vía correo electrónico.
- **RF20:** Los boletines incluirán la lista de materias, las notas obtenidas en cada periodo académico (Periodo 1, Periodo 2, Periodo 3, Periodo 4) y un promedio final. El estudiante puede seleccionar entre imprimir el primer, segundo, tercer o cuarto periodo. **Nota:** Esto depende del periodo en el cual tenga registradas las notas, si no se ha registrado notas para el periodo X en su totalidad, no se puede imprimir. Todas las materias deben tener su nota para poder imprimir.
- **RF21:** Funcionalidad para imprimir, descargar y enviar el boletín en formato PDF.

### Gestión de Docentes
- **RF22:** Registro de docentes con los siguientes datos:
  - Nombre completo
  - Identificación (ID)
  - Fecha de nacimiento
  - Dirección
  - Especialidad (Si es de naturales, física, matemáticas)
  - Teléfono de contacto
- **RF23:** Modificación de los datos de docente.
- **RF24:** Eliminación de docente del sistema (NO SE PUEDE ELIMINAR SI TIENE UNA MATERIA ASIGNADA).
- **RF25:** Búsqueda de docente por nombre y/o ID.

## Actualizaciones
Julian Arias - David Payares - Hernando Diaz

### 25/05/2024
A dia de hoy se ha subido el srcipt de la creación de las tablas en la base de datos

### 03/06/2024
A día de hoy se ha trabajado en el diseño de la GUI

