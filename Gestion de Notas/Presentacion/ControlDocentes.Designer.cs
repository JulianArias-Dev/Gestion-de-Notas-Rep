namespace Presentacion
{
    partial class ControlDocentes
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
            this.dgvDocentes = new System.Windows.Forms.DataGridView();
            this.label13 = new System.Windows.Forms.Label();
            this.CBcargo = new System.Windows.Forms.ComboBox();
            this.dtFecha = new System.Windows.Forms.DateTimePicker();
            this.label12 = new System.Windows.Forms.Label();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSApellido = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtPApellido = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSNombre = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPNombres = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtIdentificacion = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnEliminarCliente = new System.Windows.Forms.Button();
            this.btnModificarCliente = new System.Windows.Forms.Button();
            this.btnBuscarCliente = new System.Windows.Forms.Button();
            this.btnRegistarCliente = new System.Windows.Forms.Button();
            this.lblValTel = new System.Windows.Forms.Label();
            this.lblVal = new System.Windows.Forms.Label();
            this.lblValId = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.PictureBox();
            this.lblEdad = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDocentes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBack)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDocentes
            // 
            this.dgvDocentes.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvDocentes.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvDocentes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDocentes.Location = new System.Drawing.Point(35, 291);
            this.dgvDocentes.Margin = new System.Windows.Forms.Padding(2);
            this.dgvDocentes.Name = "dgvDocentes";
            this.dgvDocentes.RowHeadersWidth = 62;
            this.dgvDocentes.RowTemplate.Height = 28;
            this.dgvDocentes.Size = new System.Drawing.Size(756, 233);
            this.dgvDocentes.TabIndex = 45;
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Lucida Fax", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(32, 259);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(129, 16);
            this.label13.TabIndex = 65;
            this.label13.Text = "Listado Docentes";
            // 
            // CBcargo
            // 
            this.CBcargo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CBcargo.Font = new System.Drawing.Font("Lucida Fax", 10.20895F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBcargo.FormattingEnabled = true;
            this.CBcargo.Location = new System.Drawing.Point(655, 217);
            this.CBcargo.Margin = new System.Windows.Forms.Padding(2);
            this.CBcargo.Name = "CBcargo";
            this.CBcargo.Size = new System.Drawing.Size(201, 24);
            this.CBcargo.TabIndex = 115;
            // 
            // dtFecha
            // 
            this.dtFecha.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtFecha.Font = new System.Drawing.Font("Lucida Fax", 10.20895F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFecha.Location = new System.Drawing.Point(655, 112);
            this.dtFecha.Margin = new System.Windows.Forms.Padding(2);
            this.dtFecha.MaxDate = new System.DateTime(2099, 12, 31, 0, 0, 0, 0);
            this.dtFecha.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dtFecha.Name = "dtFecha";
            this.dtFecha.Size = new System.Drawing.Size(201, 24);
            this.dtFecha.TabIndex = 114;
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Lucida Fax", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(514, 220);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(56, 16);
            this.label12.TabIndex = 113;
            this.label12.Text = "Cargo :";
            // 
            // txtContraseña
            // 
            this.txtContraseña.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtContraseña.Font = new System.Drawing.Font("Lucida Fax", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContraseña.Location = new System.Drawing.Point(655, 182);
            this.txtContraseña.Margin = new System.Windows.Forms.Padding(2);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.Size = new System.Drawing.Size(201, 23);
            this.txtContraseña.TabIndex = 112;
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Lucida Fax", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(514, 185);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(95, 16);
            this.label11.TabIndex = 111;
            this.label11.Text = "Contraseña :";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtUsuario.Font = new System.Drawing.Font("Lucida Fax", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.Location = new System.Drawing.Point(655, 147);
            this.txtUsuario.Margin = new System.Windows.Forms.Padding(2);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(201, 23);
            this.txtUsuario.TabIndex = 110;
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Lucida Fax", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(514, 150);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(69, 16);
            this.label10.TabIndex = 109;
            this.label10.Text = "Usuario :";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Lucida Fax", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(514, 115);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(143, 16);
            this.label9.TabIndex = 108;
            this.label9.Text = "Fecha Nacimiento :";
            // 
            // txtDireccion
            // 
            this.txtDireccion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtDireccion.Font = new System.Drawing.Font("Lucida Fax", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDireccion.Location = new System.Drawing.Point(655, 77);
            this.txtDireccion.Margin = new System.Windows.Forms.Padding(2);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(201, 23);
            this.txtDireccion.TabIndex = 107;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Lucida Fax", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(514, 80);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 16);
            this.label8.TabIndex = 106;
            this.label8.Text = "Dirección :";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTelefono.Font = new System.Drawing.Font("Lucida Fax", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefono.Location = new System.Drawing.Point(655, 42);
            this.txtTelefono.Margin = new System.Windows.Forms.Padding(2);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(201, 23);
            this.txtTelefono.TabIndex = 105;
            this.txtTelefono.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Fax", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(514, 45);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 16);
            this.label1.TabIndex = 104;
            this.label1.Text = "Teléfono :";
            // 
            // txtCorreo
            // 
            this.txtCorreo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCorreo.Font = new System.Drawing.Font("Lucida Fax", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCorreo.Location = new System.Drawing.Point(229, 217);
            this.txtCorreo.Margin = new System.Windows.Forms.Padding(2);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(201, 23);
            this.txtCorreo.TabIndex = 103;
            this.txtCorreo.TextChanged += new System.EventHandler(this.txtCorreo_TextChanged);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lucida Fax", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(58, 224);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(148, 16);
            this.label4.TabIndex = 102;
            this.label4.Text = "Correo Electrónico :";
            // 
            // txtSApellido
            // 
            this.txtSApellido.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtSApellido.Font = new System.Drawing.Font("Lucida Fax", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSApellido.Location = new System.Drawing.Point(229, 182);
            this.txtSApellido.Margin = new System.Windows.Forms.Padding(2);
            this.txtSApellido.Name = "txtSApellido";
            this.txtSApellido.Size = new System.Drawing.Size(201, 23);
            this.txtSApellido.TabIndex = 101;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Lucida Fax", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(58, 189);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(139, 16);
            this.label7.TabIndex = 100;
            this.label7.Text = "Segundo Apellido :";
            // 
            // txtPApellido
            // 
            this.txtPApellido.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPApellido.Font = new System.Drawing.Font("Lucida Fax", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPApellido.Location = new System.Drawing.Point(229, 147);
            this.txtPApellido.Margin = new System.Windows.Forms.Padding(2);
            this.txtPApellido.Name = "txtPApellido";
            this.txtPApellido.Size = new System.Drawing.Size(201, 23);
            this.txtPApellido.TabIndex = 99;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Lucida Fax", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(58, 154);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 16);
            this.label5.TabIndex = 98;
            this.label5.Text = "Primer Apellido :";
            // 
            // txtSNombre
            // 
            this.txtSNombre.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtSNombre.Font = new System.Drawing.Font("Lucida Fax", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSNombre.Location = new System.Drawing.Point(229, 112);
            this.txtSNombre.Margin = new System.Windows.Forms.Padding(2);
            this.txtSNombre.Name = "txtSNombre";
            this.txtSNombre.Size = new System.Drawing.Size(201, 23);
            this.txtSNombre.TabIndex = 97;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Lucida Fax", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(58, 119);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(140, 16);
            this.label6.TabIndex = 96;
            this.label6.Text = "Segundo Nombre : ";
            // 
            // txtPNombres
            // 
            this.txtPNombres.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPNombres.Font = new System.Drawing.Font("Lucida Fax", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPNombres.Location = new System.Drawing.Point(229, 77);
            this.txtPNombres.Margin = new System.Windows.Forms.Padding(2);
            this.txtPNombres.Name = "txtPNombres";
            this.txtPNombres.Size = new System.Drawing.Size(201, 23);
            this.txtPNombres.TabIndex = 95;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Fax", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(58, 84);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 16);
            this.label3.TabIndex = 94;
            this.label3.Text = "Primer Nombre :";
            // 
            // txtIdentificacion
            // 
            this.txtIdentificacion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtIdentificacion.Font = new System.Drawing.Font("Lucida Fax", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdentificacion.Location = new System.Drawing.Point(229, 42);
            this.txtIdentificacion.Margin = new System.Windows.Forms.Padding(2);
            this.txtIdentificacion.Name = "txtIdentificacion";
            this.txtIdentificacion.Size = new System.Drawing.Size(201, 23);
            this.txtIdentificacion.TabIndex = 93;
            this.txtIdentificacion.TextChanged += new System.EventHandler(this.txtIdentificacion_TextChanged);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Fax", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(58, 49);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 16);
            this.label2.TabIndex = 92;
            this.label2.Text = "Identificación :";
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
            this.btnEliminarCliente.Location = new System.Drawing.Point(816, 461);
            this.btnEliminarCliente.Margin = new System.Windows.Forms.Padding(2);
            this.btnEliminarCliente.Name = "btnEliminarCliente";
            this.btnEliminarCliente.Size = new System.Drawing.Size(115, 30);
            this.btnEliminarCliente.TabIndex = 120;
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
            this.btnModificarCliente.Location = new System.Drawing.Point(816, 416);
            this.btnModificarCliente.Margin = new System.Windows.Forms.Padding(2);
            this.btnModificarCliente.Name = "btnModificarCliente";
            this.btnModificarCliente.Size = new System.Drawing.Size(115, 30);
            this.btnModificarCliente.TabIndex = 119;
            this.btnModificarCliente.Text = "Modificar";
            this.btnModificarCliente.UseVisualStyleBackColor = false;
            // 
            // btnBuscarCliente
            // 
            this.btnBuscarCliente.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnBuscarCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(178)))), ((int)(((byte)(255)))));
            this.btnBuscarCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscarCliente.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnBuscarCliente.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(178)))), ((int)(((byte)(255)))));
            this.btnBuscarCliente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(178)))), ((int)(((byte)(255)))));
            this.btnBuscarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBuscarCliente.Font = new System.Drawing.Font("Lucida Fax", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarCliente.Location = new System.Drawing.Point(816, 330);
            this.btnBuscarCliente.Margin = new System.Windows.Forms.Padding(2);
            this.btnBuscarCliente.Name = "btnBuscarCliente";
            this.btnBuscarCliente.Size = new System.Drawing.Size(115, 30);
            this.btnBuscarCliente.TabIndex = 118;
            this.btnBuscarCliente.Text = "Buscar";
            this.btnBuscarCliente.UseVisualStyleBackColor = false;
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
            this.btnRegistarCliente.Location = new System.Drawing.Point(816, 373);
            this.btnRegistarCliente.Margin = new System.Windows.Forms.Padding(2);
            this.btnRegistarCliente.Name = "btnRegistarCliente";
            this.btnRegistarCliente.Size = new System.Drawing.Size(115, 30);
            this.btnRegistarCliente.TabIndex = 117;
            this.btnRegistarCliente.Text = "Registrar";
            this.btnRegistarCliente.UseVisualStyleBackColor = false;
            this.btnRegistarCliente.Click += new System.EventHandler(this.btnRegistarCliente_Click);
            // 
            // lblValTel
            // 
            this.lblValTel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblValTel.AutoSize = true;
            this.lblValTel.Font = new System.Drawing.Font("Lucida Fax", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValTel.ForeColor = System.Drawing.Color.Red;
            this.lblValTel.Location = new System.Drawing.Point(860, 45);
            this.lblValTel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblValTel.Name = "lblValTel";
            this.lblValTel.Size = new System.Drawing.Size(65, 16);
            this.lblValTel.TabIndex = 152;
            this.lblValTel.Text = "Invalido";
            this.lblValTel.Visible = false;
            // 
            // lblVal
            // 
            this.lblVal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblVal.AutoSize = true;
            this.lblVal.Font = new System.Drawing.Font("Lucida Fax", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVal.ForeColor = System.Drawing.Color.Red;
            this.lblVal.Location = new System.Drawing.Point(434, 220);
            this.lblVal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblVal.Name = "lblVal";
            this.lblVal.Size = new System.Drawing.Size(65, 16);
            this.lblVal.TabIndex = 153;
            this.lblVal.Text = "Invalido";
            this.lblVal.Visible = false;
            // 
            // lblValId
            // 
            this.lblValId.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblValId.AutoSize = true;
            this.lblValId.Font = new System.Drawing.Font("Lucida Fax", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValId.ForeColor = System.Drawing.Color.Red;
            this.lblValId.Location = new System.Drawing.Point(434, 45);
            this.lblValId.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblValId.Name = "lblValId";
            this.lblValId.Size = new System.Drawing.Size(65, 16);
            this.lblValId.TabIndex = 154;
            this.lblValId.Text = "Invalido";
            this.lblValId.Visible = false;
            // 
            // btnBack
            // 
            this.btnBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.Image = global::Presentacion.Properties.Resources.logout;
            this.btnBack.Location = new System.Drawing.Point(900, 15);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(49, 50);
            this.btnBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnBack.TabIndex = 116;
            this.btnBack.TabStop = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblEdad
            // 
            this.lblEdad.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblEdad.AutoSize = true;
            this.lblEdad.Font = new System.Drawing.Font("Lucida Fax", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEdad.Location = new System.Drawing.Point(514, 259);
            this.lblEdad.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEdad.Name = "lblEdad";
            this.lblEdad.Size = new System.Drawing.Size(17, 16);
            this.lblEdad.TabIndex = 160;
            this.lblEdad.Text = "--";
            // 
            // ControlDocentes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(960, 534);
            this.Controls.Add(this.lblEdad);
            this.Controls.Add(this.lblValId);
            this.Controls.Add(this.lblVal);
            this.Controls.Add(this.lblValTel);
            this.Controls.Add(this.btnEliminarCliente);
            this.Controls.Add(this.btnModificarCliente);
            this.Controls.Add(this.btnBuscarCliente);
            this.Controls.Add(this.btnRegistarCliente);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.CBcargo);
            this.Controls.Add(this.dtFecha);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtContraseña);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCorreo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtSApellido);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtPApellido);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtSNombre);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtPNombres);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtIdentificacion);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.dgvDocentes);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(976, 573);
            this.Name = "ControlDocentes";
            this.Text = "ControlDocentes";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDocentes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBack)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvDocentes;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox CBcargo;
        private System.Windows.Forms.DateTimePicker dtFecha;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtContraseña;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSApellido;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtPApellido;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSNombre;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPNombres;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtIdentificacion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox btnBack;
        private System.Windows.Forms.Button btnEliminarCliente;
        private System.Windows.Forms.Button btnModificarCliente;
        private System.Windows.Forms.Button btnBuscarCliente;
        private System.Windows.Forms.Button btnRegistarCliente;
        private System.Windows.Forms.Label lblValTel;
        private System.Windows.Forms.Label lblVal;
        private System.Windows.Forms.Label lblValId;
        private System.Windows.Forms.Label lblEdad;
    }
}