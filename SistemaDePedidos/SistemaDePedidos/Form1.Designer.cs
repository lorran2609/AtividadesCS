namespace SistemaDePedidos
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
			this.panel1 = new System.Windows.Forms.Panel();
			this.btnPosicao = new System.Windows.Forms.Button();
			this.btnInverter = new System.Windows.Forms.Button();
			this.btnLimpar = new System.Windows.Forms.Button();
			this.btnRemover = new System.Windows.Forms.Button();
			this.btnOrdenar = new System.Windows.Forms.Button();
			this.btnCadastro = new System.Windows.Forms.Button();
			this.btnAtender = new System.Windows.Forms.Button();
			this.panel2 = new System.Windows.Forms.Panel();
			this.label1 = new System.Windows.Forms.Label();
			this.listBox1 = new System.Windows.Forms.ListBox();
			this.listBox2 = new System.Windows.Forms.ListBox();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(38)))), ((int)(((byte)(28)))));
			this.panel1.Controls.Add(this.btnPosicao);
			this.panel1.Controls.Add(this.btnInverter);
			this.panel1.Controls.Add(this.btnLimpar);
			this.panel1.Controls.Add(this.btnRemover);
			this.panel1.Controls.Add(this.btnOrdenar);
			this.panel1.Controls.Add(this.btnCadastro);
			this.panel1.Controls.Add(this.btnAtender);
			this.panel1.Location = new System.Drawing.Point(221, 76);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(339, 362);
			this.panel1.TabIndex = 0;
			// 
			// btnPosicao
			// 
			this.btnPosicao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(82)))), ((int)(((byte)(48)))));
			this.btnPosicao.FlatAppearance.BorderSize = 0;
			this.btnPosicao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnPosicao.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnPosicao.ForeColor = System.Drawing.Color.White;
			this.btnPosicao.Location = new System.Drawing.Point(98, 162);
			this.btnPosicao.Name = "btnPosicao";
			this.btnPosicao.Size = new System.Drawing.Size(143, 39);
			this.btnPosicao.TabIndex = 0;
			this.btnPosicao.Text = "Posição de pedido";
			this.btnPosicao.UseVisualStyleBackColor = false;
			this.btnPosicao.Click += new System.EventHandler(this.btnPosicao_Click);
			// 
			// btnInverter
			// 
			this.btnInverter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(82)))), ((int)(((byte)(48)))));
			this.btnInverter.FlatAppearance.BorderSize = 0;
			this.btnInverter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnInverter.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnInverter.ForeColor = System.Drawing.Color.White;
			this.btnInverter.Location = new System.Drawing.Point(98, 264);
			this.btnInverter.Name = "btnInverter";
			this.btnInverter.Size = new System.Drawing.Size(143, 39);
			this.btnInverter.TabIndex = 0;
			this.btnInverter.Text = "Inverter a lista";
			this.btnInverter.UseVisualStyleBackColor = false;
			this.btnInverter.Click += new System.EventHandler(this.btnInverter_Click);
			// 
			// btnLimpar
			// 
			this.btnLimpar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(82)))), ((int)(((byte)(48)))));
			this.btnLimpar.FlatAppearance.BorderSize = 0;
			this.btnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnLimpar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnLimpar.ForeColor = System.Drawing.Color.White;
			this.btnLimpar.Location = new System.Drawing.Point(98, 315);
			this.btnLimpar.Name = "btnLimpar";
			this.btnLimpar.Size = new System.Drawing.Size(143, 39);
			this.btnLimpar.TabIndex = 0;
			this.btnLimpar.Text = "Limpar pedidos";
			this.btnLimpar.UseVisualStyleBackColor = false;
			this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
			// 
			// btnRemover
			// 
			this.btnRemover.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(82)))), ((int)(((byte)(48)))));
			this.btnRemover.FlatAppearance.BorderSize = 0;
			this.btnRemover.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnRemover.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnRemover.ForeColor = System.Drawing.Color.White;
			this.btnRemover.Location = new System.Drawing.Point(98, 111);
			this.btnRemover.Name = "btnRemover";
			this.btnRemover.Size = new System.Drawing.Size(143, 39);
			this.btnRemover.TabIndex = 0;
			this.btnRemover.Text = "Remover um pedido";
			this.btnRemover.UseVisualStyleBackColor = false;
			this.btnRemover.Click += new System.EventHandler(this.btnRemover_Click);
			// 
			// btnOrdenar
			// 
			this.btnOrdenar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(82)))), ((int)(((byte)(48)))));
			this.btnOrdenar.FlatAppearance.BorderSize = 0;
			this.btnOrdenar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnOrdenar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnOrdenar.ForeColor = System.Drawing.Color.White;
			this.btnOrdenar.Location = new System.Drawing.Point(98, 213);
			this.btnOrdenar.Name = "btnOrdenar";
			this.btnOrdenar.Size = new System.Drawing.Size(143, 39);
			this.btnOrdenar.TabIndex = 0;
			this.btnOrdenar.Text = "Ordenar a lista";
			this.btnOrdenar.UseVisualStyleBackColor = false;
			this.btnOrdenar.Click += new System.EventHandler(this.btnOrdenar_Click);
			// 
			// btnCadastro
			// 
			this.btnCadastro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(82)))), ((int)(((byte)(48)))));
			this.btnCadastro.FlatAppearance.BorderSize = 0;
			this.btnCadastro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnCadastro.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCadastro.ForeColor = System.Drawing.Color.White;
			this.btnCadastro.Location = new System.Drawing.Point(98, 9);
			this.btnCadastro.Name = "btnCadastro";
			this.btnCadastro.Size = new System.Drawing.Size(143, 39);
			this.btnCadastro.TabIndex = 0;
			this.btnCadastro.Text = "Cadastrar pedido";
			this.btnCadastro.UseVisualStyleBackColor = false;
			this.btnCadastro.Click += new System.EventHandler(this.btnCadastro_Click);
			// 
			// btnAtender
			// 
			this.btnAtender.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(82)))), ((int)(((byte)(48)))));
			this.btnAtender.FlatAppearance.BorderSize = 0;
			this.btnAtender.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnAtender.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAtender.ForeColor = System.Drawing.Color.White;
			this.btnAtender.Location = new System.Drawing.Point(98, 60);
			this.btnAtender.Name = "btnAtender";
			this.btnAtender.Size = new System.Drawing.Size(143, 39);
			this.btnAtender.TabIndex = 0;
			this.btnAtender.Text = "Atender um pedido";
			this.btnAtender.UseVisualStyleBackColor = false;
			this.btnAtender.Click += new System.EventHandler(this.btnAtender_Click);
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(38)))), ((int)(((byte)(28)))));
			this.panel2.Controls.Add(this.label1);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel2.Location = new System.Drawing.Point(0, 0);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(784, 70);
			this.panel2.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(275, 19);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(234, 32);
			this.label1.TabIndex = 0;
			this.label1.Text = "MENU DE PEDIDOS";
			// 
			// listBox1
			// 
			this.listBox1.FormattingEnabled = true;
			this.listBox1.Location = new System.Drawing.Point(25, 96);
			this.listBox1.Name = "listBox1";
			this.listBox1.Size = new System.Drawing.Size(162, 316);
			this.listBox1.TabIndex = 2;
			// 
			// listBox2
			// 
			this.listBox2.FormattingEnabled = true;
			this.listBox2.Location = new System.Drawing.Point(595, 96);
			this.listBox2.Name = "listBox2";
			this.listBox2.Size = new System.Drawing.Size(162, 316);
			this.listBox2.TabIndex = 3;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(209)))), ((int)(((byte)(51)))));
			this.ClientSize = new System.Drawing.Size(784, 450);
			this.Controls.Add(this.listBox2);
			this.Controls.Add(this.listBox1);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.panel1.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnPosicao;
        private System.Windows.Forms.Button btnInverter;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnRemover;
        private System.Windows.Forms.Button btnOrdenar;
        private System.Windows.Forms.Button btnCadastro;
        private System.Windows.Forms.Button btnAtender;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
    }
}

