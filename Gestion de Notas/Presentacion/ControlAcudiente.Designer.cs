namespace Presentacion
{
    partial class ControlAcudiente
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
            this.label13 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSApellido = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnEliminarAcudiente = new System.Windows.Forms.Button();
            this.btnModificarAcudiente = new System.Windows.Forms.Button();
            this.btnBuscarAcudiente = new System.Windows.Forms.Button();
            this.btnRegistarAcudiente = new System.Windows.Forms.Button();
            this.dgvAcudientesList = new System.Windows.Forms.DataGridView();
            this.txtPapellido = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSNombre = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPNombre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtIdentificacion = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblValId = new System.Windows.Forms.Label();
            this.lblVal = new System.Windows.Forms.Label();
            this.lblValTel = new System.Windows.Forms.Label();
            this.lblEdad = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnBack = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAcudientesList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBack)).BeginInit();
            this.SuspendLayout();
            // 
            // dtFecha
            // 
            this.dtFecha.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtFecha.Font = new System.Drawing.Font("Lucida Fax", 10.20895F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFecha.Location = new System.Drawing.Point(606, 123);
            this.dtFecha.Margin = new System.Windows.Forms.Padding(2);
            this.dtFecha.MaxDate = new System.DateTime(2099, 12, 31, 0, 0, 0, 0);
            this.dtFecha.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dtFecha.Name = "dtFecha";
            this.dtFecha.Size = new System.Drawing.Size(201, 26);
            this.dtFecha.TabIndex = 10;
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Lucida Fax", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(21, 235);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(161, 18);
            this.label13.TabIndex = 140;
            this.label13.Text = "Listado Acudientes";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Lucida Fax", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(445, 129);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(162, 18);
            this.label9.TabIndex = 139;
            this.label9.Text = "Fecha Nacimiento :";
            // 
            // txtDireccion
            // 
            this.txtDireccion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtDireccion.Font = new System.Drawing.Font("Lucida Fax", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDireccion.Location = new System.Drawing.Point(606, 87);
            this.txtDireccion.Margin = new System.Windows.Forms.Padding(2);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(201, 25);
            this.txtDireccion.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Lucida Fax", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(445, 94);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(95, 18);
            this.label8.TabIndex = 137;
            this.label8.Text = "Dirección :";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTelefono.Font = new System.Drawing.Font("Lucida Fax", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefono.Location = new System.Drawing.Point(606, 52);
            this.txtTelefono.Margin = new System.Windows.Forms.Padding(2);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(201, 25);
            this.txtTelefono.TabIndex = 7;
            this.txtTelefono.TextChanged += new System.EventHandler(this.txtTelefono_TextChanged);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Fax", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(445, 59);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 18);
            this.label1.TabIndex = 135;
            this.label1.Text = "Teléfono :";
            // 
            // txtCorreo
            // 
            this.txtCorreo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCorreo.Font = new System.Drawing.Font("Lucida Fax", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCorreo.Location = new System.Drawing.Point(606, 20);
            this.txtCorreo.Margin = new System.Windows.Forms.Padding(2);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(201, 25);
            this.txtCorreo.TabIndex = 6;
            this.txtCorreo.TextChanged += new System.EventHandler(this.txtCorreo_TextChanged);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lucida Fax", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(445, 23);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(167, 18);
            this.label4.TabIndex = 133;
            this.label4.Text = "Correo Electrónico :";
            // 
            // txtSApellido
            // 
            this.txtSApellido.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtSApellido.Font = new System.Drawing.Font("Lucida Fax", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSApellido.Location = new System.Drawing.Point(174, 161);
            this.txtSApellido.Margin = new System.Windows.Forms.Padding(2);
            this.txtSApellido.Name = "txtSApellido";
            this.txtSApellido.Size = new System.Drawing.Size(201, 25);
            this.txtSApellido.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Lucida Fax", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(20, 164);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(161, 18);
            this.label7.TabIndex = 131;
            this.label7.Text = "Segundo Apellido :";
            // 
            // btnEliminarAcudiente
            // 
            this.btnEliminarAcudiente.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEliminarAcudiente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(48)))), ((int)(((byte)(24)))));
            this.btnEliminarAcudiente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminarAcudiente.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnEliminarAcudiente.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(48)))), ((int)(((byte)(24)))));
            this.btnEliminarAcudiente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(48)))), ((int)(((byte)(24)))));
            this.btnEliminarAcudiente.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEliminarAcudiente.Font = new System.Drawing.Font("Lucida Fax", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarAcudiente.Location = new System.Drawing.Point(814, 453);
            this.btnEliminarAcudiente.Margin = new System.Windows.Forms.Padding(2);
            this.btnEliminarAcudiente.Name = "btnEliminarAcudiente";
            this.btnEliminarAcudiente.Size = new System.Drawing.Size(115, 30);
            this.btnEliminarAcudiente.TabIndex = 130;
            this.btnEliminarAcudiente.Text = "Eliminar";
            this.btnEliminarAcudiente.UseVisualStyleBackColor = false;
            this.btnEliminarAcudiente.Click += new System.EventHandler(this.btnEliminarAcudiente_Click);
            // 
            // btnModificarAcudiente
            // 
            this.btnModificarAcudiente.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnModificarAcudiente.BackColor = System.Drawing.Color.Gold;
            this.btnModificarAcudiente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnModificarAcudiente.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnModificarAcudiente.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnModificarAcudiente.Font = new System.Drawing.Font("Lucida Fax", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarAcudiente.Location = new System.Drawing.Point(814, 408);
            this.btnModificarAcudiente.Margin = new System.Windows.Forms.Padding(2);
            this.btnModificarAcudiente.Name = "btnModificarAcudiente";
            this.btnModificarAcudiente.Size = new System.Drawing.Size(115, 30);
            this.btnModificarAcudiente.TabIndex = 129;
            this.btnModificarAcudiente.Text = "Modificar";
            this.btnModificarAcudiente.UseVisualStyleBackColor = false;
            this.btnModificarAcudiente.Click += new System.EventHandler(this.btnModificarAcudiente_Click);
            // 
            // btnBuscarAcudiente
            // 
            this.btnBuscarAcudiente.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnBuscarAcudiente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(178)))), ((int)(((byte)(255)))));
            this.btnBuscarAcudiente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscarAcudiente.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnBuscarAcudiente.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(178)))), ((int)(((byte)(255)))));
            this.btnBuscarAcudiente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(178)))), ((int)(((byte)(255)))));
            this.btnBuscarAcudiente.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBuscarAcudiente.Font = new System.Drawing.Font("Lucida Fax", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarAcudiente.Location = new System.Drawing.Point(814, 322);
            this.btnBuscarAcudiente.Margin = new System.Windows.Forms.Padding(2);
            this.btnBuscarAcudiente.Name = "btnBuscarAcudiente";
            this.btnBuscarAcudiente.Size = new System.Drawing.Size(115, 30);
            this.btnBuscarAcudiente.TabIndex = 128;
            this.btnBuscarAcudiente.Text = "Buscar";
            this.btnBuscarAcudiente.UseVisualStyleBackColor = false;
            this.btnBuscarAcudiente.Click += new System.EventHandler(this.btnBuscarAcudiente_Click);
            // 
            // btnRegistarAcudiente
            // 
            this.btnRegistarAcudiente.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnRegistarAcudiente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(254)))), ((int)(((byte)(21)))));
            this.btnRegistarAcudiente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegistarAcudiente.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnRegistarAcudiente.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(254)))), ((int)(((byte)(21)))));
            this.btnRegistarAcudiente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(254)))), ((int)(((byte)(21)))));
            this.btnRegistarAcudiente.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRegistarAcudiente.Font = new System.Drawing.Font("Lucida Fax", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistarAcudiente.Location = new System.Drawing.Point(814, 365);
            this.btnRegistarAcudiente.Margin = new System.Windows.Forms.Padding(2);
            this.btnRegistarAcudiente.Name = "btnRegistarAcudiente";
            this.btnRegistarAcudiente.Size = new System.Drawing.Size(115, 30);
            this.btnRegistarAcudiente.TabIndex = 127;
            this.btnRegistarAcudiente.Text = "Registrar";
            this.btnRegistarAcudiente.UseVisualStyleBackColor = false;
            this.btnRegistarAcudiente.Click += new System.EventHandler(this.btnRegistarAcudiente_Click);
            // 
            // dgvAcudientesList
            // 
            this.dgvAcudientesList.AllowUserToAddRows = false;
            this.dgvAcudientesList.AllowUserToDeleteRows = false;
            this.dgvAcudientesList.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvAcudientesList.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvAcudientesList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAcudientesList.Location = new System.Drawing.Point(23, 265);
            this.dgvAcudientesList.Margin = new System.Windows.Forms.Padding(2);
            this.dgvAcudientesList.Name = "dgvAcudientesList";
            this.dgvAcudientesList.ReadOnly = true;
            this.dgvAcudientesList.RowHeadersWidth = 62;
            this.dgvAcudientesList.RowTemplate.Height = 28;
            this.dgvAcudientesList.Size = new System.Drawing.Size(784, 257);
            this.dgvAcudientesList.TabIndex = 126;
            // 
            // txtPapellido
            // 
            this.txtPapellido.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPapellido.Font = new System.Drawing.Font("Lucida Fax", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPapellido.Location = new System.Drawing.Point(174, 126);
            this.txtPapellido.Margin = new System.Windows.Forms.Padding(2);
            this.txtPapellido.Name = "txtPapellido";
            this.txtPapellido.Size = new System.Drawing.Size(201, 25);
            this.txtPapellido.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Lucida Fax", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(20, 129);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(143, 18);
            this.label5.TabIndex = 124;
            this.label5.Text = "Primer Apellido :";
            // 
            // txtSNombre
            // 
            this.txtSNombre.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtSNombre.Font = new System.Drawing.Font("Lucida Fax", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSNombre.Location = new System.Drawing.Point(174, 91);
            this.txtSNombre.Margin = new System.Windows.Forms.Padding(2);
            this.txtSNombre.Name = "txtSNombre";
            this.txtSNombre.Size = new System.Drawing.Size(201, 25);
            this.txtSNombre.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Lucida Fax", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(20, 94);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(163, 18);
            this.label6.TabIndex = 122;
            this.label6.Text = "Segundo Nombre : ";
            // 
            // txtPNombre
            // 
            this.txtPNombre.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPNombre.Font = new System.Drawing.Font("Lucida Fax", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPNombre.Location = new System.Drawing.Point(174, 56);
            this.txtPNombre.Margin = new System.Windows.Forms.Padding(2);
            this.txtPNombre.Name = "txtPNombre";
            this.txtPNombre.Size = new System.Drawing.Size(201, 25);
            this.txtPNombre.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Fax", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(20, 59);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 18);
            this.label3.TabIndex = 120;
            this.label3.Text = "Primer Nombre :";
            // 
            // txtIdentificacion
            // 
            this.txtIdentificacion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtIdentificacion.Font = new System.Drawing.Font("Lucida Fax", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdentificacion.Location = new System.Drawing.Point(174, 23);
            this.txtIdentificacion.Margin = new System.Windows.Forms.Padding(2);
            this.txtIdentificacion.Name = "txtIdentificacion";
            this.txtIdentificacion.Size = new System.Drawing.Size(201, 25);
            this.txtIdentificacion.TabIndex = 1;
            this.txtIdentificacion.TextChanged += new System.EventHandler(this.txtIdentificacion_TextChanged);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Fax", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 27);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 18);
            this.label2.TabIndex = 118;
            this.label2.Text = "Identificación :";
            // 
            // lblValId
            // 
            this.lblValId.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblValId.AutoSize = true;
            this.lblValId.Font = new System.Drawing.Font("Lucida Fax", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValId.ForeColor = System.Drawing.Color.Red;
            this.lblValId.Location = new System.Drawing.Point(379, 27);
            this.lblValId.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblValId.Name = "lblValId";
            this.lblValId.Size = new System.Drawing.Size(75, 18);
            this.lblValId.TabIndex = 156;
            this.lblValId.Text = "Invalido";
            this.lblValId.Visible = false;
            // 
            // lblVal
            // 
            this.lblVal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblVal.AutoSize = true;
            this.lblVal.Font = new System.Drawing.Font("Lucida Fax", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVal.ForeColor = System.Drawing.Color.Red;
            this.lblVal.Location = new System.Drawing.Point(811, 23);
            this.lblVal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblVal.Name = "lblVal";
            this.lblVal.Size = new System.Drawing.Size(75, 18);
            this.lblVal.TabIndex = 157;
            this.lblVal.Text = "Invalido";
            this.lblVal.Visible = false;
            // 
            // lblValTel
            // 
            this.lblValTel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblValTel.AutoSize = true;
            this.lblValTel.Font = new System.Drawing.Font("Lucida Fax", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValTel.ForeColor = System.Drawing.Color.Red;
            this.lblValTel.Location = new System.Drawing.Point(811, 55);
            this.lblValTel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblValTel.Name = "lblValTel";
            this.lblValTel.Size = new System.Drawing.Size(75, 18);
            this.lblValTel.TabIndex = 158;
            this.lblValTel.Text = "Invalido";
            this.lblValTel.Visible = false;
            // 
            // lblEdad
            // 
            this.lblEdad.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblEdad.AutoSize = true;
            this.lblEdad.Font = new System.Drawing.Font("Lucida Fax", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEdad.Location = new System.Drawing.Point(445, 168);
            this.lblEdad.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEdad.Name = "lblEdad";
            this.lblEdad.Size = new System.Drawing.Size(20, 18);
            this.lblEdad.TabIndex = 159;
            this.lblEdad.Text = "--";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = global::Presentacion.Properties.Resources.clean;
            this.pictureBox1.Location = new System.Drawing.Point(771, 168);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(36, 33);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 160;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btnBack
            // 
            this.btnBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.Image = global::Presentacion.Properties.Resources.logout;
            this.btnBack.Location = new System.Drawing.Point(871, 12);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(49, 50);
            this.btnBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnBack.TabIndex = 142;
            this.btnBack.TabStop = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // ControlAcudiente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(940, 534);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblEdad);
            this.Controls.Add(this.lblValTel);
            this.Controls.Add(this.lblVal);
            this.Controls.Add(this.lblValId);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.dtFecha);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCorreo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtSApellido);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnEliminarAcudiente);
            this.Controls.Add(this.btnModificarAcudiente);
            this.Controls.Add(this.btnBuscarAcudiente);
            this.Controls.Add(this.btnRegistarAcudiente);
            this.Controls.Add(this.dgvAcudientesList);
            this.Controls.Add(this.txtPapellido);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtSNombre);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtPNombre);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtIdentificacion);
            this.Controls.Add(this.label2);
            this.Name = "ControlAcudiente";
            this.Text = "RegistrarAcudiente";
            this.Load += new System.EventHandler(this.ControlAcudiente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAcudientesList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBack)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox btnBack;
        private System.Windows.Forms.DateTimePicker dtFecha;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSApellido;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnEliminarAcudiente;
        private System.Windows.Forms.Button btnModificarAcudiente;
        private System.Windows.Forms.Button btnBuscarAcudiente;
        private System.Windows.Forms.Button btnRegistarAcudiente;
        private System.Windows.Forms.DataGridView dgvAcudientesList;
        private System.Windows.Forms.TextBox txtPapellido;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSNombre;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPNombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtIdentificacion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblValId;
        private System.Windows.Forms.Label lblVal;
        private System.Windows.Forms.Label lblValTel;
        private System.Windows.Forms.Label lblEdad;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}