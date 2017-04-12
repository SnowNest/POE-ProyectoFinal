using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace ProyectoFinal
{
    public class ClsBaseDatos
    {
        OleDbConnection conexion = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:/Users/nesto/Desktop/ProyectoFinal/DBProyecto.mdb");

        public void iniciarSesion(string consultaUsuario, string consultaContrasena)
        {

            if (consultaUsuario != "" & consultaContrasena != "")
            {                
                OleDbCommand consulta = new OleDbCommand("SELECT * FROM USUARIOS", conexion);
                conexion.Open();
                OleDbDataReader reader = consulta.ExecuteReader();
                while (reader.Read())
                {                    
                    if (consultaUsuario == reader.GetValue(0).ToString() & consultaContrasena == reader.GetValue(2).ToString())
                    {
                        if(reader.GetValue(3).ToString() == "1")
                        {
                            MessageBox.Show("Bienvenido administrador " + reader.GetValue(1).ToString());
                            reader.Close();
                            conexion.Close();
                            Administrador paginaAdmin = new Administrador();
                            paginaAdmin.Show();                            
                            return;
                        }
                        else
                        {
                            //FALTA TIENDA 
                            MessageBox.Show("No es admin;");
                            reader.Close();
                            conexion.Close();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Contraseña no valida");
                        return;
                    }
                    
                }
            }
            else
            {
                MessageBox.Show("Ingrese los datos requeridos");
                return;
            }
        }

        public void validarConexion()
        {
            try
            {
                conexion.Open();
                conexion.Close();
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("ERROR:" + ex.Message);
            }
        }

        public void agregarUsuario(string nombre, string usuario, string contrasena, string administrador)
        {
            if (nombre != "" & usuario != "" & contrasena != "")
            {
                if (validarUsuario(usuario) == true)
                {
                    conexion.Open();
                    OleDbCommand consulta = new OleDbCommand("INSERT INTO USUARIOS(NOMBRE, USUARIO, CONTRASENA, ADMINISTRADOR) VALUES('" + nombre + "', '" + usuario + "','" + contrasena + "', '" + administrador + "')", conexion);                    
                    consulta.ExecuteNonQuery();
                    conexion.Close();
                    MessageBox.Show("El usuario " + usuario + " a sido agragado correctamente");
                }

                else
                {
                    MessageBox.Show("EL usuario " + usuario + " ya existe.");
                }

            }
            else
            {
                MessageBox.Show("Inserte los campos completos");
                return;
            }

        }

        public void buscarUsuario(string nombre, string usuario, string contrasena, string administrador)
        {
            if (nombre != "" & usuario != "" & contrasena != "")
            {
                if (validarUsuario(usuario) == false & usuario != "root")
                {
                    OleDbCommand consulta = new OleDbCommand("UPDATE USUARIOS SET NOMBRE='"+ nombre +"', CONTRASENA='"+ contrasena +"', ADMINISTRADOR='"+ administrador + "' WHERE USUARIO='" + usuario +"'", conexion);
                    conexion.Open();
                    consulta.ExecuteNonQuery();
                    conexion.Close();
                    MessageBox.Show("El usuario " + usuario + " a sido modificado correctamente");
                }

                else
                {
                    MessageBox.Show("EL usuario " + usuario + " no existe.");
                }

            }
            else
            {
                MessageBox.Show("Inserte los campos completos");
                return;
            }            
        }

        public void borrarUsuario(string usuario)
        {
            if (validarUsuario(usuario) == false & usuario != "root")
            {
                OleDbCommand consulta = new OleDbCommand("DELETE FROM USUARIOS WHERE USUARIO='" + usuario+ "'", conexion);
                conexion.Open();
                consulta.ExecuteNonQuery();
                conexion.Close();
                MessageBox.Show("El usuario " + usuario + " a sido eliminado correctamente");
            }
            else
            {
                MessageBox.Show("El usuario " + usuario + " no existe");
            }
        }

        public bool validarUsuario(string usuario)
        {
            OleDbCommand consulta = new OleDbCommand("SELECT * FROM USUARIOS", conexion);
            conexion.Open();
            OleDbDataReader reader = consulta.ExecuteReader();
            while (reader.Read())
            {
                if (reader.GetValue(0).ToString() == usuario)
                {
                    reader.Close();
                    conexion.Close();
                    return false;
                }
            }
            conexion.Close();
            reader.Close();
            return true;
        }
    }
}
