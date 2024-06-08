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

namespace Presentacion
{
    public partial class ControlAcudiente : Form
    {
        public ControlAcudiente()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        private void btnRegistarAcudiente_Click(object sender, EventArgs e)
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

        private void txtTelefono_TextChanged(object sender, EventArgs e)
        {
            lblValTel.Visible = Validaciones.valTelefono(txtTelefono.Text) ? false : true;
        }
    }
}
