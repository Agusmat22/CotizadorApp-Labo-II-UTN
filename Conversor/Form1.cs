using Billetes;

namespace Conversor
{
    public partial class Form1 : Form
    {
        private bool flagPadlock;
        Pesos peso;
        Dolar dolar;
        Euros euro;

        public Form1()
        {
            InitializeComponent();
            dolar = new Dolar(1);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            flagPadlock = true;

            euro = new Euros();
            peso = new Pesos();
            dolar = new Dolar(1);

            euro = dolar;
            peso = dolar;

            this.txb_cotEuro.Text = euro.GetCantidad.ToString();
            this.txb_cotDolar.Text = dolar.GetCantidad.ToString();
            this.txb_cotPeso.Text = peso.GetCantidad.ToString();


        }



        private void textBox9_TextChanged(object sender, EventArgs e)
        {


        }

        private void btn_padlock_Click(object sender, EventArgs e)
        {
            if (flagPadlock == true)
            {
                flagPadlock = false;
                this.btn_padlock.ImageIndex = 1;

                this.txb_cotDolar.Enabled = true;
                this.txb_cotEuro.Enabled = true;
                this.txb_cotPeso.Enabled = true;

            }
            else
            {
                flagPadlock = true;
                this.btn_padlock.ImageIndex = 0;

                this.txb_cotDolar.Enabled = false;
                this.txb_cotEuro.Enabled = false;
                this.txb_cotPeso.Enabled = false;
            }
        }

        private void btn_euro_Click(object sender, EventArgs e)
        {
            string numeroIngresado = this.txb_ingresoEuro.Text;
            double.TryParse(numeroIngresado, out double numeroCast);

            euro = new Euros(numeroCast);
            peso = new Pesos();
            dolar = new Dolar();

            peso = euro;

            dolar = euro;

            //muestro la conversiones del euro

            //-primer txt box
            this.txb_muestraEuro1.Text = euro.GetCantidad.ToString();

            this.txb_muestraEuro2.Text = dolar.GetCantidad.ToString();

            this.txb_muestraEuro3.Text = peso.GetCantidad.ToString();

        }

        private void txb_cotEuro_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_dolar_Click(object sender, EventArgs e)
        {

            string numeroIngresado = this.txb_ingresoDolar.Text;
            double.TryParse(numeroIngresado, out double numeroCast);

            euro = new Euros();
            peso = new Pesos();
            dolar = new Dolar(numeroCast);

            peso = dolar;

            euro = dolar;

            //muestro la conversiones del euro

            //-primer txt box
            this.txb_muestraDolar1.Text = euro.GetCantidad.ToString();

            this.txb_muestraDolar2.Text = dolar.GetCantidad.ToString();

            this.txb_muestraDolar3.Text = peso.GetCantidad.ToString();

        }

        private void btn_peso_Click(object sender, EventArgs e)
        {

            string numeroIngresado = this.txb_ingresoPeso.Text;
            double.TryParse(numeroIngresado, out double numeroCast);

            euro = new Euros();
            peso = new Pesos(numeroCast);
            dolar = new Dolar();

            dolar = peso;

            euro = peso;

            //muestro la conversiones del euro

            //-primer txt box
            this.txb_muestraPeso1.Text = euro.GetCantidad.ToString();

            this.txb_muestraPeso2.Text = dolar.GetCantidad.ToString();

            this.txb_muestraPeso3.Text = peso.GetCantidad.ToString();

        }
    }
}