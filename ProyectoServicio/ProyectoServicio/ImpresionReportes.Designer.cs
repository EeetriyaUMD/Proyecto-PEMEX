namespace ProyectoServicio
{
    partial class ImpresionReportes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ImpresionReportes));
            this.panelImpresion = new System.Windows.Forms.DataGridView();
            this.label = new System.Windows.Forms.Label();
            this.cancelar = new System.Windows.Forms.Button();
            this.descargar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.panelImpresion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelImpresion
            // 
            this.panelImpresion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.panelImpresion.Location = new System.Drawing.Point(12, 126);
            this.panelImpresion.Name = "panelImpresion";
            this.panelImpresion.Size = new System.Drawing.Size(1215, 374);
            this.panelImpresion.TabIndex = 0;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.Location = new System.Drawing.Point(265, 34);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(59, 55);
            this.label.TabIndex = 7;
            this.label.Text = "R";
            // 
            // cancelar
            // 
            this.cancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelar.Location = new System.Drawing.Point(385, 516);
            this.cancelar.Name = "cancelar";
            this.cancelar.Size = new System.Drawing.Size(133, 38);
            this.cancelar.TabIndex = 9;
            this.cancelar.Text = "Cerrar";
            this.cancelar.UseVisualStyleBackColor = true;
            this.cancelar.Click += new System.EventHandler(this.cancelar_Click);
            // 
            // descargar
            // 
            this.descargar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descargar.Location = new System.Drawing.Point(701, 516);
            this.descargar.Name = "descargar";
            this.descargar.Size = new System.Drawing.Size(194, 38);
            this.descargar.TabIndex = 8;
            this.descargar.Text = "Exportar a PDF";
            this.descargar.UseVisualStyleBackColor = true;
            this.descargar.Click += new System.EventHandler(this.descargar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ProyectoServicio.Properties.Resources._12714050_953929027977728_1753193613_n;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(247, 108);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // ImpresionReportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1239, 566);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.cancelar);
            this.Controls.Add(this.descargar);
            this.Controls.Add(this.label);
            this.Controls.Add(this.panelImpresion);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ImpresionReportes";
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ImpresionReportes";
            ((System.ComponentModel.ISupportInitialize)(this.panelImpresion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView panelImpresion;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Button cancelar;
        private System.Windows.Forms.Button descargar;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}