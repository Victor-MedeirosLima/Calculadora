using System.ComponentModel;
using System.Globalization;
using System.Runtime.Serialization;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public decimal valor1, valor2, resultado;
        public string opera��o;

        private void Button_0_Click(object sender, EventArgs e)
        {
            textBox1.Text += "0";
        }

        private void Button_1_Click(object sender, EventArgs e)
        {
            textBox1.Text += "1";
        }

        private void Button_2_Click(object sender, EventArgs e)
        {
            textBox1.Text += "2";
        }

        private void Button_3_Click(object sender, EventArgs e)
        {
            textBox1.Text += "3";
        }

        private void Button_4_Click(object sender, EventArgs e)
        {
            textBox1.Text += "4";
        }

        private void Button_5_Click(object sender, EventArgs e)
        {
            textBox1.Text += "5";
        }

        private void Button_6_Click(object sender, EventArgs e)
        {
            textBox1.Text += "6";
        }

        private void Button_7_Click(object sender, EventArgs e)
        {
            textBox1.Text += "7";
        }

        private void Button_8_Click(object sender, EventArgs e)
        {
            textBox1.Text += "8";
        }

        private void Button_9_Click(object sender, EventArgs e)
        {
            textBox1.Text += "9";
        }

        private void Button_virgula_Click(object sender, EventArgs e)
        {
            textBox1.Text += ".";
        }

        private void Button_delete_Click(object sender, EventArgs e)
        {
            textBox1.Text = " ";
            valor1 = 0;
            valor2 = 0;

        }

        private void Button_AC_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1);
        }


        private void Button_mais_Click(object sender, EventArgs e)
        {
            opera��o = "soma";
            valor1 = decimal.Parse(textBox1.Text, CultureInfo.InvariantCulture);
            label_visor.Text = textBox1.Text + " + ";
            textBox1.Text = " ";
        }

        private void Button_menos_Click(object sender, EventArgs e)
        {
            opera��o = "subtra��o";
            valor1 = decimal.Parse(textBox1.Text, CultureInfo.InvariantCulture);
            label_visor.Text = textBox1.Text + " - ";
            textBox1.Text = " ";
        }

        private void Button_divis�o_Click(object sender, EventArgs e)
        {
            opera��o = "divis�o";
            valor1 = decimal.Parse(textBox1.Text, CultureInfo.InvariantCulture);
            label_visor.Text = textBox1.Text + " / ";
            textBox1.Text = " ";
        }

        private void Button_multiplica��o_Click(object sender, EventArgs e)
        {
            opera��o = "multiplica��o";
            valor1 = decimal.Parse(textBox1.Text, CultureInfo.InvariantCulture);
            label_visor.Text = textBox1.Text + " x ";
            textBox1.Text = " ";
        }

        private void Button_igual_Click(object sender, EventArgs e)
        {
            label_visor.Text = "";
            valor2 = decimal.Parse(textBox1.Text, CultureInfo.InvariantCulture);

            switch (opera��o)
            {
                case ("soma"):
                    resultado = valor1 + valor2;
                    textBox1.Text = Convert.ToString(resultado, CultureInfo.InvariantCulture);
                    break;

                case ("subtra��o"):
                    resultado = valor1 - valor2;
                    textBox1.Text = Convert.ToString(resultado, CultureInfo.InvariantCulture);
                    break;

                case ("divis�o"):
                    if (valor2 == 0)
                    {
                        string resultado = "n�o � possivel divir por zero";
                        textBox1.Text = resultado;
                        break;
                    }
                    else
                    {
                        resultado = valor1 / valor2;
                        textBox1.Text = Convert.ToString(resultado, CultureInfo.InvariantCulture);
                        break;
                    }

                case ("multiplica��o"):
                    resultado = valor1 * valor2;
                    textBox1.Text = Convert.ToString(resultado, CultureInfo.InvariantCulture);
                    break;
            }

        }


    }
}