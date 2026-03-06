namespace aula1_forms
{
    partial class formAula01
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtA = new TextBox();
            txtB = new TextBox();
            btnExecutar = new Button();
            btnLimpar = new Button();
            btnExibirMensagem = new Button();
            label1 = new Label();
            label2 = new Label();
            lblTexto = new Label();
            btnCalcular = new Button();
            SuspendLayout();
            // 
            // txtA
            // 
            txtA.Location = new Point(246, 123);
            txtA.Name = "txtA";
            txtA.Size = new Size(220, 23);
            txtA.TabIndex = 0;
            // 
            // txtB
            // 
            txtB.Location = new Point(246, 167);
            txtB.Name = "txtB";
            txtB.Size = new Size(220, 23);
            txtB.TabIndex = 1;
            // 
            // btnExecutar
            // 
            btnExecutar.Location = new Point(246, 196);
            btnExecutar.Name = "btnExecutar";
            btnExecutar.Size = new Size(83, 31);
            btnExecutar.TabIndex = 2;
            btnExecutar.Text = "Executar";
            btnExecutar.UseVisualStyleBackColor = true;
            btnExecutar.Click += btnExecutar_Click;
            // 
            // btnLimpar
            // 
            btnLimpar.Location = new Point(383, 196);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(83, 31);
            btnLimpar.TabIndex = 2;
            btnLimpar.Text = "Limpar";
            btnLimpar.UseVisualStyleBackColor = true;
            btnLimpar.Click += btnLimpar_Click;
            // 
            // btnExibirMensagem
            // 
            btnExibirMensagem.Location = new Point(246, 233);
            btnExibirMensagem.Name = "btnExibirMensagem";
            btnExibirMensagem.Size = new Size(220, 31);
            btnExibirMensagem.TabIndex = 2;
            btnExibirMensagem.Text = "Exibir Mensagem";
            btnExibirMensagem.UseVisualStyleBackColor = true;
            btnExibirMensagem.Click += btnExibirMensagem_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(246, 105);
            label1.Name = "label1";
            label1.Size = new Size(15, 15);
            label1.TabIndex = 3;
            label1.Text = "A";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(246, 149);
            label2.Name = "label2";
            label2.Size = new Size(14, 15);
            label2.TabIndex = 3;
            label2.Text = "B";
            // 
            // lblTexto
            // 
            lblTexto.AutoSize = true;
            lblTexto.Location = new Point(246, 280);
            lblTexto.Name = "lblTexto";
            lblTexto.Size = new Size(0, 15);
            lblTexto.TabIndex = 4;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(246, 308);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(220, 50);
            btnCalcular.TabIndex = 5;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // formAula01
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.CadetBlue;
            ClientSize = new Size(738, 481);
            Controls.Add(btnCalcular);
            Controls.Add(lblTexto);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnLimpar);
            Controls.Add(btnExibirMensagem);
            Controls.Add(btnExecutar);
            Controls.Add(txtB);
            Controls.Add(txtA);
            ForeColor = SystemColors.ControlText;
            Name = "formAula01";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Aula01";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtA;
        private TextBox txtB;
        private Button btnExecutar;
        private Button btnLimpar;
        private Button btnExibirMensagem;
        private Label label1;
        private Label label2;
        private Label lblTexto;
        private Button btnCalcular;
    }
}
