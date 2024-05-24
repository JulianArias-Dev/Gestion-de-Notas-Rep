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
    public partial class FormLogin : Form
    {
        private bool propertyhide = false;
        public FormLogin()
        {
            InitializeComponent();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnShowHide_Click(object sender, EventArgs e)
        {
            
            if (propertyhide)
            {
                // La imagen actual del botón es la misma que la imagen "hide" de los recursos
                txtConstraseña.UseSystemPasswordChar = false;
                btnShowHide.BackgroundImage = Properties.Resources.hide;
                propertyhide=false;
            }
            else
            {
                // La imagen actual del botón es diferente de la imagen "hide" de los recursos
                txtConstraseña.UseSystemPasswordChar = true;
                btnShowHide.BackgroundImage = Properties.Resources.view;
                propertyhide = true;
            }
        }

        private void txtConstraseña_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtConstraseña.Text))
            {
                txtConstraseña.Text = "Contraseña";
                txtConstraseña.UseSystemPasswordChar = false;
                propertyhide = true;
                btnShowHide.BackgroundImage = null;
            }
        }

        private void txtConstraseña_Enter(object sender, EventArgs e)
        {
            if (txtConstraseña.Text == "Contraseña")
            {
                txtConstraseña.Clear();
                txtConstraseña.UseSystemPasswordChar = true;
                propertyhide=true;
                btnShowHide.BackgroundImage = Properties.Resources.view;
            }
        }

        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtUsuario.Text))
            {
                txtUsuario.Text = "Usuario";
            }
        }

        private void txtUsuario_Enter(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "Usuario")
            {
                txtUsuario.Clear();
            }
        }
    }
}
