using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class GestionNotas : Form
    {
        public GestionNotas()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string estudiante, Curso, Materia,Periodo;
            double Nota1 = 0,Nota2 = 0,Nota3 = 0,Nota4 = 0, pp;
            estudiante = txtIdentificacion.Text;
            Curso = comboBox1.Text;
            Materia = comboBox2.Text;
            Periodo = comboBox3.Text;

            Nota1 = Convert.ToDouble(textBox1.Text);
            Nota2 = Convert.ToDouble(textBox2.Text);
            Nota3 = Convert.ToDouble(textBox3.Text);
            Nota4 = Convert.ToDouble(textBox4.Text);

            pp = (Nota1 + Nota2 + Nota3 + Nota4)/ 4;

            dvgNotas.Rows.Add(estudiante,Curso,Materia,Nota1,Nota2,Nota3,Nota4,pp);
            
        }

        
    }
}
