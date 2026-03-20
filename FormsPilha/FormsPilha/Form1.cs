using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormsPilha
{
    public partial class Form1 : Form
    {
		private Stack<String> pilha;
		private Stack<String> pilhaAvancar;

		string siteatual = "", siteanterior = "", sitedepois = "";
		public Form1()
        {
            InitializeComponent();
			pilha = new Stack<String>();
		}
        private void btnHistorico_Click(object sender, EventArgs e)
        {
			if (pnlHistorico.Visible == false)
			{
				if (pilha.Count == 0)
				{
					return;
				}
				foreach (string siteatual in pilha)
				{
					pnlHistorico.Visible = true;
				}
			}
			else
			{
				pnlHistorico.Visible = false;
			}
		}
        private void btnPesquisar_Click(object sender, EventArgs e)
        {
			if (string.IsNullOrEmpty(txtPesquisa.Text))
			{
				MessageBox.Show("ERRO, Não pode estar vazio", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			else
			{
				try
				{
					siteatual = txtPesquisa.Text;
					pilha.Push(siteatual);
					txtPesquisa.Text = "";
					lbxHistorico.Items.Add(siteatual);
					siteanterior = siteatual;
					lblSite.Text = siteatual;
				}
				catch (Exception ex)
				{
					MessageBox.Show("Erro!", ex.Message);
				}
			}
        }
        private void btnLimparHistorico_Click(object sender, EventArgs e)
        {
			lbxHistorico.Items.Clear();
        }
		private void btnSetaVoltar_Click(object sender, EventArgs e)
		{
		}

		private void btnSetaAvancar_Click(object sender, EventArgs e)
		{
		}
	}
}
