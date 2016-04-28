using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ProyectoServicio
{
    public partial class InicioSesion : Form
    {

        public InicioSesion()
        {
            InitializeComponent();
        }

        private void ingresar_Click(object sender, EventArgs e)
        {

            if (!text1.Text.Equals(""))
            {

                evaluacionUsuario(text1.Text, new LecturaEscrituraArchivo().leerArchuivo("User.txt"));
                
            }
            else
            {

                MessageBox.Show("Necesitas ingresar una ficha.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);

            }

        }

        public void evaluacionUsuario(String user, List<string> users)
        {

            if (users.IndexOf(user + "-A") != -1 || users.IndexOf(user + "-U") != -1 || users.IndexOf(user + "-V") != -1)
            {

                InicioEjecucion objeto = new InicioEjecucion();
                objeto.Sesion(text1.Text);
                objeto.asignacionPrivilegios(text1.Text, users);
                objeto.Show();
                this.Hide();

            }
            else
            {

                MessageBox.Show("El numero de la ficha no existe en el sistema.", "Aplicacion PEMEX", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                text1.Text = "";

            }

        }

        private void cancelar_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Estas seguro de salir de la aplicaion.", "Aplicacion PEMEX", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                Application.Exit();

            }

        }

        private void Salir(object sender, FormClosingEventArgs e)
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

    }
}
