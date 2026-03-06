namespace Calculadora
{
    partial class Form1
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
            Button btnVirgula;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            txtDisplay = new TextBox();
            btn7 = new Button();
            btn8 = new Button();
            btn9 = new Button();
            btn4 = new Button();
            btn5 = new Button();
            btn6 = new Button();
            btn1 = new Button();
            btn2 = new Button();
            btn3 = new Button();
            btnSoma = new Button();
            btnLimpar = new Button();
            btnMultiplicacao = new Button();
            btnDivisao = new Button();
            btnIgual = new Button();
            btnSubtracao = new Button();
            btn0 = new Button();
            lblCalculo = new Label();
            btnVirgula = new Button();
            SuspendLayout();
            // 
            // btnVirgula
            // 
            btnVirgula.Location = new Point(123, 269);
            btnVirgula.Name = "btnVirgula";
            btnVirgula.Size = new Size(53, 45);
            btnVirgula.TabIndex = 2;
            btnVirgula.Text = ",";
            btnVirgula.UseVisualStyleBackColor = true;
            btnVirgula.Click += btnVirgula_Click;
            // 
            // txtDisplay
            // 
            txtDisplay.BackColor = Color.White;
            txtDisplay.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtDisplay.Location = new Point(11, 27);
            txtDisplay.MaxLength = 21;
            txtDisplay.Name = "txtDisplay";
            txtDisplay.ReadOnly = true;
            txtDisplay.Size = new Size(224, 33);
            txtDisplay.TabIndex = 0;
            txtDisplay.TextAlign = HorizontalAlignment.Right;
            // 
            // btn7
            // 
            btn7.Font = new Font("Segoe UI", 12F);
            btn7.Location = new Point(11, 117);
            btn7.Name = "btn7";
            btn7.Size = new Size(51, 45);
            btn7.TabIndex = 1;
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = true;
            btn7.Click += btn7_Click;
            // 
            // btn8
            // 
            btn8.Font = new Font("Segoe UI", 12F);
            btn8.Location = new Point(68, 117);
            btn8.Name = "btn8";
            btn8.Size = new Size(51, 45);
            btn8.TabIndex = 1;
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = true;
            btn8.Click += btn8_Click;
            // 
            // btn9
            // 
            btn9.Font = new Font("Segoe UI", 12F);
            btn9.Location = new Point(125, 117);
            btn9.Name = "btn9";
            btn9.Size = new Size(51, 45);
            btn9.TabIndex = 1;
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = true;
            btn9.Click += btn9_Click;
            // 
            // btn4
            // 
            btn4.Font = new Font("Segoe UI", 12F);
            btn4.Location = new Point(11, 168);
            btn4.Name = "btn4";
            btn4.Size = new Size(51, 45);
            btn4.TabIndex = 1;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = true;
            btn4.Click += btn4_Click;
            // 
            // btn5
            // 
            btn5.Font = new Font("Segoe UI", 12F);
            btn5.Location = new Point(68, 168);
            btn5.Name = "btn5";
            btn5.Size = new Size(51, 45);
            btn5.TabIndex = 1;
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = true;
            btn5.Click += btn5_Click;
            // 
            // btn6
            // 
            btn6.Font = new Font("Segoe UI", 12F);
            btn6.Location = new Point(125, 168);
            btn6.Name = "btn6";
            btn6.Size = new Size(51, 45);
            btn6.TabIndex = 1;
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = true;
            btn6.Click += btn6_Click;
            // 
            // btn1
            // 
            btn1.Font = new Font("Segoe UI", 12F);
            btn1.Location = new Point(11, 219);
            btn1.Name = "btn1";
            btn1.Size = new Size(51, 45);
            btn1.TabIndex = 1;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = true;
            btn1.Click += btn1_Click;
            // 
            // btn2
            // 
            btn2.Font = new Font("Segoe UI", 12F);
            btn2.Location = new Point(68, 219);
            btn2.Name = "btn2";
            btn2.Size = new Size(51, 45);
            btn2.TabIndex = 1;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = true;
            btn2.Click += btn2_Click;
            // 
            // btn3
            // 
            btn3.Font = new Font("Segoe UI", 12F);
            btn3.Location = new Point(125, 219);
            btn3.Name = "btn3";
            btn3.Size = new Size(51, 45);
            btn3.TabIndex = 1;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = true;
            btn3.Click += btn3_Click;
            // 
            // btnSoma
            // 
            btnSoma.Font = new Font("Segoe UI", 12F);
            btnSoma.Location = new Point(182, 168);
            btnSoma.Name = "btnSoma";
            btnSoma.Size = new Size(53, 45);
            btnSoma.TabIndex = 1;
            btnSoma.Text = "+";
            btnSoma.UseVisualStyleBackColor = true;
            btnSoma.Click += btnSoma_Click;
            // 
            // btnLimpar
            // 
            btnLimpar.Font = new Font("Segoe UI", 12F);
            btnLimpar.Location = new Point(11, 66);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(108, 45);
            btnLimpar.TabIndex = 1;
            btnLimpar.Text = "Limpar";
            btnLimpar.UseVisualStyleBackColor = true;
            btnLimpar.Click += btnLimpar_Click;
            // 
            // btnMultiplicacao
            // 
            btnMultiplicacao.Font = new Font("Segoe UI", 12F);
            btnMultiplicacao.Location = new Point(184, 66);
            btnMultiplicacao.Name = "btnMultiplicacao";
            btnMultiplicacao.Size = new Size(53, 45);
            btnMultiplicacao.TabIndex = 1;
            btnMultiplicacao.Text = "X";
            btnMultiplicacao.UseVisualStyleBackColor = true;
            btnMultiplicacao.Click += btnMultiplicacao_Click;
            // 
            // btnDivisao
            // 
            btnDivisao.Font = new Font("Segoe UI", 12F);
            btnDivisao.Location = new Point(125, 66);
            btnDivisao.Name = "btnDivisao";
            btnDivisao.Size = new Size(53, 45);
            btnDivisao.TabIndex = 1;
            btnDivisao.Text = "÷";
            btnDivisao.UseVisualStyleBackColor = true;
            btnDivisao.Click += btnDivisao_Click;
            // 
            // btnIgual
            // 
            btnIgual.Font = new Font("Segoe UI", 12F);
            btnIgual.Location = new Point(182, 219);
            btnIgual.Name = "btnIgual";
            btnIgual.Size = new Size(53, 96);
            btnIgual.TabIndex = 1;
            btnIgual.Text = "=";
            btnIgual.UseVisualStyleBackColor = true;
            btnIgual.Click += btnIgual_Click;
            // 
            // btnSubtracao
            // 
            btnSubtracao.Font = new Font("Segoe UI", 12F);
            btnSubtracao.Location = new Point(184, 117);
            btnSubtracao.Name = "btnSubtracao";
            btnSubtracao.Size = new Size(53, 45);
            btnSubtracao.TabIndex = 1;
            btnSubtracao.Text = "-";
            btnSubtracao.UseVisualStyleBackColor = true;
            btnSubtracao.Click += btnSubtracao_Click;
            // 
            // btn0
            // 
            btn0.Font = new Font("Segoe UI", 12F);
            btn0.Location = new Point(11, 270);
            btn0.Name = "btn0";
            btn0.Size = new Size(108, 45);
            btn0.TabIndex = 1;
            btn0.Text = "0";
            btn0.UseVisualStyleBackColor = true;
            btn0.Click += btn0_Click;
            // 
            // lblCalculo
            // 
            lblCalculo.AutoSize = true;
            lblCalculo.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCalculo.Location = new Point(11, 9);
            lblCalculo.Name = "lblCalculo";
            lblCalculo.Size = new Size(0, 17);
            lblCalculo.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(247, 360);
            Controls.Add(lblCalculo);
            Controls.Add(btnVirgula);
            Controls.Add(btnDivisao);
            Controls.Add(btnMultiplicacao);
            Controls.Add(btn0);
            Controls.Add(btnSubtracao);
            Controls.Add(btnIgual);
            Controls.Add(btnSoma);
            Controls.Add(btn3);
            Controls.Add(btn6);
            Controls.Add(btn9);
            Controls.Add(btnLimpar);
            Controls.Add(btn2);
            Controls.Add(btn5);
            Controls.Add(btn8);
            Controls.Add(btn1);
            Controls.Add(btn4);
            Controls.Add(btn7);
            Controls.Add(txtDisplay);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Calculadora";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtDisplay;
        private Button btn1;
        private Button btn2;
        private Button btn3;
        private Button btn4;
        private Button btn5;
        private Button btn6;
        private Button btn7;
        private Button btn8;
        private Button btn9;
        private Button btnSoma;
        private Button btnLimpar;
        private Button btnMultiplicacao;
        private Button btnDivisao;
        private Button btnIgual;
        private Button btnSubtracao;
        private Button btn0;
        private Button btnVirgula;
        private Label lblCalculo;
    }
}
