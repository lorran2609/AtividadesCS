namespace aula1_forms
{
    public partial class formAula01 : Form
    {
        public formAula01()
        {
            InitializeComponent();
        }

        private void exibirMensagem()
        {
            MessageBox.Show("Hello World!", "DDS", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnExibirMensagem_Click(object sender, EventArgs e)
        {
            exibirMensagem();
        }

        private void modificarTexto()
        {
            txtA.Text = "SENAI";
            txtB.Text = "Cachoeiro";
            lblTexto.Text = "Técnico em Desenvolvimento de Sistemas";
        }

        private void btnExecutar_Click(object sender, EventArgs e)
        {
            modificarTexto();
        }

        private void limparCampos()
        {
            txtA.Clear();
            txtB.Clear();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            limparCampos();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            FormCalcular fc = new FormCalcular();
            this.Hide();
            fc.Show();
        }
    }
}
