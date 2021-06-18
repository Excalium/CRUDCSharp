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
    public partial class FormBuscaCliente : Form
    {
        SqlConnection conexao = new SqlConnection(@"Server=.\SQLEXPRESS;Database=CRUD;User Id=AcessoCRUD;Password=123;");
        SqlCommand comando;
        SqlDataAdapter da;
        DataTable dt;
        DataSet ds;

        SqlDataAdapter daCidade;
        DataTable dtCidade;
        DataSet dsCidade;

        bool pedido = false;
        bool isAdmin;

        FormPedidoVenda venda;

        public FormBuscaCliente(bool admin)
        {
            InitializeComponent();

            listClientes.Columns.Add("Código", 70);
            listClientes.Columns.Add("Razão Social / Nome", 300);
            listClientes.Columns.Add("CNPJ / CPF", 120);
            listClientes.Columns.Add("IE", 80);
            listClientes.Columns.Add("Cidade", 105);
            listClientes.View = View.Details;

            string[] filtros = { "Nome / Razão", "CNPJ / CPF", "IE / RG", "Cidade" };
            cboxFiltro.DataSource = filtros;
            cboxFiltro.DropDownStyle = ComboBoxStyle.DropDownList;

            isAdmin = admin;
        }
        public FormBuscaCliente(FormPedidoVenda f1)
        {
            InitializeComponent();

            listClientes.Columns.Add("Código", 70);
            listClientes.Columns.Add("Razão Social / Nome", 300);
            listClientes.Columns.Add("CNPJ / CPF", 120);
            listClientes.Columns.Add("IE", 80);
            listClientes.Columns.Add("Cidade", 105);
            listClientes.View = View.Details;

            string[] filtros = { "Nome / Razão", "CNPJ / CPF", "IE / RG", "Cidade" };
            cboxFiltro.DataSource = filtros;
            cboxFiltro.DropDownStyle = ComboBoxStyle.DropDownList;

            venda = f1;
            pedido = true;
        }

        private void abrirCadastro()
        {
            if(listClientes.SelectedItems.Count >= 1)
            {
                FormCadCliente abrircadastro = new FormCadCliente(listClientes.SelectedItems[0].SubItems[0].Text, isAdmin);
                abrircadastro.Show();
            }
        }

        private void LocalizarCliente(string sql)
        {
            conexao.Open();
            comando = new SqlCommand(sql, conexao);
            da = new SqlDataAdapter(comando);
            ds = new DataSet();
            da.Fill(ds, "tabelaClientes");

            comando = new SqlCommand("SELECT * FROM Cidades", conexao);
            daCidade = new SqlDataAdapter(comando);
            dsCidade = new DataSet();
            daCidade.Fill(dsCidade, "tabelaCidades");
            conexao.Close();

            dt = ds.Tables["tabelaClientes"];
            dtCidade = dsCidade.Tables["tabelaCidades"];

            int i;
            int i2;
            for (i = 0; i <= dt.Rows.Count - 1; i++)
            {
                listClientes.Items.Add(dt.Rows[i].ItemArray[0].ToString());
                listClientes.Items[i].SubItems.Add(dt.Rows[i].ItemArray[1].ToString());
                listClientes.Items[i].SubItems.Add(dt.Rows[i].ItemArray[2].ToString());
                listClientes.Items[i].SubItems.Add(dt.Rows[i].ItemArray[3].ToString());
                for (i2 = 0; i2 <= dtCidade.Rows.Count - 1; i2++)
                {
                    if (dt.Rows[i].ItemArray[8].ToString().Equals(dtCidade.Rows[i2].ItemArray[0].ToString()))
                    {
                        listClientes.Items[i].SubItems.Add(dtCidade.Rows[i2].ItemArray[1].ToString());
                    }
                    else
                    {
                        continue;
                    }
                }
            }
        }

        private void LocalizarCliente(string sql, string comand)
        {
            conexao.Open();
            comando = new SqlCommand(sql, conexao);
            comando.Parameters.AddWithValue(comand, "%" + tbPesquisa.Text + "%");
            da = new SqlDataAdapter(comando);
            ds = new DataSet();
            da.Fill(ds, "tabelaClientes");

            comando = new SqlCommand("SELECT * FROM Cidades", conexao);
            daCidade = new SqlDataAdapter(comando);
            dsCidade = new DataSet();
            daCidade.Fill(dsCidade, "tabelaCidades");
            conexao.Close();

            dt = ds.Tables["tabelaClientes"];
            dtCidade = dsCidade.Tables["tabelaCidades"];

            int i;
            int i2;
            for (i = 0; i <= dt.Rows.Count - 1; i++)
            {
                listClientes.Items.Add(dt.Rows[i].ItemArray[0].ToString());
                listClientes.Items[i].SubItems.Add(dt.Rows[i].ItemArray[1].ToString());
                listClientes.Items[i].SubItems.Add(dt.Rows[i].ItemArray[2].ToString());
                listClientes.Items[i].SubItems.Add(dt.Rows[i].ItemArray[3].ToString());
                for (i2 = 0; i2 <= dtCidade.Rows.Count - 1; i2++)
                {
                    if (dt.Rows[i].ItemArray[8].ToString().Equals(dtCidade.Rows[i2].ItemArray[0].ToString()))
                    {
                        listClientes.Items[i].SubItems.Add(dtCidade.Rows[i2].ItemArray[1].ToString());
                    }
                    else
                    {
                        continue;
                    }
                }
            }
        }

        private void listClientes_DoubleClick(object sender, MouseEventArgs e)
        {
            if(pedido != true)
            {
                abrirCadastro();
            }
            else
            {
                venda.localizarCliente(listClientes.SelectedItems[0].SubItems[0].Text);
                Close();
            }
        }

        private void btnLocalizar_Click(object sender, EventArgs e)
        {
            listClientes.Items.Clear();
            if (string.IsNullOrWhiteSpace(tbPesquisa.Text))
            {
                Console.WriteLine("Nada inserido.");
            }
            else
            {
                if (tbPesquisa.Text.Equals("*"))
                {
                    LocalizarCliente("SELECT * FROM Clientes");
                }
                else
                {
                    if (cboxFiltro.SelectedItem.ToString().Equals("Nome / Razão"))
                    {
                        LocalizarCliente("SELECT * FROM Clientes WHERE Nome LIKE @Pesquisa", "@Pesquisa");
                    }
                    if (cboxFiltro.SelectedItem.ToString().Equals("CNPJ / CPF"))
                    {
                        LocalizarCliente("SELECT * FROM Clientes WHERE CPF_CNPJ LIKE @Pesquisa", "@Pesquisa");
                    }

                    if (cboxFiltro.SelectedItem.ToString().Equals("IE / RG"))
                    {
                        LocalizarCliente("SELECT * FROM Clientes WHERE IE LIKE @Pesquisa", "@Pesquisa");
                    }
                    if (cboxFiltro.SelectedItem.ToString().Equals("Cidade"))
                    {
                        LocalizarCliente("SELECT * FROM Clientes INNER JOIN Cidades ON Clientes.CidadeKey " +
                            "= Cidades.CidadeID WHERE Cidades.Nome LIKE @Pesquisa", "@Pesquisa");
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
                venda.localizarCliente(listClientes.SelectedItems[0].SubItems[0].Text);
                Close();
            }
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            FormCadCliente novocadastro = new FormCadCliente(isAdmin);
            novocadastro.Show();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
