using System.Globalization;

namespace Calculadora
{
    public partial class Form1 : Form
    {

        float v1, v2, r;
        string operador = "";
		public Form1()
        {
            InitializeComponent();
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += 0;
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += 1;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += 2;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += 3;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += 4;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += 5;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += 6;
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += 7;
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += 8;
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += 9;
        }

        private void btnVirgula_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += ",";
        }

        private void btnSoma_Click(object sender, EventArgs e)
        {
            operador = "+";
            v1 = float.Parse(txtDisplay.Text);
			lblCalculo.Text = v1 + "" + operador;
			txtDisplay.Clear();

        }

        private void btnSubtracao_Click(object sender, EventArgs e)
        {
            operador = "-";
            v1 = float.Parse(txtDisplay.Text);
			lblCalculo.Text = v1 + "" + operador;
			txtDisplay.Clear();
        }

        private void btnMultiplicacao_Click(object sender, EventArgs e)
        {
            operador = "*";
            v1 = float.Parse(txtDisplay.Text);
            lblCalculo.Text = v1 + "" + operador;
			txtDisplay.Clear();
        }

        private void btnDivisao_Click(object sender, EventArgs e)
        {
            operador = "/";
            v1 = float.Parse(txtDisplay.Text);
            lblCalculo.Text = v1 + "" + operador;
			txtDisplay.Clear();
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            v2 = float.Parse(txtDisplay.Text);
            switch (operador)
            {
                case "+":
                    r = v1 + v2;
					break;
				case "-":
                    r = v1 - v2;
					break;
                case "*":
                    r = v1 * v2;
					break;
                case "/":
                    if (v2 == 0)
                    {
                        txtDisplay.Text = "Erro!!";
                    }
                    else
                    {
                        r = v1 / v2;
					}
					break;
			}
			txtDisplay.Text = r.ToString();
			lblCalculo.Text = v1 + "" + operador + "" + v2;
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtDisplay.Clear();
            lblCalculo.Text = "";
        }

    }
}
