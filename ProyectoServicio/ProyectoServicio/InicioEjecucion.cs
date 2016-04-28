using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoServicio
{
    public partial class InicioEjecucion : Form
    {
        public InicioEjecucion()
        {

            InitializeComponent();

        }

        public void asignacionPrivilegios(string user, List<string> users)
        {
            string privilegio = "";

            foreach (string privilegios in users)
            {

                if (privilegios.IndexOf(user + "-A") != -1 || privilegios.IndexOf(user + "-U") != -1 || privilegios.IndexOf(user + "-V") != -1)
                {

                    privilegio = privilegios.Substring(privilegios.IndexOf("-"));
                    break;

                }

            }

            switch(privilegio){

                case "-A":
                    MessageBox.Show("Bienvenido a la aplicaion PEMEX, usuario Administrador", "Aplicacion PEMEX", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;

                case "-U":
                    MessageBox.Show("Bienvenido a la aplicaion PEMEX", "Aplicacion PEMEX", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    nuevoUsuario.Enabled = false;
                    eliminarUsuario.Enabled = false;
                    configuracion.Enabled = false;
                    hora1.Enabled = false;
                    hora2.Enabled = false;
                    break;

                case "-V":
                    MessageBox.Show("Bienvenido a la aplicaion PEMEX, usuario Visitante", "Aplicacion PEMEX", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    nuevoUsuario.Enabled = false;
                    eliminarUsuario.Enabled = false;
                    configuracion.Enabled = false;
                    individual.Enabled = false;
                    hora1.Enabled = false;
                    hora2.Enabled = false;
                    break;

            }
            
            List<string> datos= new LecturaEscrituraArchivo().leerArchuivo("Conexion.txt");
            conexionBase Objeto = new conexionBase();
            Objeto.ingresarDatos(datos[0]);
            Objeto.conectarSql();
            Objeto.cerrarSql();

        }

        private void realizacionReporte_Click(object sender, EventArgs e)
        {

            DateTime hora11 = this.hora1.Value;
            DateTime hora22 = this.hora2.Value;

            if (individual.Checked == true)
            {

                if (evaluacion.Checked == true)
                {

                    Evaluacion objeto = new Evaluacion();
                    objeto.Sesion(label.Text);
                    objeto.ShowDialog();

                }

                if (cursos.Checked == true)
                {

                    Cursos objeto = new Cursos();
                    objeto.Sesion(label.Text);
                    objeto.ShowDialog();

                }

                if (evidencias.Checked == true)
                {

                    Evidencias objeto = new Evidencias();
                    objeto.Sesion(label.Text);
                    objeto.ShowDialog();

                }

                if (casos.Checked == true)
                {

                    CasosEstudio objeto = new CasosEstudio();
                    objeto.Sesion(label.Text);
                    objeto.ShowDialog();

                }

                if (encuestas.Checked == true)
                {

                    Encuestas objeto = new Encuestas();
                    objeto.Sesion(label.Text);
                    objeto.ShowDialog();

                }

            }

            if (general.Checked == true)
            {

                if (evaluacion.Checked == true)
                {

                    try
                    {

                        ImpresionReportes objeto = new ImpresionReportes("evaluaciones", hora11, hora22);
                        objeto.Sesion("Reporte de Evaluaciones");
                        objeto.ShowDialog();

                    }
                    catch (ObjectDisposedException ex)
                    {
                        
                        Console.WriteLine("Caught: {0}", ex.Message);
                    
                    }

                }

                if (cursos.Checked == true)
                {

                    try
                    {

                        ImpresionReportes objeto = new ImpresionReportes("cursos", hora11, hora22);
                        objeto.Sesion("Reporte de Cursos");
                        objeto.ShowDialog();

                    }
                    catch (ObjectDisposedException ex)
                    {

                        Console.WriteLine("Caught: {0}", ex.Message);

                    }
                    
                }

                if (evidencias.Checked == true)
                {

                    try
                    {

                        ImpresionReportes objeto = new ImpresionReportes("evidencias", hora11, hora22);
                        objeto.Sesion("Reporte de Evidencias");
                        objeto.ShowDialog();

                    }
                    catch (ObjectDisposedException ex)
                    {

                        Console.WriteLine("Caught: {0}", ex.Message);

                    }

                }

                if (casos.Checked == true)
                {

                    try
                    {

                        ImpresionReportes objeto = new ImpresionReportes("casos", hora11, hora22);
                        objeto.Sesion("Reporte de Casos de Estudio");
                        objeto.ShowDialog();

                    }
                    catch (ObjectDisposedException ex)
                    {

                        Console.WriteLine("Caught: {0}", ex.Message);

                    }

                }

                if (encuestas.Checked == true)
                {

                    try
                    {

                        ImpresionReportes objeto = new ImpresionReportes("encuestas", hora11, hora22);
                        objeto.Sesion("Reporte de Encuestas");
                        objeto.ShowDialog();

                    }
                    catch (ObjectDisposedException ex)
                    {

                        Console.WriteLine("Caught: {0}", ex.Message);

                    }

                }

            }

        }

        private void SalirAplicacion(object sender, FormClosingEventArgs e)
        {

            switch (e.CloseReason)
            {
                case CloseReason.UserClosing:

                    if (MessageBox.Show("Estas seguro de salir de la aplicaion.", "Aplicacion PEMEX", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {

                        Application.Exit();

                    }
                    else
                    {

                        e.Cancel = true;

                    }

                    break;

            }

        }

        public void Sesion(String datos)
        {

            this.label.Text = datos;

        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Estas seguro de salir de la aplicaion.", "Aplicacion PEMEX", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                Application.Exit();
            
            }

        }

        private void cerrarSesionToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Estas seguro de cerrar sesion.", "Aplicacion PEMEX", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                this.Dispose();
                InicioSesion objeto = new InicioSesion();
                objeto.ShowDialog();
                
            }

        }

        private void ayudaToolStripMenuItem2_Click(object sender, EventArgs e)
        {

            Process proc = new Process();
            proc.StartInfo.FileName = System.IO.Path.Combine(Application.StartupPath, "FicherosBaseDatos\\ArchivosConfiguracion\\pemexAyuda.pdf");
            proc.Start();
            proc.Close();

        }

        private void nuevoUsuario_Click(object sender, EventArgs e)
        {

            Usuario objeto = new Usuario("nuevo");
            objeto.Sesion(label.Text);
            objeto.ShowDialog();

        }

        private void eliminarUsuario_Click(object sender, EventArgs e)
        {

            Usuario objeto = new Usuario("eliminar");
            objeto.Sesion(label.Text); 
            objeto.ShowDialog();

        }

        private void editarImpresionDeEvaluacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {

            new Configuraciones("evaluaciones").ShowDialog();

        }

        private void baseDeDatosToolStripMenuItem_Click(object sender, EventArgs e)
        {

            new BaseDatos().ShowDialog();

        }

        private void impresionDeCursosToolStripMenuItem_Click(object sender, EventArgs e)
        {

            new Configuraciones("cursos").ShowDialog();

        }

        private void impresionDeEvidenciasToolStripMenuItem_Click(object sender, EventArgs e)
        {

            new Configuraciones("evidencias").ShowDialog();

        }

        private void impresionDeCasosDeEstudioToolStripMenuItem_Click(object sender, EventArgs e)
        {

            new Configuraciones("casos").ShowDialog();

        }

        private void impresionDeEncuestasToolStripMenuItem_Click(object sender, EventArgs e)
        {

            new Configuraciones("encuestas").ShowDialog();

        }

    }

}
