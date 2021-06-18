
namespace CRUDCSharp
{
    partial class FormBuscaCliente
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
            this.listClientes = new System.Windows.Forms.ListView();
            this.tbPesquisa = new System.Windows.Forms.TextBox();
            this.btnLocalizar = new System.Windows.Forms.Button();
            this.cboxFiltro = new System.Windows.Forms.ComboBox();
            this.btnNovo = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.btnAbrir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listClientes
            // 
            this.listClientes.BackColor = System.Drawing.SystemColors.Window;
            this.listClientes.ForeColor = System.Drawing.SystemColors.WindowText;
            this.listClientes.FullRowSelect = true;
            this.listClientes.GridLines = true;
            this.listClientes.HideSelection = false;
            this.listClientes.Location = new System.Drawing.Point(12, 129);
            this.listClientes.MultiSelect = false;
            this.listClientes.Name = "listClientes";
            this.listClientes.Size = new System.Drawing.Size(679, 272);
            this.listClientes.TabIndex = 4;
            this.listClientes.UseCompatibleStateImageBehavior = false;
            this.listClientes.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listClientes_DoubleClick);
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
            this.btnNovo.Text = "Novo Cadastro";
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
            // btnAbrir
            // 
            this.btnAbrir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnAbrir.Location = new System.Drawing.Point(166, 11);
            this.btnAbrir.Name = "btnAbrir";
            this.btnAbrir.Size = new System.Drawing.Size(148, 87);
            this.btnAbrir.TabIndex = 5;
            this.btnAbrir.Text = "Abrir Cadastro";
            this.btnAbrir.UseVisualStyleBackColor = true;
            this.btnAbrir.Click += new System.EventHandler(this.btnAbrir_Click);
            // 
            // FormBuscaCliente
            // 
            this.AcceptButton = this.btnLocalizar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(702, 409);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.btnAbrir);
            this.Controls.Add(this.cboxFiltro);
            this.Controls.Add(this.btnLocalizar);
            this.Controls.Add(this.tbPesquisa);
            this.Controls.Add(this.listClientes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormBuscaCliente";
            this.Text = "Localizar Clientes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listClientes;
        private System.Windows.Forms.TextBox tbPesquisa;
        private System.Windows.Forms.Button btnLocalizar;
        private System.Windows.Forms.ComboBox cboxFiltro;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Button btnAbrir;
    }
}