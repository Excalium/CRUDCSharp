
namespace CRUDCSharp
{
    partial class FormCadProduto
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
            this.labelVenda = new System.Windows.Forms.Label();
            this.labelCompra = new System.Windows.Forms.Label();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.tbNome = new System.Windows.Forms.TextBox();
            this.tbValVenda = new System.Windows.Forms.TextBox();
            this.tbValCusto = new System.Windows.Forms.TextBox();
            this.lbCodigo = new System.Windows.Forms.Label();
            this.tbCodigo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labelRazao
            // 
            this.labelRazao.AutoSize = true;
            this.labelRazao.Location = new System.Drawing.Point(26, 48);
            this.labelRazao.Name = "labelRazao";
            this.labelRazao.Size = new System.Drawing.Size(59, 13);
            this.labelRazao.TabIndex = 0;
            this.labelRazao.Text = "Descrição*";
            // 
            // labelVenda
            // 
            this.labelVenda.AutoSize = true;
            this.labelVenda.Location = new System.Drawing.Point(217, 91);
            this.labelVenda.Name = "labelVenda";
            this.labelVenda.Size = new System.Drawing.Size(84, 13);
            this.labelVenda.TabIndex = 1;
            this.labelVenda.Text = "Valor de Venda*";
            // 
            // labelCompra
            // 
            this.labelCompra.AutoSize = true;
            this.labelCompra.Location = new System.Drawing.Point(26, 91);
            this.labelCompra.Name = "labelCompra";
            this.labelCompra.Size = new System.Drawing.Size(89, 13);
            this.labelCompra.TabIndex = 2;
            this.labelCompra.Text = "Valor de Compra*";
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(339, 145);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(92, 33);
            this.btnSalvar.TabIndex = 5;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(186, 145);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(92, 33);
            this.btnCancelar.TabIndex = 4;
            this.btnCancelar.TabStop = false;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(29, 145);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(92, 33);
            this.btnExcluir.TabIndex = 3;
            this.btnExcluir.TabStop = false;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // tbNome
            // 
            this.tbNome.Location = new System.Drawing.Point(29, 66);
            this.tbNome.Name = "tbNome";
            this.tbNome.Size = new System.Drawing.Size(402, 20);
            this.tbNome.TabIndex = 0;
            // 
            // tbValVenda
            // 
            this.tbValVenda.Location = new System.Drawing.Point(220, 107);
            this.tbValVenda.Name = "tbValVenda";
            this.tbValVenda.Size = new System.Drawing.Size(211, 20);
            this.tbValVenda.TabIndex = 2;
            // 
            // tbValCusto
            // 
            this.tbValCusto.Location = new System.Drawing.Point(29, 107);
            this.tbValCusto.Name = "tbValCusto";
            this.tbValCusto.Size = new System.Drawing.Size(185, 20);
            this.tbValCusto.TabIndex = 1;
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
            // FormCadProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 189);
            this.Controls.Add(this.tbCodigo);
            this.Controls.Add(this.lbCodigo);
            this.Controls.Add(this.tbValCusto);
            this.Controls.Add(this.tbValVenda);
            this.Controls.Add(this.tbNome);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.labelCompra);
            this.Controls.Add(this.labelVenda);
            this.Controls.Add(this.labelRazao);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormCadProduto";
            this.Text = "Cadastrar Produto";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelRazao;
        private System.Windows.Forms.Label labelVenda;
        private System.Windows.Forms.Label labelCompra;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.TextBox tbNome;
        private System.Windows.Forms.TextBox tbValVenda;
        private System.Windows.Forms.TextBox tbValCusto;
        private System.Windows.Forms.Label lbCodigo;
        private System.Windows.Forms.TextBox tbCodigo;
    }
}

