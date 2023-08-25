namespace Calculadora
{
    public partial class Form1 : Form
    {
        double numero1 = 0, numero2 = 0;
        char Operador;

        public Form1()
        {
            InitializeComponent();
        }

        //Funcion Agregar Numeros

        private void agregarNumeros(object sender, EventArgs e)
        {
            var boton = ((Button)sender);

            if (txtResultado.Text == "0")
            {
                txtResultado.Text = "";
            }

            txtResultado.Text += boton.Text;
        }
        // Funmcion Operador

        private void clickOperador(object sender, EventArgs e)
        {
            var boton = ((Button)sender);
            numero1 = Convert.ToDouble(txtResultado.Text);
            Operador = Convert.ToChar(boton.Tag);

            if (Operador == '²')
            {
                numero1 = Math.Pow(numero1, 2);
                txtResultado.Text = numero1.ToString();
            }
            else if (Operador == '√')
            {
                numero1 = Math.Sqrt(numero1);
                txtResultado.Text = numero1.ToString();

            }
            else
            {
                txtResultado.Text = "0";
            }


        }

        private void btnMas_Click(object sender, EventArgs e)
        {

        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            numero2 = Convert.ToDouble(txtResultado.Text);

            if (Operador == '+')
            {
                txtResultado.Text = (numero1 + numero2).ToString();
                numero1 = Convert.ToDouble(txtResultado.Text);
            }
            else if (Operador == '-')
            {
                txtResultado.Text = (numero1 - numero2).ToString();
                numero1 = Convert.ToDouble(txtResultado.Text);
            }
            else if (Operador == 'x')
            {
                txtResultado.Text = (numero1 * numero2).ToString();
                numero1 = Convert.ToDouble(txtResultado.Text);
            }
            else if (Operador == '/')
            {
                if (txtResultado.Text != "0") 
                {
                    txtResultado.Text = (numero1 / numero2).ToString();
                    numero1 = Convert.ToDouble(txtResultado.Text);
                }else
                {
                    MessageBox.Show("No se puede dividir entre Cero");
                }
                
            }
            else if (Operador == '%')
            {
                txtResultado.Text = (numero1 * numero2 / 100).ToString();
                numero1 = Convert.ToDouble(txtResultado.Text);
            }
        }

        private void btnBorra_Click(object sender, EventArgs e)
        {
            if (txtResultado.Text.Length > 1)
            {
                txtResultado.Text = txtResultado.Text.Substring(0, txtResultado.Text.Length - 1);
            }
            else
            {
                txtResultado.Text = "0";
            }
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            numero1 = 0;
            numero2 = 0;
            Operador = '\0';
            txtResultado.Text = "0";
        }

        private void btnCE_Click(object sender, EventArgs e)
        {
            txtResultado.Text = "";
        }

        private void btnPunto_Click(object sender, EventArgs e)
        {
            if (!txtResultado.Text.Contains("."))
            {
                txtResultado.Text += ".";
            }
        }

        private void btnMasMenos_Click(object sender, EventArgs e)
        {
            numero1 = Convert.ToDouble(txtResultado.Text);
            numero1 *= -1;
            txtResultado.Text = numero1.ToString();
        }
    }
}