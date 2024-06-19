namespace Presentacion
{
    partial class PeriodosAcademicos
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
            this.dtFecha = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.dateTimePicker3 = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvAcudientesList = new System.Windows.Forms.DataGridView();
            this.txtNombres = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.btnEliminarCliente = new System.Windows.Forms.Button();
            this.btnModificarCliente = new System.Windows.Forms.Button();
            this.btnRegistarCliente = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAcudientesList)).BeginInit();
            this.SuspendLayout();
            // 
            // dtFecha
            // 
            this.dtFecha.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtFecha.Font = new System.Drawing.Font("Lucida Fax", 10.20895F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFecha.Location = new System.Drawing.Point(185, 129);
            this.dtFecha.Margin = new System.Windows.Forms.Padding(2);
            this.dtFecha.MaxDate = new System.DateTime(2099, 12, 31, 0, 0, 0, 0);
            this.dtFecha.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dtFecha.Name = "dtFecha";
            this.dtFecha.Size = new System.Drawing.Size(201, 24);
            this.dtFecha.TabIndex = 140;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Lucida Fax", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(54, 135);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(114, 16);
            this.label9.TabIndex = 141;
            this.label9.Text = "Inicio Periodo :";
            // 
            // dateTimePicker3
            // 
            this.dateTimePicker3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dateTimePicker3.Font = new System.Drawing.Font("Lucida Fax", 10.20895F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker3.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker3.Location = new System.Drawing.Point(558, 129);
            this.dateTimePicker3.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePicker3.MaxDate = new System.DateTime(2099, 12, 31, 0, 0, 0, 0);
            this.dateTimePicker3.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker3.Name = "dateTimePicker3";
            this.dateTimePicker3.Size = new System.Drawing.Size(201, 24);
            this.dateTimePicker3.TabIndex = 146;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Fax", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(427, 135);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 16);
            this.label3.TabIndex = 147;
            this.label3.Text = "Final Periodo :";
            // 
            // dgvAcudientesList
            // 
            this.dgvAcudientesList.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvAcudientesList.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvAcudientesList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAcudientesList.Location = new System.Drawing.Point(57, 266);
            this.dgvAcudientesList.Margin = new System.Windows.Forms.Padding(2);
            this.dgvAcudientesList.Name = "dgvAcudientesList";
            this.dgvAcudientesList.RowHeadersWidth = 62;
            this.dgvAcudientesList.RowTemplate.Height = 28;
            this.dgvAcudientesList.Size = new System.Drawing.Size(702, 257);
            this.dgvAcudientesList.TabIndex = 190;
            // 
            // txtNombres
            // 
            this.txtNombres.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNombres.Font = new System.Drawing.Font("Lucida Fax", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombres.Location = new System.Drawing.Point(185, 89);
            this.txtNombres.Margin = new System.Windows.Forms.Padding(2);
            this.txtNombres.Name = "txtNombres";
            this.txtNombres.Size = new System.Drawing.Size(201, 23);
            this.txtNombres.TabIndex = 194;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Lucida Fax", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(54, 96);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(130, 16);
            this.label6.TabIndex = 193;
            this.label6.Text = "Nombre Periodo :";
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Lucida Fax", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(54, 248);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(132, 16);
            this.label13.TabIndex = 195;
            this.label13.Text = "Listado Periodos :";
            // 
            // btnEliminarCliente
            // 
            this.btnEliminarCliente.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEliminarCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(48)))), ((int)(((byte)(24)))));
            this.btnEliminarCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminarCliente.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnEliminarCliente.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(48)))), ((int)(((byte)(24)))));
            this.btnEliminarCliente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(48)))), ((int)(((byte)(24)))));
            this.btnEliminarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEliminarCliente.Font = new System.Drawing.Font("Lucida Fax", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarCliente.Location = new System.Drawing.Point(763, 410);
            this.btnEliminarCliente.Margin = new System.Windows.Forms.Padding(2);
            this.btnEliminarCliente.Name = "btnEliminarCliente";
            this.btnEliminarCliente.Size = new System.Drawing.Size(115, 30);
            this.btnEliminarCliente.TabIndex = 199;
            this.btnEliminarCliente.Text = "Eliminar";
            this.btnEliminarCliente.UseVisualStyleBackColor = false;
            // 
            // btnModificarCliente
            // 
            this.btnModificarCliente.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnModificarCliente.BackColor = System.Drawing.Color.Gold;
            this.btnModificarCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnModificarCliente.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnModificarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnModificarCliente.Font = new System.Drawing.Font("Lucida Fax", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarCliente.Location = new System.Drawing.Point(763, 365);
            this.btnModificarCliente.Margin = new System.Windows.Forms.Padding(2);
            this.btnModificarCliente.Name = "btnModificarCliente";
            this.btnModificarCliente.Size = new System.Drawing.Size(115, 30);
            this.btnModificarCliente.TabIndex = 198;
            this.btnModificarCliente.Text = "Modificar";
            this.btnModificarCliente.UseVisualStyleBackColor = false;
            // 
            // btnRegistarCliente
            // 
            this.btnRegistarCliente.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnRegistarCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(254)))), ((int)(((byte)(21)))));
            this.btnRegistarCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegistarCliente.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnRegistarCliente.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(254)))), ((int)(((byte)(21)))));
            this.btnRegistarCliente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(254)))), ((int)(((byte)(21)))));
            this.btnRegistarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRegistarCliente.Font = new System.Drawing.Font("Lucida Fax", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistarCliente.Location = new System.Drawing.Point(763, 322);
            this.btnRegistarCliente.Margin = new System.Windows.Forms.Padding(2);
            this.btnRegistarCliente.Name = "btnRegistarCliente";
            this.btnRegistarCliente.Size = new System.Drawing.Size(115, 30);
            this.btnRegistarCliente.TabIndex = 196;
            this.btnRegistarCliente.Text = "Registrar";
            this.btnRegistarCliente.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Fax", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(427, 96);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 16);
            this.label1.TabIndex = 200;
            this.label1.Text = "Año Periodo:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dateTimePicker1.Font = new System.Drawing.Font("Lucida Fax", 10.20895F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(558, 90);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePicker1.MaxDate = new System.DateTime(2099, 12, 31, 0, 0, 0, 0);
            this.dateTimePicker1.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(201, 24);
            this.dateTimePicker1.TabIndex = 201;
            // 
            // PeriodosAcademicos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(960, 534);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnEliminarCliente);
            this.Controls.Add(this.btnModificarCliente);
            this.Controls.Add(this.btnRegistarCliente);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtNombres);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dgvAcudientesList);
            this.Controls.Add(this.dateTimePicker3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtFecha);
            this.Controls.Add(this.label9);
            this.Name = "PeriodosAcademicos";
            this.Text = "PeriodosAcademicos";
            this.Load += new System.EventHandler(this.PeriodosAcademicos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAcudientesList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtFecha;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dateTimePicker3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvAcudientesList;
        private System.Windows.Forms.TextBox txtNombres;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnEliminarCliente;
        private System.Windows.Forms.Button btnModificarCliente;
        private System.Windows.Forms.Button btnRegistarCliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}