using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormLoginPage
{
	public partial class Form1 : Form
	{
		private class User
		{
			public int Id { get; set; }
			public string Nome { get; set; }
			public string Telefone { get; set; }
			public string Login { get; set; }
			public string Senha { get; set; }
		}

		private readonly List<User> users = new List<User>();

		public Form1()
		{
			InitializeComponent();
		}

		private void btnCadastro_Click(object sender, EventArgs e)
		{
			pnlCadastro.Visible = true;
		}

		private void btnSairCadastro_Click(object sender, EventArgs e)
		{
			pnlCadastro.Visible = false;
		}
		private void login()
		{
			lblErro.Visible = false;

			if (string.IsNullOrWhiteSpace(txtLogin.Text))
			{
				lblErro.Text = "Preencha o login.";
				lblErro.Visible = true;
				return;
			}
			if (string.IsNullOrWhiteSpace(txtPassword.Text))
			{
				lblErro.Text = "Preencha a senha.";
				lblErro.Visible = true;
				return;
			}

			var username = txtLogin.Text;
			var password = txtSenha.Text;
			var user = users.FirstOrDefault(u => string.Equals(u.Login, username, StringComparison.OrdinalIgnoreCase));
			if (user == null)
			{
				lblErro.Text = "Login Inexistente";
				lblErro.Visible = true;
				return;
			}

			if (user.Senha != password)
			{
				lblErro.Text = "Senha Incorreta";
				lblErro.Visible = true;
				return;
			}
			lblErro.Visible = false;
			F_TelaPrincipal f_telaprincipal = new F_TelaPrincipal(user.Nome);
			this.Hide();
			f_telaprincipal.ShowDialog();
			this.Show();
		}

		private void btnCadastrar_Click(object sender, EventArgs e)
		{
			Cadastro();
		}

		private void Cadastro()
		{
			if (string.IsNullOrWhiteSpace(txtNomeComp.Text) ||
				string.IsNullOrWhiteSpace(txtNumTel.Text) ||
				string.IsNullOrWhiteSpace(txtNomeUser.Text) ||
				string.IsNullOrWhiteSpace(txtSenha.Text))
			{
				MessageBox.Show("Preencha todos os campos para cadastrar.");
				return;
			}

			if (txtConfirmSenha.Text != txtSenha.Text)
			{
				MessageBox.Show("As senhas não coincidem. Tente novamente.");
				return;
			}

			var username = txtNomeUser.Text;
			if (users.Any(u => string.Equals(u.Login, username, StringComparison.OrdinalIgnoreCase)))
			{
				MessageBox.Show("Nome de usuário já existe. Escolha outro.");
				return;
			}

			var newId = users.Count > 0 ? users.Max(u => u.Id) + 1 : 1;
			var user = new User
			{
				Id = newId,
				Nome = txtNomeComp.Text,
				Telefone = txtNumTel.Text,
				Login = username,
				Senha = txtSenha.Text
			};

			users.Add(user);

			MessageBox.Show("Cadastro realizado com sucesso.");
			txtConfirmSenha.Clear();
			txtLogin.Clear();
			txtNomeComp.Clear();
			txtNomeUser.Clear();
			txtNumTel.Clear();
			txtSenha.Clear();
			pnlCadastro.Visible = false;
		}

        private void btnEntrar_Click(object sender, EventArgs e)
        {
			login();
        }
    }

}