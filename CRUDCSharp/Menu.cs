using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUDCSharp
{
    public partial class Menu : Form
    {
        FormLogin f1;
        bool isAdmin;
        public Menu(FormLogin flogin, bool admin)
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            isAdmin = admin;
            f1 = flogin;
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            FormBuscaCliente clientes = new FormBuscaCliente(isAdmin);
            clientes.StartPosition = FormStartPosition.Manual;
            clientes.Location = new Point(700, 300);
            clientes.Show();
        }

        private void Menu_Closing(object sender, FormClosingEventArgs e)
        {
            DialogResult res = MessageBox.Show("Deseja sair do sistema?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (res == DialogResult.Yes)
                f1.Close();
            else
                e.Cancel = true;
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Deseja sair do sistema?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (res == DialogResult.Yes)
                f1.Close();
        }

        private void btnProdutos_Click(object sender, EventArgs e)
        {
            FormBuscaProduto produtos = new FormBuscaProduto(isAdmin);
            produtos.StartPosition = FormStartPosition.Manual;
            produtos.Location = new Point(700, 300);
            produtos.Show();
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            FormBuscaUsuario usuarios = new FormBuscaUsuario(isAdmin);
            usuarios.StartPosition = FormStartPosition.Manual;
            usuarios.Location = new Point(700, 300);
            usuarios.Show();
        }

        private void btnVendas_Click(object sender, EventArgs e)
        {
            FormBuscaPedido pedidos = new FormBuscaPedido(isAdmin);
            pedidos.StartPosition = FormStartPosition.Manual;
            pedidos.Location = new Point(700, 300);
            pedidos.Show();
        }
    }
}
