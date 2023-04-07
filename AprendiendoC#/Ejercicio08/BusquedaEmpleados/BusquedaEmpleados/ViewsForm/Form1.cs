using BusquedaEmpleados.DAO;
using BusquedaEmpleados.DAO.Controllers;
using BusquedaEmpleados.MODELS;
using BusquedaEmpleados.ViewsForm;
using System.Linq.Expressions;

namespace BusquedaEmpleados
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text;
            string password = txtPassword.Text;

            try
            {
                ControlUsuarios ctrl = new ControlUsuarios();
                string respuesta = ctrl.ctrLogin(usuario, password);    
                if (respuesta.Length > 0) {
                    MessageBox.Show(respuesta,"Aviso",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
                else
                {
                    Form3 gestionEmpleados = new Form3();
                    gestionEmpleados.Show();
                }
            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtRegistrarCuenta_Click(object sender, EventArgs e)
        {
            Form2 registrarCuenta = new Form2();
            registrarCuenta.Show();
        }
    }
}