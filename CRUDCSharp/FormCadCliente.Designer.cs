
namespace CRUDCSharp
{
    partial class FormCadCliente
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
            this.labelCNPJ = new System.Windows.Forms.Label();
            this.labelIE = new System.Windows.Forms.Label();
            this.labelCEP = new System.Windows.Forms.Label();
            this.labelCidade = new System.Windows.Forms.Label();
            this.labelLogradouro = new System.Windows.Forms.Label();
            this.labelNumero = new System.Windows.Forms.Label();
            this.labelBairro = new System.Windows.Forms.Label();
            this.labelComplemento = new System.Windows.Forms.Label();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.tbNome = new System.Windows.Forms.TextBox();
            this.tbIE = new System.Windows.Forms.TextBox();
            this.tbCidade = new System.Windows.Forms.TextBox();
            this.tbLogradouro = new System.Windows.Forms.TextBox();
            this.tbNumero = new System.Windows.Forms.TextBox();
            this.tbBairro = new System.Windows.Forms.TextBox();
            this.tbComplemento = new System.Windows.Forms.TextBox();
            this.lbCodigo = new System.Windows.Forms.Label();
            this.tbCodigo = new System.Windows.Forms.TextBox();
            this.btnLocalizar = new System.Windows.Forms.Button();
            this.tbCodigoCidade = new System.Windows.Forms.TextBox();
            this.tbCNPJ = new System.Windows.Forms.MaskedTextBox();
            this.tbCEP = new System.Windows.Forms.MaskedTextBox();
            this.cboxTipo = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // labelRazao
            // 
            this.labelRazao.AutoSize = true;
            this.labelRazao.Location = new System.Drawing.Point(26, 48);
            this.labelRazao.Name = "labelRazao";
            this.labelRazao.Size = new System.Drawing.Size(113, 13);
            this.labelRazao.TabIndex = 0;
            this.labelRazao.Text = "Razão Social / Nome*";
            // 
            // labelCNPJ
            // 
            this.labelCNPJ.AutoSize = true;
            this.labelCNPJ.Location = new System.Drawing.Point(26, 91);
            this.labelCNPJ.Name = "labelCNPJ";
            this.labelCNPJ.Size = new System.Drawing.Size(69, 13);
            this.labelCNPJ.TabIndex = 1;
            this.labelCNPJ.Text = "CNPJ / CPF*";
            // 
            // labelIE
            // 
            this.labelIE.AutoSize = true;
            this.labelIE.Location = new System.Drawing.Point(163, 91);
            this.labelIE.Name = "labelIE";
            this.labelIE.Size = new System.Drawing.Size(48, 13);
            this.labelIE.TabIndex = 2;
            this.labelIE.Text = "IE / RG*";
            // 
            // labelCEP
            // 
            this.labelCEP.AutoSize = true;
            this.labelCEP.Location = new System.Drawing.Point(26, 132);
            this.labelCEP.Name = "labelCEP";
            this.labelCEP.Size = new System.Drawing.Size(32, 13);
            this.labelCEP.TabIndex = 3;
            this.labelCEP.Text = "CEP*";
            // 
            // labelCidade
            // 
            this.labelCidade.AutoSize = true;
            this.labelCidade.Location = new System.Drawing.Point(133, 132);
            this.labelCidade.Name = "labelCidade";
            this.labelCidade.Size = new System.Drawing.Size(44, 13);
            this.labelCidade.TabIndex = 4;
            this.labelCidade.Text = "Cidade*";
            // 
            // labelLogradouro
            // 
            this.labelLogradouro.AutoSize = true;
            this.labelLogradouro.Location = new System.Drawing.Point(26, 173);
            this.labelLogradouro.Name = "labelLogradouro";
            this.labelLogradouro.Size = new System.Drawing.Size(65, 13);
            this.labelLogradouro.TabIndex = 5;
            this.labelLogradouro.Text = "Logradouro*";
            // 
            // labelNumero
            // 
            this.labelNumero.AutoSize = true;
            this.labelNumero.Location = new System.Drawing.Point(310, 173);
            this.labelNumero.Name = "labelNumero";
            this.labelNumero.Size = new System.Drawing.Size(48, 13);
            this.labelNumero.TabIndex = 6;
            this.labelNumero.Text = "Numero*";
            // 
            // labelBairro
            // 
            this.labelBairro.AutoSize = true;
            this.labelBairro.Location = new System.Drawing.Point(26, 214);
            this.labelBairro.Name = "labelBairro";
            this.labelBairro.Size = new System.Drawing.Size(38, 13);
            this.labelBairro.TabIndex = 7;
            this.labelBairro.Text = "Bairro*";
            // 
            // labelComplemento
            // 
            this.labelComplemento.AutoSize = true;
            this.labelComplemento.Location = new System.Drawing.Point(225, 214);
            this.labelComplemento.Name = "labelComplemento";
            this.labelComplemento.Size = new System.Drawing.Size(71, 13);
            this.labelComplemento.TabIndex = 8;
            this.labelComplemento.Text = "Complemento";
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(339, 273);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(92, 33);
            this.btnSalvar.TabIndex = 14;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(186, 273);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(92, 33);
            this.btnCancelar.TabIndex = 13;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(29, 273);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(92, 33);
            this.btnExcluir.TabIndex = 12;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // tbNome
            // 
            this.tbNome.Location = new System.Drawing.Point(29, 66);
            this.tbNome.MaxLength = 60;
            this.tbNome.Name = "tbNome";
            this.tbNome.Size = new System.Drawing.Size(402, 20);
            this.tbNome.TabIndex = 2;
            // 
            // tbIE
            // 
            this.tbIE.Location = new System.Drawing.Point(166, 107);
            this.tbIE.MaxLength = 14;
            this.tbIE.Name = "tbIE";
            this.tbIE.Size = new System.Drawing.Size(101, 20);
            this.tbIE.TabIndex = 4;
            // 
            // tbCidade
            // 
            this.tbCidade.AcceptsTab = true;
            this.tbCidade.Location = new System.Drawing.Point(186, 148);
            this.tbCidade.Name = "tbCidade";
            this.tbCidade.ReadOnly = true;
            this.tbCidade.Size = new System.Drawing.Size(178, 20);
            this.tbCidade.TabIndex = 16;
            this.tbCidade.TabStop = false;
            // 
            // tbLogradouro
            // 
            this.tbLogradouro.Location = new System.Drawing.Point(29, 189);
            this.tbLogradouro.MaxLength = 60;
            this.tbLogradouro.Name = "tbLogradouro";
            this.tbLogradouro.Size = new System.Drawing.Size(278, 20);
            this.tbLogradouro.TabIndex = 7;
            // 
            // tbNumero
            // 
            this.tbNumero.Location = new System.Drawing.Point(313, 189);
            this.tbNumero.MaxLength = 6;
            this.tbNumero.Name = "tbNumero";
            this.tbNumero.Size = new System.Drawing.Size(118, 20);
            this.tbNumero.TabIndex = 9;
            // 
            // tbBairro
            // 
            this.tbBairro.Location = new System.Drawing.Point(29, 230);
            this.tbBairro.MaxLength = 60;
            this.tbBairro.Name = "tbBairro";
            this.tbBairro.Size = new System.Drawing.Size(193, 20);
            this.tbBairro.TabIndex = 10;
            // 
            // tbComplemento
            // 
            this.tbComplemento.Location = new System.Drawing.Point(228, 230);
            this.tbComplemento.MaxLength = 60;
            this.tbComplemento.Name = "tbComplemento";
            this.tbComplemento.Size = new System.Drawing.Size(203, 20);
            this.tbComplemento.TabIndex = 11;
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
            this.tbCodigo.TabIndex = 1;
            // 
            // btnLocalizar
            // 
            this.btnLocalizar.Location = new System.Drawing.Point(370, 147);
            this.btnLocalizar.Name = "btnLocalizar";
            this.btnLocalizar.Size = new System.Drawing.Size(61, 22);
            this.btnLocalizar.TabIndex = 6;
            this.btnLocalizar.Text = "Localizar";
            this.btnLocalizar.UseVisualStyleBackColor = true;
            this.btnLocalizar.Click += new System.EventHandler(this.btnLocalizar_Click);
            // 
            // tbCodigoCidade
            // 
            this.tbCodigoCidade.AcceptsTab = true;
            this.tbCodigoCidade.Location = new System.Drawing.Point(135, 148);
            this.tbCodigoCidade.Name = "tbCodigoCidade";
            this.tbCodigoCidade.ReadOnly = true;
            this.tbCodigoCidade.Size = new System.Drawing.Size(45, 20);
            this.tbCodigoCidade.TabIndex = 0;
            this.tbCodigoCidade.TabStop = false;
            // 
            // tbCNPJ
            // 
            this.tbCNPJ.Location = new System.Drawing.Point(29, 107);
            this.tbCNPJ.Name = "tbCNPJ";
            this.tbCNPJ.Size = new System.Drawing.Size(131, 20);
            this.tbCNPJ.TabIndex = 3;
            // 
            // tbCEP
            // 
            this.tbCEP.Location = new System.Drawing.Point(27, 148);
            this.tbCEP.Mask = "00000-000";
            this.tbCEP.Name = "tbCEP";
            this.tbCEP.Size = new System.Drawing.Size(100, 20);
            this.tbCEP.TabIndex = 5;
            // 
            // cboxTipo
            // 
            this.cboxTipo.FormattingEnabled = true;
            this.cboxTipo.Location = new System.Drawing.Point(313, 23);
            this.cboxTipo.Name = "cboxTipo";
            this.cboxTipo.Size = new System.Drawing.Size(118, 21);
            this.cboxTipo.TabIndex = 26;
            this.cboxTipo.SelectedIndexChanged += new System.EventHandler(this.cboxTipo_SelectedIndexChanged);
            // 
            // FormCadCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 319);
            this.Controls.Add(this.cboxTipo);
            this.Controls.Add(this.tbCEP);
            this.Controls.Add(this.tbCNPJ);
            this.Controls.Add(this.tbCodigoCidade);
            this.Controls.Add(this.btnLocalizar);
            this.Controls.Add(this.tbCodigo);
            this.Controls.Add(this.lbCodigo);
            this.Controls.Add(this.tbComplemento);
            this.Controls.Add(this.tbBairro);
            this.Controls.Add(this.tbNumero);
            this.Controls.Add(this.tbLogradouro);
            this.Controls.Add(this.tbCidade);
            this.Controls.Add(this.tbIE);
            this.Controls.Add(this.tbNome);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.labelComplemento);
            this.Controls.Add(this.labelBairro);
            this.Controls.Add(this.labelNumero);
            this.Controls.Add(this.labelLogradouro);
            this.Controls.Add(this.labelCidade);
            this.Controls.Add(this.labelCEP);
            this.Controls.Add(this.labelIE);
            this.Controls.Add(this.labelCNPJ);
            this.Controls.Add(this.labelRazao);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormCadCliente";
            this.Text = "Cadastrar Cliente";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelRazao;
        private System.Windows.Forms.Label labelCNPJ;
        private System.Windows.Forms.Label labelIE;
        private System.Windows.Forms.Label labelCEP;
        private System.Windows.Forms.Label labelCidade;
        private System.Windows.Forms.Label labelLogradouro;
        private System.Windows.Forms.Label labelNumero;
        private System.Windows.Forms.Label labelBairro;
        private System.Windows.Forms.Label labelComplemento;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.TextBox tbNome;
        private System.Windows.Forms.TextBox tbIE;
        private System.Windows.Forms.TextBox tbCidade;
        private System.Windows.Forms.TextBox tbLogradouro;
        private System.Windows.Forms.TextBox tbNumero;
        private System.Windows.Forms.TextBox tbBairro;
        private System.Windows.Forms.TextBox tbComplemento;
        private System.Windows.Forms.Label lbCodigo;
        private System.Windows.Forms.TextBox tbCodigo;
        private System.Windows.Forms.Button btnLocalizar;
        private System.Windows.Forms.TextBox tbCodigoCidade;
        private System.Windows.Forms.MaskedTextBox tbCNPJ;
        private System.Windows.Forms.MaskedTextBox tbCEP;
        private System.Windows.Forms.ComboBox cboxTipo;
    }
}

