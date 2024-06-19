using System;
using System.Data;
using System.Windows.Forms;
using BLL;
using Entity;

namespace Presentacion
{
    public partial class ControlAcudiente : Form
    {
        private Acudiente Acudiente;

        public ControlAcudiente()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtIdentificacion_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtIdentificacion.Text)) 
            {
                lblValId.Visible=false; return; 
            }
            lblValId.Visible = Validaciones.ValIdentificacion(txtIdentificacion.Text) ? false : true;
        }

        private void txtCorreo_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCorreo.Text)) 
            {
                lblVal.Visible = false; return;
            }
            lblVal.Visible = Validaciones.ValCorreo(txtCorreo.Text) ? false : true;
        }

        private void txtTelefono_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTelefono.Text)) 
            {
                lblValTel.Visible = false; return;
            }  
            lblValTel.Visible = Validaciones.valTelefono(txtTelefono.Text) ? false : true;
        }

        private void btnRegistarAcudiente_Click(object sender, EventArgs e)
        {
            Acudiente  = recolectarInformacion();

            if (Acudiente==null) return;

            DialogResult result = MessageBox.Show($"¿Estás seguro de registrar estos datos? \n{Acudiente.showAcudiente()}", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                var mss = AcudientesService.InsertarAcudiente(Acudiente);
                MessageBox.Show(mss);
                if (!mss.Contains("Error"))
                {
                    limpiarCampos();
                    cargarDvg();
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

            Acudiente = auxiliar;

            DialogResult result = MessageBox.Show($"¿Estás seguro de actualizar con estos datos? \n{Acudiente.showAcudiente()}", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                var mss = AcudientesService.ModificarAcudiente(Acudiente);
                MessageBox.Show(mss);
                if (!mss.Contains("Error"))
                {
                    limpiarCampos();
                    cargarDvg();
                }
            }
            else if (result == DialogResult.No)
            {
                MessageBox.Show("De acuerdo, se ha cancelado la operación");
            }
        }

        private void btnBuscarAcudiente_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtIdentificacion.Text))
            {
                MessageBox.Show("El campo de identificacion no puede estar vacío");
                txtIdentificacion.Focus();
                return;
            }

            var aux = new Acudiente()
            {
                identificacion=txtIdentificacion.Text
            };

            Acudiente = AcudientesService.BuscarAcudiente(aux);

            if (Acudiente==null)
            {
                MessageBox.Show("No se ha encontrado un Acudiente con esa identificación");
                return;
            }

            txtIdentificacion.Text = Acudiente.identificacion;
            txtPNombre.Text = Acudiente.primerNombre;
            txtSNombre.Text = Acudiente.segundoNombre;
            txtPapellido.Text = Acudiente.primerApellido;
            txtSApellido.Text = Acudiente.segundoApellido;
            txtCorreo.Text = Acudiente.email;
            txtTelefono.Text = Acudiente.telefono;
            txtDireccion.Text = Acudiente.direccion;
            dtFecha.Value = Acudiente.fechaNacimiento;
            lblEdad.Text = $"Edad: {Acudiente.Edad}";
        }

        private void btnEliminarAcudiente_Click(object sender, EventArgs e)
        {
            if (Acudiente==null)
            {
                MessageBox.Show("No hay acudiente para eliminar");
                return;
            } 

            DialogResult result = MessageBox.Show($"¿Estás seguro de Eliminar este acudiente? \n{Acudiente.showAcudiente()}", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                var mss = AcudientesService.EliminarAcudiente(Acudiente);
                MessageBox.Show(mss);
                if (!mss.Contains("Error"))
                {
                    limpiarCampos();
                    cargarDvg();
                }
            }
            else if (result == DialogResult.No)
            {
                MessageBox.Show("De acuerdo, se ha cancelado la operación");
            }
        }

        private Acudiente recolectarInformacion()
        {
            if (string.IsNullOrEmpty(txtIdentificacion.Text))
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

                if (DateTime.Now.Year - fechaNacimiento.Year > 18 ||
                    (DateTime.Now.Year - fechaNacimiento.Year == 18 &&
                     DateTime.Now.Month > fechaNacimiento.Month) ||
                    (DateTime.Now.Year - fechaNacimiento.Year == 18 &&
                     DateTime.Now.Month == fechaNacimiento.Month &&
                     DateTime.Now.Day >= fechaNacimiento.Day))
                {
                    var aux = new Acudiente()
                    {
                        idAcudiente = Acudiente != null ? Acudiente.idAcudiente : 0,
                        identificacion = txtIdentificacion.Text,
                        primerNombre = txtPNombre.Text,
                        segundoNombre = txtSNombre.Text,
                        primerApellido = txtPapellido.Text,
                        segundoApellido = txtSApellido.Text,
                        email = txtCorreo.Text,
                        telefono = txtTelefono.Text,
                        direccion = txtDireccion.Text,
                        fechaNacimiento = dtFecha.Value
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

        private void  limpiarCampos()
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
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            limpiarCampos();
        }

        private void ControlAcudiente_Load(object sender, EventArgs e)
        {
            cargarDvg();
        }

        private void cargarDvg()
        {
            DataTable table = AcudientesService.ListaAcudientes();

            if (table!=null)
            {
                dgvAcudientesList.Rows.Clear();
                dgvAcudientesList.DataSource = table;
                dgvAcudientesList.Refresh();
            }
        }
    }
}
