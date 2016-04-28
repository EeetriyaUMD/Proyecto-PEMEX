namespace ProyectoServicio
{
    partial class InicioEjecucion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InicioEjecucion));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.realizacionReporte = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.general = new System.Windows.Forms.RadioButton();
            this.individual = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.encuestas = new System.Windows.Forms.RadioButton();
            this.casos = new System.Windows.Forms.RadioButton();
            this.evidencias = new System.Windows.Forms.RadioButton();
            this.cursos = new System.Windows.Forms.RadioButton();
            this.evaluacion = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.hora1 = new System.Windows.Forms.DateTimePicker();
            this.hora2 = new System.Windows.Forms.DateTimePicker();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivo = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoUsuario = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarUsuario = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarSesionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configuracion = new System.Windows.Forms.ToolStripMenuItem();
            this.editarImpresionDeEvaluacionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.impresionDeCursosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.impresionDeEvidenciasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.impresionDeCasosDeEstudioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.impresionDeEncuestasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.baseDeDatosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(258, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(289, 31);
            this.label1.TabIndex = 9;
            this.label1.Text = "Opciones de Reporte";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(47, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 25);
            this.label2.TabIndex = 10;
            this.label2.Text = "Reporte";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(296, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(166, 25);
            this.label3.TabIndex = 11;
            this.label3.Text = "Tipo de Reporte";
            // 
            // realizacionReporte
            // 
            this.realizacionReporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.realizacionReporte.Location = new System.Drawing.Point(166, 411);
            this.realizacionReporte.Name = "realizacionReporte";
            this.realizacionReporte.Size = new System.Drawing.Size(228, 32);
            this.realizacionReporte.TabIndex = 15;
            this.realizacionReporte.Text = "Realización de Reporte";
            this.realizacionReporte.UseVisualStyleBackColor = true;
            this.realizacionReporte.Click += new System.EventHandler(this.realizacionReporte_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSize = true;
            this.groupBox1.Controls.Add(this.general);
            this.groupBox1.Controls.Add(this.individual);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(52, 180);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(216, 112);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            // 
            // general
            // 
            this.general.AutoSize = true;
            this.general.Checked = true;
            this.general.Location = new System.Drawing.Point(6, 18);
            this.general.Name = "general";
            this.general.Size = new System.Drawing.Size(106, 29);
            this.general.TabIndex = 1;
            this.general.TabStop = true;
            this.general.Text = "General";
            this.general.UseVisualStyleBackColor = true;
            // 
            // individual
            // 
            this.individual.AutoSize = true;
            this.individual.Location = new System.Drawing.Point(6, 53);
            this.individual.Name = "individual";
            this.individual.Size = new System.Drawing.Size(121, 29);
            this.individual.TabIndex = 0;
            this.individual.Text = "Individual";
            this.individual.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.AutoSize = true;
            this.groupBox2.Controls.Add(this.encuestas);
            this.groupBox2.Controls.Add(this.casos);
            this.groupBox2.Controls.Add(this.evidencias);
            this.groupBox2.Controls.Add(this.cursos);
            this.groupBox2.Controls.Add(this.evaluacion);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(290, 179);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(211, 218);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            // 
            // encuestas
            // 
            this.encuestas.AutoSize = true;
            this.encuestas.Location = new System.Drawing.Point(6, 159);
            this.encuestas.Name = "encuestas";
            this.encuestas.Size = new System.Drawing.Size(131, 29);
            this.encuestas.TabIndex = 4;
            this.encuestas.Text = "Encuestas";
            this.encuestas.UseVisualStyleBackColor = true;
            // 
            // casos
            // 
            this.casos.AutoSize = true;
            this.casos.Location = new System.Drawing.Point(6, 124);
            this.casos.Name = "casos";
            this.casos.Size = new System.Drawing.Size(199, 29);
            this.casos.TabIndex = 3;
            this.casos.Text = "Casos de Estudio";
            this.casos.UseVisualStyleBackColor = true;
            // 
            // evidencias
            // 
            this.evidencias.AutoSize = true;
            this.evidencias.Location = new System.Drawing.Point(6, 89);
            this.evidencias.Name = "evidencias";
            this.evidencias.Size = new System.Drawing.Size(135, 29);
            this.evidencias.TabIndex = 2;
            this.evidencias.Text = "Evidencias";
            this.evidencias.UseVisualStyleBackColor = true;
            // 
            // cursos
            // 
            this.cursos.AutoSize = true;
            this.cursos.Location = new System.Drawing.Point(6, 54);
            this.cursos.Name = "cursos";
            this.cursos.Size = new System.Drawing.Size(98, 29);
            this.cursos.TabIndex = 1;
            this.cursos.Text = "Cursos";
            this.cursos.UseVisualStyleBackColor = true;
            // 
            // evaluacion
            // 
            this.evaluacion.AutoSize = true;
            this.evaluacion.Checked = true;
            this.evaluacion.Location = new System.Drawing.Point(6, 19);
            this.evaluacion.Name = "evaluacion";
            this.evaluacion.Size = new System.Drawing.Size(147, 29);
            this.evaluacion.TabIndex = 0;
            this.evaluacion.TabStop = true;
            this.evaluacion.Text = "Evaluciones";
            this.evaluacion.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(342, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 18);
            this.label4.TabIndex = 19;
            this.label4.Text = "Usuario";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.Location = new System.Drawing.Point(408, 96);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(85, 18);
            this.label.TabIndex = 20;
            this.label.Text = "Sin Usuario";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(47, 302);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 25);
            this.label5.TabIndex = 22;
            this.label5.Text = "Periodo";
            // 
            // hora1
            // 
            this.hora1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.hora1.Location = new System.Drawing.Point(52, 338);
            this.hora1.Name = "hora1";
            this.hora1.Size = new System.Drawing.Size(127, 20);
            this.hora1.TabIndex = 23;
            // 
            // hora2
            // 
            this.hora2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.hora2.Location = new System.Drawing.Point(52, 364);
            this.hora2.Name = "hora2";
            this.hora2.Size = new System.Drawing.Size(127, 20);
            this.hora2.TabIndex = 24;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Menu;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivo,
            this.configuracion,
            this.ayudaToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(548, 24);
            this.menuStrip1.TabIndex = 26;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivo
            // 
            this.archivo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoUsuario,
            this.eliminarUsuario,
            this.cerrarSesionToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.archivo.Name = "archivo";
            this.archivo.Size = new System.Drawing.Size(60, 20);
            this.archivo.Text = "Archivo";
            // 
            // nuevoUsuario
            // 
            this.nuevoUsuario.Name = "nuevoUsuario";
            this.nuevoUsuario.Size = new System.Drawing.Size(160, 22);
            this.nuevoUsuario.Text = "Nuevo Usuario";
            this.nuevoUsuario.Click += new System.EventHandler(this.nuevoUsuario_Click);
            // 
            // eliminarUsuario
            // 
            this.eliminarUsuario.Name = "eliminarUsuario";
            this.eliminarUsuario.Size = new System.Drawing.Size(160, 22);
            this.eliminarUsuario.Text = "Eliminar Usuario";
            this.eliminarUsuario.Click += new System.EventHandler(this.eliminarUsuario_Click);
            // 
            // cerrarSesionToolStripMenuItem
            // 
            this.cerrarSesionToolStripMenuItem.Name = "cerrarSesionToolStripMenuItem";
            this.cerrarSesionToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.cerrarSesionToolStripMenuItem.Text = "Cerrar Sesion";
            this.cerrarSesionToolStripMenuItem.Click += new System.EventHandler(this.cerrarSesionToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // configuracion
            // 
            this.configuracion.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editarImpresionDeEvaluacionesToolStripMenuItem,
            this.impresionDeCursosToolStripMenuItem,
            this.impresionDeEvidenciasToolStripMenuItem,
            this.impresionDeCasosDeEstudioToolStripMenuItem,
            this.impresionDeEncuestasToolStripMenuItem,
            this.baseDeDatosToolStripMenuItem});
            this.configuracion.Name = "configuracion";
            this.configuracion.Size = new System.Drawing.Size(95, 20);
            this.configuracion.Text = "Configuracion";
            // 
            // editarImpresionDeEvaluacionesToolStripMenuItem
            // 
            this.editarImpresionDeEvaluacionesToolStripMenuItem.Name = "editarImpresionDeEvaluacionesToolStripMenuItem";
            this.editarImpresionDeEvaluacionesToolStripMenuItem.Size = new System.Drawing.Size(235, 22);
            this.editarImpresionDeEvaluacionesToolStripMenuItem.Text = "Impresion de Evaluaciones";
            this.editarImpresionDeEvaluacionesToolStripMenuItem.Click += new System.EventHandler(this.editarImpresionDeEvaluacionesToolStripMenuItem_Click);
            // 
            // impresionDeCursosToolStripMenuItem
            // 
            this.impresionDeCursosToolStripMenuItem.Name = "impresionDeCursosToolStripMenuItem";
            this.impresionDeCursosToolStripMenuItem.Size = new System.Drawing.Size(235, 22);
            this.impresionDeCursosToolStripMenuItem.Text = "Impresion de  Cursos";
            this.impresionDeCursosToolStripMenuItem.Click += new System.EventHandler(this.impresionDeCursosToolStripMenuItem_Click);
            // 
            // impresionDeEvidenciasToolStripMenuItem
            // 
            this.impresionDeEvidenciasToolStripMenuItem.Name = "impresionDeEvidenciasToolStripMenuItem";
            this.impresionDeEvidenciasToolStripMenuItem.Size = new System.Drawing.Size(235, 22);
            this.impresionDeEvidenciasToolStripMenuItem.Text = "Impresion de Evidencias";
            this.impresionDeEvidenciasToolStripMenuItem.Click += new System.EventHandler(this.impresionDeEvidenciasToolStripMenuItem_Click);
            // 
            // impresionDeCasosDeEstudioToolStripMenuItem
            // 
            this.impresionDeCasosDeEstudioToolStripMenuItem.Name = "impresionDeCasosDeEstudioToolStripMenuItem";
            this.impresionDeCasosDeEstudioToolStripMenuItem.Size = new System.Drawing.Size(235, 22);
            this.impresionDeCasosDeEstudioToolStripMenuItem.Text = "Impresion de Casos de Estudio";
            this.impresionDeCasosDeEstudioToolStripMenuItem.Click += new System.EventHandler(this.impresionDeCasosDeEstudioToolStripMenuItem_Click);
            // 
            // impresionDeEncuestasToolStripMenuItem
            // 
            this.impresionDeEncuestasToolStripMenuItem.Name = "impresionDeEncuestasToolStripMenuItem";
            this.impresionDeEncuestasToolStripMenuItem.Size = new System.Drawing.Size(235, 22);
            this.impresionDeEncuestasToolStripMenuItem.Text = "Impresion de Encuestas";
            this.impresionDeEncuestasToolStripMenuItem.Click += new System.EventHandler(this.impresionDeEncuestasToolStripMenuItem_Click);
            // 
            // baseDeDatosToolStripMenuItem
            // 
            this.baseDeDatosToolStripMenuItem.Name = "baseDeDatosToolStripMenuItem";
            this.baseDeDatosToolStripMenuItem.Size = new System.Drawing.Size(235, 22);
            this.baseDeDatosToolStripMenuItem.Text = "Base de Datos";
            this.baseDeDatosToolStripMenuItem.Click += new System.EventHandler(this.baseDeDatosToolStripMenuItem_Click);
            // 
            // ayudaToolStripMenuItem1
            // 
            this.ayudaToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ayudaToolStripMenuItem2});
            this.ayudaToolStripMenuItem1.Name = "ayudaToolStripMenuItem1";
            this.ayudaToolStripMenuItem1.Size = new System.Drawing.Size(53, 20);
            this.ayudaToolStripMenuItem1.Text = "Ayuda";
            // 
            // ayudaToolStripMenuItem2
            // 
            this.ayudaToolStripMenuItem2.Name = "ayudaToolStripMenuItem2";
            this.ayudaToolStripMenuItem2.Size = new System.Drawing.Size(108, 22);
            this.ayudaToolStripMenuItem2.Text = "Ayuda";
            this.ayudaToolStripMenuItem2.Click += new System.EventHandler(this.ayudaToolStripMenuItem2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ProyectoServicio.Properties.Resources._12714050_953929027977728_1753193613_n;
            this.pictureBox1.Location = new System.Drawing.Point(12, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(247, 108);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // InicioEjecucion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 453);
            this.Controls.Add(this.hora2);
            this.Controls.Add(this.hora1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.realizacionReporte);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "InicioEjecucion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicio de Aplicación de PEMEX";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SalirAplicacion);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button realizacionReporte;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton individual;
        private System.Windows.Forms.RadioButton general;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton encuestas;
        private System.Windows.Forms.RadioButton casos;
        private System.Windows.Forms.RadioButton evidencias;
        private System.Windows.Forms.RadioButton cursos;
        private System.Windows.Forms.RadioButton evaluacion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker hora1;
        private System.Windows.Forms.DateTimePicker hora2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivo;
        private System.Windows.Forms.ToolStripMenuItem configuracion;
        private System.Windows.Forms.ToolStripMenuItem nuevoUsuario;
        private System.Windows.Forms.ToolStripMenuItem eliminarUsuario;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarImpresionDeEvaluacionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem impresionDeCursosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem impresionDeEvidenciasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem impresionDeCasosDeEstudioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem impresionDeEncuestasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem cerrarSesionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem baseDeDatosToolStripMenuItem;
    }
}