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
    public partial class FormLogin : Form
    {
        SqlConnection conexao = new SqlConnection(@"Server=.\SQLEXPRESS;Database=CRUD;User Id=AcessoCRUD;Password=123;");
        SqlCommand comando;
        SqlDataAdapter da;
        DataTable dt;
        string strSQL;

        bool isAdmin = false;

        public FormLogin()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            try
            {
                conexao.Open();
                strSQL = "SELECT * FROM Usuarios WHERE LoginUsuario = @Login AND Senha = @Senha";
                comando = new SqlCommand(strSQL, conexao);
                comando.Parameters.AddWithValue("@Login", tbLogin.Text);
                comando.Parameters.AddWithValue("@Senha", tbSenha.Text);
                da = new SqlDataAdapter(comando);
                dt = new DataTable();
                da.Fill(dt);

                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("Usuário ou senha inválidos, verifique e tente novamente!", "Falha de Credenciais", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (dt.Rows[0].ItemArray[4].Equals(true))
                    {
                        isAdmin = true;
                    }
                    Menu menu = new Menu(this, isAdmin);
                    menu.Show();

                    Hide();
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Falha no Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conexao.Close();
                comando.Dispose();
                comando = null;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
