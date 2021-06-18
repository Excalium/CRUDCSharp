using System;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CRUDCSharp
{
    public partial class FormCadProduto : Form
    {
        SqlConnection conexao = new SqlConnection(@"Server=.\SQLEXPRESS;Database=CRUD;User Id=AcessoCRUD;Password=123;");
        SqlCommand comando;
        SqlDataReader dr;
        string strSQL;

        bool editando;

        public FormCadProduto(bool admin)
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            editando = false;

            if (!admin)
            {
                btnExcluir.Enabled = false;
            }
        }

        public FormCadProduto(string id, bool admin)
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            Editando_Cadastro();

            if (!admin)
            {
                btnExcluir.Enabled = false;
            }

            try
            {
                strSQL = "SELECT * FROM Produtos WHERE ProdutoID = @Id";

                comando = new SqlCommand(strSQL, conexao);

                comando.Parameters.AddWithValue("@Id", id);

                conexao.Open();

                dr = comando.ExecuteReader();

                while (dr.Read())
                {
                    tbCodigo.Text = id.ToString();
                    tbNome.Text = (string)dr["Nome"];
                    tbValVenda.Text = Convert.ToString(dr["Val_Venda"]);
                    tbValCusto.Text = Convert.ToString(dr["Val_Custo"]);
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
            Text = "Alterar Produto";
        }

        private bool Verificar_Campos()
        {
            if (string.IsNullOrWhiteSpace(tbCodigo.Text) && editando)
            {
                MessageBox.Show("O campo 'Código' é de preenchimento obrigatório!", "Salvar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (string.IsNullOrWhiteSpace(tbNome.Text))
            {
                MessageBox.Show("O campo 'Descrição' é de preenchimento obrigatório!", "Salvar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (string.IsNullOrWhiteSpace(tbValCusto.Text))
            {
                MessageBox.Show("O campo 'Valor de Compra' é de preenchimento obrigatório!", "Salvar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (string.IsNullOrWhiteSpace(tbValVenda.Text))
            {
                MessageBox.Show("O campo 'Valor de Venda' é de preenchimento obrigatório!", "Salvar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
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
                            strSQL = "INSERT INTO Produtos (Nome, Val_Venda, Val_Custo) VALUES (@Nome, @Val_Venda, @Val_Custo)";

                            comando = new SqlCommand(strSQL, conexao);

                            comando.Parameters.AddWithValue("@Nome", tbNome.Text);
                            comando.Parameters.AddWithValue("@Val_Venda", tbValVenda.Text.Replace(",","."));
                            comando.Parameters.AddWithValue("@Val_Custo", tbValCusto.Text.Replace(",", "."));

                            conexao.Open();
                            comando.ExecuteNonQuery();
                            MessageBox.Show("Produto salvo com sucesso!", "Registro de Produto", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            strSQL = "SELECT TOP 1 * FROM Produtos ORDER BY ProdutoID DESC";

                            comando = new SqlCommand(strSQL, conexao);
                            dr = comando.ExecuteReader();
                            dr.Read();
                            tbCodigo.Text = Convert.ToString(dr["ProdutoID"]);
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
                            SqlCommand identityOn = new SqlCommand("SET IDENTITY_INSERT Produtos ON", conexao);
                            SqlCommand identityOff = new SqlCommand("SET IDENTITY_INSERT Produtos OFF", conexao);

                            strSQL = "INSERT INTO Produtos (ProdutoID, Nome, Val_Venda, Val_Custo) VALUES (@Id, @Nome, @Val_Venda, @Val_Custo)";

                            comando = new SqlCommand(strSQL, conexao);

                            comando.Parameters.AddWithValue("@Id", tbCodigo.Text);
                            comando.Parameters.AddWithValue("@Nome", tbNome.Text);
                            comando.Parameters.AddWithValue("@Val_Venda", tbValVenda.Text.Replace(",", "."));
                            comando.Parameters.AddWithValue("@Val_Custo", tbValCusto.Text.Replace(",", "."));

                            conexao.Open();
                            identityOn.ExecuteNonQuery();
                            comando.ExecuteNonQuery();
                            identityOff.ExecuteNonQuery();
                            MessageBox.Show("Produto salvo com sucesso!", "Registro de Produto", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                        strSQL = "UPDATE Produtos SET " +
                            "Nome = @Nome, Val_Venda = @Val_Venda, Val_Custo = @Val_Custo WHERE ProdutoID = @Id";

                        comando = new SqlCommand(strSQL, conexao);

                        comando.Parameters.AddWithValue("@Id", tbCodigo.Text);
                        comando.Parameters.AddWithValue("@Nome", tbNome.Text);
                        comando.Parameters.AddWithValue("@Val_Venda", tbValVenda.Text.Replace(",", "."));
                        comando.Parameters.AddWithValue("@Val_Custo", tbValCusto.Text.Replace(",", "."));

                        conexao.Open();
                        comando.ExecuteNonQuery();
                        MessageBox.Show("Produto alterado com sucesso!", "Registro de Produto", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            DialogResult res = MessageBox.Show("Deseja excluir o produto?", "Confirmar Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (res == DialogResult.Yes)
            {
                try
                {
                    strSQL = "DELETE Produtos WHERE ProdutoID = @Id";

                    comando = new SqlCommand(strSQL, conexao);

                    comando.Parameters.AddWithValue("@Id", tbCodigo.Text);

                    conexao.Open();
                    comando.ExecuteNonQuery();

                    MessageBox.Show("Produto excluído!", "Exclusão de Produto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch
                {
                    MessageBox.Show("Produto não pode ser excluído!", "Erro ao Excluir", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
