namespace ProyectoServicio
{
    partial class CasosEstudio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CasosEstudio));
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dato1 = new System.Windows.Forms.ComboBox();
            this.dato2 = new System.Windows.Forms.ComboBox();
            this.dato3 = new System.Windows.Forms.ComboBox();
            this.dato4 = new System.Windows.Forms.ComboBox();
            this.dato5 = new System.Windows.Forms.ComboBox();
            this.realizacionReporte = new System.Windows.Forms.Button();
            this.cancelar = new System.Windows.Forms.Button();
            this.label = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(251, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(355, 31);
            this.label1.TabIndex = 7;
            this.label1.Text = "Reporte Casos de Estudio";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 143);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 24);
            this.label6.TabIndex = 20;
            this.label6.Text = "Escuela";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 188);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 24);
            this.label2.TabIndex = 21;
            this.label2.Text = "Especialidad";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 233);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 24);
            this.label3.TabIndex = 22;
            this.label3.Text = "Puesto";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 278);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(170, 24);
            this.label4.TabIndex = 23;
            this.label4.Text = "Plan de Formación";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 323);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 24);
            this.label5.TabIndex = 24;
            this.label5.Text = "Organismo";
            // 
            // dato1
            // 
            this.dato1.AutoCompleteCustomSource.AddRange(new string[] {
            "Comercialización",
            "Mantenimiento"});
            this.dato1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.dato1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.dato1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dato1.FormattingEnabled = true;
            this.dato1.Items.AddRange(new object[] {
            "Comercialización",
            "Mantenimiento"});
            this.dato1.Location = new System.Drawing.Point(207, 143);
            this.dato1.Name = "dato1";
            this.dato1.Size = new System.Drawing.Size(384, 32);
            this.dato1.TabIndex = 25;
            this.dato1.Text = "--  Selecciona la Opcion  --";
            this.dato1.SelectedIndexChanged += new System.EventHandler(this.dato1_SelectedIndexChanged);
            // 
            // dato2
            // 
            this.dato2.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.dato2.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.dato2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dato2.FormattingEnabled = true;
            this.dato2.Location = new System.Drawing.Point(207, 188);
            this.dato2.Name = "dato2";
            this.dato2.Size = new System.Drawing.Size(384, 32);
            this.dato2.TabIndex = 26;
            this.dato2.Text = "--  Selecciona la Opcion  --";
            this.dato2.SelectedIndexChanged += new System.EventHandler(this.dato2_SelectedIndexChanged);
            // 
            // dato3
            // 
            this.dato3.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.dato3.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.dato3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dato3.FormattingEnabled = true;
            this.dato3.Location = new System.Drawing.Point(207, 233);
            this.dato3.Name = "dato3";
            this.dato3.Size = new System.Drawing.Size(384, 32);
            this.dato3.TabIndex = 27;
            this.dato3.Text = "--  Selecciona la Opcion  --";
            this.dato3.SelectedIndexChanged += new System.EventHandler(this.dato3_SelectedIndexChanged);
            // 
            // dato4
            // 
            this.dato4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dato4.FormattingEnabled = true;
            this.dato4.Location = new System.Drawing.Point(207, 278);
            this.dato4.Name = "dato4";
            this.dato4.Size = new System.Drawing.Size(384, 32);
            this.dato4.TabIndex = 28;
            this.dato4.Text = "--  Selecciona la Opcion  --";
            this.dato4.SelectedIndexChanged += new System.EventHandler(this.dato4_SelectedIndexChanged);
            // 
            // dato5
            // 
            this.dato5.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.dato5.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.dato5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dato5.FormattingEnabled = true;
            this.dato5.Location = new System.Drawing.Point(207, 323);
            this.dato5.Name = "dato5";
            this.dato5.Size = new System.Drawing.Size(384, 32);
            this.dato5.TabIndex = 29;
            this.dato5.Text = "--  Selecciona la Opcion  --";
            // 
            // realizacionReporte
            // 
            this.realizacionReporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.realizacionReporte.Location = new System.Drawing.Point(379, 374);
            this.realizacionReporte.Name = "realizacionReporte";
            this.realizacionReporte.Size = new System.Drawing.Size(111, 34);
            this.realizacionReporte.TabIndex = 32;
            this.realizacionReporte.Text = "Realizar";
            this.realizacionReporte.UseVisualStyleBackColor = true;
            this.realizacionReporte.Click += new System.EventHandler(this.realizacionReporte_Click);
            // 
            // cancelar
            // 
            this.cancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelar.Location = new System.Drawing.Point(133, 374);
            this.cancelar.Name = "cancelar";
            this.cancelar.Size = new System.Drawing.Size(101, 34);
            this.cancelar.TabIndex = 33;
            this.cancelar.Text = "Cancer";
            this.cancelar.UseVisualStyleBackColor = true;
            this.cancelar.Click += new System.EventHandler(this.cancelar_Click);
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.Location = new System.Drawing.Point(445, 84);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(18, 20);
            this.label.TabIndex = 41;
            this.label.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(375, 84);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 20);
            this.label7.TabIndex = 40;
            this.label7.Text = "Usuario";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ProyectoServicio.Properties.Resources._12714050_953929027977728_1753193613_n;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(247, 108);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 42;
            this.pictureBox1.TabStop = false;
            // 
            // CasosEstudio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 424);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cancelar);
            this.Controls.Add(this.realizacionReporte);
            this.Controls.Add(this.dato5);
            this.Controls.Add(this.dato4);
            this.Controls.Add(this.dato3);
            this.Controls.Add(this.dato2);
            this.Controls.Add(this.dato1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CasosEstudio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CasosEstudio";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox dato1;
        private System.Windows.Forms.ComboBox dato2;
        private System.Windows.Forms.ComboBox dato3;
        private System.Windows.Forms.ComboBox dato4;
        private System.Windows.Forms.ComboBox dato5;
        private System.Windows.Forms.Button realizacionReporte;
        private System.Windows.Forms.Button cancelar;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox1;

    }
}