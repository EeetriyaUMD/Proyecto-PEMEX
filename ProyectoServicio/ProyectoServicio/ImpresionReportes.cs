using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;
using System.Diagnostics;

namespace ProyectoServicio
{

    public partial class ImpresionReportes : Form
    {

        private string impresion;
        LecturaEscrituraArchivo objeto = null;
        List<string> listaConsulta = null;

        public ImpresionReportes(string impresion, String busqueda)
        {

            this.impresion = impresion;
            objeto = new LecturaEscrituraArchivo();
            InitializeComponent();

            switch (impresion)
            {

                case "evaluaciones":
                    listaConsulta = objeto.leerArchuivo("Evaluaciones.txt");
                    break;

                case "cursos":
                    listaConsulta = objeto.leerArchuivo("Cursos.txt");
                    break;

                case "evidencias":
                    listaConsulta = objeto.leerArchuivo("Evidencias.txt");
                    break;

                case "casos":
                    listaConsulta = objeto.leerArchuivo("Casos.txt");
                    break;

                case "encuestas":
                    listaConsulta = objeto.leerArchuivo("Encuestas.txt");
                    break;

            }

            try
            {

                if (listaConsulta[0].Equals(""))
                {

                    MessageBox.Show("No hay una configuracion previa de impresion de datos.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                    this.Close();
                }
                else
                {

                    List<string> datos = new LecturaEscrituraArchivo().leerArchuivo("Conexion.txt");
                    conexionBase objeto1 = new conexionBase();
                    Console.WriteLine(realizacionConsulta(listaConsulta).Substring(0, realizacionConsulta(listaConsulta).IndexOf(";")) + busqueda);
                    objeto1.ingresarDatos(datos[0]);
                    objeto1.conectarSql();
                    objeto1.consultaDatosTabla(realizacionConsulta(listaConsulta).Substring(0, realizacionConsulta(listaConsulta).IndexOf(";")) + busqueda, panelImpresion);
                    objeto1.cerrarSql();
                    
                }

            }
            catch (ArgumentOutOfRangeException ex)
            {

                MessageBox.Show("No hay una configuracion previa de impresion de datos.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);

            }
            catch (ObjectDisposedException ex)
            {
                
                MessageBox.Show("No hay una configuracion previa de impresion de datos.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);

            }
            catch (NullReferenceException ex)
            {

                MessageBox.Show("No hay una configuracion previa de impresion de datos.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);

            }

        }
        
        public ImpresionReportes(string impresion, DateTime hora1, DateTime hora2)
        {

            this.impresion = impresion;
            objeto = new LecturaEscrituraArchivo();
            InitializeComponent();

            switch (impresion)
            {

                case "evaluaciones":
                    listaConsulta = objeto.leerArchuivo("Evaluaciones.txt");
                    break;

                case "cursos":
                    listaConsulta = objeto.leerArchuivo("Cursos.txt");
                    break;

                case "evidencias":
                    listaConsulta = objeto.leerArchuivo("Evidencias.txt");
                    break;

                case "casos":
                    listaConsulta = objeto.leerArchuivo("Casos.txt");
                    break;

                case "encuestas":
                    listaConsulta = objeto.leerArchuivo("Encuestas.txt");
                    break;

            }

            try
            {

                if (listaConsulta[0].Equals(""))
                {

                    MessageBox.Show("No hay una configuracion previa de impresion de datos.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                    this.Close();
                }
                else
                {

                    List<string> datos = new LecturaEscrituraArchivo().leerArchuivo("Conexion.txt");
                    conexionBase objeto1 = new conexionBase();
                    Console.WriteLine(realizacionConsulta(listaConsulta));
                    objeto1.ingresarDatos(datos[0]);
                    objeto1.conectarSql();
                    objeto1.consultaDatosTabla(realizacionConsulta(listaConsulta), panelImpresion);
                    objeto1.cerrarSql();
                
                }

            }
            catch (ArgumentOutOfRangeException ex)
            {

                MessageBox.Show("No hay una configuracion previa de impresion de datos.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                this.Close();

            }

        }

        public string realizacionConsulta(List<string> consulta)
        {

            String columnas = "";
            String tablas = "";

            foreach (string dato in consulta)
            {

                columnas += ", [" + dato.Substring(dato.IndexOf(".") + 1) + "]";

                if (tablas.IndexOf(dato.Substring(0, dato.IndexOf(".") - 1)) == -1)
                {

                    tablas += ", [" + dato.Substring(0, dato.IndexOf(".")) + "]";

                }

            }

            return "SELECT " + columnas.Substring(columnas.IndexOf(",") + 1) + " FROM " + tablas.Substring(tablas.IndexOf(",") + 1) + ";";
        }

        private void cancelar_Click(object sender, EventArgs e)
        {

            this.Dispose();

        }


        private void descargar_Click(object sender, EventArgs e)
        {

            if (panelImpresion.RowCount == 0)
            {

                MessageBox.Show("No Hay Datos Para Realizar Un Reporte", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {

                SaveFileDialog save = new SaveFileDialog();
                save.Filter = "PDF Files (*.pdf)|*.pdf|All Files (*.*)|*.*";

                if (save.ShowDialog() == DialogResult.OK)
                {

                    string filename = save.FileName;
                    DateTime hora = DateTime.Now;
                    string fcha_ttal = Convert.ToDateTime(hora).Day + "/" + Convert.ToDateTime(hora).Month + "/" + Convert.ToDateTime(hora).Year;
                    Document doc = new Document(PageSize.A3, 9, 9, 9, 9);
                    Chunk ap = new Chunk("REPORTE " + fcha_ttal + "\n\n", FontFactory.GetFont("COURIER", 18));

                    try
                    {
                        FileStream file = new FileStream(filename, FileMode.OpenOrCreate);
                        PdfWriter writer = PdfWriter.GetInstance(doc, file);
                        writer.ViewerPreferences = PdfWriter.PageModeUseThumbs;
                        writer.ViewerPreferences = PdfWriter.PageLayoutOneColumn;
                        doc.Open();

                        doc.Add(new Paragraph(ap));
                        GenerarDocumentos(doc);

                        Process.Start(filename);
                        doc.Close();

                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show(ex.Message + " -- " + ex.StackTrace.ToString());

                    }

                }

            }

        }

        public void GenerarDocumentos(Document document)
        {

            PdfPTable datatable = new PdfPTable(panelImpresion.ColumnCount);
            datatable.DefaultCell.Padding = 8;
            float[] headerwidths = GetTamañoColumnas(panelImpresion);

            datatable.SetWidths(headerwidths);
            datatable.WidthPercentage = 100;
            datatable.DefaultCell.BorderWidth = 1;

            datatable.DefaultCell.BackgroundColor = iTextSharp.text.BaseColor.WHITE;
            datatable.DefaultCell.BorderColor = iTextSharp.text.BaseColor.BLACK;
            iTextSharp.text.Font fuente = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA);

            Phrase objP = new Phrase("A", fuente);
            datatable.DefaultCell.HorizontalAlignment = Element.ALIGN_CENTER;

            for (int i = 0; i < panelImpresion.ColumnCount; i++)
            {

                objP = new Phrase(panelImpresion.Columns[i].HeaderText, fuente);
                datatable.HorizontalAlignment = Element.ALIGN_CENTER;
                datatable.AddCell(objP);

            }

            datatable.HeaderRows = 1;
            datatable.DefaultCell.BorderWidth = 1;

            for (int i = 0; i < panelImpresion.RowCount - 1; i++)
            {

                for (int j = 0; j < panelImpresion.ColumnCount; j++)
                {

                    objP = new Phrase(panelImpresion[j, i].Value.ToString(), fuente);
                    datatable.AddCell(objP);

                }

                datatable.CompleteRow();

            }

            document.Add(datatable);

        }

        public float[] GetTamañoColumnas(DataGridView dg)
        {

            float[] values = new float[dg.ColumnCount];

            for (int i = 0; i < dg.ColumnCount; i++)
            {

                values[i] = (float)dg.Columns[i].Width;

            }

            return values;

        }


        public void Sesion(String datos)
        {

            label.Text = datos;

        }

    }

}
