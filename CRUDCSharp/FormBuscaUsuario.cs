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
    public partial class FormBuscaUsuario : Form
    {
        SqlConnection conexao = new SqlConnection(@"Server=.\SQLEXPRESS;Database=CRUD;User Id=AcessoCRUD;Password=123;");
        SqlCommand comando;
        SqlDataAdapter da;
        DataTable dt;
        DataSet ds;

        bool isAdmin;

        public FormBuscaUsuario(bool admin)
        {
            InitializeComponent();

            listUsuarios.Columns.Add("Código", 70);
            listUsuarios.Columns.Add("Nome", 170);
            listUsuarios.Columns.Add("Usuario", 120);
            listUsuarios.Columns.Add("Administrador", 90);
            listUsuarios.View = View.Details;

            string[] filtros = { "Código", "Nome", "Usuario"};
            cboxFiltro.DataSource = filtros;
            cboxFiltro.DropDownStyle = ComboBoxStyle.DropDownList;

            isAdmin = admin;
        }
        private void abrirCadastro()
        {
            if (listUsuarios.SelectedItems.Count >= 1)
            {
                FormCadUsuario abrircadastro = new FormCadUsuario(listUsuarios.SelectedItems[0].SubItems[0].Text, isAdmin);
                abrircadastro.Show();
            }
        }

        private void LocalizarUsuario(string sql)
        {
            conexao.Open();
            comando = new SqlCommand(sql, conexao);
            da = new SqlDataAdapter(comando);
            ds = new DataSet();
            da.Fill(ds, "tabelaUsuarios");
            conexao.Close();

            dt = ds.Tables["tabelaUsuarios"];

            int i;
            for (i = 0; i <= dt.Rows.Count - 1; i++)
            {
                listUsuarios.Items.Add(dt.Rows[i].ItemArray[0].ToString());
                listUsuarios.Items[i].SubItems.Add(dt.Rows[i].ItemArray[1].ToString());
                listUsuarios.Items[i].SubItems.Add(dt.Rows[i].ItemArray[2].ToString());
                if (dt.Rows[i].ItemArray[4].Equals(true))
                {
                    listUsuarios.Items[i].SubItems.Add("Sim");
                }
                else
                {
                    listUsuarios.Items[i].SubItems.Add("Não");
                }
            }
        }

        private void LocalizarUsuario(string sql, string comand)
        {
            conexao.Open();
            comando = new SqlCommand(sql, conexao);
            comando.Parameters.AddWithValue(comand, "%" + tbPesquisa.Text + "%");
            da = new SqlDataAdapter(comando);
            ds = new DataSet();
            da.Fill(ds, "tabelaUsuarios");
            conexao.Close();

            dt = ds.Tables["tabelaUsuarios"];

            int i;
            for (i = 0; i <= dt.Rows.Count - 1; i++)
            {
                listUsuarios.Items.Add(dt.Rows[i].ItemArray[0].ToString());
                listUsuarios.Items[i].SubItems.Add(dt.Rows[i].ItemArray[1].ToString());
                listUsuarios.Items[i].SubItems.Add(dt.Rows[i].ItemArray[2].ToString());
                if (dt.Rows[i].ItemArray[4].Equals(true))
                {
                    listUsuarios.Items[i].SubItems.Add("Sim");
                }
                else
                {
                    listUsuarios.Items[i].SubItems.Add("Não");
                }
            }
        }

        private void listUsuarios_DoubleClick(object sender, MouseEventArgs e)
        {
            abrirCadastro();
        }

        private void btnLocalizar_Click(object sender, EventArgs e)
        {
            listUsuarios.Items.Clear();
            if (string.IsNullOrWhiteSpace(tbPesquisa.Text))
            {
                Console.WriteLine("Nada inserido.");
            }
            else
            {
                if (tbPesquisa.Text.Equals("*"))
                {
                    LocalizarUsuario("SELECT * FROM Usuarios");
                }
                else
                {
                    if (cboxFiltro.SelectedItem.ToString().Equals("Código"))
                    {
                        LocalizarUsuario("SELECT * FROM Usuarios WHERE UsuarioID LIKE @Pesquisa", "@Pesquisa");
                    }
                    if (cboxFiltro.SelectedItem.ToString().Equals("Nome"))
                    {
                        LocalizarUsuario("SELECT * FROM Usuarios WHERE Nome LIKE @Pesquisa", "@Pesquisa");
                    }

                    if (cboxFiltro.SelectedItem.ToString().Equals("Usuario"))
                    {
                        LocalizarUsuario("SELECT * FROM Usuarios WHERE LoginUsuario LIKE @Pesquisa", "@Pesquisa");
                    }
                }
            }
        }

        private void btnAbrir_Click(object sender, EventArgs e)
        {
            abrirCadastro();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            FormCadUsuario novocadastro = new FormCadUsuario(isAdmin);
            novocadastro.Show();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
