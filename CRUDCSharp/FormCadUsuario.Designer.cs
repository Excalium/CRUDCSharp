
namespace CRUDCSharp
{
    partial class FormCadUsuario
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
            this.labelRazao = new System.Windows.Forms.Label();
            this.labelLogin = new System.Windows.Forms.Label();
            this.labelSenha = new System.Windows.Forms.Label();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.tbNome = new System.Windows.Forms.TextBox();
            this.tbLogin = new System.Windows.Forms.TextBox();
            this.tbSenha = new System.Windows.Forms.TextBox();
            this.lbCodigo = new System.Windows.Forms.Label();
            this.tbCodigo = new System.Windows.Forms.TextBox();
            this.cboxAdmin = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // labelRazao
            // 
            this.labelRazao.AutoSize = true;
            this.labelRazao.Location = new System.Drawing.Point(26, 48);
            this.labelRazao.Name = "labelRazao";
            this.labelRazao.Size = new System.Drawing.Size(39, 13);
            this.labelRazao.TabIndex = 0;
            this.labelRazao.Text = "Nome*";
            // 
            // labelLogin
            // 
            this.labelLogin.AutoSize = true;
            this.labelLogin.Location = new System.Drawing.Point(26, 91);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(37, 13);
            this.labelLogin.TabIndex = 1;
            this.labelLogin.Text = "Login*";
            // 
            // labelSenha
            // 
            this.labelSenha.AutoSize = true;
            this.labelSenha.Location = new System.Drawing.Point(177, 91);
            this.labelSenha.Name = "labelSenha";
            this.labelSenha.Size = new System.Drawing.Size(42, 13);
            this.labelSenha.TabIndex = 2;
            this.labelSenha.Text = "Senha*";
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(208, 144);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(92, 33);
            this.btnSalvar.TabIndex = 4;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(110, 144);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(92, 33);
            this.btnCancelar.TabIndex = 23;
            this.btnCancelar.TabStop = false;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(12, 144);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(92, 33);
            this.btnExcluir.TabIndex = 22;
            this.btnExcluir.TabStop = false;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // tbNome
            // 
            this.tbNome.Location = new System.Drawing.Point(29, 66);
            this.tbNome.Name = "tbNome";
            this.tbNome.Size = new System.Drawing.Size(271, 20);
            this.tbNome.TabIndex = 0;
            // 
            // tbLogin
            // 
            this.tbLogin.Location = new System.Drawing.Point(29, 107);
            this.tbLogin.Name = "tbLogin";
            this.tbLogin.Size = new System.Drawing.Size(145, 20);
            this.tbLogin.TabIndex = 1;
            // 
            // tbSenha
            // 
            this.tbSenha.Location = new System.Drawing.Point(180, 107);
            this.tbSenha.Name = "tbSenha";
            this.tbSenha.PasswordChar = '*';
            this.tbSenha.Size = new System.Drawing.Size(120, 20);
            this.tbSenha.TabIndex = 2;
            // 
            // lbCodigo
            // 
            this.lbCodigo.AutoSize = true;
            this.lbCodigo.Location = new System.Drawing.Point(26, 7);
            this.lbCodigo.Name = "lbCodigo";
            this.lbCodigo.Size = new System.Drawing.Size(44, 13);
            this.lbCodigo.TabIndex = 25;
            this.lbCodigo.Text = "Código*";
            // 
            // tbCodigo
            // 
            this.tbCodigo.Location = new System.Drawing.Point(29, 23);
            this.tbCodigo.Name = "tbCodigo";
            this.tbCodigo.Size = new System.Drawing.Size(92, 20);
            this.tbCodigo.TabIndex = 11;
            this.tbCodigo.TabStop = false;
            // 
            // cboxAdmin
            // 
            this.cboxAdmin.AutoSize = true;
            this.cboxAdmin.Location = new System.Drawing.Point(139, 25);
            this.cboxAdmin.Name = "cboxAdmin";
            this.cboxAdmin.Size = new System.Drawing.Size(99, 17);
            this.cboxAdmin.TabIndex = 3;
            this.cboxAdmin.Text = "Administrador?*";
            this.cboxAdmin.UseVisualStyleBackColor = true;
            // 
            // FormCadUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(313, 187);
            this.Controls.Add(this.cboxAdmin);
            this.Controls.Add(this.tbCodigo);
            this.Controls.Add(this.lbCodigo);
            this.Controls.Add(this.tbSenha);
            this.Controls.Add(this.tbLogin);
            this.Controls.Add(this.tbNome);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.labelSenha);
            this.Controls.Add(this.labelLogin);
            this.Controls.Add(this.labelRazao);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormCadUsuario";
            this.Text = "Cadastrar Usuario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelRazao;
        private System.Windows.Forms.Label labelLogin;
        private System.Windows.Forms.Label labelSenha;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.TextBox tbNome;
        private System.Windows.Forms.TextBox tbLogin;
        private System.Windows.Forms.TextBox tbSenha;
        private System.Windows.Forms.Label lbCodigo;
        private System.Windows.Forms.TextBox tbCodigo;
        private System.Windows.Forms.CheckBox cboxAdmin;
    }
}

