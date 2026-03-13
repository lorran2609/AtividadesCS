using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace SistemaDePedidos
{
	public partial class Form1 : Form
    {
		List<string> NomeCliente = new List<string>();
		List<int> NumPedido = new List<int>();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCadastro_Click(object sender, EventArgs e)
        {
			try
			{
				string nomecliente = Interaction.InputBox("Digite o nome do cliente", "Digitar nome", "", 300, 300);
				int numerodopedido = Array.IndexOf(, null);
				if (numerodopedido == -1)
				{
					MessageBox.Show("Vetor Cheio", "Falha", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;
				}
				if (!string.IsNullOrEmpty(NumPedido && !double.TryParse(NumPedido, out double v))
				{
					NomeCliente[numerodopedido] = nomecliente;
					MessageBox.Show("Adicionado", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
					return;
				}

				MessageBox.Show("Esse nome é invalido", "Falha", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			catch (Exception ex)
			{
				MessageBox.Show("Erro inesperado", ex.Message);
			}
		}

        private void btnAtender_Click(object sender, EventArgs e)
        {

        }

        private void btnRemover_Click(object sender, EventArgs e)
        {

        }

        private void btnPosicao_Click(object sender, EventArgs e)
        {

        }

        private void btnOrdenar_Click(object sender, EventArgs e)
        {

        }

        private void btnInverter_Click(object sender, EventArgs e)
        {

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {

        }
    }
}
