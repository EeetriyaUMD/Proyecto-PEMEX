using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoServicio
{

    class conexionBase
    {

        private string cadenaConexion;
        private SqlConnection conecta = null;
        private string consultaTablas = "SELECT CAST(table_name as varchar)  FROM INFORMATION_SCHEMA.TABLES;";
        
        public void conectarSql()
        {

            conecta = new SqlConnection();
         
            try
            {

                conecta.ConnectionString = cadenaConexion;
                conecta.Open();

            }
            catch (Exception ex)
            {

                MessageBox.Show("Los datos de la base de datos no son correctos por tal motivo.\nSe recominda que se ingresen los nuevos datos de la base de datos.\n" + ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            
            }
        
        }

        public List<string> consultarTablas()
        {

            List<string> tablas = new List<string>();
            SqlCommand comandos = new SqlCommand(consultaTablas, conecta);
            SqlDataReader lectura = comandos.ExecuteReader();

            try
            {

                while (lectura.Read())
                {

                    tablas.Add(String.Format("{0}", lectura[0]));
            
                }
            
            }
            catch (SqlException e)
            {

                Console.WriteLine(e.Message);
          
            }

            lectura.Close();
            return tablas;
        }

        public List<string> consultaColumna(string tabla)
        {

            string consultaColumnas = "SELECT COLUMN_NAME FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = '" + tabla + "' ORDER BY DATA_TYPE;";

            List<string> tablas = new List<string>();
            SqlCommand comandos = new SqlCommand(consultaColumnas, conecta);
            SqlDataReader lectura = comandos.ExecuteReader();

            try
            {

                while (lectura.Read())
                {

                    tablas.Add(String.Format("{0}", lectura[0]));

                }

            }
            catch (SqlException e)
            {

                Console.WriteLine(e.Message);

            }

            lectura.Close();
            return tablas;
        }

        public void borrarTabla(string tabla)
        {

            string consultaColumnas = "DROP TABLE " + tabla + ";";

            List<string> tablas = new List<string>();
            SqlCommand comandos = new SqlCommand(consultaColumnas, conecta);

            try
            {

                comandos.ExecuteReader();

            }
            catch (SqlException e)
            {

                MessageBox.Show("No hay tabla seleccionadas para borrar.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);

            }

        }

        public void consultaDatosTabla(string consulta, DataGridView panelImpresion)
        {

            DataTable datos = new DataTable();
            SqlCommand comandos = new SqlCommand(consulta, conecta);
            SqlDataAdapter adapter = new SqlDataAdapter(comandos);
            adapter.Fill(datos);
            panelImpresion.DataSource = datos;
        
        }

        public void cerrarSql()
        {

            conecta.Close();

        }

        public void ingresarDatos(string datosConexion)
        {

            cadenaConexion = datosConexion;

        }

    }
}
