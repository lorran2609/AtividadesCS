namespace FormsPilha
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
			this.txtPesquisa = new System.Windows.Forms.TextBox();
			this.btnSetaAvancar = new System.Windows.Forms.Button();
			this.btnSetaVoltar = new System.Windows.Forms.Button();
			this.panel1 = new System.Windows.Forms.Panel();
			this.btnHistorico = new System.Windows.Forms.Button();
			this.btnPesquisar = new System.Windows.Forms.Button();
			this.pnlHistorico = new System.Windows.Forms.Panel();
			this.btnLimparHistorico = new System.Windows.Forms.Button();
			this.lbxHistorico = new System.Windows.Forms.ListBox();
			this.lblSite = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.panel2 = new System.Windows.Forms.Panel();
			this.panel1.SuspendLayout();
			this.pnlHistorico.SuspendLayout();
			this.panel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// txtPesquisa
			// 
			this.txtPesquisa.BackColor = System.Drawing.SystemColors.Window;
			this.txtPesquisa.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtPesquisa.Location = new System.Drawing.Point(110, 25);
			this.txtPesquisa.Name = "txtPesquisa";
			this.txtPesquisa.Size = new System.Drawing.Size(427, 27);
			this.txtPesquisa.TabIndex = 0;
			// 
			// btnSetaAvancar
			// 
			this.btnSetaAvancar.BackColor = System.Drawing.SystemColors.Window;
			this.btnSetaAvancar.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSetaAvancar.Image = ((System.Drawing.Image)(resources.GetObject("btnSetaAvancar.Image")));
			this.btnSetaAvancar.Location = new System.Drawing.Point(59, 25);
			this.btnSetaAvancar.Name = "btnSetaAvancar";
			this.btnSetaAvancar.Size = new System.Drawing.Size(27, 27);
			this.btnSetaAvancar.TabIndex = 1;
			this.btnSetaAvancar.UseVisualStyleBackColor = false;
			this.btnSetaAvancar.Click += new System.EventHandler(this.btnSetaAvancar_Click);
			// 
			// btnSetaVoltar
			// 
			this.btnSetaVoltar.BackColor = System.Drawing.SystemColors.Window;
			this.btnSetaVoltar.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSetaVoltar.Image = ((System.Drawing.Image)(resources.GetObject("btnSetaVoltar.Image")));
			this.btnSetaVoltar.Location = new System.Drawing.Point(26, 25);
			this.btnSetaVoltar.Name = "btnSetaVoltar";
			this.btnSetaVoltar.Size = new System.Drawing.Size(27, 27);
			this.btnSetaVoltar.TabIndex = 1;
			this.btnSetaVoltar.UseVisualStyleBackColor = false;
			this.btnSetaVoltar.Click += new System.EventHandler(this.btnSetaVoltar_Click);
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.SystemColors.ButtonShadow;
			this.panel1.Controls.Add(this.txtPesquisa);
			this.panel1.Controls.Add(this.btnSetaVoltar);
			this.panel1.Controls.Add(this.btnHistorico);
			this.panel1.Controls.Add(this.btnPesquisar);
			this.panel1.Controls.Add(this.btnSetaAvancar);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(800, 76);
			this.panel1.TabIndex = 2;
			// 
			// btnHistorico
			// 
			this.btnHistorico.BackColor = System.Drawing.SystemColors.Window;
			this.btnHistorico.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnHistorico.Location = new System.Drawing.Point(657, 25);
			this.btnHistorico.Name = "btnHistorico";
			this.btnHistorico.Size = new System.Drawing.Size(111, 27);
			this.btnHistorico.TabIndex = 1;
			this.btnHistorico.Text = "HISTÓRICO";
			this.btnHistorico.UseVisualStyleBackColor = false;
			this.btnHistorico.Click += new System.EventHandler(this.btnHistorico_Click);
			// 
			// btnPesquisar
			// 
			this.btnPesquisar.BackColor = System.Drawing.SystemColors.Window;
			this.btnPesquisar.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnPesquisar.Image = ((System.Drawing.Image)(resources.GetObject("btnPesquisar.Image")));
			this.btnPesquisar.Location = new System.Drawing.Point(565, 25);
			this.btnPesquisar.Name = "btnPesquisar";
			this.btnPesquisar.Size = new System.Drawing.Size(27, 27);
			this.btnPesquisar.TabIndex = 1;
			this.btnPesquisar.UseVisualStyleBackColor = false;
			this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
			// 
			// pnlHistorico
			// 
			this.pnlHistorico.BackColor = System.Drawing.SystemColors.ButtonShadow;
			this.pnlHistorico.Controls.Add(this.btnLimparHistorico);
			this.pnlHistorico.Controls.Add(this.lbxHistorico);
			this.pnlHistorico.Dock = System.Windows.Forms.DockStyle.Right;
			this.pnlHistorico.Location = new System.Drawing.Point(624, 76);
			this.pnlHistorico.Name = "pnlHistorico";
			this.pnlHistorico.Size = new System.Drawing.Size(176, 374);
			this.pnlHistorico.TabIndex = 3;
			this.pnlHistorico.Visible = false;
			// 
			// btnLimparHistorico
			// 
			this.btnLimparHistorico.BackColor = System.Drawing.SystemColors.Window;
			this.btnLimparHistorico.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnLimparHistorico.Location = new System.Drawing.Point(33, 319);
			this.btnLimparHistorico.Name = "btnLimparHistorico";
			this.btnLimparHistorico.Size = new System.Drawing.Size(111, 43);
			this.btnLimparHistorico.TabIndex = 2;
			this.btnLimparHistorico.Text = "LIMPAR HISTÓRICO";
			this.btnLimparHistorico.UseVisualStyleBackColor = false;
			this.btnLimparHistorico.Click += new System.EventHandler(this.btnLimparHistorico_Click);
			// 
			// lbxHistorico
			// 
			this.lbxHistorico.FormattingEnabled = true;
			this.lbxHistorico.Location = new System.Drawing.Point(15, 10);
			this.lbxHistorico.Name = "lbxHistorico";
			this.lbxHistorico.Size = new System.Drawing.Size(147, 303);
			this.lbxHistorico.TabIndex = 0;
			// 
			// lblSite
			// 
			this.lblSite.AutoSize = true;
			this.lblSite.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblSite.Location = new System.Drawing.Point(164, 171);
			this.lblSite.Name = "lblSite";
			this.lblSite.Size = new System.Drawing.Size(0, 32);
			this.lblSite.TabIndex = 2;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(54, 171);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(104, 30);
			this.label1.TabIndex = 4;
			this.label1.Text = "Site atual:";
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.SystemColors.Window;
			this.panel2.Controls.Add(this.label1);
			this.panel2.Controls.Add(this.lblSite);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel2.Location = new System.Drawing.Point(0, 76);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(624, 374);
			this.panel2.TabIndex = 4;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.pnlHistorico);
			this.Controls.Add(this.panel1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.pnlHistorico.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtPesquisa;
        private System.Windows.Forms.Button btnSetaAvancar;
        private System.Windows.Forms.Button btnSetaVoltar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnHistorico;
        private System.Windows.Forms.Panel pnlHistorico;
        private System.Windows.Forms.ListBox lbxHistorico;
        private System.Windows.Forms.Label lblSite;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Button btnLimparHistorico;
        private System.Windows.Forms.Panel panel2;
    }
}

