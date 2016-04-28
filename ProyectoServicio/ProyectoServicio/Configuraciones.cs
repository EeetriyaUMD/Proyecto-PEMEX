using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoServicio
{

    public partial class Configuraciones : Form
    {

        private List<string> datosCargados;
        private string configuracion;
        LecturaEscrituraArchivo obj = null;

        public Configuraciones(string configuracion)
        {
            
            InitializeComponent();
            obj = new LecturaEscrituraArchivo();
            this.configuracion = configuracion;
            listBox1.DataSource = null;
            listBox2.DataSource = null;
            listBox3.DataSource = null;
            datosCargados = new List<string>();
            List<string> datos = new LecturaEscrituraArchivo().leerArchuivo("Conexion.txt");
            conexionBase objeto = new conexionBase();
            objeto.ingresarDatos(datos[0]);
            objeto.conectarSql();
            listBox1.DataSource = objeto.consultarTablas();
            objeto.cerrarSql();

            switch (configuracion)
            {

                case "evaluaciones": 
                    listBox3.DataSource = datosCargados = obj.leerArchuivo("Evaluaciones.txt");
                    label5.Text = "Evaluaciones";
                    break;

                case "cursos": 
                    listBox3.DataSource = datosCargados = obj.leerArchuivo("Cursos.txt");
                    label5.Text = "Cursos";
                    break;

                case "evidencias": 
                    listBox3.DataSource = datosCargados = obj.leerArchuivo("Evidencias.txt");
                    label5.Text = "Evidencias";
                    break;

                case "casos": 
                    listBox3.DataSource = datosCargados = obj.leerArchuivo("Casos.txt");
                    label5.Text = "Casos de Estudio";
                    break;

                case "encuestas": 
                    listBox3.DataSource = datosCargados = obj.leerArchuivo("Encuestas.txt");
                    label5.Text = "Encuestas";
                    break;

            }

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Estas seguro de guardar los datos para la consulta.", "Aplicacion PEMEX", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                switch (configuracion)
                {

                    case "evaluaciones": obj.guardarArchuivo(datosCargados, "Evaluaciones.txt", false);
                        break;

                    case "cursos": obj.guardarArchuivo(datosCargados, "Cursos.txt", false);
                        break;

                    case "evidencias": obj.guardarArchuivo(datosCargados, "Evidencias.txt", false);
                        break;

                    case "casos": obj.guardarArchuivo(datosCargados, "Casos.txt", false);
                        break;

                    case "encuestas": obj.guardarArchuivo(datosCargados, "Encuestas.txt", false);
                        break;

                }

                this.Dispose();

            }

        }

        private void button2_Click(object sender, EventArgs e)
        {

            this.Dispose();

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            List<string> datos = new LecturaEscrituraArchivo().leerArchuivo("Conexion.txt");
            conexionBase objeto = new conexionBase();
            objeto.ingresarDatos(datos[0]);
            objeto.conectarSql();
            listBox2.DataSource = objeto.consultaColumna(listBox1.GetItemText(listBox1.SelectedItem));
            objeto.cerrarSql();

        }

        private void button3_Click(object sender, EventArgs e)
        {

            if((listBox1.GetItemText(listBox1.SelectedItem) + "." + listBox2.GetItemText(listBox2.SelectedItem)).Equals(".")){

                MessageBox.Show("No hay datos que agregar.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);

            }
            else
            {

                datosCargados.Add(listBox1.GetItemText(listBox1.SelectedItem) + "." + listBox2.GetItemText(listBox2.SelectedItem));
                listBox3.DataSource = null;
                listBox3.DataSource = datosCargados;

            }

            

        }

        private void button4_Click(object sender, EventArgs e)
        {

            try
            {

                datosCargados.RemoveAt(listBox3.SelectedIndex);

            }
            catch (ArgumentOutOfRangeException ex)
            {

                MessageBox.Show("No hay datos que borrar o no se ha seleccionado un campo de la colsulta.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);

            }

            listBox3.DataSource = null;
            listBox3.DataSource = datosCargados;

        }

        private void button5_Click(object sender, EventArgs e)
        {

            try
            {

                if (MessageBox.Show("Estas seguro de eliminar la Tabla: " + listBox1.GetItemText(listBox1.SelectedItem), "Aplicacion PEMEX", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    List<string> datos = new LecturaEscrituraArchivo().leerArchuivo("Conexion.txt");
                    conexionBase objeto = new conexionBase();
                    objeto.ingresarDatos(datos[0]);
                    objeto.conectarSql();
                    objeto.borrarTabla(listBox1.GetItemText(listBox1.SelectedItem));
                    objeto.cerrarSql();

                    listBox1.DataSource = null;
                    objeto.ingresarDatos(datos[0]);
                    objeto.conectarSql();
                    listBox1.DataSource = objeto.consultarTablas();
                    objeto.cerrarSql();

                    objeto.ingresarDatos(datos[0]);
                    objeto.conectarSql();
                    listBox2.DataSource = objeto.consultaColumna(listBox1.GetItemText(listBox1.SelectedItem));
                    objeto.cerrarSql();

                }

            }
            catch (ArgumentOutOfRangeException ex)
            {

                MessageBox.Show("No hay tabla seleccionadas para borrar.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);

            }

        }

    }

}
