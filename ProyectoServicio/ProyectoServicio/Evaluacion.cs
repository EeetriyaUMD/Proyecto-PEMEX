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
    public partial class Evaluacion : Form
    {

        ImportacionArchivos objeto = null;

        public Evaluacion()
        {

            InitializeComponent();
            objeto = new ImportacionArchivos();

        }

        private void cancelar_Click(object sender, EventArgs e)
        {

            this.Dispose();

        }

        private void realizacionReporte_Click(object sender, EventArgs e)
        {

            this.Dispose();
            
                if (dato1.SelectedIndex != -1)
                {

                    if (dato1.SelectedIndex != -1 && dato2.SelectedIndex != -1 && dato3.SelectedIndex != -1 && dato4.SelectedIndex != -1 && dato5.SelectedIndex != -1)
                    {

                        ImpresionReportes objeto = new ImpresionReportes("evaluaciones", " WHERE [Escuela] = '" + dato1.GetItemText(dato1.SelectedItem) + "' " +
                        "AND [Especialidad] = '" + dato2.GetItemText(dato2.SelectedItem) + "' " +
                        "AND [Puesto Actual] = '" + dato3.GetItemText(dato3.SelectedItem) + "' " +
                        "AND [Puesto Meta] = '" + dato4.GetItemText(dato4.SelectedItem) + "' " +
                        "AND [Organismo] = '" + dato5.GetItemText(dato5.SelectedItem) + "'");
                        objeto.Sesion("Reporte de Evaluaciones");
                        objeto.ShowDialog();

                    }
                    else
                    {

                        if (dato1.SelectedIndex != -1 && dato2.SelectedIndex != -1 && dato3.SelectedIndex != -1 && dato4.SelectedIndex != -1)
                        {

                            ImpresionReportes objeto = new ImpresionReportes("evaluaciones", " WHERE [Escuela] = '" + dato1.GetItemText(dato1.SelectedItem) + "' " +
                            "AND [Especialidad] = '" + dato2.GetItemText(dato2.SelectedItem) + "' " +
                            "AND [Puesto Actual] = '" + dato3.GetItemText(dato3.SelectedItem) + "' " +
                            "AND [Puesto Meta] = '" + dato4.GetItemText(dato4.SelectedItem) + "'");
                            objeto.Sesion("Reporte de Evaluaciones");
                            objeto.ShowDialog();

                        }
                        else
                        {

                            if (dato1.SelectedIndex != -1 && dato2.SelectedIndex != -1 && dato3.SelectedIndex != -1)
                            {

                                ImpresionReportes objeto = new ImpresionReportes("evaluaciones", " WHERE [Escuela] = '" + dato1.GetItemText(dato1.SelectedItem) + "' " +
                                "AND [Especialidad] = '" + dato2.GetItemText(dato2.SelectedItem) + "' " +
                                "AND [Puesto Actual] = '" + dato3.GetItemText(dato3.SelectedItem) + "'");
                                objeto.Sesion("Reporte de Evaluaciones");
                                objeto.ShowDialog();

                            }
                            else
                            {

                                if (dato1.SelectedIndex != -1 && dato2.SelectedIndex != -1)
                                {

                                    ImpresionReportes objeto = new ImpresionReportes("evaluaciones", " WHERE [Escuela] = '" + dato1.GetItemText(dato1.SelectedItem) + "' " +
                                    "AND [Especialidad] = '" + dato2.GetItemText(dato2.SelectedItem) + "'");
                                    objeto.Sesion("Reporte de Evaluaciones");
                                    objeto.ShowDialog();

                                }
                                else
                                {

                                    if (dato1.SelectedIndex != -1)
                                    {

                                            ImpresionReportes objeto = new ImpresionReportes("evaluaciones", " WHERE [Escuela] = '" + dato1.GetItemText(dato1.SelectedItem) + "'");
                                            objeto.Sesion("Reporte de Evaluaciones");
                                            objeto.ShowDialog();

                                    }

                                }

                            }

                        }

                    }

                }
                else
                {

                    MessageBox.Show("Se debera seleccionar las opciones para realizar el reporte.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

        }

        public void Sesion(String datos)
        {

            this.label.Text = datos;

        }

        private void dato1_SelectedIndexChanged(object sender, EventArgs e)
        {

            switch (dato1.GetItemText(dato1.SelectedItem))
            {

                case "Comercialización":
                    objeto.extraerDatosCombobox(objeto.iniciarConexcion("ArchivosConfiguracion\\datosConfiguracion", "Comercialización", "*"), dato2);
                    break;

                case "Mantenimiento":
                    objeto.extraerDatosCombobox(objeto.iniciarConexcion("ArchivosConfiguracion\\datosConfiguracion", "Mantenimiento", "*"), dato2);
                    break;

                default:
                    objeto.extraerDatosCombobox(objeto.iniciarConexcion("ArchivosConfiguracion\\datosConfiguracion", dato1.GetItemText(dato1.SelectedItem), "*"), dato2);
                    break;

            }

            dato2.Text = "--  Selecciona la Opcion  --";
            dato3.Items.Clear();
            dato3.Text = "--  Selecciona la Opcion  --";
            dato4.Items.Clear();
            dato4.Text = "--  Selecciona la Opcion  --";
            dato5.Items.Clear();
            dato5.Text = "--  Selecciona la Opcion  --";
            
        }

        private void dato2_SelectedIndexChanged(object sender, EventArgs e)
        {

            switch (dato2.GetItemText(dato2.SelectedItem))
            {

                case "Ventas":
                    objeto.extraerDatosCombobox(objeto.iniciarConexcion("ArchivosConfiguracion\\datosConfiguracion", "Ventas", "*"), dato3);
                    objeto.extraerDatosCombobox(objeto.iniciarConexcion("ArchivosConfiguracion\\datosConfiguracion", "Ventas", "*"), dato4);
                    break;

                case "Inteligencia de Mercado y Operativa":
                    objeto.extraerDatosCombobox(objeto.iniciarConexcion("ArchivosConfiguracion\\datosConfiguracion", "Inteligencia de Mercado y Opera", "*"), dato3);
                    objeto.extraerDatosCombobox(objeto.iniciarConexcion("ArchivosConfiguracion\\datosConfiguracion", "Inteligencia de Mercado y Opera", "*"), dato4);
                    break;

                case "Coordinación Comercial y Operativa":
                    objeto.extraerDatosCombobox(objeto.iniciarConexcion("ArchivosConfiguracion\\datosConfiguracion", "Coordinación Comercial y Operat", "*"), dato3);
                    objeto.extraerDatosCombobox(objeto.iniciarConexcion("ArchivosConfiguracion\\datosConfiguracion", "Coordinación Comercial y Operat", "*"), dato4);
                    break;

                case "Mantenimiento de Ductos":
                    objeto.extraerDatosCombobox(objeto.iniciarConexcion("ArchivosConfiguracion\\datosConfiguracion", "Mantenimiento de Ductos", "*"), dato3);
                    objeto.extraerDatosCombobox(objeto.iniciarConexcion("ArchivosConfiguracion\\datosConfiguracion", "Mantenimiento de Ductos", "*"), dato4);
                    break;

                case "Mantenimiento Mecánico Estático":
                    objeto.extraerDatosCombobox(objeto.iniciarConexcion("ArchivosConfiguracion\\datosConfiguracion", "Mantenimiento Mecánico Estático", "*"), dato3);
                    objeto.extraerDatosCombobox(objeto.iniciarConexcion("ArchivosConfiguracion\\datosConfiguracion", "Mantenimiento Mecánico Estático", "*"), dato4);
                    break;

                case "Mantenimiento General en Terminales":
                    objeto.extraerDatosCombobox(objeto.iniciarConexcion("ArchivosConfiguracion\\datosConfiguracion", "Mantenimiento General en Termin", "*"), dato3);
                    objeto.extraerDatosCombobox(objeto.iniciarConexcion("ArchivosConfiguracion\\datosConfiguracion", "Mantenimiento General en Termin", "*"), dato4);
                    break;

                case "Ingeniería del Mantenimiento":
                    objeto.extraerDatosCombobox(objeto.iniciarConexcion("ArchivosConfiguracion\\datosConfiguracion", "Ingeniería del Mantenimiento", "*"), dato3);
                    objeto.extraerDatosCombobox(objeto.iniciarConexcion("ArchivosConfiguracion\\datosConfiguracion", "Ingeniería del Mantenimiento", "*"), dato4);
                    break;

                case "Medición PGPB PROD":
                    objeto.extraerDatosCombobox(objeto.iniciarConexcion("ArchivosConfiguracion\\datosConfiguracion", "Medición PGPB PROD", "*"), dato3);
                    objeto.extraerDatosCombobox(objeto.iniciarConexcion("ArchivosConfiguracion\\datosConfiguracion", "Medición PGPB PROD", "*"), dato4);
                    break;

                case "Medición DUCTOS":
                    objeto.extraerDatosCombobox(objeto.iniciarConexcion("ArchivosConfiguracion\\datosConfiguracion", "Medición DUCTOS", "*"), dato3);
                    objeto.extraerDatosCombobox(objeto.iniciarConexcion("ArchivosConfiguracion\\datosConfiguracion", "Medición DUCTOS", "*"), dato4);
                    break;

                case "Medición PPQ OPER":
                    objeto.extraerDatosCombobox(objeto.iniciarConexcion("ArchivosConfiguracion\\datosConfiguracion", "Medición PPQ OPER", "*"), dato3);
                    objeto.extraerDatosCombobox(objeto.iniciarConexcion("ArchivosConfiguracion\\datosConfiguracion", "Medición PPQ OPER", "*"), dato4);
                    break;

                case "Mantenimiento de Instrumentación y Control (REFINERIAS, CPG'S Y CPQ)":
                    objeto.extraerDatosCombobox(objeto.iniciarConexcion("ArchivosConfiguracion\\datosConfiguracion", "Mantenimiento de Instrumentació", "*"), dato3);
                    objeto.extraerDatosCombobox(objeto.iniciarConexcion("ArchivosConfiguracion\\datosConfiguracion", "Mantenimiento de Instrumentació", "*"), dato4);
                    break;

                case "Medición TAR":
                    objeto.extraerDatosCombobox(objeto.iniciarConexcion("ArchivosConfiguracion\\datosConfiguracion", "Medición TAR", "*"), dato3);
                    objeto.extraerDatosCombobox(objeto.iniciarConexcion("ArchivosConfiguracion\\datosConfiguracion", "Medición TAR", "*"), dato4);
                    break;

                case "Medición PEP PROD":
                    objeto.extraerDatosCombobox(objeto.iniciarConexcion("ArchivosConfiguracion\\datosConfiguracion", "Medición PEP PROD", "*"), dato3);
                    objeto.extraerDatosCombobox(objeto.iniciarConexcion("ArchivosConfiguracion\\datosConfiguracion", "Medición PEP PROD", "*"), dato4);
                    break;

                case "Medición PXR PROD":
                    objeto.extraerDatosCombobox(objeto.iniciarConexcion("ArchivosConfiguracion\\datosConfiguracion", "Medición PXR PROD", "*"), dato3);
                    objeto.extraerDatosCombobox(objeto.iniciarConexcion("ArchivosConfiguracion\\datosConfiguracion", "Medición PXR PROD", "*"), dato4);
                    break;

                case "Medición TDGL":
                    objeto.extraerDatosCombobox(objeto.iniciarConexcion("ArchivosConfiguracion\\datosConfiguracion", "Medición TDGL", "*"), dato3);
                    objeto.extraerDatosCombobox(objeto.iniciarConexcion("ArchivosConfiguracion\\datosConfiguracion", "Medición TDGL", "*"), dato4);
                    break;

                case "Medición Base":
                    objeto.extraerDatosCombobox(objeto.iniciarConexcion("ArchivosConfiguracion\\datosConfiguracion", "Medición Base", "*"), dato3);
                    objeto.extraerDatosCombobox(objeto.iniciarConexcion("ArchivosConfiguracion\\datosConfiguracion", "Medición Base", "*"), dato4);
                    break;

                case "Mantenimiento Eléctrico":
                    objeto.extraerDatosCombobox(objeto.iniciarConexcion("ArchivosConfiguracion\\datosConfiguracion", "Mantenimiento Eléctrico", "*"), dato3);
                    objeto.extraerDatosCombobox(objeto.iniciarConexcion("ArchivosConfiguracion\\datosConfiguracion", "Mantenimiento Eléctrico", "*"), dato4);
                    break;

                case "Mantenimiento de Instrumentación y Control":
                    objeto.extraerDatosCombobox(objeto.iniciarConexcion("ArchivosConfiguracion\\datosConfiguracion", "Mantenimiento de Instrumen", "*"), dato3);
                    objeto.extraerDatosCombobox(objeto.iniciarConexcion("ArchivosConfiguracion\\datosConfiguracion", "Mantenimiento de Instrumen", "*"), dato4);
                    break;

                default:
                    objeto.extraerDatosCombobox(objeto.iniciarConexcion("ArchivosConfiguracion\\datosConfiguracion", dato2.GetItemText(dato2.SelectedItem), "*"), dato3);
                    objeto.extraerDatosCombobox(objeto.iniciarConexcion("ArchivosConfiguracion\\datosConfiguracion", dato2.GetItemText(dato2.SelectedItem), "*"), dato4);
                    break;

            }
            dato3.Text = "--  Selecciona la Opcion  --";
            dato4.Text = "--  Selecciona la Opcion  --";
            dato5.Items.Clear();
            dato5.Text = "--  Selecciona la Opcion  --";

        }

        private void dato3_SelectedIndexChanged(object sender, EventArgs e)
        {

            dato4.SelectedIndex = dato4.FindStringExact(dato3.GetItemText(dato3.SelectedItem));

            switch (dato3.GetItemText(dato3.SelectedItem))
            {

                case "Jefe de Especialidad de Ventas":
                    objeto.extraerDatosCombobox(objeto.iniciarConexcion("ArchivosConfiguracion\\datosConfiguracion", "Jefe de Especialidad de Ventas", "*"), dato5);
                    break;

                case "Especialista de Ventas":
                    objeto.extraerDatosCombobox(objeto.iniciarConexcion("ArchivosConfiguracion\\datosConfiguracion", "Especialista de Ventas", "*"), dato5);
                    break;

                case "Superintendente General de Ventas": Console.WriteLine("hola");
                    objeto.extraerDatosCombobox(objeto.iniciarConexcion("ArchivosConfiguracion\\datosConfiguracion", "Superintendente General de Vent", "*"), dato5);
                    break;

                case "Subgerente de Ventas":
                    objeto.extraerDatosCombobox(objeto.iniciarConexcion("ArchivosConfiguracion\\datosConfiguracion", "Subgerente de Ventas", "*"), dato5);
                    break;

                case "Jefe de Especialidad de Servicio Técnico":
                    objeto.extraerDatosCombobox(objeto.iniciarConexcion("ArchivosConfiguracion\\datosConfiguracion", "Jefe de Especialidad de Servici", "*"), dato5);
                    break;

                case "Jefe de Departamento de Servicio Técnico":
                    objeto.extraerDatosCombobox(objeto.iniciarConexcion("ArchivosConfiguracion\\datosConfiguracion", "Jefe de Departamento de Servici", "*"), dato5);
                    break;

                case "Subgerente de Servicio Técnico":
                    objeto.extraerDatosCombobox(objeto.iniciarConexcion("ArchivosConfiguracion\\datosConfiguracion", "Subgerente de Servicio Técnico", "*"), dato5);
                    break;

                case "Especialista de Comercio Exterior":
                    objeto.extraerDatosCombobox(objeto.iniciarConexcion("ArchivosConfiguracion\\datosConfiguracion", "Especialista de Comercio Exteri", "*"), dato5);
                    break;

                case "Jefe de Especialidad de Comercio Exterior":
                    objeto.extraerDatosCombobox(objeto.iniciarConexcion("ArchivosConfiguracion\\datosConfiguracion", "Jefe de Especialidad de Comerci", "*"), dato5);
                    break;

                case "Superintendente General de Comercio Exterior":
                    objeto.extraerDatosCombobox(objeto.iniciarConexcion("ArchivosConfiguracion\\datosConfiguracion", "Superintendente General de Come", "*"), dato5);
                    break;

                case "Subgerente de Comercio Exterior":
                    objeto.extraerDatosCombobox(objeto.iniciarConexcion("ArchivosConfiguracion\\datosConfiguracion", "Subgerente de Comercio Exterior", "*"), dato5);
                    break;

                case "Especialidad Ventas Nacionales":
                    objeto.extraerDatosCombobox(objeto.iniciarConexcion("ArchivosConfiguracion\\datosConfiguracion", "Especialidad Ventas Nacionales", "*"), dato5);
                    break;

                case "Especialista de Mercadotecnia":
                    objeto.extraerDatosCombobox(objeto.iniciarConexcion("ArchivosConfiguracion\\datosConfiguracion", "Especialista de Mercadotecnia", "*"), dato5);
                    break;

                case "Jefe de Especialidad de Mercadotecnia":
                    objeto.extraerDatosCombobox(objeto.iniciarConexcion("ArchivosConfiguracion\\datosConfiguracion", "Jefe de Especialidad de Mercado", "*"), dato5);
                    break;

                case "Superintendente General de Mercadotecnia":
                    objeto.extraerDatosCombobox(objeto.iniciarConexcion("ArchivosConfiguracion\\datosConfiguracion", "Superintendente General de Merc", "*"), dato5);
                    break;

                case "Subgerente de Mercadotecnia":
                    objeto.extraerDatosCombobox(objeto.iniciarConexcion("ArchivosConfiguracion\\datosConfiguracion", "Subgerente de Mercadotecnia", "*"), dato5);
                    break;

                case "Especialista de Precios":
                    objeto.extraerDatosCombobox(objeto.iniciarConexcion("ArchivosConfiguracion\\datosConfiguracion", "Especialista de Precios", "*"), dato5);
                    break;

                case "Jefe de Especialidad de Precios":
                    objeto.extraerDatosCombobox(objeto.iniciarConexcion("ArchivosConfiguracion\\datosConfiguracion", "Jefe de Especialidad de Precios", "*"), dato5);
                    break;

                case "Superintendente General de Precios":
                    objeto.extraerDatosCombobox(objeto.iniciarConexcion("ArchivosConfiguracion\\datosConfiguracion", "Superintendente General de Prec", "*"), dato5);
                    break;

                case "Subgerente de Precios":
                    objeto.extraerDatosCombobox(objeto.iniciarConexcion("ArchivosConfiguracion\\datosConfiguracion", "Subgerente de Precios", "*"), dato5);
                    break;

                case "Analista de Coordinación Comercial y Operativa":
                    objeto.extraerDatosCombobox(objeto.iniciarConexcion("ArchivosConfiguracion\\datosConfiguracion", "Analista de Coordinación Comerc", "*"), dato5);
                    break;

                case "Jefe de Área de Coordinación Operativa Comercial":
                    objeto.extraerDatosCombobox(objeto.iniciarConexcion("ArchivosConfiguracion\\datosConfiguracion", "Jefe de Área de Coordinación Op", "*"), dato5);
                    break;

                case "Analista Junior de Coordinación Operativa Comercial":
                    objeto.extraerDatosCombobox(objeto.iniciarConexcion("ArchivosConfiguracion\\datosConfiguracion", "Analista Junior de Coordinación", "*"), dato5);
                    break;

                case "Subgerente de Coordinación Operativa Comercial":
                    objeto.extraerDatosCombobox(objeto.iniciarConexcion("ArchivosConfiguracion\\datosConfiguracion", "Subgerente de Coordinación Oper", "*"), dato5);
                    break;

                case "Especialista de Coordinación Comercial y Operativa":
                    objeto.extraerDatosCombobox(objeto.iniciarConexcion("ArchivosConfiguracion\\datosConfiguracion", "Especialista de Coordinación Co", "*"), dato5);
                    break;

                case "Analista de Coordinación Operativa Comercial":
                    objeto.extraerDatosCombobox(objeto.iniciarConexcion("ArchivosConfiguracion\\datosConfiguracion", "Analista de Coordinación Operat", "*"), dato5);
                    break;

                case "Técnico de Mantto Ductos":
                    objeto.extraerDatosCombobox(objeto.iniciarConexcion("ArchivosConfiguracion\\datosConfiguracion", "Técnico de Mantto Ductos", "*"), dato5);
                    break;

                case "Técnico Especializado de Mantto Ductos":
                    objeto.extraerDatosCombobox(objeto.iniciarConexcion("ArchivosConfiguracion\\datosConfiguracion", "Técnico Especializado de Mantto", "*"), dato5);
                    break;

                case "Especialista de Mantto Ductos":
                    objeto.extraerDatosCombobox(objeto.iniciarConexcion("ArchivosConfiguracion\\datosConfiguracion", "Especialista de Mantto Ductos", "*"), dato5);
                    break;

                case "Especialista Técnico de Mantto Ductos":
                    objeto.extraerDatosCombobox(objeto.iniciarConexcion("ArchivosConfiguracion\\datosConfiguracion", "Especialista Técnico de Mantto", "*"), dato5);
                    break;

                case "Jefe de Área de Mantto Ductos":
                    objeto.extraerDatosCombobox(objeto.iniciarConexcion("ArchivosConfiguracion\\datosConfiguracion", "Jefe de Área de Mantto Ductos", "*"), dato5);
                    break;

                case "Jefe de Especialidad Técnica de Mantto Ductos":
                    objeto.extraerDatosCombobox(objeto.iniciarConexcion("ArchivosConfiguracion\\datosConfiguracion", "Jefe de Especialidad Técnica de", "*"), dato5);
                    break;

                case "Superintendente de Especialidad de Mantto Ductos":
                    objeto.extraerDatosCombobox(objeto.iniciarConexcion("ArchivosConfiguracion\\datosConfiguracion", "Superintendente de Especialidad", "*"), dato5);
                    break;

                case "Superintendente General de Mantto Ductos":
                    objeto.extraerDatosCombobox(objeto.iniciarConexcion("ArchivosConfiguracion\\datosConfiguracion", "Superintendente General de Mant", "*"), dato5);
                    break;

                case "Subgerente de Mantto Ductos":
                    objeto.extraerDatosCombobox(objeto.iniciarConexcion("ArchivosConfiguracion\\datosConfiguracion", "Subgerente de Mantto Ductos", "*"), dato5);
                    break;

                case "Especialista de Mantenimiento Mecánico Estático":
                    objeto.extraerDatosCombobox(objeto.iniciarConexcion("ArchivosConfiguracion\\datosConfiguracion", "Especialista de Mantenimiento M", "*"), dato5);
                    break;

                case "Especialista Técnico de Mantenimiento Mecánico Estático":
                    objeto.extraerDatosCombobox(objeto.iniciarConexcion("ArchivosConfiguracion\\datosConfiguracion", "Especialista Técnico de Manteni", "*"), dato5);
                    break;

                case "Superintendente de Especialidad de Mantenimiento Mecánico Estático":
                    objeto.extraerDatosCombobox(objeto.iniciarConexcion("ArchivosConfiguracion\\datosConfiguracion", "Superintendente Mantenimiento M", "*"), dato5);
                    break;

                case "Superintendente General de Mantenimiento Mecánico Estático":
                    objeto.extraerDatosCombobox(objeto.iniciarConexcion("ArchivosConfiguracion\\datosConfiguracion", "Superintendente General", "*"), dato5);
                    break;

                case "Técnico Especializado de Mantenimiento Mecánico Estático":
                    objeto.extraerDatosCombobox(objeto.iniciarConexcion("ArchivosConfiguracion\\datosConfiguracion", "Técnico Especializado de Manten", "*"), dato5);
                    break;

                case "Jefe de Área de Mantenimiento Mecánico Estático":
                    objeto.extraerDatosCombobox(objeto.iniciarConexcion("ArchivosConfiguracion\\datosConfiguracion", "Jefe de Área de Mantenimiento M", "*"), dato5);
                    break;

                case "Jefe de Especialidad Técnica de Mantenimiento Mecánico Estático":
                    objeto.extraerDatosCombobox(objeto.iniciarConexcion("ArchivosConfiguracion\\datosConfiguracion", "Jefe de Especialidad", "*"), dato5);
                    break;

                case "Especialista Líder en Mantenimiento Mecánico Estático Plantas":
                    objeto.extraerDatosCombobox(objeto.iniciarConexcion("ArchivosConfiguracion\\datosConfiguracion", "Especialista Líder en Mantenimi", "*"), dato5);
                    break;

                case "Superintendente de Especialidad de Mantenimiento General en Terminales":
                    objeto.extraerDatosCombobox(objeto.iniciarConexcion("ArchivosConfiguracion\\datosConfiguracion", "Superintendente Mantenimiento T", "*"), dato5);
                    break;

                case "Especialista Técnico en Mantenimiento General en Terminales":
                    objeto.extraerDatosCombobox(objeto.iniciarConexcion("ArchivosConfiguracion\\datosConfiguracion", "Especialista Técnico en Manteni", "*"), dato5);
                    break;

                case "Superintendente General de Mantenimiento General en Terminales":
                    objeto.extraerDatosCombobox(objeto.iniciarConexcion("ArchivosConfiguracion\\datosConfiguracion", "Superintendente Mantenimiento G", "*"), dato5);
                    break;

                case "Técnico Especializado de Mantenimiento General en Terminales":
                    objeto.extraerDatosCombobox(objeto.iniciarConexcion("ArchivosConfiguracion\\datosConfiguracion", "Técnico Especializado", "*"), dato5);
                    break;

                case "Especialista de Mantenimiento General en Terminales":
                    objeto.extraerDatosCombobox(objeto.iniciarConexcion("ArchivosConfiguracion\\datosConfiguracion", "Especialista de Mantenimiento G", "*"), dato5);
                    break;

                case "Jefe de Área de Mantenimiento General en Terminales":
                    objeto.extraerDatosCombobox(objeto.iniciarConexcion("ArchivosConfiguracion\\datosConfiguracion", "Jefe de Área de Mantenimiento G", "*"), dato5);
                    break;

                case "Jefe de Especialidad Técnica de Mantenimiento General en Terminales":
                    objeto.extraerDatosCombobox(objeto.iniciarConexcion("ArchivosConfiguracion\\datosConfiguracion", "Jefe de Especialidad en Termina", "*"), dato5);
                    break;

                case "Subgerente de Mantenimiento General en Terminales":
                    objeto.extraerDatosCombobox(objeto.iniciarConexcion("ArchivosConfiguracion\\datosConfiguracion", "Subgerente de Mantenimiento Gen", "*"), dato5);
                    break;

                case "Superintendente General de Inspección Técnica":
                    objeto.extraerDatosCombobox(objeto.iniciarConexcion("ArchivosConfiguracion\\datosConfiguracion", "Superintendente General de Insp", "*"), dato5);
                    break;

                case "Especialista Líder de Inspección Técnica":
                    objeto.extraerDatosCombobox(objeto.iniciarConexcion("ArchivosConfiguracion\\datosConfiguracion", "Especialista Líder de Inspecció", "*"), dato5);
                    break;

                case "Especialista Técnico de Inspección Técnica":
                    objeto.extraerDatosCombobox(objeto.iniciarConexcion("ArchivosConfiguracion\\datosConfiguracion", "Especialista Técnico de Inspecc", "*"), dato5);
                    break;

                case "Especialista de Inspección Técnica":
                    objeto.extraerDatosCombobox(objeto.iniciarConexcion("ArchivosConfiguracion\\datosConfiguracion", "Especialista de Inspección Téc", "*"), dato5);
                    break;

                case "Jefe de Especialidad de Inspección Técnica":
                    objeto.extraerDatosCombobox(objeto.iniciarConexcion("ArchivosConfiguracion\\datosConfiguracion", "Jefe de Especialidad de Inspecc", "*"), dato5);
                    break;

                case "Técnico Especializado de Inspección Técnica":
                    objeto.extraerDatosCombobox(objeto.iniciarConexcion("ArchivosConfiguracion\\datosConfiguracion", "Técnico Especializado de Inspec", "*"), dato5);
                    break;

                case "Ingeniero de Medición PGPB PROD":
                    objeto.extraerDatosCombobox(objeto.iniciarConexcion("ArchivosConfiguracion\\datosConfiguracion", "Ingeniero de Medición PGPB PROD", "*"), dato5);
                    break;

                case "Jefe de Especialidad de Medición PGPB PROD":
                    objeto.extraerDatosCombobox(objeto.iniciarConexcion("ArchivosConfiguracion\\datosConfiguracion", "Jefe de Especialidad de Medició", "*"), dato5);
                    break;

                case "Especialista de Medición PGPB PROD":
                    objeto.extraerDatosCombobox(objeto.iniciarConexcion("ArchivosConfiguracion\\datosConfiguracion", "Especialista de Medición PGPB P", "*"), dato5);
                    break;

                case "Ingeniero de Medición DUCTOS":
                    objeto.extraerDatosCombobox(objeto.iniciarConexcion("ArchivosConfiguracion\\datosConfiguracion", "Ingeniero de Medición DUCTOS", "*"), dato5);
                    break;

                case "Jefe de Especialidad de Medición DUCTOS":
                    objeto.extraerDatosCombobox(objeto.iniciarConexcion("ArchivosConfiguracion\\datosConfiguracion", "Jefe de Especialidad DUCTOS", "*"), dato5);
                    break;

                case "Especialista de Medición DUCTOS":
                    objeto.extraerDatosCombobox(objeto.iniciarConexcion("ArchivosConfiguracion\\datosConfiguracion", "Especialista de Medición DUCTOS", "*"), dato5);
                    break;

                case "Ingeniero de Medición PPQ OPER":
                    objeto.extraerDatosCombobox(objeto.iniciarConexcion("ArchivosConfiguracion\\datosConfiguracion", "Ingeniero de Medición PPQ OPER", "*"), dato5);
                    break;

                case "Jefe de Especialidad de Medición PPQ OPER":
                    objeto.extraerDatosCombobox(objeto.iniciarConexcion("ArchivosConfiguracion\\datosConfiguracion", "Jefe de Especialidad PPQ OPER", "*"), dato5);
                    break;

                case "Especialista de Medición PPQ OPER":
                    objeto.extraerDatosCombobox(objeto.iniciarConexcion("ArchivosConfiguracion\\datosConfiguracion", "Especialista de Medición PPQ OP", "*"), dato5);
                    break;

                case "Mantenimiento de Instrumentación y Control (REFINERIAS, CPG'S Y CPQ)":
                    objeto.extraerDatosCombobox(objeto.iniciarConexcion("ArchivosConfiguracion\\datosConfiguracion", "Mantenimiento de Instrumentació", "*"), dato5);
                    break;

                case "Ingeniero de Medición TAR´S":
                    objeto.extraerDatosCombobox(objeto.iniciarConexcion("ArchivosConfiguracion\\datosConfiguracion", "Ingeniero de Medición TAR´S", "*"), dato5);
                    break;

                case "Jefe de Especialidad de Medición TAR´S":
                    objeto.extraerDatosCombobox(objeto.iniciarConexcion("ArchivosConfiguracion\\datosConfiguracion", "Jefe de Especialidad TAR´S", "*"), dato5);
                    break;

                case "Especialista de Medición TAR´S":
                    objeto.extraerDatosCombobox(objeto.iniciarConexcion("ArchivosConfiguracion\\datosConfiguracion", "Especialista de Medición TAR´S", "*"), dato5);
                    break;

                case "Ingeniero de Medición PEP PROD":
                    objeto.extraerDatosCombobox(objeto.iniciarConexcion("ArchivosConfiguracion\\datosConfiguracion", "Ingeniero de Medición PEP PROD", "*"), dato5);
                    break;

                case "Jefe de Especialidad de Medición PEP PROD":
                    objeto.extraerDatosCombobox(objeto.iniciarConexcion("ArchivosConfiguracion\\datosConfiguracion", "Jefe de Especialidad PEP PROD", "*"), dato5);
                    break;

                case "Especialista de Medición PEP PROD":
                    objeto.extraerDatosCombobox(objeto.iniciarConexcion("ArchivosConfiguracion\\datosConfiguracion", "Especialista de Medición PEP PR", "*"), dato5);
                    break;

                case "Ingeniero de Medición PXR PROD":
                    objeto.extraerDatosCombobox(objeto.iniciarConexcion("ArchivosConfiguracion\\datosConfiguracion", "Ingeniero de Medición PXR PROD", "*"), dato5);
                    break;

                case "Jefe de Especialidad de Medición PXR PROD":
                    objeto.extraerDatosCombobox(objeto.iniciarConexcion("ArchivosConfiguracion\\datosConfiguracion", "Jefe de Especialidad PXR PROD", "*"), dato5);
                    break;

                case "Especialista de Medición PXR PROD":
                    objeto.extraerDatosCombobox(objeto.iniciarConexcion("ArchivosConfiguracion\\datosConfiguracion", "Especialista de Medición PXR PR", "*"), dato5);
                    break;

                case "Ingeniero de Medición TDGL'S":
                    objeto.extraerDatosCombobox(objeto.iniciarConexcion("ArchivosConfiguracion\\datosConfiguracion", "Ingeniero de Medición TDGL'S", "*"), dato5);
                    break;

                case "Jefe de Especialidad de Medición TDGL´S":
                    objeto.extraerDatosCombobox(objeto.iniciarConexcion("ArchivosConfiguracion\\datosConfiguracion", "Jefe de Especialidad TDGL´S", "*"), dato5);
                    break;

                case "Especialista de Medición TDGL´S":
                    objeto.extraerDatosCombobox(objeto.iniciarConexcion("ArchivosConfiguracion\\datosConfiguracion", "Especialista de Medición TDGL´S", "*"), dato5);
                    break;

                case "Jefe de Especialidad de Medición Base":
                    objeto.extraerDatosCombobox(objeto.iniciarConexcion("ArchivosConfiguracion\\datosConfiguracion", "Jefe de Medición Base", "*"), dato5);
                    break;

                case "Especialista de Medición Base":
                    objeto.extraerDatosCombobox(objeto.iniciarConexcion("ArchivosConfiguracion\\datosConfiguracion", "Especialista de Medición Base", "*"), dato5);
                    break;

                case "Ingeniero de Medición Base":
                    objeto.extraerDatosCombobox(objeto.iniciarConexcion("ArchivosConfiguracion\\datosConfiguracion", "Ingeniero de Medición Base", "*"), dato5);
                    break;

                case "Técnico Especializado de Mantenimiento Eléctrico":
                    objeto.extraerDatosCombobox(objeto.iniciarConexcion("ArchivosConfiguracion\\datosConfiguracion", "Técnico Mantenimiento Eléctrico", "*"), dato5);
                    break;

                case "Especialista de Mantenimiento Eléctrico":
                    objeto.extraerDatosCombobox(objeto.iniciarConexcion("ArchivosConfiguracion\\datosConfiguracion", "Especialista de Mantenimiento E", "*"), dato5);
                    break;

                case "Especialista Técnico de Mantenimiento Eléctrico":
                    objeto.extraerDatosCombobox(objeto.iniciarConexcion("ArchivosConfiguracion\\datosConfiguracion", "Especialista Mantenimiento Eléc", "*"), dato5);
                    break;

                case "Superintendente General de Mantenimiento Eléctrico":
                    objeto.extraerDatosCombobox(objeto.iniciarConexcion("ArchivosConfiguracion\\datosConfiguracion", "Superintendente Mantenimiento E", "*"), dato5);
                    break;

                case "Especialista Lider en Mantenimiento Eléctrico":
                    objeto.extraerDatosCombobox(objeto.iniciarConexcion("ArchivosConfiguracion\\datosConfiguracion", "Especialista Lider en Mantenimi", "*"), dato5);
                    break;

                case "Jefe de Especialidad Técnica de Mantenimiento Eléctrico":
                    objeto.extraerDatosCombobox(objeto.iniciarConexcion("ArchivosConfiguracion\\datosConfiguracion", "Jefe Mantenimiento Eléctrico", "*"), dato5);
                    break;

                case "Superintendente de Especialidad de Mantenimiento Eléctrico":
                    objeto.extraerDatosCombobox(objeto.iniciarConexcion("ArchivosConfiguracion\\datosConfiguracion", "Superintendente Eléctrico", "*"), dato5);
                    break;

                case "Subgerente de Mantenimiento Eléctrico":
                    objeto.extraerDatosCombobox(objeto.iniciarConexcion("ArchivosConfiguracion\\datosConfiguracion", "Subgerente de Mantenimiento Elé", "*"), dato5);
                    break;

                case "Jefe de Área de Mantenimiento Eléctrico":
                    objeto.extraerDatosCombobox(objeto.iniciarConexcion("ArchivosConfiguracion\\datosConfiguracion", "Jefe de Área de Mantenimiento E", "*"), dato5);
                    break;

                case "Mantenimiento de Instrumentación y Control":
                    objeto.extraerDatosCombobox(objeto.iniciarConexcion("ArchivosConfiguracion\\datosConfiguracion", "Mantenimiento de Instrumen", "*"), dato5);
                    break;

                default:
                    objeto.extraerDatosCombobox(objeto.iniciarConexcion("ArchivosConfiguracion\\datosConfiguracion", dato3.GetItemText(dato3.SelectedItem), "*"), dato5);
                    break;

            }

            dato5.Text = "--  Selecciona la Opcion  --";

        }

        private void dato4_SelectedIndexChanged(object sender, EventArgs e)
        {

            

        }

    }

}
