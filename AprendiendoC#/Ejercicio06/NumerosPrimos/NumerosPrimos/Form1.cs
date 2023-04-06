namespace NumerosPrimos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string resultado = "";
            double numero = 2;
            int contador = 0;
            while (contador < 100)
            {
                if (esNumeroPrimo(numero)) {
                    resultado = resultado + "," + numero;
                    contador++; 
                }
                numero++;
            }
            MessageBox.Show(resultado);
        }

        private bool esNumeroPrimo(double numero)
        {
            bool numeroPrimo = true;
            for (int i = 2; i < numero; i++)
            {
                if (numero % i == 0)
                {
                    numeroPrimo = false;
                }
            }
            return numeroPrimo;
        }
    }
}