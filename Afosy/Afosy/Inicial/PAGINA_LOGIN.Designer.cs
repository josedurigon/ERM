namespace Afosy
{
    partial class PAGINA_LOGIN
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PAGINA_LOGIN));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LOGIN_CAIXA = new System.Windows.Forms.TextBox();
            this.SENHA_CAIXA = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BOTAO_ENTRAR = new System.Windows.Forms.Button();
            this.linkCadastrarPaginaLogin = new System.Windows.Forms.LinkLabel();
            this.linkEsqueciMinhaSenha = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(198, 500);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "LOGIN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(198, 579);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "SENHA";
            // 
            // LOGIN_CAIXA
            // 
            this.LOGIN_CAIXA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LOGIN_CAIXA.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LOGIN_CAIXA.Location = new System.Drawing.Point(331, 503);
            this.LOGIN_CAIXA.Name = "LOGIN_CAIXA";
            this.LOGIN_CAIXA.Size = new System.Drawing.Size(396, 24);
            this.LOGIN_CAIXA.TabIndex = 2;
            // 
            // SENHA_CAIXA
            // 
            this.SENHA_CAIXA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SENHA_CAIXA.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SENHA_CAIXA.Location = new System.Drawing.Point(331, 582);
            this.SENHA_CAIXA.Name = "SENHA_CAIXA";
            this.SENHA_CAIXA.Size = new System.Drawing.Size(396, 24);
            this.SENHA_CAIXA.TabIndex = 3;
            this.SENHA_CAIXA.UseSystemPasswordChar = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(331, 107);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(343, 264);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // BOTAO_ENTRAR
            // 
            this.BOTAO_ENTRAR.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BOTAO_ENTRAR.Location = new System.Drawing.Point(411, 704);
            this.BOTAO_ENTRAR.Name = "BOTAO_ENTRAR";
            this.BOTAO_ENTRAR.Size = new System.Drawing.Size(182, 52);
            this.BOTAO_ENTRAR.TabIndex = 5;
            this.BOTAO_ENTRAR.Text = "ENTRAR";
            this.BOTAO_ENTRAR.UseVisualStyleBackColor = true;
            this.BOTAO_ENTRAR.Click += new System.EventHandler(this.BOTAO_ENTRAR_Click);
            // 
            // linkCadastrarPaginaLogin
            // 
            this.linkCadastrarPaginaLogin.AutoSize = true;
            this.linkCadastrarPaginaLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkCadastrarPaginaLogin.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(56)))), ((int)(((byte)(200)))));
            this.linkCadastrarPaginaLogin.Location = new System.Drawing.Point(462, 788);
            this.linkCadastrarPaginaLogin.Name = "linkCadastrarPaginaLogin";
            this.linkCadastrarPaginaLogin.Size = new System.Drawing.Size(79, 17);
            this.linkCadastrarPaginaLogin.TabIndex = 6;
            this.linkCadastrarPaginaLogin.TabStop = true;
            this.linkCadastrarPaginaLogin.Text = "Cadastrar";
            this.linkCadastrarPaginaLogin.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkCadastrarPaginaLogin_LinkClicked);
            // 
            // linkEsqueciMinhaSenha
            // 
            this.linkEsqueciMinhaSenha.AutoSize = true;
            this.linkEsqueciMinhaSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkEsqueciMinhaSenha.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(56)))), ((int)(((byte)(200)))));
            this.linkEsqueciMinhaSenha.Location = new System.Drawing.Point(419, 822);
            this.linkEsqueciMinhaSenha.Name = "linkEsqueciMinhaSenha";
            this.linkEsqueciMinhaSenha.Size = new System.Drawing.Size(162, 17);
            this.linkEsqueciMinhaSenha.TabIndex = 7;
            this.linkEsqueciMinhaSenha.TabStop = true;
            this.linkEsqueciMinhaSenha.Text = "Esqueci minha senha";
            this.linkEsqueciMinhaSenha.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkEsqueciMinhaSenha_LinkClicked);
            // 
            // PAGINA_LOGIN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(984, 911);
            this.Controls.Add(this.linkEsqueciMinhaSenha);
            this.Controls.Add(this.linkCadastrarPaginaLogin);
            this.Controls.Add(this.BOTAO_ENTRAR);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.SENHA_CAIXA);
            this.Controls.Add(this.LOGIN_CAIXA);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "PAGINA_LOGIN";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AFOSY";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox LOGIN_CAIXA;
        private System.Windows.Forms.TextBox SENHA_CAIXA;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button BOTAO_ENTRAR;
        private System.Windows.Forms.LinkLabel linkCadastrarPaginaLogin;
        private System.Windows.Forms.LinkLabel linkEsqueciMinhaSenha;
    }
}

