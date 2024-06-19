using BLL;
using Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class ControlCursos : Form
    {
        private CursosService service = new CursosService();
        private Curso curso = new Curso();

        public ControlCursos()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ControlCursos_Load(object sender, EventArgs e)
        {
            cmbGrado.DataSource = service.listadoGrados;
            cmbGrado.DisplayMember = "Nombre";
            cmbGrado.ValueMember = "IdGrado";
            cmbGrado.Text = "";
        }

        private void btnRegistarCliente_Click(object sender, EventArgs e)
        {
            curso  = recolectarInformacion();

            if (curso==null) return;

            DialogResult result = MessageBox.Show($"¿Estás seguro de registrar estos datos? \n{curso.showCurso()}", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                var mss = service.InsertarCurso(curso);
                MessageBox.Show(mss);
                if (!mss.Contains("Error"))
                {
                    limpiarCampos();
                }
            }
            else if (result == DialogResult.No)
            {
                MessageBox.Show("De acuerdo, se ha cancelado la operación");
            }
        }

        private void btnModificarAcudiente_Click(object sender, EventArgs e)
        {
            var auxiliar = recolectarInformacion();
            
            if (auxiliar==null) return;

            curso=auxiliar;

            DialogResult result = MessageBox.Show($"¿Estás seguro de modificar estos datos? \n{curso.showCurso()}", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                var mss = service.ModificarCurso(curso);
                MessageBox.Show(mss);
                if (!mss.Contains("Error"))
                {
                    limpiarCampos();
                }
            }
            else if (result == DialogResult.No)
            {
                MessageBox.Show("De acuerdo, se ha cancelado la operación");
            }
        }

        private void btnBuscarCurso_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCursoCode.Text))
            {
                MessageBox.Show("Debe suministrar el nombre del curso. \nEjemplo: '6°-A' o '6°-01'");
                txtCursoCode.Focus();
                return;
            }

            curso = service.buscarCurso(txtCursoCode.Text);

            if (curso==null)
            {
                MessageBox.Show("No se ha encontrado el curso");
                return;
            }

            txtCursoCode.Text=curso.Codigo;
            cmbGrado.Text=curso.grado.Nombre;
        }


        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (curso==null)
            {
                MessageBox.Show("No hay curso para eliminar");
                return;
            }

            DialogResult result = MessageBox.Show($"¿Estás seguro de Eliminar este acudiente? \n{curso.showCurso()}", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                var mss = service.EliminarCurso(curso);
                MessageBox.Show(mss);
                if (!mss.Contains("Error"))
                {
                    limpiarCampos();
                }
            }
            else if (result == DialogResult.No)
            {
                MessageBox.Show("De acuerdo, se ha cancelado la operación");
            }
        }

        private Curso recolectarInformacion()
        {
            if (cmbGrado.SelectedValue==null || string.IsNullOrEmpty(cmbGrado.Text))
            {
                MessageBox.Show("Debe seleccionar el grado");
                cmbGrado.Focus();
                return null;
            }
            else if (string.IsNullOrEmpty(txtCursoCode.Text))
            {
                MessageBox.Show("Debe suministrar un codigo al curso. \nEjemplo: 'A...' o '01...'");
                txtCursoCode.Focus();
                return null;
            }

            var aux = new Curso()
            {
                IdCurso= curso != null ? curso.IdCurso : 0 ,
                Codigo = txtCursoCode.Text,
                grado = cmbGrado.SelectedItem as Grado
            };
            return aux;
        }

        private void limpiarCampos()
        {
            txtCursoCode.Clear();
            cmbGrado.Text="";
        }

        private void btnCargarEstudiantes_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCurso.Text))
            {
                MessageBox.Show("Debe suministrar el nombre del curso. \nEjemplo: '6°-A' o '6°-01'");
                txtCursoCode.Focus();
                return;
            }

            curso = service.buscarCurso(txtCurso.Text);

            if (curso==null)
            {
                MessageBox.Show("No se ha encontrado el curso");
                return;
            }

            DataTable table = EstudiantesService.EstudiantesporCurso(curso.IdCurso);

            if (table!=null)
            {
                dgvStudentList.DataSource=table;
                dgvStudentList.Refresh();
            }
        }
    }
}
