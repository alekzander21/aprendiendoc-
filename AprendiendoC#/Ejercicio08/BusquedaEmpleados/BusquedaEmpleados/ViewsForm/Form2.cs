using BusquedaEmpleados.DAO.Controllers;
using BusquedaEmpleados.MODELS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BusquedaEmpleados.ViewsForm
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnRegistroUsuario_Click(object sender, EventArgs e)
        {
            usuarios usuario = new usuarios();
            usuario.userEmpleados = txtCreateUser.Text;
            usuario.passEmpleados = txtCreatePass.Text;
            usuario.conPassEmpleados = txtCreatConfirmPass.Text;
            usuario.nombreEmpleado = txtCreateNombre.Text;

            try
            {
                ControlUsuarios control = new ControlUsuarios();
                string respuesta = control.ctrlRegistro(usuario);

                if (respuesta.Length > 0)
                {
                    MessageBox.Show(respuesta, "Aviso", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("Usuario Registrado Exitosamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
