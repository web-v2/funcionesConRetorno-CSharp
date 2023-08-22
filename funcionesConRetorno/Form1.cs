namespace funcionesConRetorno
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double descCompra = calcularDescuento(Double.Parse(textBox1.Text));

            double compraFinal = Double.Parse(textBox1.Text) - descCompra;

            textBox2.Text = descCompra.ToString();
            textBox3.Text = compraFinal.ToString();
        }

        public double calcularDescuento(double totalC)
        {
            double desc = 0;

            if (totalC > 100 && totalC <= 200)
            {
                desc = totalC*0.05;
            }

            if (totalC > 200 && totalC <= 300)
            {
                desc = totalC * 0.1;
            }

            if (totalC > 300)
            {
                desc = totalC * 0.2;
            }

            return desc;
        }
    }
}