using GestionClientes.models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionClientes.dao
{
    public  class ClienteDAO
    {
        public MySqlConnection Conectar()
        {
            string servidor = "localhost";
            string user = "root";
            string password = "";
            string database = "GestionClientes";

            /*Cadena de Conexión a Mysqli*/
            string conn = "Database=" + database + "; Data Source=" + servidor + "; User Id=" + user + "; Password= " + password + "";

            /*Realizando Conexión*/
            MySqlConnection conexiondb = new MySqlConnection(conn);
            conexiondb.Open();

            return conexiondb;
        }

        public List<Cliente> listadoDeClientes() {
            List<Cliente> lista = new List<Cliente>();
            /*Mostramos la lista*/

            string consulta = "SELECT * FROM Clientes";
            MySqlCommand comando = new MySqlCommand(consulta);
            comando.Connection = Conectar();

            MySqlDataReader lectura = comando.ExecuteReader();

            while (lectura.Read())
            {
                Cliente cliente = new Cliente();
                cliente.id = lectura.GetString("id");
                cliente.nombre = lectura.GetString("nombre");
                cliente.apellido = lectura.GetString("apellido");
                cliente.telefono = lectura.GetString("telefono");
                cliente.tarjeta = lectura.GetString("tarjeta");
                lista.Add(cliente); 
            }

            comando.Connection.Close();

            return lista;
        }

        public  void guardarLista(Cliente cliente)
        {
            string consulta = "INSERT INTO Clientes (id,nombre,apellido,telefono,tarjeta) values(NULL,'"+cliente.nombre +"','" + cliente.apellido+"','"+ cliente.telefono+"','"+cliente.tarjeta+"') ";
            MySqlCommand comando = new MySqlCommand(consulta);
            comando.Connection = Conectar();
            comando.ExecuteNonQuery();

            comando.Connection.Close();
        }

        public void eliminarLista(Cliente cliente)
        {
            string consulta = "DELETE FROM Clientes WHERE id = '" + cliente.id+"'";
            MySqlCommand comando = new MySqlCommand(consulta);
            comando.Connection = Conectar();
            comando.ExecuteNonQuery();  
            comando.Connection.Close();
        }
    }
}
