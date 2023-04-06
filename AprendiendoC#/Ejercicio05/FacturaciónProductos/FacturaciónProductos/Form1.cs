namespace FacturaciónProductos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string productoSeleccionado = cboProductos.SelectedItem.ToString();
            listCarritoCompras.Items.Add(productoSeleccionado);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cboProductos.Items.Add("Pantalon");
            cboProductos.Items.Add("Camisa");
            cboProductos.Items.Add("Zapatos");
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            //Pantalon 20
            //Camisa 35
            //Zapatos 24

            double precioFinal = 0;
            int productosCargdos = listCarritoCompras.Items.Count;
            for (int i = 0; i < productosCargdos; i++)
            {
                string productoElegido = listCarritoCompras.Items[i].ToString();
                if (productoElegido == "Pantalon") { precioFinal += 20; }
                else if (productoElegido == "Camisa") { precioFinal += 35; }
                if (productoElegido == "Zapatos") { precioFinal += 24; }

            }
            if(txtCodigoPromocional.Text == "NAVIDAD")
            {
                precioFinal = precioFinal * 0.9;
            }
            MessageBox.Show("El precio final es: $" + precioFinal);

        }
    }
}