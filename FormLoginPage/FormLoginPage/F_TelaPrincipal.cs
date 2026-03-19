using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormLoginPage
{
    public partial class F_TelaPrincipal : Form
    {
        public F_TelaPrincipal()
        {
            InitializeComponent();
        }
		public F_TelaPrincipal(string login)
		{
			InitializeComponent();
			pnlAdmin.Visible = true;
			lblMensagem.Text = $"Logado como: {login}";
		}

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            this.Hide();
            form1.ShowDialog();
        }

        private void btnExcluirUser_Click(object sender, EventArgs e)
        {
            if (pnlExcluir.Visible == false)
            {
				pnlExcluir.Visible = true;
			}
            else
            {
                pnlExcluir.Visible = false;
			}
		}

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Deseja realmente excluir o usuário?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
		}
    }
}
