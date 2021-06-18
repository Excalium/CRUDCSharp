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
    public partial class FormCadUsuario : Form
    {
        SqlConnection conexao = new SqlConnection(@"Server=.\SQLEXPRESS;Database=CRUD;User Id=AcessoCRUD;Password=123;");
        SqlCommand comando;
        SqlDataReader dr;
        SqlDataAdapter da;
        DataTable dt;

        string strSQL;

        bool editando;

        public FormCadUsuario(bool admin)
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            editando = false;

            if (!admin)
            {
                btnExcluir.Enabled = false;
            }
        }

        private void Check_Admin(bool admin)
        {
            if (!admin)
            {
                btnExcluir.Enabled = false;

                tbLogin.Enabled = false;
                tbSenha.Enabled = false;

                cboxAdmin.Enabled = false;
            }
        }

        public FormCadUsuario(string id, bool admin)
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            Editando_Cadastro();
            Check_Admin(admin);

            try
            {
                strSQL = "SELECT * FROM Usuarios WHERE UsuarioID = @Id";

                comando = new SqlCommand(strSQL, conexao);

                comando.Parameters.AddWithValue("@Id", id);

                conexao.Open();

                dr = comando.ExecuteReader();

                while (dr.Read())
                {
                    tbCodigo.Text = id.ToString();
                    tbNome.Text = (string)dr["Nome"];
                    tbLogin.Text = Convert.ToString(dr["LoginUsuario"]);
                    tbSenha.Text = Convert.ToString(dr["Senha"]);
                    if(dr["isAdmin"].Equals(true))
                    {
                        cboxAdmin.Checked = true;
                    }
                    else
                    {
                        cboxAdmin.Checked = false;
                    }

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Erro ao abrir o cadastro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conexao.Close();
                comando.Dispose();
                comando = null;
            }
        }

        private void Editando_Cadastro()
        {
            tbCodigo.ReadOnly = true;
            editando = true;
            Text = "Alterar Usuario";
        }

        private bool Verificar_Campos()
        {
            if (string.IsNullOrWhiteSpace(tbNome.Text)
                || string.IsNullOrWhiteSpace(tbLogin.Text) || string.IsNullOrWhiteSpace(tbSenha.Text))
            {
                MessageBox.Show("Todos os campos são de preenchimento obrigatório!", "Erro ao Salvar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                strSQL = "SELECT * FROM Usuarios WHERE LoginUsuario = @Login";
                comando = new SqlCommand(strSQL, conexao);
                comando.Parameters.AddWithValue("@Login", tbLogin.Text);
                da = new SqlDataAdapter(comando);
                dt = new DataTable();
                da.Fill(dt);

                if (dt.Rows.Count != 0 && string.IsNullOrWhiteSpace(tbCodigo.Text))
                {
                    MessageBox.Show("Usuário já cadastrado!", "Erro ao Salvar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                else
                {
                    return true;
                }
            }
        }


        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (Verificar_Campos())
            {
                if (!editando)
                {
                    if (string.IsNullOrWhiteSpace(tbCodigo.Text))
                    {
                        try
                        {
                            strSQL = "INSERT INTO Usuarios (Nome, LoginUsuario, Senha, isAdmin) VALUES (@Nome, @LoginUsuario, @Senha, @isAdmin)";

                            comando = new SqlCommand(strSQL, conexao);

                            comando.Parameters.AddWithValue("@Nome", tbNome.Text);
                            comando.Parameters.AddWithValue("@LoginUsuario", tbLogin.Text);
                            comando.Parameters.AddWithValue("@Senha", tbSenha.Text);
                            comando.Parameters.AddWithValue("@isAdmin", cboxAdmin.Checked);

                            conexao.Open();
                            comando.ExecuteNonQuery();
                            MessageBox.Show("Usuário salvo com sucesso!", "Registro de Usuário", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            strSQL = "SELECT TOP 1 * FROM Usuarios ORDER BY UsuarioID DESC";

                            comando = new SqlCommand(strSQL, conexao);
                            dr = comando.ExecuteReader();
                            dr.Read();
                            tbCodigo.Text = Convert.ToString(dr["UsuarioID"]);
                            Editando_Cadastro();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, "Erro ao Salvar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        finally
                        {
                            conexao.Close();
                            comando.Dispose();
                            comando = null;
                        }
                    }
                    else
                    {
                        try
                        {
                            SqlCommand identityOn = new SqlCommand("SET IDENTITY_INSERT Usuarios ON", conexao);
                            SqlCommand identityOff = new SqlCommand("SET IDENTITY_INSERT Usuarios OFF", conexao);

                            strSQL = "INSERT INTO Usuarios (UsuarioID, Nome, LoginUsuario, Senha, isAdmin) VALUES (@Id, @Nome, @LoginUsuario, @Senha, @isAdmin)";

                            comando = new SqlCommand(strSQL, conexao);

                            comando.Parameters.AddWithValue("@Id", tbCodigo.Text);
                            comando.Parameters.AddWithValue("@Nome", tbNome.Text);
                            comando.Parameters.AddWithValue("@LoginUsuario", tbLogin.Text);
                            comando.Parameters.AddWithValue("@Senha", tbSenha.Text);
                            comando.Parameters.AddWithValue("@isAdmin", cboxAdmin.Checked);

                            conexao.Open();
                            identityOn.ExecuteNonQuery();
                            comando.ExecuteNonQuery();
                            identityOff.ExecuteNonQuery();
                            MessageBox.Show("Usuário salvo com sucesso!", "Registro de Usuário", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Editando_Cadastro();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, "Erro ao Salvar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        finally
                        {
                            conexao.Close();
                            comando.Dispose();
                            comando = null;
                        }
                    }

                }
                else
                {
                    try
                    {
                        strSQL = "UPDATE Usuarios SET " +
                            "Nome = @Nome, LoginUsuario = @LoginUsuario, Senha = @Senha, isAdmin = @isAdmin WHERE UsuarioID = @Id";

                        comando = new SqlCommand(strSQL, conexao);

                        comando.Parameters.AddWithValue("@Id", tbCodigo.Text);
                        comando.Parameters.AddWithValue("@Nome", tbNome.Text);
                        comando.Parameters.AddWithValue("@LoginUsuario", tbLogin.Text);
                        comando.Parameters.AddWithValue("@Senha", tbSenha.Text);
                        comando.Parameters.AddWithValue("@isAdmin", cboxAdmin.Checked);

                        conexao.Open();
                        comando.ExecuteNonQuery();
                        MessageBox.Show("Usuário alterado com sucesso!", "Registro de Usuário", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Erro ao Salvar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        conexao.Close();
                        comando.Dispose();
                        comando = null;
                    }
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Deseja excluir o usuário?", "Confirmar Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (res == DialogResult.Yes)
            {
                try
                {
                    strSQL = "DELETE Usuarios WHERE UsuarioID = @Id";

                    comando = new SqlCommand(strSQL, conexao);

                    comando.Parameters.AddWithValue("@Id", tbCodigo.Text);

                    conexao.Open();
                    comando.ExecuteNonQuery();

                    MessageBox.Show("Usuario excluído!", "Exclusão de Usuario", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message, "Erro ao Excluir", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    conexao.Close();
                    comando.Dispose();
                    comando = null;
                    Close();
                }
            }            
        }
    }
}
