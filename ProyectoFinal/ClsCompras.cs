using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace ProyectoFinal
{
    public class ClsCompras
    {
        OleDbConnection conexion = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:/Users/nesto/Desktop/ProyectoFinal/DBProyecto.mdb");

        public bool validarstock(int cantidad, string producto)
        {
            OleDbCommand consulta = new OleDbCommand("SELECT * FROM productos", conexion);
            conexion.Open();
            OleDbDataReader reader = consulta.ExecuteReader();
            while (reader.Read())
            {
                if (reader.GetValue(1).ToString() == producto)
                {
                    if(Convert.ToInt32(reader.GetValue(3).ToString()) > cantidad)
                    {                       
                        int stock = Convert.ToInt32(reader.GetValue(3).ToString()) - cantidad;
                        reader.Close();
                        OleDbCommand actualizarstock = new OleDbCommand("UPDATE PRODUCTOS SET STOCK='" + Convert.ToString(stock) + "' WHERE PRODUCTO='" + producto + "'", conexion);
                        actualizarstock.ExecuteNonQuery();                        
                        conexion.Close();
                        return true;
                    }
                    else
                    {
                        conexion.Close();
                        reader.Close();
                        return false;
                    }
                }         
            }
            MessageBox.Show("Error en busqueda. Intente denuevo");
            conexion.Close();
            return false;
        }
        public int creartiket(int cantidad, string producto)
        {
            OleDbCommand consulta = new OleDbCommand("SELECT * FROM productos", conexion);
            conexion.Open();
            OleDbDataReader reader = consulta.ExecuteReader();
            while (reader.Read())
            {
                if (reader.GetValue(1).ToString() == producto)
                {
                    int total = Convert.ToInt32(reader.GetValue(2).ToString()) * cantidad;
                    conexion.Close();
                    MessageBox.Show("El total es: " + total);
                    return total;
                }
            }

            return 0;
        }
    }
}
