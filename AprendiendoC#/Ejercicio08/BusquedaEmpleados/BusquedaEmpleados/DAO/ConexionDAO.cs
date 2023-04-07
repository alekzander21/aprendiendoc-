using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusquedaEmpleados.DAO
{
    public class ConexionDAO
    {
        public static MySqlConnection Conectar()
        {
            string servidor = "localhost";
            string user = "root";
            string pass = "";
            string database = "GestionEmpleados";

            string conn = "Database=" + database + "; Data Source=" + servidor + "; User Id=" + user + "; Password= " + pass + "";
            
            MySqlConnection conexiondb = new MySqlConnection(conn);
            conexiondb.Open();  
            conexiondb.Close(); 

            return conexiondb;  
        }


    }
}
