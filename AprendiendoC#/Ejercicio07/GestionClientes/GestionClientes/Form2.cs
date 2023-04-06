using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GestionClientes.dao;
using GestionClientes.models;

namespace GestionClientes
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            renderizarLista();
        }

        private void renderizarLista()
        {
            ClienteDAO clienteDAO = new ClienteDAO();
            List<Cliente> listDB = clienteDAO.listadoDeClientes();
            listClientes.Items.Clear();
            for (int i = 0; i < listDB.Count; i++)
            {
                Cliente cliente = listDB[i];
                listClientes.Items.Add(cliente);
            }
        }

        private void btnGuardarCliente_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente();
            cliente.nombre = txtNombre.Text;
            cliente.apellido = txtApellido.Text;
            cliente.tarjeta = txtTarjetaCredito.Text;
            cliente.telefono = txtTelefono.Text;

            ClienteDAO clienteDAO = new ClienteDAO();
            clienteDAO.guardarLista(cliente);
            renderizarLista();
            listClientes.Items.Add(cliente);
        }

        private void btnEliminarCliente_Click(object sender, EventArgs e)
        {
            Cliente cliente = (Cliente)listClientes.SelectedItem;
            ClienteDAO clienteDAO=new ClienteDAO();

            clienteDAO.eliminarLista(cliente);  
            renderizarLista();  
        }

        private void button1_Click(object sender, EventArgs e)
        {


        }
    }
}
