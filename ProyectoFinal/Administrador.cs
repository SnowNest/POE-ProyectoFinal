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
    public partial class Administrador : Form
    {
        public Administrador()
        {
            InitializeComponent();
        }

        private void btnIngresoTienda_Click(object sender, EventArgs e)
        {
            Tienda abrirVentana = new Tienda();
            abrirVentana.Show();
        }

        private void btnAdministrarUsuarios_Click(object sender, EventArgs e)
        {
            AdmninistrarUsuarios abrirVentana = new AdmninistrarUsuarios();
            abrirVentana.Show();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAdministrarTienda_Click(object sender, EventArgs e)
        {

        }

        private void Administrador_Load(object sender, EventArgs e)
        {

        }
    }
}
