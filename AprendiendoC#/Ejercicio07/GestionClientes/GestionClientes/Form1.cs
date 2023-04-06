namespace GestionClientes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string user = txtUser.Text;
            string password = txtPassword.Text;

            if (user == "Fabrizio" && password == "Alekzander")
            {
                Form2 gestionClientes = new Form2();
                gestionClientes.Show();
            }
            else
            {
                MessageBox.Show("Usuario Incorrecto");
            }
        }
    }
}