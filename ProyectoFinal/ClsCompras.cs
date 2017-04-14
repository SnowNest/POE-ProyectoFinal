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
                    if(reader.GetInt32(3) > cantidad)
                    {                       
                        reader.Close();
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
                else
                {
                    MessageBox.Show("Error en busqueda. Intente denuevo");
                }
            }
            conexion.Close();
            return false;
        }
        public void creartiket(int cantidad, string producto)
        {
            return;
        }
    }
}
