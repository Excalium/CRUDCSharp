
namespace CRUDCSharp
{
    partial class FormPedidoVenda
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
            this.btnFinalizar = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.tbNomeCliente = new System.Windows.Forms.TextBox();
            this.lbCodigoPedido = new System.Windows.Forms.Label();
            this.tbCodPedido = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLocCliente = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listPedidoItens = new System.Windows.Forms.ListView();
            this.btnLocProduto = new System.Windows.Forms.Button();
            this.lbCodProduto = new System.Windows.Forms.Label();
            this.tbDescricao = new System.Windows.Forms.TextBox();
            this.lbDescricao = new System.Windows.Forms.Label();
            this.tbCodProduto = new System.Windows.Forms.TextBox();
            this.tbCodCliente = new System.Windows.Forms.TextBox();
            this.gboxTotais = new System.Windows.Forms.GroupBox();
            this.tbAcres = new System.Windows.Forms.TextBox();
            this.lbAcrescimos = new System.Windows.Forms.Label();
            this.tbDesc = new System.Windows.Forms.TextBox();
            this.lbDescontos = new System.Windows.Forms.Label();
            this.tbBruto = new System.Windows.Forms.TextBox();
            this.lbTotalBruto = new System.Windows.Forms.Label();
            this.tbLiquido = new System.Windows.Forms.TextBox();
            this.lbTotalLiquido = new System.Windows.Forms.Label();
            this.btnInserir = new System.Windows.Forms.Button();
            this.tbValorItem = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbQuantidade = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.gboxTotais.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelRazao
            // 
            this.labelRazao.AutoSize = true;
            this.labelRazao.Location = new System.Drawing.Point(162, 101);
            this.labelRazao.Name = "labelRazao";
            this.labelRazao.Size = new System.Drawing.Size(109, 13);
            this.labelRazao.TabIndex = 0;
            this.labelRazao.Text = "Razão Social / Nome";
            // 
            // btnFinalizar
            // 
            this.btnFinalizar.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnFinalizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnFinalizar.Location = new System.Drawing.Point(573, 388);
            this.btnFinalizar.Name = "btnFinalizar";
            this.btnFinalizar.Size = new System.Drawing.Size(174, 62);
            this.btnFinalizar.TabIndex = 8;
            this.btnFinalizar.Text = "Finalizar Venda";
            this.btnFinalizar.UseVisualStyleBackColor = false;
            this.btnFinalizar.Click += new System.EventHandler(this.btnFinalizar_Click);
            // 
            // btnFechar
            // 
            this.btnFechar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnFechar.Location = new System.Drawing.Point(632, 22);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(119, 79);
            this.btnFechar.TabIndex = 103;
            this.btnFechar.TabStop = false;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnExcluir.Location = new System.Drawing.Point(13, 22);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(119, 79);
            this.btnExcluir.TabIndex = 101;
            this.btnExcluir.TabStop = false;
            this.btnExcluir.Text = "Excluir Pedido";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // tbNomeCliente
            // 
            this.tbNomeCliente.Location = new System.Drawing.Point(165, 118);
            this.tbNomeCliente.Name = "tbNomeCliente";
            this.tbNomeCliente.ReadOnly = true;
            this.tbNomeCliente.Size = new System.Drawing.Size(324, 20);
            this.tbNomeCliente.TabIndex = 1;
            this.tbNomeCliente.TabStop = false;
            // 
            // lbCodigoPedido
            // 
            this.lbCodigoPedido.AutoSize = true;
            this.lbCodigoPedido.Location = new System.Drawing.Point(6, 102);
            this.lbCodigoPedido.Name = "lbCodigoPedido";
            this.lbCodigoPedido.Size = new System.Drawing.Size(65, 13);
            this.lbCodigoPedido.TabIndex = 25;
            this.lbCodigoPedido.Text = "Cód. Pedido";
            // 
            // tbCodPedido
            // 
            this.tbCodPedido.Location = new System.Drawing.Point(9, 118);
            this.tbCodPedido.Name = "tbCodPedido";
            this.tbCodPedido.ReadOnly = true;
            this.tbCodPedido.Size = new System.Drawing.Size(72, 20);
            this.tbCodPedido.TabIndex = 100;
            this.tbCodPedido.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(84, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 28;
            this.label1.Text = "Cód. Cliente";
            // 
            // btnLocCliente
            // 
            this.btnLocCliente.Location = new System.Drawing.Point(495, 116);
            this.btnLocCliente.Name = "btnLocCliente";
            this.btnLocCliente.Size = new System.Drawing.Size(61, 24);
            this.btnLocCliente.TabIndex = 1;
            this.btnLocCliente.Text = "Localizar";
            this.btnLocCliente.UseVisualStyleBackColor = true;
            this.btnLocCliente.Click += new System.EventHandler(this.btnLocCliente_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnExcluir);
            this.groupBox1.Controls.Add(this.btnFechar);
            this.groupBox1.Location = new System.Drawing.Point(-4, -19);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(766, 106);
            this.groupBox1.TabIndex = 31;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "gboxOpcoes";
            // 
            // listPedidoItens
            // 
            this.listPedidoItens.FullRowSelect = true;
            this.listPedidoItens.GridLines = true;
            this.listPedidoItens.HideSelection = false;
            this.listPedidoItens.Location = new System.Drawing.Point(9, 192);
            this.listPedidoItens.Name = "listPedidoItens";
            this.listPedidoItens.Size = new System.Drawing.Size(547, 258);
            this.listPedidoItens.TabIndex = 32;
            this.listPedidoItens.TabStop = false;
            this.listPedidoItens.UseCompatibleStateImageBehavior = false;
            this.listPedidoItens.KeyDown += new System.Windows.Forms.KeyEventHandler(this.listPedidoItens_KeyDownDelete);
            // 
            // btnLocProduto
            // 
            this.btnLocProduto.Location = new System.Drawing.Point(87, 164);
            this.btnLocProduto.Name = "btnLocProduto";
            this.btnLocProduto.Size = new System.Drawing.Size(61, 23);
            this.btnLocProduto.TabIndex = 3;
            this.btnLocProduto.Text = "Localizar";
            this.btnLocProduto.UseVisualStyleBackColor = true;
            this.btnLocProduto.Click += new System.EventHandler(this.btnLocProduto_Click);
            // 
            // lbCodProduto
            // 
            this.lbCodProduto.AutoSize = true;
            this.lbCodProduto.Location = new System.Drawing.Point(6, 149);
            this.lbCodProduto.Name = "lbCodProduto";
            this.lbCodProduto.Size = new System.Drawing.Size(69, 13);
            this.lbCodProduto.TabIndex = 35;
            this.lbCodProduto.Text = "Cód. Produto";
            // 
            // tbDescricao
            // 
            this.tbDescricao.Location = new System.Drawing.Point(154, 166);
            this.tbDescricao.Name = "tbDescricao";
            this.tbDescricao.ReadOnly = true;
            this.tbDescricao.Size = new System.Drawing.Size(194, 20);
            this.tbDescricao.TabIndex = 111;
            this.tbDescricao.TabStop = false;
            // 
            // lbDescricao
            // 
            this.lbDescricao.AutoSize = true;
            this.lbDescricao.Location = new System.Drawing.Point(151, 149);
            this.lbDescricao.Name = "lbDescricao";
            this.lbDescricao.Size = new System.Drawing.Size(55, 13);
            this.lbDescricao.TabIndex = 33;
            this.lbDescricao.Text = "Descrição";
            // 
            // tbCodProduto
            // 
            this.tbCodProduto.Location = new System.Drawing.Point(9, 166);
            this.tbCodProduto.Name = "tbCodProduto";
            this.tbCodProduto.Size = new System.Drawing.Size(72, 20);
            this.tbCodProduto.TabIndex = 2;
            this.tbCodProduto.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbCodProduto_KeyDownEnter);
            // 
            // tbCodCliente
            // 
            this.tbCodCliente.Location = new System.Drawing.Point(87, 118);
            this.tbCodCliente.Name = "tbCodCliente";
            this.tbCodCliente.Size = new System.Drawing.Size(72, 20);
            this.tbCodCliente.TabIndex = 0;
            this.tbCodCliente.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbCodCliente_KeyDownEnter);
            // 
            // gboxTotais
            // 
            this.gboxTotais.Controls.Add(this.tbAcres);
            this.gboxTotais.Controls.Add(this.lbAcrescimos);
            this.gboxTotais.Controls.Add(this.tbDesc);
            this.gboxTotais.Controls.Add(this.lbDescontos);
            this.gboxTotais.Controls.Add(this.tbBruto);
            this.gboxTotais.Controls.Add(this.lbTotalBruto);
            this.gboxTotais.Controls.Add(this.tbLiquido);
            this.gboxTotais.Controls.Add(this.lbTotalLiquido);
            this.gboxTotais.Location = new System.Drawing.Point(573, 97);
            this.gboxTotais.Name = "gboxTotais";
            this.gboxTotais.Size = new System.Drawing.Size(174, 285);
            this.gboxTotais.TabIndex = 40;
            this.gboxTotais.TabStop = false;
            // 
            // tbAcres
            // 
            this.tbAcres.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.tbAcres.Location = new System.Drawing.Point(6, 105);
            this.tbAcres.Name = "tbAcres";
            this.tbAcres.Size = new System.Drawing.Size(162, 29);
            this.tbAcres.TabIndex = 6;
            this.tbAcres.TabStop = false;
            this.tbAcres.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbAcres_KeyDownEnter);
            this.tbAcres.LostFocus += new System.EventHandler(this.tbAcres_LostFocus);
            // 
            // lbAcrescimos
            // 
            this.lbAcrescimos.AutoSize = true;
            this.lbAcrescimos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbAcrescimos.Location = new System.Drawing.Point(2, 82);
            this.lbAcrescimos.Name = "lbAcrescimos";
            this.lbAcrescimos.Size = new System.Drawing.Size(122, 20);
            this.lbAcrescimos.TabIndex = 46;
            this.lbAcrescimos.Text = "Acréscimos ( + )";
            // 
            // tbDesc
            // 
            this.tbDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.tbDesc.Location = new System.Drawing.Point(6, 175);
            this.tbDesc.Name = "tbDesc";
            this.tbDesc.Size = new System.Drawing.Size(162, 29);
            this.tbDesc.TabIndex = 7;
            this.tbDesc.TabStop = false;
            this.tbDesc.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbDesc_KeyDownEnter);
            this.tbDesc.LostFocus += new System.EventHandler(this.tbDesc_LostFocus);
            // 
            // lbDescontos
            // 
            this.lbDescontos.AutoSize = true;
            this.lbDescontos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbDescontos.Location = new System.Drawing.Point(2, 152);
            this.lbDescontos.Name = "lbDescontos";
            this.lbDescontos.Size = new System.Drawing.Size(113, 20);
            this.lbDescontos.TabIndex = 44;
            this.lbDescontos.Text = "Descontos ( - )";
            // 
            // tbBruto
            // 
            this.tbBruto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.tbBruto.Location = new System.Drawing.Point(6, 32);
            this.tbBruto.Name = "tbBruto";
            this.tbBruto.ReadOnly = true;
            this.tbBruto.Size = new System.Drawing.Size(162, 29);
            this.tbBruto.TabIndex = 104;
            this.tbBruto.TabStop = false;
            // 
            // lbTotalBruto
            // 
            this.lbTotalBruto.AutoSize = true;
            this.lbTotalBruto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbTotalBruto.Location = new System.Drawing.Point(2, 9);
            this.lbTotalBruto.Name = "lbTotalBruto";
            this.lbTotalBruto.Size = new System.Drawing.Size(87, 20);
            this.lbTotalBruto.TabIndex = 42;
            this.lbTotalBruto.Text = "Total Bruto";
            // 
            // tbLiquido
            // 
            this.tbLiquido.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.tbLiquido.Location = new System.Drawing.Point(6, 250);
            this.tbLiquido.Name = "tbLiquido";
            this.tbLiquido.ReadOnly = true;
            this.tbLiquido.Size = new System.Drawing.Size(162, 29);
            this.tbLiquido.TabIndex = 107;
            this.tbLiquido.TabStop = false;
            // 
            // lbTotalLiquido
            // 
            this.lbTotalLiquido.AutoSize = true;
            this.lbTotalLiquido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbTotalLiquido.Location = new System.Drawing.Point(2, 227);
            this.lbTotalLiquido.Name = "lbTotalLiquido";
            this.lbTotalLiquido.Size = new System.Drawing.Size(99, 20);
            this.lbTotalLiquido.TabIndex = 0;
            this.lbTotalLiquido.Text = "Total Líquido";
            // 
            // btnInserir
            // 
            this.btnInserir.Location = new System.Drawing.Point(495, 164);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(61, 23);
            this.btnInserir.TabIndex = 110;
            this.btnInserir.TabStop = false;
            this.btnInserir.Text = "Inserir";
            this.btnInserir.UseVisualStyleBackColor = true;
            this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
            // 
            // tbValorItem
            // 
            this.tbValorItem.Location = new System.Drawing.Point(417, 166);
            this.tbValorItem.Name = "tbValorItem";
            this.tbValorItem.Size = new System.Drawing.Size(72, 20);
            this.tbValorItem.TabIndex = 5;
            this.tbValorItem.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbValorItem_KeyDownEnter);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(414, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 102;
            this.label2.Text = "Val. Venda";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(349, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 113;
            this.label3.Text = "Qntd";
            // 
            // tbQuantidade
            // 
            this.tbQuantidade.Location = new System.Drawing.Point(354, 166);
            this.tbQuantidade.Name = "tbQuantidade";
            this.tbQuantidade.Size = new System.Drawing.Size(57, 20);
            this.tbQuantidade.TabIndex = 4;
            this.tbQuantidade.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbQuantidade_KeyDownEnter);
            // 
            // FormPedidoVenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(756, 462);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbQuantidade);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbValorItem);
            this.Controls.Add(this.btnInserir);
            this.Controls.Add(this.gboxTotais);
            this.Controls.Add(this.tbCodCliente);
            this.Controls.Add(this.tbCodProduto);
            this.Controls.Add(this.btnLocProduto);
            this.Controls.Add(this.lbCodProduto);
            this.Controls.Add(this.tbDescricao);
            this.Controls.Add(this.lbDescricao);
            this.Controls.Add(this.listPedidoItens);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnLocCliente);
            this.Controls.Add(this.btnFinalizar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbCodPedido);
            this.Controls.Add(this.lbCodigoPedido);
            this.Controls.Add(this.tbNomeCliente);
            this.Controls.Add(this.labelRazao);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormPedidoVenda";
            this.Text = "Cadastrar Pedido";
            this.groupBox1.ResumeLayout(false);
            this.gboxTotais.ResumeLayout(false);
            this.gboxTotais.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelRazao;
        private System.Windows.Forms.Button btnFinalizar;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.TextBox tbNomeCliente;
        private System.Windows.Forms.Label lbCodigoPedido;
        private System.Windows.Forms.TextBox tbCodPedido;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLocCliente;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView listPedidoItens;
        private System.Windows.Forms.Button btnLocProduto;
        private System.Windows.Forms.Label lbCodProduto;
        private System.Windows.Forms.TextBox tbDescricao;
        private System.Windows.Forms.Label lbDescricao;
        private System.Windows.Forms.TextBox tbCodProduto;
        private System.Windows.Forms.TextBox tbCodCliente;
        private System.Windows.Forms.GroupBox gboxTotais;
        private System.Windows.Forms.TextBox tbAcres;
        private System.Windows.Forms.Label lbAcrescimos;
        private System.Windows.Forms.TextBox tbDesc;
        private System.Windows.Forms.Label lbDescontos;
        private System.Windows.Forms.TextBox tbBruto;
        private System.Windows.Forms.Label lbTotalBruto;
        private System.Windows.Forms.TextBox tbLiquido;
        private System.Windows.Forms.Label lbTotalLiquido;
        private System.Windows.Forms.Button btnInserir;
        private System.Windows.Forms.TextBox tbValorItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbQuantidade;
    }
}

