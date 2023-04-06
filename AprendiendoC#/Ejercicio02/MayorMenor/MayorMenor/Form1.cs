namespace MayorMenor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*Armar un Programa que permita cargar 3 numeros y mostrar cual es el mayor y cual es el menor*/

            int numero1 = Int32.Parse(txtNumberA.Text);
            int numero2 = Int32.Parse(txtNumer2.Text);
            int numero3 = Int32.Parse(txtNumber3.Text);
            int mayor = numero1;
            int menor = numero1;

            if(numero2 > mayor)
            {
                mayor = numero2;
            }

            if(numero3 > mayor)
            {
                mayor = numero3;
            }

            if(numero2 < menor) {
                menor = numero2;
            }
            if(numero3 < menor) {  menor = numero3;}

            MessageBox.Show("El numero mayor es: " + mayor);
            MessageBox.Show("El numero menor es: " + menor);
        }
    }
}