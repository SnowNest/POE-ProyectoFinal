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
    public partial class AdministrarTienda : Form
    {
        ClsBaseDatosTienda tienda = new ClsBaseDatosTienda();

        public AdministrarTienda()
        {
            InitializeComponent();
        }

        void bloqueo()
        {
            btnActualizar.Enabled = false;
            btnAgregar.Enabled = false;
            btnBorrar.Enabled = false;
            cbCategoria.Enabled = false;
            cbProducto.Enabled = false;
            txtStock.Enabled = false;
            txtStock.Text = "";
            label1.Text = "Stock";

        }

        private void btnOpcionEliminar_Click(object sender, EventArgs e)
        {
            bloqueo();
            cbCategoria.Enabled = true;
            cbProducto.Enabled = true;
            btnBorrar.Enabled = true;
            lblOpcion.Text = "Eliminar Producto";
        }

        private void btnOpcionAgregarProducto_Click(object sender, EventArgs e)
        {
            bloqueo();
            lblOpcion.Text = "Agregar Producto";
            lblOpcion.Text = "Modificar Stock";
            btnAgregar.Enabled = true;
            cbCategoria.Enabled = true;
            txtStock.Enabled = true;
            label1.Text = "ADD";
            MessageBox.Show("Seleccione la categoria y agrege");
        }

        private void btnModificarStock_Click(object sender, EventArgs e)
        {
            bloqueo();
            lblOpcion.Text = "Modificar Stock";            
            btnActualizar.Enabled = true;
            cbCategoria.Enabled = true;
            cbProducto.Enabled = true;
            txtStock.Enabled = true;
            MessageBox.Show("Modifique el stock y de en actualizar");

        }

        private void AdministrarTienda_Load(object sender, EventArgs e)
        {
            bloqueo();
        }

        private void cbCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbProducto.Items.Clear();            
            switch (Convert.ToString(cbCategoria.Text))
            {
                case "Pintura":
                    cbProducto.Items.Insert(0, "cuarto de galon");
                    cbProducto.Items.Insert(1, "medio galon");
                    cbProducto.Items.Insert(2, "galon");
                    cbProducto.Items.Insert(3, "colorante");
                    cbProducto.Items.Insert(4, "esmalte");
                    cbProducto.Items.Insert(5, "aerosol");                    
                    break;

                case "Plomeria":
                    cbProducto.Items.Insert(0, "minas");
                    cbProducto.Items.Insert(1, "pegamentos");
                    cbProducto.Items.Insert(2, "tuberia");
                    cbProducto.Items.Insert(3, "codos");
                    cbProducto.Items.Insert(4, "tapas");
                    cbProducto.Items.Insert(5, "tuberia de cobre");
                    break;

                case "Electrico":
                    cbProducto.Items.Insert(0, "rollo de cable");
                    cbProducto.Items.Insert(1, "contactos");
                    cbProducto.Items.Insert(2, "apagadores");
                    cbProducto.Items.Insert(3, "zocalos de focos");
                    cbProducto.Items.Insert(4, "tuberia");
                    cbProducto.Items.Insert(5, "fusibles");
                    break;

                case "Herramientas":
                    cbProducto.Items.Insert(0, "taladro");
                    cbProducto.Items.Insert(1, "martillo");
                    cbProducto.Items.Insert(2, "desarmador");
                    cbProducto.Items.Insert(3, "segueta");
                    cbProducto.Items.Insert(4, "remachadora");
                    cbProducto.Items.Insert(5, "soldador");
                    break;

                default:
                    Console.WriteLine("Seleccione una opcion");
                    break;
            }
        }

        private void cbProducto_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtStock.Text = tienda.stock(cbProducto.Text);
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if(cbProducto.Text != "" & txtStock.Text != "")
            {
                
                tienda.actualizarStock(cbProducto.Text, txtStock.Text);
            }
            else
            {
                MessageBox.Show("Seleccione un producto y modifique la cantidad");
            }

            txtStock.Text = "";
            
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (cbCategoria.Text != "" & txtStock.Text != "")
            {
                tienda.agregarrStock(cbProducto.Text, cbCategoria.Text);
            }
            else
            {
                MessageBox.Show("Seleccione un producto y modifique la cantidad");
            }

            txtStock.Text = "";
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (cbProducto.Text != "")
            {
                tienda.eliminar(cbProducto.Text);
            }
            else
            {
                MessageBox.Show("Seleccione un producto");
            }
        }
    }
}
