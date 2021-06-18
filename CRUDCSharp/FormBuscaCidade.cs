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
    public partial class FormBuscaCidade : Form
    {
        SqlConnection conexao = new SqlConnection(@"Server=.\SQLEXPRESS;Database=CRUD;User Id=AcessoCRUD;Password=123;");
        SqlCommand comando;

        SqlDataAdapter daCidade;
        DataTable dtCidade;
        DataSet dsCidade;

        SqlDataAdapter daEstado;
        DataTable dtEstado;
        DataSet dsEstado;

        FormCadCliente cadastro;
        public FormBuscaCidade(FormCadCliente f1)
        {
            InitializeComponent();
            StartPosition = FormStartPosition.Manual;
            Location = new Point(1075, 370);

            listCidades.Columns.Add("Código", 70);
            listCidades.Columns.Add("Cidade", 180);
            listCidades.Columns.Add("Estado", 105);
            listCidades.Columns.Add("UF", 30);
            listCidades.View = View.Details;


            cadastro = f1;
        }

        private void FormBuscaCidade_Load(object sender, EventArgs e)
        {
            
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            listCidades.Items.Clear();

            conexao.Open();
            comando = new SqlCommand("SELECT * FROM Cidades WHERE Nome LIKE @Pesquisa", conexao);
            comando.Parameters.AddWithValue("@Pesquisa", "%" + tbBuscaCidade.Text + "%");

            daCidade = new SqlDataAdapter(comando);
            dsCidade = new DataSet();
            daCidade.Fill(dsCidade, "tabelaCidades");

            comando = new SqlCommand("SELECT * FROM Estados", conexao);
            daEstado = new SqlDataAdapter(comando);
            dsEstado = new DataSet();
            daEstado.Fill(dsEstado, "tabelaEstados");
            conexao.Close();


            dtCidade = dsCidade.Tables["tabelaCidades"];
            dtEstado = dsEstado.Tables["tabelaEstados"];

            int i;
            int i2;
            for (i = 0; i <= dtCidade.Rows.Count - 1; i++)
            {
                listCidades.Items.Add(dtCidade.Rows[i].ItemArray[0].ToString());
                listCidades.Items[i].SubItems.Add(dtCidade.Rows[i].ItemArray[1].ToString());
                for (i2 = 0; i2 <= dtEstado.Rows.Count -1; i2++)
                {
                    if (dtCidade.Rows[i].ItemArray[2].ToString().Equals(dtEstado.Rows[i2].ItemArray[0].ToString()))
                    {
                        listCidades.Items[i].SubItems.Add(dtEstado.Rows[i2].ItemArray[1].ToString());
                        listCidades.Items[i].SubItems.Add(dtEstado.Rows[i2].ItemArray[2].ToString());
                    }
                    else
                    {
                        continue;
                    }
                }
                
            }
        }

        private void listCidades_DoubleClick(object sender, MouseEventArgs e)
        {
            cadastro.setCidade(listCidades.SelectedItems[0].SubItems[0].Text, listCidades.SelectedItems[0].SubItems[1].Text);
            Close();
        }

    }
}
