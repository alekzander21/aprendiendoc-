using BusquedaEmpleados.DAO;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusquedaEmpleados.MODELS
{
    public class RegistroUsuarios
    {
        public int registro(usuarios usuarios)
        {

            MySqlConnection conexion = ConexionDAO.Conectar();
            conexion.Open();
            
            string sql = "INSERT INTO Usuarios(userEmpleados,passEmpleados,nombreEmpleado) VALUES(@userEmpleados,@passEmpleados,@nombreEmpleado)";
            MySqlCommand comando = new MySqlCommand(sql, conexion);
            comando.Parameters.AddWithValue("@userEmpleados",usuarios.userEmpleados);
            comando.Parameters.AddWithValue("@passEmpleados", usuarios.passEmpleados);
            comando.Parameters.AddWithValue("@nombreEmpleado",usuarios.nombreEmpleado);

            int resultado = comando.ExecuteNonQuery();
            return resultado;
        }

        public static bool existeUsuario(string usuario)
        {
            MySqlDataReader reader;

            MySqlConnection conexion = ConexionDAO.Conectar();
            conexion.Open();

            string sql = "SELECT * FROM Usuarios WHERE userEmpleados LIKE @userEmpleados";
            MySqlCommand comando = new MySqlCommand(sql, conexion);
            comando.Parameters.AddWithValue("@userEmpleados", usuario);

            reader = comando.ExecuteReader();

            if (reader.HasRows)
            {
                return true;
            }
            else
            {
                return false;   
            }
        }

        public usuarios loginUsuario(string usuario)
        {
            MySqlDataReader reader;

            MySqlConnection conexion = ConexionDAO.Conectar();
            conexion.Open();

            string sql = "SELECT idUser ,passEmpleados,nombreEmpleado FROM Usuarios WHERE userEmpleados LIKE @userEmpleados";
            MySqlCommand comando = new MySqlCommand(sql, conexion);
            comando.Parameters.AddWithValue("@userEmpleados", usuario);

            reader = comando.ExecuteReader();

            usuarios usr = null;

            /*Bucle While para traer los resultados de la consulta*/
            while(reader.Read())
            {
                usr = new usuarios();
                usr.idUser = reader["idUser"].ToString();
                usr.passEmpleados = reader["passEmpleados"].ToString();
                usr.nombreEmpleado = reader["nombreEmpleado"].ToString();

            }

            return usr;
        }
    }
}
