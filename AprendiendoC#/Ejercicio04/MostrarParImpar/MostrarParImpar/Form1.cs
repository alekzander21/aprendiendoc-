namespace MostrarParImpar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            /*Calcular si el numero es par o impar*/
            int numero = Int32.Parse(txtNumero.Text);

            if(numero % 2 == 0)
            {
                MessageBox.Show("El numero es par");
            }
            else
            {
                MessageBox.Show("El numero es impar");
            }
        }
    }
}