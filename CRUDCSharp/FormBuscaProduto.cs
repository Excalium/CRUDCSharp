using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CRUDCSharp
{
    public partial class FormBuscaProduto : Form
    {
        SqlConnection conexao = new SqlConnection(@"Server=.\SQLEXPRESS;Database=CRUD;User Id=AcessoCRUD;Password=123;");
        SqlCommand comando;
        SqlDataAdapter da;
        DataTable dt;
        DataSet ds;

        FormPedidoVenda venda;
        bool pedido = false;
        bool isAdmin;

        public FormBuscaProduto(bool admin)
        {
            InitializeComponent();

            listProdutos.Columns.Add("Código", 70);
            listProdutos.Columns.Add("Descrição", 360);
            listProdutos.Columns.Add("Valor Custo", 120);
            listProdutos.Columns.Add("Valor Venda", 120);
            listProdutos.View = View.Details;

            string[] filtros = { "Código", "Descrição"};
            cboxFiltro.DataSource = filtros;
            cboxFiltro.DropDownStyle = ComboBoxStyle.DropDownList;

            isAdmin = admin;
        }
        public FormBuscaProduto(FormPedidoVenda f1)
        {
            InitializeComponent();

            listProdutos.Columns.Add("Código", 70);
            listProdutos.Columns.Add("Descrição", 360);
            listProdutos.Columns.Add("Valor Custo", 120);
            listProdutos.Columns.Add("Valor Venda", 120);
            listProdutos.View = View.Details;

            string[] filtros = { "Código", "Descrição" };
            cboxFiltro.DataSource = filtros;
            cboxFiltro.DropDownStyle = ComboBoxStyle.DropDownList;

            venda = f1;
            pedido = true;
        }
        private void abrirCadastro()
        {
            if (listProdutos.SelectedItems.Count >= 1)
            {
                FormCadProduto abrircadastro = new FormCadProduto(listProdutos.SelectedItems[0].SubItems[0].Text, isAdmin);
                abrircadastro.Show();
            }
        }

        private void LocalizarProduto(string sql)
        {
            conexao.Open();
            comando = new SqlCommand(sql, conexao);
            da = new SqlDataAdapter(comando);
            ds = new DataSet();
            da.Fill(ds, "tabelaProdutos");
            conexao.Close();

            dt = ds.Tables["tabelaProdutos"];

            int i;
            for (i = 0; i <= dt.Rows.Count - 1; i++)
            {
                listProdutos.Items.Add(dt.Rows[i].ItemArray[0].ToString());
                listProdutos.Items[i].SubItems.Add(dt.Rows[i].ItemArray[1].ToString());
                listProdutos.Items[i].SubItems.Add(dt.Rows[i].ItemArray[2].ToString());
                listProdutos.Items[i].SubItems.Add(dt.Rows[i].ItemArray[3].ToString());
            }
        }

        private void LocalizarProduto(string sql, string comand)
        {
            conexao.Open();
            comando = new SqlCommand(sql, conexao);
            comando.Parameters.AddWithValue(comand, "%" + tbPesquisa.Text + "%");
            da = new SqlDataAdapter(comando);
            ds = new DataSet();
            da.Fill(ds, "tabelaProdutos");
            conexao.Close();

            dt = ds.Tables["tabelaProdutos"];

            int i;
            for (i = 0; i <= dt.Rows.Count - 1; i++)
            {
                listProdutos.Items.Add(dt.Rows[i].ItemArray[0].ToString());
                listProdutos.Items[i].SubItems.Add(dt.Rows[i].ItemArray[1].ToString());
                listProdutos.Items[i].SubItems.Add(dt.Rows[i].ItemArray[2].ToString());
                listProdutos.Items[i].SubItems.Add(dt.Rows[i].ItemArray[3].ToString());
            }
        }

        private void listProdutos_DoubleClick(object sender, MouseEventArgs e)
        {
            if(pedido != true)
            {
                abrirCadastro();
            }
            else
            {
                venda.localizarProduto(listProdutos.SelectedItems[0].SubItems[0].Text);
                Close();

            }
        }

        private void btnLocalizar_Click(object sender, EventArgs e)
        {
            listProdutos.Items.Clear();
            if (string.IsNullOrWhiteSpace(tbPesquisa.Text))
            {
                Console.WriteLine("Nada inserido.");
            }
            else
            {
                if (tbPesquisa.Text.Equals("*"))
                {
                    LocalizarProduto("SELECT * FROM Produtos");
                }
                else
                {
                    if (cboxFiltro.SelectedItem.ToString().Equals("Código"))
                    {
                        LocalizarProduto("SELECT * FROM Produtos WHERE ProdutoID LIKE @Pesquisa", "@Pesquisa");
                    }
                    if (cboxFiltro.SelectedItem.ToString().Equals("Descrição"))
                    {
                        LocalizarProduto("SELECT * FROM Produtos WHERE Nome LIKE @Pesquisa", "@Pesquisa");
                    }
                }
            }
        }

        private void btnAbrir_Click(object sender, EventArgs e)
        {
            if (pedido != true)
            {
                abrirCadastro();
            }
            else
            {
                venda.localizarProduto(listProdutos.SelectedItems[0].SubItems[0].Text);
                Close();
            }
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            FormCadProduto novocadastro = new FormCadProduto(isAdmin);
            novocadastro.Show();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
