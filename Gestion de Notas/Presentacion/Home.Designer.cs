namespace Presentacion
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.opcion1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.estudiantesTSM = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarAcudienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarEstudianteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.docentesTSM = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.asignarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.personalTSM = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionAcademicaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionDeNotasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.estadisticasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cursosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.crearCursosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.periodosAcademicosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fatherPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.fatherPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(178)))), ((int)(((byte)(255)))));
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 11.78182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(22, 22);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.opcion1ToolStripMenuItem,
            this.gestionDeNotasToolStripMenuItem,
            this.cursosToolStripMenuItem,
            this.periodosAcademicosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1332, 29);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // opcion1ToolStripMenuItem
            // 
            this.opcion1ToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.opcion1ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.estudiantesTSM,
            this.docentesTSM,
            this.personalTSM,
            this.gestionAcademicaToolStripMenuItem});
            this.opcion1ToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.opcion1ToolStripMenuItem.Name = "opcion1ToolStripMenuItem";
            this.opcion1ToolStripMenuItem.Size = new System.Drawing.Size(80, 25);
            this.opcion1ToolStripMenuItem.Text = "Registro";
            // 
            // estudiantesTSM
            // 
            this.estudiantesTSM.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrarAcudienteToolStripMenuItem,
            this.registrarEstudianteToolStripMenuItem});
            this.estudiantesTSM.Name = "estudiantesTSM";
            this.estudiantesTSM.Size = new System.Drawing.Size(245, 26);
            this.estudiantesTSM.Text = "Matricula";
            this.estudiantesTSM.Click += new System.EventHandler(this.estudiantesTSM_Click);
            // 
            // registrarAcudienteToolStripMenuItem
            // 
            this.registrarAcudienteToolStripMenuItem.Name = "registrarAcudienteToolStripMenuItem";
            this.registrarAcudienteToolStripMenuItem.Size = new System.Drawing.Size(219, 26);
            this.registrarAcudienteToolStripMenuItem.Text = "Registrar Acudiente";
            this.registrarAcudienteToolStripMenuItem.ToolTipText = "Registra la informacion del acudiente al hacer la matricula";
            this.registrarAcudienteToolStripMenuItem.Click += new System.EventHandler(this.registrarAcudienteToolStripMenuItem_Click);
            // 
            // registrarEstudianteToolStripMenuItem
            // 
            this.registrarEstudianteToolStripMenuItem.Name = "registrarEstudianteToolStripMenuItem";
            this.registrarEstudianteToolStripMenuItem.Size = new System.Drawing.Size(219, 26);
            this.registrarEstudianteToolStripMenuItem.Text = "Registrar Estudiante";
            this.registrarEstudianteToolStripMenuItem.Click += new System.EventHandler(this.registrarEstudianteToolStripMenuItem_Click);
            // 
            // docentesTSM
            // 
            this.docentesTSM.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrarToolStripMenuItem,
            this.asignarToolStripMenuItem});
            this.docentesTSM.Name = "docentesTSM";
            this.docentesTSM.Size = new System.Drawing.Size(245, 26);
            this.docentesTSM.Text = "Docentes";
            this.docentesTSM.Click += new System.EventHandler(this.docentesTSM_Click);
            // 
            // registrarToolStripMenuItem
            // 
            this.registrarToolStripMenuItem.Name = "registrarToolStripMenuItem";
            this.registrarToolStripMenuItem.Size = new System.Drawing.Size(143, 26);
            this.registrarToolStripMenuItem.Text = "Registrar";
            this.registrarToolStripMenuItem.Click += new System.EventHandler(this.registrarToolStripMenuItem_Click_1);
            // 
            // asignarToolStripMenuItem
            // 
            this.asignarToolStripMenuItem.Name = "asignarToolStripMenuItem";
            this.asignarToolStripMenuItem.Size = new System.Drawing.Size(143, 26);
            this.asignarToolStripMenuItem.Text = "Asignar";
            this.asignarToolStripMenuItem.Click += new System.EventHandler(this.asignarToolStripMenuItem_Click_1);
            // 
            // personalTSM
            // 
            this.personalTSM.Name = "personalTSM";
            this.personalTSM.Size = new System.Drawing.Size(245, 26);
            this.personalTSM.Text = "Personal Administrativo";
            this.personalTSM.Click += new System.EventHandler(this.personalTSM_Click);
            // 
            // gestionAcademicaToolStripMenuItem
            // 
            this.gestionAcademicaToolStripMenuItem.Name = "gestionAcademicaToolStripMenuItem";
            this.gestionAcademicaToolStripMenuItem.Size = new System.Drawing.Size(245, 26);
            this.gestionAcademicaToolStripMenuItem.Text = "Gestion Academica";
            this.gestionAcademicaToolStripMenuItem.Click += new System.EventHandler(this.gestionAcademicaToolStripMenuItem_Click);
            // 
            // gestionDeNotasToolStripMenuItem
            // 
            this.gestionDeNotasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestionarToolStripMenuItem,
            this.consultarToolStripMenuItem,
            this.estadisticasToolStripMenuItem});
            this.gestionDeNotasToolStripMenuItem.Name = "gestionDeNotasToolStripMenuItem";
            this.gestionDeNotasToolStripMenuItem.Size = new System.Drawing.Size(141, 25);
            this.gestionDeNotasToolStripMenuItem.Text = "Gestion de Notas";
            // 
            // gestionarToolStripMenuItem
            // 
            this.gestionarToolStripMenuItem.Name = "gestionarToolStripMenuItem";
            this.gestionarToolStripMenuItem.Size = new System.Drawing.Size(180, 26);
            this.gestionarToolStripMenuItem.Text = "Gestionar";
            this.gestionarToolStripMenuItem.Click += new System.EventHandler(this.gestionarToolStripMenuItem_Click);
            // 
            // consultarToolStripMenuItem
            // 
            this.consultarToolStripMenuItem.Name = "consultarToolStripMenuItem";
            this.consultarToolStripMenuItem.Size = new System.Drawing.Size(180, 26);
            this.consultarToolStripMenuItem.Text = "Consultar";
            // 
            // estadisticasToolStripMenuItem
            // 
            this.estadisticasToolStripMenuItem.Name = "estadisticasToolStripMenuItem";
            this.estadisticasToolStripMenuItem.Size = new System.Drawing.Size(180, 26);
            this.estadisticasToolStripMenuItem.Text = "Estadisticas";
            // 
            // cursosToolStripMenuItem
            // 
            this.cursosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.crearCursosToolStripMenuItem});
            this.cursosToolStripMenuItem.Name = "cursosToolStripMenuItem";
            this.cursosToolStripMenuItem.Size = new System.Drawing.Size(72, 25);
            this.cursosToolStripMenuItem.Text = "Grados";
            // 
            // crearCursosToolStripMenuItem
            // 
            this.crearCursosToolStripMenuItem.Name = "crearCursosToolStripMenuItem";
            this.crearCursosToolStripMenuItem.Size = new System.Drawing.Size(322, 26);
            this.crearCursosToolStripMenuItem.Text = "Crear Cursos y Asignar Estudiantes";
            this.crearCursosToolStripMenuItem.Click += new System.EventHandler(this.crearCursosToolStripMenuItem_Click);
            // 
            // periodosAcademicosToolStripMenuItem
            // 
            this.periodosAcademicosToolStripMenuItem.Name = "periodosAcademicosToolStripMenuItem";
            this.periodosAcademicosToolStripMenuItem.Size = new System.Drawing.Size(169, 25);
            this.periodosAcademicosToolStripMenuItem.Text = "Periodos Academicos";
            this.periodosAcademicosToolStripMenuItem.Click += new System.EventHandler(this.periodosAcademicosToolStripMenuItem_Click);
            // 
            // fatherPanel
            // 
            this.fatherPanel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.fatherPanel.BackgroundImage = global::Presentacion.Properties.Resources.Logo;
            this.fatherPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.fatherPanel.Controls.Add(this.label1);
            this.fatherPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fatherPanel.Location = new System.Drawing.Point(0, 29);
            this.fatherPanel.Margin = new System.Windows.Forms.Padding(2);
            this.fatherPanel.Name = "fatherPanel";
            this.fatherPanel.Size = new System.Drawing.Size(1332, 727);
            this.fatherPanel.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 47.78181F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.label1.Location = new System.Drawing.Point(5, 614);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1159, 65);
            this.label1.TabIndex = 0;
            this.label1.Text = "Intelligent Score Management for Institutes";
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1332, 756);
            this.Controls.Add(this.fatherPanel);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(976, 636);
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Intelligent Score Management for Institutes - ISMI";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.fatherPanel.ResumeLayout(false);
            this.fatherPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem opcion1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem estudiantesTSM;
        private System.Windows.Forms.Panel fatherPanel;
        private System.Windows.Forms.ToolStripMenuItem docentesTSM;
        private System.Windows.Forms.ToolStripMenuItem personalTSM;
        private System.Windows.Forms.ToolStripMenuItem gestionDeNotasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem estadisticasToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem cursosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem crearCursosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarAcudienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarEstudianteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem asignarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem periodosAcademicosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionAcademicaToolStripMenuItem;
    }
}