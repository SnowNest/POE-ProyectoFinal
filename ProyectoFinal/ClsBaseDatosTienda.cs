using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace ProyectoFinal
{
    public class ClsBaseDatosTienda
    {
        OleDbConnection conexion = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:/Users/nesto/Desktop/ProyectoFinal/DBProyecto.mdb");

        public string stock(string producto)
        {
            OleDbCommand consulta = new OleDbCommand("SELECT * FROM PRODUCTOS", conexion);
            conexion.Open();
            OleDbDataReader reader = consulta.ExecuteReader();
            while (reader.Read())
            {
                if (reader.GetValue(1).ToString() == producto)
                {
                    string stock = reader.GetValue(3).ToString();
                    reader.Close();
                    conexion.Close();
                    return stock;
                    
                }
            }            
            return "";
        }

        public void actualizarStock(string producto, string cantidad)
        {
            try
            {
                int a =Convert.ToInt32(cantidad);
                OleDbCommand actualizarstock = new OleDbCommand("UPDATE PRODUCTOS SET STOCK='" + cantidad + "' WHERE PRODUCTO='" + producto + "'", conexion);
                conexion.Open();
                actualizarstock.ExecuteNonQuery();
                conexion.Close();
                MessageBox.Show("Se actualizo el stok a " + cantidad);
                return;
            }
            catch
            {
                MessageBox.Show("Use numero no letras");
                return;
            }
        }

        public void agregarrStock(string producto, string categoria)
        {
            OleDbCommand consulta = new OleDbCommand("INSERT INTO PRODUCTOS(CATEGORIA, PRODUCTO) VALUES('"+categoria+"','"+producto+"')", conexion);
            conexion.Open();
            consulta.ExecuteNonQuery();
            conexion.Close();
            MessageBox.Show("Se agrego producto");
            return;
        }

        public void eliminar(string producto)
        {
            OleDbCommand consulta = new OleDbCommand("DELETE FROM PRODUCTOSs WHERE USUARIO='" + producto + "'", conexion);
            conexion.Open();
            consulta.ExecuteNonQuery();
            conexion.Close();
            MessageBox.Show("El producto a sido eliminado correctamente");
        }

    }
}
