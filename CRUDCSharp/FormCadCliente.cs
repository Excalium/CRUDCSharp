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
    public partial class FormCadCliente : Form
    {
        SqlConnection conexao = new SqlConnection(@"Server=.\SQLEXPRESS;Database=CRUD;User Id=AcessoCRUD;Password=123;");
        SqlCommand comando;
        SqlDataReader dr;
        string strSQL;

        bool editando;

        public FormCadCliente(bool admin)
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            editando = false;

            string[] tipos = { "Pessoa Física", "Pessoa Jurídica" };
            cboxTipo.DataSource = tipos;
            cboxTipo.DropDownStyle = ComboBoxStyle.DropDownList;


            if (!admin)
            {
                btnExcluir.Enabled = false;
            }
        }

        public void setCidade(string codigo, string nome)
        {
            tbCodigoCidade.Text = codigo;
            tbCidade.Text = nome;
        }

        public FormCadCliente(string id, bool admin)
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            Editando_Cadastro();

            string[] tipos = { "Pessoa Física", "Pessoa Jurídica" };
            cboxTipo.DataSource = tipos;
            cboxTipo.DropDownStyle = ComboBoxStyle.DropDownList;

            if (!admin)
            {
                btnExcluir.Enabled = false;
            }

            try
            {
                strSQL = "SELECT * FROM Clientes WHERE ClienteID = @Id";

                comando = new SqlCommand(strSQL, conexao);

                comando.Parameters.AddWithValue("@Id", id);

                conexao.Open();

                dr = comando.ExecuteReader();

                while (dr.Read())
                {
                    if (dr["CPF_CNPJ"].ToString().Length == 11)
                        cboxTipo.SelectedIndex = 0;
                    if (dr["CPF_CNPJ"].ToString().Length == 14)
                        cboxTipo.SelectedIndex = 1;
                    tbCodigo.Text = id.ToString();
                    tbNome.Text = (string)dr["Nome"];
                    tbCNPJ.Text = Convert.ToString(dr["CPF_CNPJ"]);
                    tbIE.Text = Convert.ToString(dr["IE"]);
                    tbCEP.Text = Convert.ToString(dr["CEP"]);
                    tbLogradouro.Text = (string)dr["Logradouro"];
                    tbNumero.Text = Convert.ToString(dr["Numero"]);
                    tbBairro.Text = (string)dr["Bairro"];
                    tbCodigoCidade.Text = Convert.ToString(dr["CidadeKey"]);
                    tbComplemento.Text = (string)dr["Complemento"];
                }
                dr.Close();

                strSQL = "SELECT Nome FROM Cidades WHERE CidadeID = @CidadeID";
                comando = new SqlCommand(strSQL, conexao);
                comando.Parameters.AddWithValue("@CidadeID", tbCodigoCidade.Text);

                dr = comando.ExecuteReader();
                dr.Read();

                tbCidade.Text = (string)(dr["Nome"]);
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
            Text = "Alterar Cliente";
        }

        private bool Verificar_Campos()
        {
            if (string.IsNullOrWhiteSpace(tbNome.Text))
            {
                MessageBox.Show("O campo 'Razão Social / Nome' é de preenchimento obrigatório!", "Salvar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (string.IsNullOrWhiteSpace(tbCNPJ.Text.Replace(".", "").Replace("/", "").Replace("-", "").Replace("_", "")))
            {
                MessageBox.Show("O campo 'CNPJ / CPF' é de preenchimento obrigatório!", "Salvar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (string.IsNullOrWhiteSpace(tbIE.Text))
            {
                MessageBox.Show("O campo 'Insc. Estadual / RG' é de preenchimento obrigatório!", "Salvar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (string.IsNullOrWhiteSpace(tbCEP.Text.Replace("-", "").Replace("_", "")))
            {
                MessageBox.Show("O campo 'CEP' é de preenchimento obrigatório!", "Salvar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (string.IsNullOrWhiteSpace(tbCodigoCidade.Text))
            {
                MessageBox.Show("É necessário localizar a Cidade!", "Salvar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (string.IsNullOrWhiteSpace(tbLogradouro.Text))
            {
                MessageBox.Show("O campo 'Logradouro' é de preenchimento obrigatório!", "Salvar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (string.IsNullOrWhiteSpace(tbBairro.Text))
            {
                MessageBox.Show("O campo 'Bairro' é de preenchimento obrigatório!", "Salvar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                            strSQL = "INSERT INTO Clientes (Nome, CPF_CNPJ, IE, CEP, Logradouro, Numero, Bairro, Complemento, CidadeKey) " +
                                "VALUES (@Nome, @CPF_CNPJ, @IE, @CEP, @Logradouro, @Numero, @Bairro, @Complemento, @CidadeKey)";

                            comando = new SqlCommand(strSQL, conexao);

                            comando.Parameters.AddWithValue("@Nome", tbNome.Text);
                            comando.Parameters.AddWithValue("@CPF_CNPJ", tbCNPJ.Text.Replace(".", "").Replace("/", "").Replace("-", ""));
                            comando.Parameters.AddWithValue("@IE", tbIE.Text);
                            comando.Parameters.AddWithValue("@CEP", tbCEP.Text.Replace("-", ""));
                            comando.Parameters.AddWithValue("@Logradouro", tbLogradouro.Text);
                            comando.Parameters.AddWithValue("@Numero", tbNumero.Text);
                            comando.Parameters.AddWithValue("@Bairro", tbBairro.Text);
                            comando.Parameters.AddWithValue("@Complemento", tbComplemento.Text);
                            comando.Parameters.AddWithValue("@CidadeKey", tbCodigoCidade.Text);

                            conexao.Open();
                            comando.ExecuteNonQuery();
                            MessageBox.Show("Cliente salvo com sucesso!", "Registro de Cliente", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            strSQL = "SELECT TOP 1 * FROM Clientes ORDER BY ClienteID DESC";

                            comando = new SqlCommand(strSQL, conexao);
                            dr = comando.ExecuteReader();
                            dr.Read();
                            tbCodigo.Text = Convert.ToString(dr["ClienteID"]);
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
                            SqlCommand identityOn = new SqlCommand("SET IDENTITY_INSERT Clientes ON", conexao);
                            SqlCommand identityOff = new SqlCommand("SET IDENTITY_INSERT Clientes OFF", conexao);

                            strSQL = "INSERT INTO Clientes (ClienteID, Nome, CPF_CNPJ, IE, CEP, Logradouro, Numero, Bairro, Complemento, CidadeKey) " +
                                "VALUES (@Id, @Nome, @CPF_CNPJ, @IE, @CEP, @Logradouro, @Numero, @Bairro, @Complemento, @CidadeKey)";

                            comando = new SqlCommand(strSQL, conexao);

                            comando.Parameters.AddWithValue("@Id", tbCodigo.Text);
                            comando.Parameters.AddWithValue("@Nome", tbNome.Text);
                            comando.Parameters.AddWithValue("@CPF_CNPJ", tbCNPJ.Text.Replace(".", "").Replace("/", "").Replace("-", ""));
                            comando.Parameters.AddWithValue("@IE", tbIE.Text);
                            comando.Parameters.AddWithValue("@CEP", tbCEP.Text.Replace("-", ""));
                            comando.Parameters.AddWithValue("@Logradouro", tbLogradouro.Text);
                            comando.Parameters.AddWithValue("@Numero", tbNumero.Text);
                            comando.Parameters.AddWithValue("@Bairro", tbBairro.Text);
                            comando.Parameters.AddWithValue("@Complemento", tbComplemento.Text);
                            comando.Parameters.AddWithValue("@CidadeKey", tbCodigoCidade.Text);

                            conexao.Open();
                            identityOn.ExecuteNonQuery();
                            comando.ExecuteNonQuery();
                            identityOff.ExecuteNonQuery();
                            MessageBox.Show("Cliente salvo com sucesso!", "Registro de Cliente", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                        strSQL = "UPDATE Clientes SET " +
                            "Nome = @Nome, CPF_CNPJ = @CPF_CNPJ, IE = @IE, CEP = @CEP, Logradouro = @Logradouro, " +
                            "Numero = @Numero, Bairro = @Bairro, Complemento = @Complemento, CidadeKey = @CidadeKey " +
                            "WHERE ClienteID = @Id";

                        comando = new SqlCommand(strSQL, conexao);

                        comando.Parameters.AddWithValue("@Id", tbCodigo.Text);
                        comando.Parameters.AddWithValue("@Nome", tbNome.Text);
                        comando.Parameters.AddWithValue("@CPF_CNPJ", tbCNPJ.Text.Replace(".", "").Replace("/", "").Replace("-", ""));
                        comando.Parameters.AddWithValue("@IE", tbIE.Text);
                        comando.Parameters.AddWithValue("@CEP", tbCEP.Text.Replace("-", ""));
                        comando.Parameters.AddWithValue("@Logradouro", tbLogradouro.Text);
                        comando.Parameters.AddWithValue("@Numero", tbNumero.Text);
                        comando.Parameters.AddWithValue("@Bairro", tbBairro.Text);
                        comando.Parameters.AddWithValue("@Complemento", tbComplemento.Text);
                        comando.Parameters.AddWithValue("@CidadeKey", tbCodigoCidade.Text);

                        conexao.Open();
                        comando.ExecuteNonQuery();
                        MessageBox.Show("Cliente alterado com sucesso!", "Registro de Cliente", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            DialogResult res = MessageBox.Show("Deseja excluir o cliente?", "Confirmar Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (res == DialogResult.Yes)
            {
                try
                {
                    strSQL = "DELETE Clientes WHERE ClienteID = @Id";

                    comando = new SqlCommand(strSQL, conexao);

                    comando.Parameters.AddWithValue("@Id", tbCodigo.Text);

                    conexao.Open();
                    comando.ExecuteNonQuery();

                    MessageBox.Show("Cliente excluído!", "Exclusão de Cliente", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch
                {
                    MessageBox.Show("Cliente não pode ser excluído!", "Erro ao Excluir", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void btnLocalizar_Click(object sender, EventArgs e)
        {
            FormBuscaCidade cidades = new FormBuscaCidade(this);
            cidades.Show();
        }

        private void cboxTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboxTipo.SelectedIndex == 0)
            {
                tbCNPJ.Mask = "000,000,000-00";
                labelRazao.Text = "Nome*";
                labelCNPJ.Text = "CPF*";
                labelIE.Text = "RG*";
            }

            if(cboxTipo.SelectedIndex == 1)
            {
                tbCNPJ.Mask = "00,000,000/0000-00";
                labelRazao.Text = "Razão Social*";
                labelCNPJ.Text = "CNPJ*";
                labelIE.Text = "Insc. Estadual*";
            }
        }
    }
}
