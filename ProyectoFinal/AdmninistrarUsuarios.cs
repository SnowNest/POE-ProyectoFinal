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
    public partial class AdmninistrarUsuarios : Form
    {
        ClsBaseDatos bd = new ClsBaseDatos();
        public AdmninistrarUsuarios()
        {
            InitializeComponent();
        }

        public void bloqueo()
        {
            txtNombre.Enabled = false;
            txtUsuario.Enabled = false;
            txtContrasena.Enabled = false;
            btnAgregar.Enabled = false;
            btnBorrar.Enabled = false;
            btnBuscar.Enabled = false;
            btnModificar.Enabled = false;
            chbxAdministraor.Enabled = false;
        }
        
        private void AdmninistrarUsuarios_Load(object sender, EventArgs e)
        {
            bloqueo();
        }

        private void btnOpcionBorrar_Click(object sender, EventArgs e)
        {
            bloqueo();
            txtUsuario.Enabled = true;
            btnBorrar.Enabled = true;
            lblOpcion.Text = "BORRAR:";
            return;            
        }

        private void btnOpcionBuscar_Click(object sender, EventArgs e)
        {
            bloqueo();
            MessageBox.Show("Para modificar un usuario primero se nececita validar el usuario, posteriormente se desbloquean los campos a modificar");
            txtUsuario.Enabled = true;
            btnBuscar.Enabled = true;
            lblOpcion.Text = "BUSCAR:";
            return;
        }

        private void btnOpcionAgregar_Click(object sender, EventArgs e)
        {
            bloqueo();
            txtNombre.Enabled = true;
            txtUsuario.Enabled = true;
            txtContrasena.Enabled = true;
            btnAgregar.Enabled = true;
            chbxAdministraor.Enabled = true;
            lblOpcion.Text = "AGREGAR:";
            return;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

            if (bd.validarUsuario(txtUsuario.Text) == false)
            {
                bloqueo();
                txtNombre.Enabled = true;
                txtContrasena.Enabled = true;
                chbxAdministraor.Enabled = true;
                btnModificar.Enabled = true;
                lblOpcion.Text = "MODIFICAR "+ txtUsuario.Text +":";
            }
            else
            {
                MessageBox.Show("El usuario: " + txtUsuario.Text +" no existe" );
                txtUsuario.Clear();
            }           
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            bd.agregarUsuario(txtNombre.Text, txtUsuario.Text, txtContrasena.Text, chbxAdministraor.Checked ? "1" : "0");
            txtUsuario.Clear();
            txtNombre.Clear();
            txtContrasena.Clear();
            chbxAdministraor.Checked = false;

        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            bd.borrarUsuario(txtUsuario.Text);
            txtUsuario.Clear();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            bd.buscarUsuario(txtNombre.Text, txtUsuario.Text, txtContrasena.Text, chbxAdministraor.Checked ? "1" : "0");
            txtUsuario.Clear();
            txtNombre.Clear();
            txtContrasena.Clear();
            chbxAdministraor.Checked = false;

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}