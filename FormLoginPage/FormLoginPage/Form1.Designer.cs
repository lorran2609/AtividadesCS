namespace FormLoginPage
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.panel1 = new System.Windows.Forms.Panel();
			this.pnlCadastro = new System.Windows.Forms.Panel();
			this.btnSairCadastro = new System.Windows.Forms.Button();
			this.btnCadastrar = new System.Windows.Forms.Button();
			this.label7 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.cbxTipoUser = new System.Windows.Forms.ComboBox();
			this.txtNomeUser = new System.Windows.Forms.TextBox();
			this.txtConfirmSenha = new System.Windows.Forms.TextBox();
			this.txtSenha = new System.Windows.Forms.TextBox();
			this.txtNumTel = new System.Windows.Forms.TextBox();
			this.txtNomeComp = new System.Windows.Forms.TextBox();
			this.panel2 = new System.Windows.Forms.Panel();
			this.lblErro = new System.Windows.Forms.Label();
			this.btnCadastro = new System.Windows.Forms.Button();
			this.btnEntrar = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.txtPassword = new System.Windows.Forms.TextBox();
			this.txtLogin = new System.Windows.Forms.TextBox();
			this.panel1.SuspendLayout();
			this.pnlCadastro.SuspendLayout();
			this.panel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.DarkGray;
			this.panel1.Controls.Add(this.pnlCadastro);
			this.panel1.Controls.Add(this.panel2);
			this.panel1.Location = new System.Drawing.Point(12, 12);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(776, 426);
			this.panel1.TabIndex = 0;
			// 
			// pnlCadastro
			// 
			this.pnlCadastro.BackColor = System.Drawing.Color.WhiteSmoke;
			this.pnlCadastro.Controls.Add(this.btnSairCadastro);
			this.pnlCadastro.Controls.Add(this.btnCadastrar);
			this.pnlCadastro.Controls.Add(this.label7);
			this.pnlCadastro.Controls.Add(this.label9);
			this.pnlCadastro.Controls.Add(this.label8);
			this.pnlCadastro.Controls.Add(this.label6);
			this.pnlCadastro.Controls.Add(this.label5);
			this.pnlCadastro.Controls.Add(this.label4);
			this.pnlCadastro.Controls.Add(this.cbxTipoUser);
			this.pnlCadastro.Controls.Add(this.txtNomeUser);
			this.pnlCadastro.Controls.Add(this.txtConfirmSenha);
			this.pnlCadastro.Controls.Add(this.txtSenha);
			this.pnlCadastro.Controls.Add(this.txtNumTel);
			this.pnlCadastro.Controls.Add(this.txtNomeComp);
			this.pnlCadastro.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.pnlCadastro.Location = new System.Drawing.Point(157, 3);
			this.pnlCadastro.Name = "pnlCadastro";
			this.pnlCadastro.Size = new System.Drawing.Size(462, 420);
			this.pnlCadastro.TabIndex = 1;
			this.pnlCadastro.Visible = false;
			// 
			// btnSairCadastro
			// 
			this.btnSairCadastro.Image = ((System.Drawing.Image)(resources.GetObject("btnSairCadastro.Image")));
			this.btnSairCadastro.Location = new System.Drawing.Point(429, 3);
			this.btnSairCadastro.Name = "btnSairCadastro";
			this.btnSairCadastro.Size = new System.Drawing.Size(30, 30);
			this.btnSairCadastro.TabIndex = 5;
			this.btnSairCadastro.UseVisualStyleBackColor = true;
			this.btnSairCadastro.Click += new System.EventHandler(this.btnSairCadastro_Click);
			// 
			// btnCadastrar
			// 
			this.btnCadastrar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCadastrar.Location = new System.Drawing.Point(150, 355);
			this.btnCadastrar.Name = "btnCadastrar";
			this.btnCadastrar.Size = new System.Drawing.Size(163, 37);
			this.btnCadastrar.TabIndex = 4;
			this.btnCadastrar.Text = "Cadastre-se";
			this.btnCadastrar.UseVisualStyleBackColor = true;
			this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(106, 104);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(96, 13);
			this.label7.TabIndex = 3;
			this.label7.Text = "Nome de Usuario";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label9.Location = new System.Drawing.Point(106, 262);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(93, 13);
			this.label9.TabIndex = 3;
			this.label9.Text = "Confirmar Senha";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.Location = new System.Drawing.Point(106, 207);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(39, 13);
			this.label8.TabIndex = 3;
			this.label8.Text = "Senha";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(106, 154);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(103, 13);
			this.label6.TabIndex = 3;
			this.label6.Text = "Número de Celular";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(106, 52);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(90, 13);
			this.label5.TabIndex = 3;
			this.label5.Text = "Nome Completo";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(180, 16);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(102, 25);
			this.label4.TabIndex = 2;
			this.label4.Text = "REGISTRO";
			// 
			// cbxTipoUser
			// 
			this.cbxTipoUser.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbxTipoUser.FormattingEnabled = true;
			this.cbxTipoUser.Items.AddRange(new object[] {
            "Administrador",
            "Comum"});
			this.cbxTipoUser.Location = new System.Drawing.Point(106, 313);
			this.cbxTipoUser.Name = "cbxTipoUser";
			this.cbxTipoUser.Size = new System.Drawing.Size(116, 25);
			this.cbxTipoUser.TabIndex = 1;
			this.cbxTipoUser.Text = "Tipo de usuário";
			// 
			// txtNomeUser
			// 
			this.txtNomeUser.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtNomeUser.Location = new System.Drawing.Point(106, 124);
			this.txtNomeUser.Name = "txtNomeUser";
			this.txtNomeUser.Size = new System.Drawing.Size(251, 25);
			this.txtNomeUser.TabIndex = 0;
			// 
			// txtConfirmSenha
			// 
			this.txtConfirmSenha.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtConfirmSenha.Location = new System.Drawing.Point(106, 282);
			this.txtConfirmSenha.Name = "txtConfirmSenha";
			this.txtConfirmSenha.Size = new System.Drawing.Size(251, 25);
			this.txtConfirmSenha.TabIndex = 0;
			// 
			// txtSenha
			// 
			this.txtSenha.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtSenha.Location = new System.Drawing.Point(106, 227);
			this.txtSenha.Name = "txtSenha";
			this.txtSenha.Size = new System.Drawing.Size(251, 25);
			this.txtSenha.TabIndex = 0;
			// 
			// txtNumTel
			// 
			this.txtNumTel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtNumTel.Location = new System.Drawing.Point(106, 174);
			this.txtNumTel.Name = "txtNumTel";
			this.txtNumTel.Size = new System.Drawing.Size(251, 25);
			this.txtNumTel.TabIndex = 0;
			// 
			// txtNomeComp
			// 
			this.txtNomeComp.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtNomeComp.Location = new System.Drawing.Point(106, 72);
			this.txtNomeComp.Name = "txtNomeComp";
			this.txtNomeComp.Size = new System.Drawing.Size(251, 25);
			this.txtNomeComp.TabIndex = 0;
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.WhiteSmoke;
			this.panel2.Controls.Add(this.lblErro);
			this.panel2.Controls.Add(this.btnCadastro);
			this.panel2.Controls.Add(this.btnEntrar);
			this.panel2.Controls.Add(this.label3);
			this.panel2.Controls.Add(this.label2);
			this.panel2.Controls.Add(this.label1);
			this.panel2.Controls.Add(this.txtPassword);
			this.panel2.Controls.Add(this.txtLogin);
			this.panel2.Location = new System.Drawing.Point(247, 48);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(280, 322);
			this.panel2.TabIndex = 0;
			// 
			// lblErro
			// 
			this.lblErro.AutoSize = true;
			this.lblErro.BackColor = System.Drawing.Color.Transparent;
			this.lblErro.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblErro.ForeColor = System.Drawing.Color.Red;
			this.lblErro.Location = new System.Drawing.Point(29, 174);
			this.lblErro.Name = "lblErro";
			this.lblErro.Size = new System.Drawing.Size(48, 13);
			this.lblErro.TabIndex = 5;
			this.lblErro.Text = "label10";
			this.lblErro.Visible = false;
			// 
			// btnCadastro
			// 
			this.btnCadastro.FlatAppearance.BorderSize = 0;
			this.btnCadastro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnCadastro.Location = new System.Drawing.Point(63, 298);
			this.btnCadastro.Name = "btnCadastro";
			this.btnCadastro.Size = new System.Drawing.Size(150, 21);
			this.btnCadastro.TabIndex = 4;
			this.btnCadastro.Text = "Não tem conta? Cadastre-se";
			this.btnCadastro.UseVisualStyleBackColor = true;
			this.btnCadastro.Click += new System.EventHandler(this.btnCadastro_Click);
			// 
			// btnEntrar
			// 
			this.btnEntrar.BackColor = System.Drawing.Color.Silver;
			this.btnEntrar.FlatAppearance.BorderSize = 0;
			this.btnEntrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnEntrar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnEntrar.Location = new System.Drawing.Point(67, 208);
			this.btnEntrar.Name = "btnEntrar";
			this.btnEntrar.Size = new System.Drawing.Size(146, 39);
			this.btnEntrar.TabIndex = 3;
			this.btnEntrar.Text = "ENTRAR";
			this.btnEntrar.UseVisualStyleBackColor = false;
			this.btnEntrar.Click += new System.EventHandler(this.btnEntrar_Click);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(26, 130);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(39, 13);
			this.label3.TabIndex = 2;
			this.label3.Text = "Senha";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(26, 60);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(47, 13);
			this.label2.TabIndex = 2;
			this.label2.Text = "Usuario";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(105, 13);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(71, 25);
			this.label1.TabIndex = 1;
			this.label1.Text = "LOGIN";
			// 
			// txtPassword
			// 
			this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtPassword.Location = new System.Drawing.Point(26, 146);
			this.txtPassword.Name = "txtPassword";
			this.txtPassword.Size = new System.Drawing.Size(229, 25);
			this.txtPassword.TabIndex = 0;
			// 
			// txtLogin
			// 
			this.txtLogin.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtLogin.Location = new System.Drawing.Point(26, 76);
			this.txtLogin.Name = "txtLogin";
			this.txtLogin.Size = new System.Drawing.Size(229, 25);
			this.txtLogin.TabIndex = 0;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.panel1);
			this.Name = "Form1";
			this.Text = "LOGIN";
			this.panel1.ResumeLayout(false);
			this.pnlCadastro.ResumeLayout(false);
			this.pnlCadastro.PerformLayout();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.Button btnCadastro;
        private System.Windows.Forms.Button btnEntrar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pnlCadastro;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbxTipoUser;
        private System.Windows.Forms.TextBox txtNomeComp;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNomeUser;
        private System.Windows.Forms.TextBox txtConfirmSenha;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.TextBox txtNumTel;
        private System.Windows.Forms.Button btnSairCadastro;
        private System.Windows.Forms.Label lblErro;
    }
}

