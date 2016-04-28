using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;
using System.Data;
using System.Data.OleDb;

namespace ProyectoServicio
{
    class ImportacionArchivos
    {

        OleDbConnection conexion;
        OleDbDataAdapter adaptadorDatos;
        DataTable vistaTabla;
        String direccion;


        public OleDbDataAdapter iniciarConexcion(string ruta, string nombreHoja, string filas)
        {

            direccion = System.IO.Path.Combine(Application.StartupPath, "FicherosBaseDatos\\" + ruta);

            try
            {

                conexion = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;data source=" + direccion + ";Extended Properties='Excel 12.0 Xml;HDR=Yes'");
                conexion.Open();
                adaptadorDatos = new OleDbDataAdapter("Select " + filas + " from [" + nombreHoja + "$]", conexion);
                
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString(), "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            return adaptadorDatos;

        }

        private void cerrarConexion()
        {

            adaptadorDatos.Dispose();
            conexion.Close();

        }

        public void extraerDatosCombobox(OleDbDataAdapter adaptador, ComboBox cargadorDatos)
        {

            cargadorDatos.Items.Clear();
            vistaTabla = new DataTable();
            adaptador.Fill(vistaTabla);
            
            foreach (DataRow dato in vistaTabla.Rows)
            {

                cargadorDatos.Items.Add(dato["Nombre"].ToString());

            }

            cerrarConexion();

        }

    }

}
