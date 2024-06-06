namespace Presentacion
{
    partial class GestionNotas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dvgNotas = new System.Windows.Forms.DataGridView();
            this.IdEstudiante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Curso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Materia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nota1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nota2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nota3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nota4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dvgNotas)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Fax", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(70, 107);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 16);
            this.label1.TabIndex = 39;
            this.label1.Text = "Curso :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Fax", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(70, 65);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 16);
            this.label3.TabIndex = 40;
            this.label3.Text = "Materia :";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(143, 102);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(144, 21);
            this.comboBox1.TabIndex = 71;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(143, 64);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(144, 21);
            this.comboBox2.TabIndex = 72;
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(143, 140);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(144, 21);
            this.comboBox3.TabIndex = 75;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Lucida Fax", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(70, 145);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 16);
            this.label5.TabIndex = 74;
            this.label5.Text = "Periodo:";
            // 
            // dvgNotas
            // 
            this.dvgNotas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dvgNotas.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dvgNotas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgNotas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdEstudiante,
            this.Curso,
            this.Materia,
            this.Nota1,
            this.Nota2,
            this.Nota3,
            this.Nota4,
            this.pp});
            this.dvgNotas.Location = new System.Drawing.Point(73, 200);
            this.dvgNotas.Margin = new System.Windows.Forms.Padding(2);
            this.dvgNotas.Name = "dvgNotas";
            this.dvgNotas.RowHeadersWidth = 62;
            this.dvgNotas.RowTemplate.Height = 28;
            this.dvgNotas.Size = new System.Drawing.Size(717, 370);
            this.dvgNotas.TabIndex = 78;
            // 
            // IdEstudiante
            // 
            this.IdEstudiante.HeaderText = "Id Estudiante";
            this.IdEstudiante.Name = "IdEstudiante";
            // 
            // Curso
            // 
            this.Curso.HeaderText = "Curso";
            this.Curso.Name = "Curso";
            // 
            // Materia
            // 
            this.Materia.HeaderText = "Materia";
            this.Materia.Name = "Materia";
            // 
            // Nota1
            // 
            this.Nota1.HeaderText = "Nota 1";
            this.Nota1.Name = "Nota1";
            // 
            // Nota2
            // 
            this.Nota2.HeaderText = "Nota 2";
            this.Nota2.Name = "Nota2";
            // 
            // Nota3
            // 
            this.Nota3.HeaderText = "Nota 3";
            this.Nota3.Name = "Nota3";
            // 
            // Nota4
            // 
            this.Nota4.HeaderText = "Nota 4";
            this.Nota4.Name = "Nota4";
            // 
            // pp
            // 
            this.pp.HeaderText = "Promedio Ponderado";
            this.pp.Name = "pp";
            // 
            // GestionNotas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(962, 600);
            this.Controls.Add(this.dvgNotas);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "GestionNotas";
            this.Text = "GestionNotas";
            ((System.ComponentModel.ISupportInitialize)(this.dvgNotas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dvgNotas;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdEstudiante;
        private System.Windows.Forms.DataGridViewTextBoxColumn Curso;
        private System.Windows.Forms.DataGridViewTextBoxColumn Materia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nota1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nota2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nota3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nota4;
        private System.Windows.Forms.DataGridViewTextBoxColumn pp;
    }
}