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
    public partial class Tienda : Form
    {
        ClsCompras compra = new ClsCompras();
        public Tienda()
        {
            InitializeComponent();
        }

        private void Tienda_Load(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cbCategorias_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbProducto.Items.Clear();
            lbprecios.Items.Clear();
            switch (Convert.ToString(cbCategorias.Text))
            {
                case "Pintura":
                    cbProducto.Items.Insert(0, "cuarto de galon");
                    cbProducto.Items.Insert(1, "medio galon");
                    cbProducto.Items.Insert(2, "galon");
                    cbProducto.Items.Insert(3, "colorante");
                    cbProducto.Items.Insert(4, "esmalte");
                    cbProducto.Items.Insert(5, "aerosol");
                    lbprecios.Items.Add("cuarto de galon...$50");
                    lbprecios.Items.Add("medio galon.......$80");
                    lbprecios.Items.Add("galon.............$190");
                    lbprecios.Items.Add("colorante.........$50");
                    lbprecios.Items.Add("esmalte...........$70");
                    lbprecios.Items.Add("aerosol...........$60");
                    break;

                case "Plomeria":
                    cbProducto.Items.Insert(0, "minas");
                    cbProducto.Items.Insert(1, "pegamentos");
                    cbProducto.Items.Insert(2, "tuberia");
                    cbProducto.Items.Insert(3, "codos");
                    cbProducto.Items.Insert(4, "tapas");
                    cbProducto.Items.Insert(5, "tuberia de cobre");
                    lbprecios.Items.Add("minas.................$30");
                    lbprecios.Items.Add("pegamentos............$15");
                    lbprecios.Items.Add("tuberia...............$20");
                    lbprecios.Items.Add("codos.................$10");
                    lbprecios.Items.Add("tapas.................$20");
                    lbprecios.Items.Add("tuberia de cobre(m)...$50");

                    break;
                case "Electrico":
                    cbProducto.Items.Insert(0, "rollo de cable");
                    cbProducto.Items.Insert(1, "contactos");
                    cbProducto.Items.Insert(2, "apagadores");
                    cbProducto.Items.Insert(3, "zocalos de focos");
                    cbProducto.Items.Insert(4, "tuberia");
                    cbProducto.Items.Insert(5, "fusibles");
                    lbprecios.Items.Add("rollo de cable.....$500");
                    lbprecios.Items.Add("contactos..........$30");
                    lbprecios.Items.Add("apagadores.........$20");
                    lbprecios.Items.Add("zocalos de focos...$10");
                    lbprecios.Items.Add("tuberia............$40");
                    lbprecios.Items.Add("fusibles...........$30");

                    break;
                case "Herramientas":
                    cbProducto.Items.Insert(0, "taladro");
                    cbProducto.Items.Insert(1, "martillo");
                    cbProducto.Items.Insert(2, "desarmador");
                    cbProducto.Items.Insert(3, "segueta");
                    cbProducto.Items.Insert(4, "remachadora");
                    cbProducto.Items.Insert(5, "soldador");
                    lbprecios.Items.Add("taladro......$1500");
                    lbprecios.Items.Add("martillo.......$50");
                    lbprecios.Items.Add("desarmador.....$10");
                    lbprecios.Items.Add("segueta........$50");
                    lbprecios.Items.Add("remachadora...$200");
                    lbprecios.Items.Add("soldador......$100");
                    break;
                default:
                    Console.WriteLine("Seleccione una opcion");
                    break;
            }
        }

        private void cbProducto_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAgregarCarrito_Click(object sender, EventArgs e)
        {

            try
            {
                if (Convert.ToInt32(txtCantidad.Text) > 0)
                {
                    if (compra.validarstock(Convert.ToInt32(txtCantidad.Text) , Convert.ToString(cbProducto.Text)) == true)
                    {
                        compra.creartiket(Convert.ToInt32(txtCantidad.Text), Convert.ToString(cbProducto.Text));
                        lbCarrito.Items.Add("[" + Convert.ToInt32(txtCantidad.Text) + "]---" + Convert.ToString(cbProducto.Text));
                        MessageBox.Show("Se agrego el carrito");
                    }
                    else
                    {
                        MessageBox.Show("No hay stock suficiente. Intente con otra cantidad inferior");
                    }
                }
                else
                {
                    MessageBox.Show("Ingrese por lo menos 1 a cantidaad");
                }
            }
            catch
            {
                MessageBox.Show("Ingrese una cantidad correcta");
            }
        }

        private void txtCantidad_TextChanged(object sender, EventArgs e)
        {
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCompra_Click(object sender, EventArgs e)
        {

        }
    }
}
