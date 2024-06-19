using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using System.Net.Http.Headers;

namespace BLL
{
    public class CursosService
    {
        private GradosDB grados;
        private CursosDB cursos;
        public List<Grado> listadoGrados;
        public List<Curso> listadoCursos;

        public CursosService() { 
            grados = new GradosDB();
            cursos = new CursosDB();
            getList();
            getCursos();
        }

        private void getList()
        {
            listadoGrados=grados.ListadoGrados();
        }

        private void getCursos()
        {
            listadoCursos= (List<Curso>)cursos.SP_CursosCRUD(new Curso(), 1);
        }

        public Curso buscarCurso(string curso)
        {
            if (listadoCursos==null) return null;

            return listadoCursos.FirstOrDefault(c => c.Nombre.Equals(curso));
        }

        public string InsertarCurso(Curso curso)
        {
            int result = Convert.ToInt32(cursos.SP_CursosCRUD(curso, 2));

            string message = Resultado(result);
            getCursos();
            return message;
        }

        public string ModificarCurso(Curso curso)
        {
            int result = Convert.ToInt32(cursos.SP_CursosCRUD(curso, 3));

            string message = Resultado(result);
            getCursos();
            return message;
        }

        public string EliminarCurso(Curso curso)
        {
            int result = Convert.ToInt32(cursos.SP_CursosCRUD(curso, 4));

            string message = Resultado(result);
            getCursos();
            return message;
        }

        private static string Resultado(int code)
        {
            switch (code)
            {
                case 235:
                    return $"Error {code}: El curso no está registrado, no se pudo realizar la operación.";
                case 236:
                    return $"Error {code}: Los datos del curso no se pueden Eliminar porque hay estudiantes asociados al mismo.";
                case 301:
                    return $"Error {code}: Codigo duplicado, ya hay un curso con ese codigo para este grado.";
                case 201:
                    return $"Se ha creado exitosamente el curso";
                case 202:
                    return $"Se ha modificado exitosamente el codigo del grupo";
                case 203:
                    return $"Se han eliminado correctamente curso";
                default:
                    return $"Error desconocido: Código {code}";
            }
        }
    }
}
