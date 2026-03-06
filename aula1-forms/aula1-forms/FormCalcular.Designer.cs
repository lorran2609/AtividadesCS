namespace aula1_forms
{
    partial class FormCalcular
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnSubtracao = new Button();
            btnDivisao = new Button();
            btnAdicao = new Button();
            btnMultiplicacao = new Button();
            txtValor1 = new TextBox();
            txtValor2 = new TextBox();
            lblResultado = new Label();
            SuspendLayout();
            // 
            // btnSubtracao
            // 
            btnSubtracao.Font = new Font("Segoe UI", 12F);
            btnSubtracao.Location = new Point(83, 12);
            btnSubtracao.Name = "btnSubtracao";
            btnSubtracao.Size = new Size(48, 48);
            btnSubtracao.TabIndex = 0;
            btnSubtracao.Text = "-";
            btnSubtracao.UseVisualStyleBackColor = true;
            btnSubtracao.Click += btnSubtracao_Click;
            // 
            // btnDivisao
            // 
            btnDivisao.Font = new Font("Segoe UI", 12F);
            btnDivisao.Location = new Point(233, 12);
            btnDivisao.Name = "btnDivisao";
            btnDivisao.Size = new Size(48, 48);
            btnDivisao.TabIndex = 0;
            btnDivisao.Text = "/";
            btnDivisao.UseVisualStyleBackColor = true;
            btnDivisao.Click += btnDivisao_Click;
            // 
            // btnAdicao
            // 
            btnAdicao.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAdicao.Location = new Point(12, 12);
            btnAdicao.Name = "btnAdicao";
            btnAdicao.Size = new Size(48, 48);
            btnAdicao.TabIndex = 0;
            btnAdicao.Text = "+";
            btnAdicao.UseVisualStyleBackColor = true;
            btnAdicao.Click += btnAdicao_Click;
            // 
            // btnMultiplicacao
            // 
            btnMultiplicacao.Font = new Font("Segoe UI", 12F);
            btnMultiplicacao.Location = new Point(155, 12);
            btnMultiplicacao.Name = "btnMultiplicacao";
            btnMultiplicacao.Size = new Size(48, 48);
            btnMultiplicacao.TabIndex = 0;
            btnMultiplicacao.Text = "X";
            btnMultiplicacao.UseVisualStyleBackColor = true;
            btnMultiplicacao.Click += btnMultiplicacao_Click;
            // 
            // txtValor1
            // 
            txtValor1.Location = new Point(12, 90);
            txtValor1.Name = "txtValor1";
            txtValor1.PlaceholderText = "Valor A";
            txtValor1.Size = new Size(119, 23);
            txtValor1.TabIndex = 1;
            // 
            // txtValor2
            // 
            txtValor2.Location = new Point(155, 90);
            txtValor2.Name = "txtValor2";
            txtValor2.PlaceholderText = "Valor B";
            txtValor2.Size = new Size(126, 23);
            txtValor2.TabIndex = 1;
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblResultado.ForeColor = Color.ForestGreen;
            lblResultado.Location = new Point(12, 127);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(33, 37);
            lblResultado.TabIndex = 2;
            lblResultado.Text = "0";
            // 
            // FormCalcular
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(299, 173);
            Controls.Add(lblResultado);
            Controls.Add(txtValor2);
            Controls.Add(txtValor1);
            Controls.Add(btnMultiplicacao);
            Controls.Add(btnDivisao);
            Controls.Add(btnAdicao);
            Controls.Add(btnSubtracao);
            Name = "FormCalcular";
            Text = "FormCalcular";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSubtracao;
        private Button button2;
        private Button btnDivisao;
        private Button btnAdicao;
        private Button btnMultiplicacao;
        private TextBox txtValor1;
        private TextBox txtValor2;
        private Label lblResultado;
    }
}