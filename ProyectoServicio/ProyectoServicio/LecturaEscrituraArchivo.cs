using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoServicio
{
    class LecturaEscrituraArchivo
    {

        String ruta = System.IO.Path.Combine(Application.StartupPath, "FicherosBaseDatos\\ArchivosConfiguracion\\");
        List<string> lista = new List<string>();
            
        public List<string> leerArchuivo(string archivo){

            lista.Clear();

            using (StreamReader lectura = new StreamReader(ruta + archivo))
            {
                string line;

                while ((line = lectura.ReadLine()) != null)
                {
                
                    lista.Add(line);
                
                }

                lectura.Close();
            
            }

            return lista;

        }

        public void guardarArchuivo(string texto, string archivo, Boolean opcion)
        {

            using (StreamWriter escritura = new StreamWriter(ruta + archivo, opcion))
            {

                escritura.WriteLine(texto);
                escritura.Close();

            }

        }

        public void guardarArchuivo(List<string> texto, string archivo, Boolean opcion)
        {
            String datos = "";

            using (StreamWriter escritura = new StreamWriter(ruta + archivo, opcion))
            {

                foreach (string x in texto)
                {

                    datos += x + "\n";

                }
                escritura.Write(datos);
                escritura.Close();

            }

        }

    }
}
