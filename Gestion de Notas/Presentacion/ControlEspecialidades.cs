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
    public partial class FormControlEspecialidades : Form
    {
        private EspecialidadService especialidadService = new EspecialidadService();
        public FormControlEspecialidades()
        {
            InitializeComponent();
            CargarEspecialidades();
            txtBuscar.TextChanged += txtBuscar_TextChanged;
        }

        private void CargarEspecialidades()
        {
            try
            {
                List<Especialidad> especialidades = especialidadService.ObtenerTodasEspecialidades();
                listEspecialidades.DataSource = especialidades;
                listEspecialidades.DisplayMember = "Nombre";
                listEspecialidades.ValueMember = "IdEspecialidad";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar las especialidades: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            string nombreEspecialidad = txtNombreEspecialidad.Text.Trim();

            if (string.IsNullOrEmpty(nombreEspecialidad))
            {
                MessageBox.Show("Por favor, ingrese un nombre de especialidad.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string resultado = EspecialidadService.InsertarEspecialidad(nombreEspecialidad);

            MessageBox.Show(resultado, "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            CargarEspecialidades();
            txtNombreEspecialidad.Clear();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (listEspecialidades.SelectedItem == null)
            {
                MessageBox.Show("Por favor, seleccione una especialidad para eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Especialidad especialidadSeleccionada = (Especialidad)listEspecialidades.SelectedItem;
            string resultado = EspecialidadService.EliminarEspecialidad(especialidadSeleccionada.IdEspecialidad);

            MessageBox.Show(resultado, "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            CargarEspecialidades();
            txtNombreEspecialidad.Text = "";
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (listEspecialidades.SelectedItem == null)
            {
                MessageBox.Show("Por favor, seleccione una especialidad para modificar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Especialidad especialidadSeleccionada = (Especialidad)listEspecialidades.SelectedItem;
            string nuevoNombre = txtNombreEspecialidad.Text.Trim();

            if (string.IsNullOrEmpty(nuevoNombre))
            {
                MessageBox.Show("Por favor, ingrese un nuevo nombre de especialidad.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string resultado = EspecialidadService.ModificarEspecialidad(especialidadSeleccionada.IdEspecialidad, nuevoNombre);

            MessageBox.Show(resultado, "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            CargarEspecialidades();
            txtNombreEspecialidad.Clear();
        }

        private void listEspecialidades_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listEspecialidades.SelectedItem != null)
            {
                Especialidad especialidadSeleccionada = (Especialidad)listEspecialidades.SelectedItem;
                txtNombreEspecialidad.Text = especialidadSeleccionada.Nombre;
            }
        }

        private void LimpiarEspecialidad_Click(object sender, EventArgs e)
        {
            txtNombreEspecialidad.Text = "";
        }

        private void FormControlEspecialidades_Load(object sender, EventArgs e)
        {
            listEspecialidades.ClearSelected();
            txtNombreEspecialidad.Text = "";
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            string filtro = txtBuscar.Text.ToLower();

            if (string.IsNullOrWhiteSpace(filtro))
            {
                CargarEspecialidades();
                listEspecialidades.ClearSelected();
                txtNombreEspecialidad.Text = "";
            }
            else
            {
                List<Especialidad> especialidadesFiltradas = new List<Especialidad>();
                foreach (Especialidad especialidad in listEspecialidades.Items)
                {
                    if (especialidad.Nombre.ToLower().Contains(filtro))
                    {
                        especialidadesFiltradas.Add(especialidad);
                    }
                }

                listEspecialidades.DataSource = especialidadesFiltradas;
                listEspecialidades.DisplayMember = "Nombre";
                listEspecialidades.ValueMember = "IdEspecialidad";
            }
        }

        private void txtNombreEspecialidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != (char)Keys.Back && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
