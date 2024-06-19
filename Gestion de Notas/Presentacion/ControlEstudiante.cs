using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using Entity;

namespace Presentacion
{
    public partial class ControlEstudiante : Form
    {
        private Estudiante estudiante;
        private Acudiente acudiente = new Acudiente();
        private Curso curso = new Curso();
        private CursosService cursosService = new CursosService(); 

        public ControlEstudiante()
        {
            InitializeComponent();
            
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        

        private void txtCorreo_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCorreo.Text)) 
            {
                lblVal.Visible=false; return;
            }

            lblVal.Visible = Validaciones.ValCorreo(txtCorreo.Text) ? false : true;
        }

        private void txtIdentificacion_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtIdentificacion.Text))
            {
                lblValId.Visible=false; return;
            }

            lblValId.Visible = Validaciones.ValIdentificacion(txtIdentificacion.Text) ? false : true;
        }

        private void txtTelefono_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTelefono.Text))
            {
                lblValTel.Visible=false; return;
            }

            lblValTel.Visible = Validaciones.valTelefono(txtTelefono.Text) ? false : true;
        }

        private void btnBuscarCurso_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCurso.Text))
            {
                MessageBox.Show("Debe suministrar el nombre del curso. \nEjemplo: '6°-A' o '6°-01'");
                txtCurso.Focus();
                return;
            }

            curso = cursosService.buscarCurso(txtCurso.Text);

            if (curso==null)
            {
                MessageBox.Show("No se ha encontrado el curso");
                return;
            }

            txtCurso.Text=curso.Nombre;
        }

        private void btnBuscarAcudiente_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtidAcudiente.Text))
            {
                MessageBox.Show("El campo de identificacion no puede estar vacío");
                txtidAcudiente.Focus();
                return;
            }

            var aux = new Acudiente()
            {
                identificacion=txtidAcudiente.Text
            };

            acudiente = AcudientesService.BuscarAcudiente(aux);

            if (acudiente==null)
            {
                MessageBox.Show("No se ha encontrado un Acudiente con esa identificación");
                return;
            }

            lblApellidosA.Text = $"Apellidos: {acudiente.primerApellido} {acudiente.segundoApellido}";
            lbNombreA.Text = $"Nombres: {acudiente.primerNombre} {acudiente.segundoNombre}";
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtIdentificacion.Text))
            {
                MessageBox.Show("El campo de identificacion no puede estar vacío");
                txtIdentificacion.Focus();
                return;
            }

            var aux = new Estudiante()
            {
                Identificacion=txtIdentificacion.Text,
                Curso = new Curso(),
                Acudiente = new Acudiente()
            };

            estudiante = EstudiantesService.BuscarEstudiante(aux);

            if (estudiante==null)
            {
                MessageBox.Show("No se ha encontrado un Estudiante con esa identificación");
                return;
            }
            acudiente = estudiante.Acudiente;
            curso = estudiante.Curso;

            txtIdentificacion.Text = estudiante.Identificacion;
            txtPNombre.Text = estudiante.PrimerNombre;
            txtSNombre.Text = estudiante.SegundoNombre;
            txtPapellido.Text = estudiante.PrimerApellido;
            txtSApellido.Text = estudiante.SegundoApellido;
            txtCorreo.Text = estudiante.Email;
            txtTelefono.Text = estudiante.Telefono;
            txtDireccion.Text = estudiante.Direccion;
            dtFecha.Value = estudiante.FechaNacimiento;
            lblEdad.Text = $"Edad: {estudiante.Edad}";

            txtCurso.Text=curso.Nombre;
            txtidAcudiente.Text = acudiente.identificacion;
            lblApellidosA.Text = $"Apellidos: {acudiente.primerApellido} {acudiente.segundoApellido}";
            lbNombreA.Text = $"Nombres: {acudiente.primerNombre} {acudiente.segundoNombre}";
        }

        private void btnRegistar_Click(object sender, EventArgs e)
        {
            estudiante  = recolectarInformacion();

            if (estudiante==null) return;

            DialogResult result = MessageBox.Show($"¿Estás seguro de registrar estos datos? \n{estudiante.showStudent()}", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                var mss = EstudiantesService.InsertarEstudiante(estudiante);
                MessageBox.Show(mss);
                if (!mss.Contains("Error"))
                {
                    limpiarCampos();
                    cargarDgv();
                }
            }
            else if (result == DialogResult.No)
            {
                MessageBox.Show("De acuerdo, se ha cancelado la operación");
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            var auxiliar = recolectarInformacion();

            if (auxiliar==null) return;

            estudiante = auxiliar;

            DialogResult result = MessageBox.Show($"¿Estás seguro de actualizar con estos datos? \n{estudiante.showStudent()}", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                var mss = EstudiantesService.ModificarEstudiante(estudiante);
                MessageBox.Show(mss);
                if (!mss.Contains("Error"))
                {
                    limpiarCampos();
                    cargarDgv();
                }
            }
            else if (result == DialogResult.No)
            {
                MessageBox.Show("De acuerdo, se ha cancelado la operación");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (estudiante==null)
            {
                MessageBox.Show("No hay estudiante para eliminar");
                return;
            }

            DialogResult result = MessageBox.Show($"¿Estás seguro de Eliminar este estudiante? \n{estudiante.showStudent()}", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                var mss = EstudiantesService.EliminarEstudiante(estudiante);
                MessageBox.Show(mss);
                if (!mss.Contains("Error"))
                {
                    limpiarCampos();
                    cargarDgv();
                }
            }
            else if (result == DialogResult.No)
            {
                MessageBox.Show("De acuerdo, se ha cancelado la operación");
            }
        }

        private Estudiante recolectarInformacion()
        {
            if (acudiente==null)
            {
                MessageBox.Show("No se ha asignado un acudiente para el estudiante");
                txtidAcudiente.Focus();
                return null;
            }
            else if (curso == null)
            {
                MessageBox.Show("No se ha asignado un curso para el estudiante");
                txtCurso.Focus();
                return null;
            }
            else if (string.IsNullOrEmpty(txtIdentificacion.Text))
            {
                MessageBox.Show("El campo de identificacion no puede estar vacío");
                txtIdentificacion.Focus();
                return null;
            }
            else if (string.IsNullOrEmpty(txtPNombre.Text))
            {
                MessageBox.Show("El campo de Primer Nombre no puede estar vacío");
                txtPNombre.Focus();
                return null;
            }
            else if (string.IsNullOrEmpty(txtPapellido.Text))
            {
                MessageBox.Show("El campo de Primer Apellido no puede estar vacío");
                txtPapellido.Focus();
                return null;
            }
            else if (string.IsNullOrEmpty(txtSApellido.Text))
            {
                MessageBox.Show("El campo de Segundo Apellido no puede estar vacío");
                txtSApellido.Focus();
                return null;
            }
            else if (string.IsNullOrEmpty(txtCorreo.Text))
            {
                MessageBox.Show("El campo de Correo Electrónico no puede estar vacío");
                txtCorreo.Focus();
                return null;
            }
            else if (string.IsNullOrEmpty(txtDireccion.Text))
            {
                MessageBox.Show("El campo de Dirección no puede estar vacío");
                txtDireccion.Focus();
                return null;
            }
            else if (string.IsNullOrEmpty(txtTelefono.Text))
            {
                MessageBox.Show("El campo de Teléfono no puede estar vacío");
                txtTelefono.Focus();
                return null;
            }
            else if (string.IsNullOrEmpty(txtTelefono.Text))
            {
                MessageBox.Show("El campo de Teléfono no puede estar vacío");
                txtTelefono.Focus();
                return null;
            }
            else
            {
                DateTime fechaNacimiento = dtFecha.Value;
                int edad = DateTime.Now.Year - fechaNacimiento.Year;

                // Verifica si la persona aún no ha cumplido años este año
                if (DateTime.Now.Month < fechaNacimiento.Month ||
                    (DateTime.Now.Month == fechaNacimiento.Month && DateTime.Now.Day < fechaNacimiento.Day))
                {
                    edad--;
                }

                if (edad>9 && edad<17)
                    {
                    var aux = new Estudiante()
                    {
                        IdEstudiante= estudiante != null ? estudiante.IdEstudiante : 0,
                        Identificacion = txtIdentificacion.Text,
                        PrimerNombre = txtPNombre.Text,
                        SegundoNombre = txtSNombre.Text,
                        PrimerApellido = txtPapellido.Text,
                        SegundoApellido = txtSApellido.Text,
                        Email = txtCorreo.Text,
                        Telefono = txtTelefono.Text,
                        Direccion = txtDireccion.Text,
                        FechaNacimiento = dtFecha.Value,
                        Acudiente = acudiente != null ? acudiente : null,
                        Curso = curso != null ? curso : null,
                        Estado="ACTIVO"
                    };

                    return aux;
                }
                else
                {
                    MessageBox.Show("El estudiante debe tener una edad de entre 9 y 17 años");
                    dtFecha.Focus();
                    return null;
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            limpiarCampos();
        }

        private void limpiarCampos()
        {
            txtIdentificacion.Clear();
            txtPNombre.Clear();
            txtSNombre.Clear();
            txtPapellido.Clear();
            txtSApellido.Clear();
            txtCorreo.Clear();
            txtTelefono.Clear();
            txtDireccion.Clear();
            dtFecha.Value = DateTime.Now;
            lblEdad.Text = $"--";
            txtCurso.Clear();
            txtidAcudiente.Clear();
            lbNombreA.Text="Nombres: ";
            lblApellidosA.Text = "Apellidos: ";
        }

        private void ControlEstudiante_Load(object sender, EventArgs e)
        {
            cargarDgv();
        }

        private void cargarDgv()
        {
            DataTable table = EstudiantesService.ListaEstudiantes();

            if (table!=null)
            {
                dgvStudentList.Rows.Clear();
                dgvStudentList.DataSource = table;
                dgvStudentList.Refresh();
            }

            
        }
    }
}
