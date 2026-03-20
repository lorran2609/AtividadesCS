namespace FormLoginPage
{
    partial class F_TelaPrincipal
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F_TelaPrincipal));
			this.panel1 = new System.Windows.Forms.Panel();
			this.label1 = new System.Windows.Forms.Label();
			this.btnLogOut = new System.Windows.Forms.Button();
			this.lblMensagem = new System.Windows.Forms.Label();
			this.pnlAdmin = new System.Windows.Forms.Panel();
			this.pnlExcluir = new System.Windows.Forms.Panel();
			this.btnFecharExcluir = new System.Windows.Forms.Button();
			this.btnExcluir = new System.Windows.Forms.Button();
			this.txtExclusao = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.btnExcluirUser = new System.Windows.Forms.Button();
			this.listBox1 = new System.Windows.Forms.ListBox();
			this.label2 = new System.Windows.Forms.Label();
			this.panel1.SuspendLayout();
			this.pnlAdmin.SuspendLayout();
			this.pnlExcluir.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.Gray;
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.btnLogOut);
			this.panel1.Controls.Add(this.lblMensagem);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(800, 80);
			this.panel1.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(312, 25);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(177, 30);
			this.label1.TabIndex = 2;
			this.label1.Text = "TELA PRINCIPAL";
			// 
			// btnLogOut
			// 
			this.btnLogOut.Image = ((System.Drawing.Image)(resources.GetObject("btnLogOut.Image")));
			this.btnLogOut.Location = new System.Drawing.Point(734, 20);
			this.btnLogOut.Name = "btnLogOut";
			this.btnLogOut.Size = new System.Drawing.Size(40, 40);
			this.btnLogOut.TabIndex = 1;
			this.btnLogOut.UseVisualStyleBackColor = true;
			this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
			// 
			// lblMensagem
			// 
			this.lblMensagem.AutoSize = true;
			this.lblMensagem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblMensagem.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.lblMensagem.Location = new System.Drawing.Point(3, 62);
			this.lblMensagem.Name = "lblMensagem";
			this.lblMensagem.Size = new System.Drawing.Size(40, 15);
			this.lblMensagem.TabIndex = 0;
			this.lblMensagem.Text = "label1";
			// 
			// pnlAdmin
			// 
			this.pnlAdmin.BackColor = System.Drawing.Color.WhiteSmoke;
			this.pnlAdmin.Controls.Add(this.pnlExcluir);
			this.pnlAdmin.Controls.Add(this.btnExcluirUser);
			this.pnlAdmin.Controls.Add(this.listBox1);
			this.pnlAdmin.Controls.Add(this.label2);
			this.pnlAdmin.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pnlAdmin.Location = new System.Drawing.Point(0, 80);
			this.pnlAdmin.Name = "pnlAdmin";
			this.pnlAdmin.Size = new System.Drawing.Size(800, 370);
			this.pnlAdmin.TabIndex = 1;
			// 
			// pnlExcluir
			// 
			this.pnlExcluir.Controls.Add(this.btnFecharExcluir);
			this.pnlExcluir.Controls.Add(this.btnExcluir);
			this.pnlExcluir.Controls.Add(this.txtExclusao);
			this.pnlExcluir.Controls.Add(this.label3);
			this.pnlExcluir.Location = new System.Drawing.Point(525, 246);
			this.pnlExcluir.Name = "pnlExcluir";
			this.pnlExcluir.Size = new System.Drawing.Size(213, 109);
			this.pnlExcluir.TabIndex = 3;
			this.pnlExcluir.Visible = false;
			// 
			// btnFecharExcluir
			// 
			this.btnFecharExcluir.Image = ((System.Drawing.Image)(resources.GetObject("btnFecharExcluir.Image")));
			this.btnFecharExcluir.Location = new System.Drawing.Point(190, 3);
			this.btnFecharExcluir.Name = "btnFecharExcluir";
			this.btnFecharExcluir.Size = new System.Drawing.Size(20, 20);
			this.btnFecharExcluir.TabIndex = 2;
			this.btnFecharExcluir.UseVisualStyleBackColor = true;
			this.btnFecharExcluir.Click += new System.EventHandler(this.btnFecharExcluir_Click);
			// 
			// btnExcluir
			// 
			this.btnExcluir.BackColor = System.Drawing.Color.Firebrick;
			this.btnExcluir.FlatAppearance.BorderSize = 0;
			this.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnExcluir.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnExcluir.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.btnExcluir.Location = new System.Drawing.Point(6, 76);
			this.btnExcluir.Name = "btnExcluir";
			this.btnExcluir.Size = new System.Drawing.Size(105, 28);
			this.btnExcluir.TabIndex = 1;
			this.btnExcluir.Text = "EXCLUIR";
			this.btnExcluir.UseVisualStyleBackColor = false;
			this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
			// 
			// txtExclusao
			// 
			this.txtExclusao.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtExclusao.Location = new System.Drawing.Point(6, 41);
			this.txtExclusao.Name = "txtExclusao";
			this.txtExclusao.Size = new System.Drawing.Size(105, 29);
			this.txtExclusao.TabIndex = 0;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(6, 25);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(200, 13);
			this.label3.TabIndex = 0;
			this.label3.Text = "Digite o ID do usuario que deseja excluir:";
			// 
			// btnExcluirUser
			// 
			this.btnExcluirUser.BackColor = System.Drawing.Color.Firebrick;
			this.btnExcluirUser.FlatAppearance.BorderSize = 0;
			this.btnExcluirUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnExcluirUser.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnExcluirUser.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.btnExcluirUser.Location = new System.Drawing.Point(525, 297);
			this.btnExcluirUser.Name = "btnExcluirUser";
			this.btnExcluirUser.Size = new System.Drawing.Size(105, 58);
			this.btnExcluirUser.TabIndex = 0;
			this.btnExcluirUser.Text = "EXCLUIR USUARIO";
			this.btnExcluirUser.UseVisualStyleBackColor = false;
			this.btnExcluirUser.Click += new System.EventHandler(this.btnExcluirUser_Click);
			// 
			// listBox1
			// 
			this.listBox1.FormattingEnabled = true;
			this.listBox1.Location = new System.Drawing.Point(282, 39);
			this.listBox1.Name = "listBox1";
			this.listBox1.Size = new System.Drawing.Size(237, 316);
			this.listBox1.TabIndex = 1;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(325, 15);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(156, 21);
			this.label2.TabIndex = 0;
			this.label2.Text = "LISTA DE USUARIOS";
			// 
			// F_TelaPrincipal
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.LightGray;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.pnlAdmin);
			this.Controls.Add(this.panel1);
			this.Name = "F_TelaPrincipal";
			this.Text = "Tela Principal";
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.pnlAdmin.ResumeLayout(false);
			this.pnlAdmin.PerformLayout();
			this.pnlExcluir.ResumeLayout(false);
			this.pnlExcluir.PerformLayout();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblMensagem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Panel pnlAdmin;
        private System.Windows.Forms.Button btnExcluirUser;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pnlExcluir;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtExclusao;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnFecharExcluir;
    }
}