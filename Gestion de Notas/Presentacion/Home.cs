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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        //Child Form
        private Form acive = null;

        private void openChildForm(Form child)
        {
            if (acive!=null)
                acive.Close();
            acive = child;
            child.TopLevel = false;
            child.FormBorderStyle = FormBorderStyle.None;
            child.Dock = DockStyle.Fill;
            fatherPanel.Controls.Add(child);
            fatherPanel.Tag =child;
            fatherPanel.BorderStyle = BorderStyle.Fixed3D;
            fatherPanel.BorderStyle = BorderStyle.Fixed3D;
            child.BringToFront();
            child.Show();
        }

        private void docentesTSM_Click(object sender, EventArgs e)
        {
            var children = new ControlDocentes();
            openChildForm(children);
        }

        private void estudiantesTSM_Click(object sender, EventArgs e)
        {
            var children = new ControlEstudiante();
            openChildForm(children);
        }

        private void personalTSM_Click(object sender, EventArgs e)
        {
            var children = new ControlAdministrativos();
            openChildForm(children);
        }

        private void materiasTSM_Click(object sender, EventArgs e)
        {
            var children = new AsignacionMaterias();
            openChildForm(children);
        }

        private void especialidadesTSM_Click(object sender, EventArgs e)
        {
            var children = new AsignacionEspecialidades();
            openChildForm(children);
        }

        private void crearCursosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var children = new ControlCursos();
            openChildForm(children);
        }

        private void asignarMateriasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var children = new ControlMateriasA();
            openChildForm(children);
        }
    }
}
