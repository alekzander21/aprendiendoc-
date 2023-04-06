namespace CalcularPromedio
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            /*Calcular Promedio*/

            int numero1 = Int32.Parse(txtNumero1.Text);
            int numero2 = Int32.Parse(txtNumero2.Text);
            int numero3 = Int32.Parse(txtNumero3.Text);
            
            double operacion;

            operacion = numero1 + numero2 + numero3;
            operacion = operacion / 3;
            MessageBox.Show("El promedio es: " + operacion);
        }
    }
}