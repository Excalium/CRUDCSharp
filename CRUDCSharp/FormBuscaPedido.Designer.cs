
namespace CRUDCSharp
{
    partial class FormBuscaPedido
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
            this.listPedidos = new System.Windows.Forms.ListView();
            this.tbPesquisa = new System.Windows.Forms.TextBox();
            this.btnLocalizar = new System.Windows.Forms.Button();
            this.cboxFiltro = new System.Windows.Forms.ComboBox();
            this.btnNovo = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.btnVisualizar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listPedidos
            // 
            this.listPedidos.BackColor = System.Drawing.SystemColors.Window;
            this.listPedidos.ForeColor = System.Drawing.SystemColors.WindowText;
            this.listPedidos.FullRowSelect = true;
            this.listPedidos.GridLines = true;
            this.listPedidos.HideSelection = false;
            this.listPedidos.Location = new System.Drawing.Point(12, 129);
            this.listPedidos.MultiSelect = false;
            this.listPedidos.Name = "listPedidos";
            this.listPedidos.Size = new System.Drawing.Size(679, 272);
            this.listPedidos.TabIndex = 4;
            this.listPedidos.UseCompatibleStateImageBehavior = false;
            this.listPedidos.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listPedidos_DoubleClick);
            // 
            // tbPesquisa
            // 
            this.tbPesquisa.Location = new System.Drawing.Point(125, 104);
            this.tbPesquisa.Name = "tbPesquisa";
            this.tbPesquisa.Size = new System.Drawing.Size(469, 20);
            this.tbPesquisa.TabIndex = 1;
            // 
            // btnLocalizar
            // 
            this.btnLocalizar.Location = new System.Drawing.Point(600, 102);
            this.btnLocalizar.Name = "btnLocalizar";
            this.btnLocalizar.Size = new System.Drawing.Size(91, 23);
            this.btnLocalizar.TabIndex = 2;
            this.btnLocalizar.Text = "Localizar";
            this.btnLocalizar.UseVisualStyleBackColor = true;
            this.btnLocalizar.Click += new System.EventHandler(this.btnLocalizar_Click);
            // 
            // cboxFiltro
            // 
            this.cboxFiltro.FormattingEnabled = true;
            this.cboxFiltro.Location = new System.Drawing.Point(12, 103);
            this.cboxFiltro.Name = "cboxFiltro";
            this.cboxFiltro.Size = new System.Drawing.Size(107, 21);
            this.cboxFiltro.TabIndex = 3;
            // 
            // btnNovo
            // 
            this.btnNovo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnNovo.Location = new System.Drawing.Point(12, 11);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(148, 86);
            this.btnNovo.TabIndex = 6;
            this.btnNovo.Text = "Novo Pedido";
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // btnFechar
            // 
            this.btnFechar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnFechar.Location = new System.Drawing.Point(542, 10);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(148, 86);
            this.btnFechar.TabIndex = 7;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // btnVisualizar
            // 
            this.btnVisualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnVisualizar.Location = new System.Drawing.Point(166, 11);
            this.btnVisualizar.Name = "btnVisualizar";
            this.btnVisualizar.Size = new System.Drawing.Size(148, 87);
            this.btnVisualizar.TabIndex = 5;
            this.btnVisualizar.Text = "Visualizar Pedido";
            this.btnVisualizar.UseVisualStyleBackColor = true;
            this.btnVisualizar.Click += new System.EventHandler(this.btnVisualizar_Click);
            // 
            // FormBuscaPedido
            // 
            this.AcceptButton = this.btnLocalizar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(702, 409);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.btnVisualizar);
            this.Controls.Add(this.cboxFiltro);
            this.Controls.Add(this.btnLocalizar);
            this.Controls.Add(this.tbPesquisa);
            this.Controls.Add(this.listPedidos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormBuscaPedido";
            this.Text = "Localizar Pedidos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listPedidos;
        private System.Windows.Forms.TextBox tbPesquisa;
        private System.Windows.Forms.Button btnLocalizar;
        private System.Windows.Forms.ComboBox cboxFiltro;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Button btnVisualizar;
    }
}