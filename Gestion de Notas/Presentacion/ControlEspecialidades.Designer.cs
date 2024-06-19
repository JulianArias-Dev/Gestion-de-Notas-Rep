namespace Presentacion
{
    partial class FormControlEspecialidades
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
            this.btnBack = new System.Windows.Forms.PictureBox();
            this.gboxEspecialidad = new System.Windows.Forms.GroupBox();
            this.LimpiarEspecialidad = new System.Windows.Forms.PictureBox();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.txtNombreEspecialidad = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.listEspecialidades = new System.Windows.Forms.ListBox();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.btnBack)).BeginInit();
            this.gboxEspecialidad.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LimpiarEspecialidad)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.Image = global::Presentacion.Properties.Resources.logout;
            this.btnBack.Location = new System.Drawing.Point(901, 12);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(49, 50);
            this.btnBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnBack.TabIndex = 119;
            this.btnBack.TabStop = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // gboxEspecialidad
            // 
            this.gboxEspecialidad.Controls.Add(this.LimpiarEspecialidad);
            this.gboxEspecialidad.Controls.Add(this.btnModificar);
            this.gboxEspecialidad.Controls.Add(this.btnEliminar);
            this.gboxEspecialidad.Controls.Add(this.btnRegistrar);
            this.gboxEspecialidad.Controls.Add(this.txtNombreEspecialidad);
            this.gboxEspecialidad.Controls.Add(this.label1);
            this.gboxEspecialidad.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gboxEspecialidad.Location = new System.Drawing.Point(48, 121);
            this.gboxEspecialidad.Name = "gboxEspecialidad";
            this.gboxEspecialidad.Size = new System.Drawing.Size(624, 244);
            this.gboxEspecialidad.TabIndex = 120;
            this.gboxEspecialidad.TabStop = false;
            this.gboxEspecialidad.Text = "Especialidad";
            // 
            // LimpiarEspecialidad
            // 
            this.LimpiarEspecialidad.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LimpiarEspecialidad.Image = global::Presentacion.Properties.Resources.clean;
            this.LimpiarEspecialidad.Location = new System.Drawing.Point(368, 174);
            this.LimpiarEspecialidad.Name = "LimpiarEspecialidad";
            this.LimpiarEspecialidad.Size = new System.Drawing.Size(36, 33);
            this.LimpiarEspecialidad.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.LimpiarEspecialidad.TabIndex = 161;
            this.LimpiarEspecialidad.TabStop = false;
            this.LimpiarEspecialidad.Click += new System.EventHandler(this.LimpiarEspecialidad_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.Gold;
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnModificar.Location = new System.Drawing.Point(478, 116);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(93, 31);
            this.btnModificar.TabIndex = 7;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.Red;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEliminar.Location = new System.Drawing.Point(478, 174);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(93, 31);
            this.btnEliminar.TabIndex = 4;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.BackColor = System.Drawing.Color.Lime;
            this.btnRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRegistrar.Location = new System.Drawing.Point(478, 56);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(93, 34);
            this.btnRegistrar.TabIndex = 2;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = false;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // txtNombreEspecialidad
            // 
            this.txtNombreEspecialidad.Font = new System.Drawing.Font("Lucida Fax", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreEspecialidad.Location = new System.Drawing.Point(39, 136);
            this.txtNombreEspecialidad.Name = "txtNombreEspecialidad";
            this.txtNombreEspecialidad.Size = new System.Drawing.Size(365, 25);
            this.txtNombreEspecialidad.TabIndex = 1;
            this.txtNombreEspecialidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombreEspecialidad_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Fax", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(36, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(368, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Por favor, ingrese el nombre de la especialidad:";
            // 
            // listEspecialidades
            // 
            this.listEspecialidades.BackColor = System.Drawing.SystemColors.Window;
            this.listEspecialidades.Font = new System.Drawing.Font("Lucida Fax", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listEspecialidades.ForeColor = System.Drawing.SystemColors.WindowText;
            this.listEspecialidades.FormattingEnabled = true;
            this.listEspecialidades.ItemHeight = 17;
            this.listEspecialidades.Location = new System.Drawing.Point(728, 128);
            this.listEspecialidades.Name = "listEspecialidades";
            this.listEspecialidades.Size = new System.Drawing.Size(200, 242);
            this.listEspecialidades.TabIndex = 121;
            this.listEspecialidades.SelectedIndexChanged += new System.EventHandler(this.listEspecialidades_SelectedIndexChanged);
            // 
            // txtBuscar
            // 
            this.txtBuscar.Font = new System.Drawing.Font("Lucida Fax", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscar.Location = new System.Drawing.Point(728, 386);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(200, 25);
            this.txtBuscar.TabIndex = 122;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Fax", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(290, 391);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(425, 17);
            this.label2.TabIndex = 162;
            this.label2.Text = "Escriba el nombre de la especialidad que desea buscar:";
            // 
            // FormControlEspecialidades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(962, 541);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.listEspecialidades);
            this.Controls.Add(this.gboxEspecialidad);
            this.Controls.Add(this.btnBack);
            this.MinimumSize = new System.Drawing.Size(978, 580);
            this.Name = "FormControlEspecialidades";
            this.Text = "Control Especialidades";
            this.Load += new System.EventHandler(this.FormControlEspecialidades_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnBack)).EndInit();
            this.gboxEspecialidad.ResumeLayout(false);
            this.gboxEspecialidad.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LimpiarEspecialidad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox btnBack;
        private System.Windows.Forms.GroupBox gboxEspecialidad;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.TextBox txtNombreEspecialidad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.ListBox listEspecialidades;
        private System.Windows.Forms.PictureBox LimpiarEspecialidad;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Label label2;
    }
}