namespace AprendiendoC_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<int> lista = traerListado();
            mostraLista(lista);
        }
        private void mostraLista(List<int> lista)
        {

            for (int i = 0; i < lista.Count; i++)
            {
                int numero = lista[i];
                MessageBox.Show("El numero es : " + numero);
            }
        }

        private List<int> traerListado()
        {
            List<int> lista = new List<int>();
            lista.Add(1);
            lista.Add(3);
            mostraLista(lista);

            return lista;

        }
    }
}