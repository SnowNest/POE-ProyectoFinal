using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinal
{
    public partial class Acceso : Form
    {
        ClsBaseDatos bd = new ClsBaseDatos();
        public Acceso()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Acceso_Load(object sender, EventArgs e)
        {

        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text != "" & txtContrasena.Text != "")
            {
                if (bd.validarUsuario(txtUsuario.Text) == false)
                {
                    ClsBaseDatos iniciarSesion = new ClsBaseDatos();
                    iniciarSesion.iniciarSesion(txtUsuario.Text, txtContrasena.Text);
                    txtContrasena.Clear();
                    txtUsuario.Clear();
                }
                else
                {
                    MessageBox.Show("El usuario: " + txtUsuario.Text + " no existe");
                    txtUsuario.Clear();
                }
            }
            else
            {
                MessageBox.Show("Falta usuario y/o contraseña");
            }               
        }
    }
}
