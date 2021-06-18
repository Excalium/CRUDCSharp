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
    public partial class FormBuscaPedido : Form
    {
        SqlConnection conexao = new SqlConnection(@"Server=.\SQLEXPRESS;Database=CRUD;User Id=AcessoCRUD;Password=123;");
        SqlCommand comando;
        SqlDataAdapter da;
        DataTable dt;
        DataSet ds;

        bool isAdmin;

        public FormBuscaPedido(bool admin)
        {
            InitializeComponent();

            listPedidos.Columns.Add("Código", 100);
            listPedidos.Columns.Add("Cliente", 455);
            listPedidos.Columns.Add("Valor Total", 120);
            listPedidos.View = View.Details;

            string[] filtros = { "Código", "Cliente"};
            cboxFiltro.DataSource = filtros;
            cboxFiltro.DropDownStyle = ComboBoxStyle.DropDownList;

            isAdmin = admin;
        }
        private void abrirPedido()
        {
            if (listPedidos.SelectedItems.Count >= 1)
            {
                FormPedidoVenda abrircadastro = new FormPedidoVenda(listPedidos.SelectedItems[0].SubItems[0].Text, isAdmin);
                abrircadastro.Show();
            }
        }

        private void LocalizarPedido(string sql)
        {
            conexao.Open();
            comando = new SqlCommand(sql, conexao);
            da = new SqlDataAdapter(comando);
            ds = new DataSet();
            da.Fill(ds, "tabelaPedidos");
            conexao.Close();

            dt = ds.Tables["tabelaPedidos"];

            int i;
            for (i = 0; i <= dt.Rows.Count - 1; i++)
            {
                listPedidos.Items.Add(dt.Rows[i].ItemArray[0].ToString());
                listPedidos.Items[i].SubItems.Add(dt.Rows[i].ItemArray[6].ToString());
                listPedidos.Items[i].SubItems.Add(dt.Rows[i].ItemArray[4].ToString());
            }
        }

        private void LocalizarPedido(string sql, string comand)
        {
            conexao.Open();
            comando = new SqlCommand(sql, conexao);
            comando.Parameters.AddWithValue(comand, "%" + tbPesquisa.Text + "%");
            da = new SqlDataAdapter(comando);
            ds = new DataSet();
            da.Fill(ds, "tabelaPedidos");
            conexao.Close();

            dt = ds.Tables["tabelaPedidos"];

            int i;
            for (i = 0; i <= dt.Rows.Count - 1; i++)
            {
                listPedidos.Items.Add(dt.Rows[i].ItemArray[0].ToString());
                listPedidos.Items[i].SubItems.Add(dt.Rows[i].ItemArray[6].ToString());
                listPedidos.Items[i].SubItems.Add(dt.Rows[i].ItemArray[4].ToString());
            }
        }

        private void listPedidos_DoubleClick(object sender, MouseEventArgs e)
        {
            abrirPedido();
        }

        private void btnLocalizar_Click(object sender, EventArgs e)
        {
            listPedidos.Items.Clear();
            if (string.IsNullOrWhiteSpace(tbPesquisa.Text))
            {
                Console.WriteLine("Nada inserido.");
            }
            else
            {
                if (tbPesquisa.Text.Equals("*"))
                {
                    LocalizarPedido("SELECT * FROM PedidosVenda INNER JOIN Clientes ON PedidosVenda.ClienteKey = Clientes.ClienteID");
                }
                else
                {
                    if (cboxFiltro.SelectedItem.ToString().Equals("Código"))
                    {
                        LocalizarPedido("SELECT * FROM PedidosVenda INNER JOIN Clientes ON PedidosVenda.ClienteKey = Clientes.ClienteID WHERE PedidoID LIKE @Pesquisa", "@Pesquisa");
                    }
                    if (cboxFiltro.SelectedItem.ToString().Equals("Cliente"))
                    {
                        LocalizarPedido("SELECT * FROM PedidosVenda INNER JOIN Clientes ON PedidosVenda.ClienteKey = Clientes.ClienteID WHERE Nome LIKE @Pesquisa", "@Pesquisa");
                    }
                }
            }
        }

        private void btnVisualizar_Click(object sender, EventArgs e)
        {
            abrirPedido();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            FormPedidoVenda novocadastro = new FormPedidoVenda(isAdmin);
            novocadastro.Show();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
