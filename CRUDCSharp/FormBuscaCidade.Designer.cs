
namespace CRUDCSharp
{
    partial class FormBuscaCidade
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
            this.tbBuscaCidade = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.listCidades = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // tbBuscaCidade
            // 
            this.tbBuscaCidade.Location = new System.Drawing.Point(12, 13);
            this.tbBuscaCidade.Name = "tbBuscaCidade";
            this.tbBuscaCidade.Size = new System.Drawing.Size(309, 20);
            this.tbBuscaCidade.TabIndex = 1;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(327, 11);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // listCidades
            // 
            this.listCidades.FullRowSelect = true;
            this.listCidades.GridLines = true;
            this.listCidades.HideSelection = false;
            this.listCidades.Location = new System.Drawing.Point(12, 40);
            this.listCidades.MultiSelect = false;
            this.listCidades.Name = "listCidades";
            this.listCidades.Size = new System.Drawing.Size(390, 225);
            this.listCidades.TabIndex = 3;
            this.listCidades.UseCompatibleStateImageBehavior = false;
            this.listCidades.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listCidades_DoubleClick);
            // 
            // FormBuscaCidade
            // 
            this.AcceptButton = this.btnBuscar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 276);
            this.Controls.Add(this.listCidades);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.tbBuscaCidade);
            this.MaximizeBox = false;
            this.Name = "FormBuscaCidade";
            this.Text = "Localizar Cidades";
            this.Load += new System.EventHandler(this.FormBuscaCidade_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tbBuscaCidade;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.ListView listCidades;
    }
}