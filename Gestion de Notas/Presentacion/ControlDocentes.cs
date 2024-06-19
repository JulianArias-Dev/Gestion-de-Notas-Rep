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
    public partial class ControlDocentes : Form
    {
        public ControlDocentes()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRegistarCliente_Click(object sender, EventArgs e)
        {

        }

        private void txtIdentificacion_TextChanged(object sender, EventArgs e)
        {
            lblValId.Visible = Validaciones.ValIdentificacion(txtIdentificacion.Text) ? false : true;
        }

        private void txtCorreo_TextChanged(object sender, EventArgs e)
        {
            lblVal.Visible = Validaciones.ValCorreo(txtCorreo.Text) ? false : true;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            lblValTel.Visible = Validaciones.valTelefono(txtPApellido.Text) ? false : true;
        }

        private Docente recolectarInformacion()
        {
            if (string.IsNullOrEmpty(txtIdentificacion.Text))
            {
                MessageBox.Show("El campo de identificacion no puede estar vacío");
                txtIdentificacion.Focus();
                return null;
            }
            else if (string.IsNullOrEmpty(txtPNombres.Text))
            {
                MessageBox.Show("El campo de Primer Nombre no puede estar vacío");
                txtPNombres.Focus();
                return null;
            }
            else if (string.IsNullOrEmpty(txtPApellido.Text))
            {
                MessageBox.Show("El campo de Primer Apellido no puede estar vacío");
                txtPApellido.Focus();
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

                if (DateTime.Now.Year - fechaNacimiento.Year > 18 ||
                    (DateTime.Now.Year - fechaNacimiento.Year == 18 &&
                     DateTime.Now.Month > fechaNacimiento.Month) ||
                    (DateTime.Now.Year - fechaNacimiento.Year == 18 &&
                     DateTime.Now.Month == fechaNacimiento.Month &&
                     DateTime.Now.Day >= fechaNacimiento.Day))
                {
                    var aux = new Docente()
                    {
                        IdDocente = Docente != null ? Docente.IdDocente : 0,
                        Identificacion = txtIdentificacion.Text,
                        PrimerNombre = txtPNombres.Text,
                        SegundoNombre = txtSNombre.Text,
                        PrimerApellido = txtPApellido.Text,
                        SegundoApellido = txtSApellido.Text,
                        email = txtCorreo.Text,
                        Telefono = txtTelefono.Text,
                        Direccion = txtDireccion.Text,
                        FechaNacimiento = dtFecha.Value,
                        Usuario = Convert.ToInt32(txtUsuario.Text)
                    };


                    return aux;

                }                                 
                else
                {
                    MessageBox.Show("El acudiente debe ser mayor de edad");
                    dtFecha.Focus();
                    return null;
                }
            }
        }

        private void limpiarCampos()
        {
            txtIdentificacion.Clear();
            txtPNombres.Clear();
            txtSNombre.Clear();
            txtPApellido.Clear();
            txtSApellido.Clear();
            txtCorreo.Clear();
            txtTelefono.Clear();
            txtDireccion.Clear();
            dtFecha.Value = DateTime.Now;
            lblEdad.Text = $"--";
        }


        private void ControlDocentes_Load(object sender, EventArgs e)
        {
            DataTable table = DocentesService.ListaDocentes();

            if (table != null)
            {
                dgvDocentes.DataSource = table;
            }
        }
    }
}


