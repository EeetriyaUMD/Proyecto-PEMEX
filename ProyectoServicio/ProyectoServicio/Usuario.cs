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
    public partial class Usuario : Form
    {

        LecturaEscrituraArchivo objeto = null;
        public string operacionUsuario = "";
        public string usuario;

        public Usuario(string operacionusuario)
        {
            
            objeto = new LecturaEscrituraArchivo();
            operacionUsuario = operacionusuario;
            InitializeComponent();
            contruccionOperacion();

        }

        private void contruccionOperacion()
        {

            switch (operacionUsuario)
            {

                case "eliminar":
                    privilegio.Visible = false;
                    button2.Text = "Eliminar";
                    label2.Visible = false;
                    break;

            }

        }

        private void button1_Click(object sender, EventArgs e)
        {

            this.Dispose();

        }

        private void button2_Click(object sender, EventArgs e)
        {

            switch(operacionUsuario){

                case "nuevo":
                    if (privilegio.SelectedIndex == -1 || folio.Text.Equals(""))
                    {

                        MessageBox.Show("Se debera ingresar una nueva ficha y un privilegio,\nsi se quiere ingresar nuevo usuario.\nVerificar datos.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                    else
                    {

                        switch (privilegio.SelectedIndex)
                        {

                            case 0:
                                MessageBox.Show("Usuario nuevo guardado como:\nFicha: " + folio.Text + "\nPrivolegio: Administrador", "Aplicacion PEMEX", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                objeto.guardarArchuivo(folio.Text + "-A", "User.txt", true);
                                this.Dispose();
                                break;

                            case 1:
                                MessageBox.Show("Usuario nuevo guardado como:\nFicha: " + folio.Text + "\nPrivolegio: de Usuario", "Aplicacion PEMEX", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                objeto.guardarArchuivo(folio.Text + "-U", "User.txt", true);
                                this.Dispose();
                                break;

                            case 2:
                                MessageBox.Show("Usuario nuevo guardado como:\nFicha: " + folio.Text + "\nPrivolegio: Invitado", "Aplicacion PEMEX", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                objeto.guardarArchuivo(folio.Text + "-V", "User.txt", true);
                                this.Dispose();
                                break;

                        }

                    }
                    break;

                case "eliminar":
                    if (folio.Text.Equals(""))
                    {

                        MessageBox.Show("Se debera ingresar una ficha para su eliminacion.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                    else
                    {

                        if(!folio.Text.Equals(usuario)){

                            List<string> lista = objeto.leerArchuivo("User.txt");
                            string usu = "";

                            foreach (string x in lista)
                            {

                                if (x.IndexOf(folio.Text + "-A") != -1 || x.IndexOf(folio.Text + "-U") != -1 || x.IndexOf(folio.Text + "-V") != -1)
                                {

                                    usu = x;
                                    
                                }
                       
                            }

                            if (!usu.Equals(""))
                            {

                                lista.Remove(usu);
                                MessageBox.Show("Sea borrado con exito la Ficha: " + folio.Text, "Aplicacion PEMEX", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                objeto.guardarArchuivo(lista, "User.txt", false);
                                this.Dispose();

                            }
                            else
                            {

                                MessageBox.Show("No existe la ficha por tal motivo no se borro.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                folio.Text = "";

                            }
                            
                        }
                        else
                        {

                            MessageBox.Show("No se puede eliminar al folio que estas usando.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }
                        
                    }
                    break;

            }

        }
        public void Sesion(String usuario)
        {

            this.usuario = usuario;

        }

    }

}
