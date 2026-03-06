using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.DirectoryServices;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace aula1_forms
{
    public partial class FormCalcular : Form
    {
        public FormCalcular()
        {
            InitializeComponent();
        }

        private void somar()
        {
            float a = float.Parse(txtValor1.Text);
			float b = float.Parse(txtValor2.Text);
            lblResultado.Text = (a + b).ToString();
        }

        private void btnAdicao_Click(object sender, EventArgs e)
        {
            somar();
        }

        private void subtrair()
        {
			float a = float.Parse(txtValor1.Text);
			float b = float.Parse(txtValor2.Text);
            lblResultado.Text = (a - b).ToString();
        }

        private void btnSubtracao_Click(object sender, EventArgs e)
        {
            subtrair();
        }

        private void multiplicar()
        {
			float a = float.Parse(txtValor1.Text);
			float b = float.Parse(txtValor2.Text);
            lblResultado.Text = (a * b).ToString();
        }

        private void btnMultiplicacao_Click(object sender, EventArgs e)
        {
            multiplicar();
        }

        private void dividir()
        {
			float a = float.Parse(txtValor1.Text);
			float b = float.Parse(txtValor2.Text);
            lblResultado.Text = (a / b).ToString();
        }

        private void btnDivisao_Click(object sender, EventArgs e)
        {
            dividir();
        }
    }
}
