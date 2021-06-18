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
    public partial class FormPedidoVenda : Form
    {
        SqlConnection conexao = new SqlConnection(@"Server=.\SQLEXPRESS;Database=CRUD;User Id=AcessoCRUD;Password=123;");
        SqlCommand comando;
        SqlDataAdapter da;
        DataSet ds;
        DataTable dt;
        SqlDataReader dr;
        string strSQL;

        bool isAdmin;
        bool editando = false;

        double valor_bruto = 0.0;
        double valor_acres = 0.0;
        double valor_desc = 0.0;
        double valor_total = 0.0;

        public FormPedidoVenda(bool admin)
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;

            listPedidoItens.Columns.Add("Código", 80);
            listPedidoItens.Columns.Add("Descrição", 300);
            listPedidoItens.Columns.Add("Quantidade", 80);
            listPedidoItens.Columns.Add("Valor Venda", 80);
            listPedidoItens.View = View.Details;
            atualizarValores();

            isAdmin = admin;

            if (!admin)
            {
                btnExcluir.Enabled = false;
            }
        }

        public FormPedidoVenda(string id, bool admin)
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;

            listPedidoItens.Columns.Add("Código", 80);
            listPedidoItens.Columns.Add("Descrição", 300);
            listPedidoItens.Columns.Add("Quantidade", 80);
            listPedidoItens.Columns.Add("Valor Venda", 80);
            listPedidoItens.View = View.Details;

            Editando_Pedido();
            Check_Admin(admin);
            isAdmin = admin;
            atualizarValores();

            try
            {
                conexao.Open();

                strSQL = "SELECT * FROM PedidosVenda INNER JOIN Clientes ON PedidosVenda.ClienteKey = Clientes.ClienteID WHERE PedidoID = @Id";
                comando = new SqlCommand(strSQL, conexao);
                comando.Parameters.AddWithValue("@Id", id);

                dr = comando.ExecuteReader();

                while (dr.Read())
                {
                    tbCodPedido.Text = id.ToString();
                    tbCodCliente.Text = Convert.ToString(dr["ClienteID"]);
                    tbNomeCliente.Text = (string)dr["Nome"];
                    tbAcres.Text = Convert.ToString(dr["Acrescimo"]);
                    tbDesc.Text = Convert.ToString(dr["Desconto"]);
                    valor_acres = Convert.ToDouble(tbAcres.Text);
                    valor_desc = Convert.ToDouble(tbDesc.Text);
                }
                dr.Close();

                strSQL = "SELECT * FROM PedidosVendaItens INNER JOIN Produtos ON PedidosVendaItens.ProdutoKey = Produtos.ProdutoID WHERE PedidoKey = @Id";
                comando = new SqlCommand(strSQL, conexao);
                comando.Parameters.AddWithValue("@Id", id);
                da = new SqlDataAdapter(comando);
                ds = new DataSet();
                da.Fill(ds, "tabelaProdutos");

                dt = ds.Tables["tabelaProdutos"];

                int i;
                for (i = 0; i <= dt.Rows.Count - 1; i++)
                {
                    listPedidoItens.Items.Add(dt.Rows[i].ItemArray[1].ToString());
                    listPedidoItens.Items[i].SubItems.Add(dt.Rows[i].ItemArray[5].ToString());
                    listPedidoItens.Items[i].SubItems.Add(dt.Rows[i].ItemArray[2].ToString());
                    listPedidoItens.Items[i].SubItems.Add(dt.Rows[i].ItemArray[3].ToString());
                    valor_bruto += Convert.ToDouble(dt.Rows[i].ItemArray[2]) * Convert.ToDouble(dt.Rows[i].ItemArray[3]);
                }

                atualizarValores();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Erro ao abrir o pedido", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conexao.Close();
                comando.Dispose();
                comando = null;
            }
        }

        private void Check_Admin(bool admin)
        {
            if (!admin)
            {
                btnExcluir.Enabled = false;
                btnFinalizar.Enabled = false;
                btnLocCliente.Enabled = false;
                btnLocProduto.Enabled = false;
                btnInserir.Enabled = false;

                tbCodCliente.Enabled = false;
                tbCodProduto.Enabled = false;

                tbAcres.Enabled = false;
                tbDesc.Enabled = false;
            }
        }

        public void localizarCliente(string id)
        {
            try
            {
                strSQL = "SELECT * FROM Clientes WHERE ClienteID = @Id";

                comando = new SqlCommand(strSQL, conexao);

                comando.Parameters.AddWithValue("@Id", id);

                conexao.Open();

                dr = comando.ExecuteReader();

                while (dr.Read())
                {
                    tbCodCliente.Text = id.ToString();
                    tbNomeCliente.Text = (string)dr["Nome"];
                }
                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro ao Selecionar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conexao.Close();
                comando.Dispose();
                comando = null;
                tbCodProduto.Focus();
            }
        }

        public void localizarProduto(string id)
        {
            try
            {
                strSQL = "SELECT * FROM Produtos WHERE ProdutoID = @Id";

                comando = new SqlCommand(strSQL, conexao);

                comando.Parameters.AddWithValue("@Id", id);

                conexao.Open();

                dr = comando.ExecuteReader();

                while (dr.Read())
                {
                    tbCodProduto.Text = id.ToString();
                    tbDescricao.Text = (string)dr["Nome"];
                    tbValorItem.Text = Convert.ToString(dr["Val_Venda"]);
                }
                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro ao Selecionar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conexao.Close();
                comando.Dispose();
                comando = null;
                tbQuantidade.Focus();
            }
        }

        private void atualizarValores()
        {
            tbBruto.Text = string.Format("{0:0.00}", valor_bruto);
            tbAcres.Text = string.Format("{0:0.00}", valor_acres);
            tbDesc.Text = string.Format("{0:0.00}", valor_desc);

            valor_total = valor_bruto + valor_acres - valor_desc;
            tbLiquido.Text = string.Format("{0:0.00}", valor_total);
        }
        private bool Verificar_Campos()
        {
            if (string.IsNullOrWhiteSpace(tbCodCliente.Text))
            {
                MessageBox.Show("O campo 'Cód. Cliente' é de preenchimento obrigatório!", "Salvar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (listPedidoItens.Items.Count < 1)
            {
                MessageBox.Show("É necessário inserir produtos!", "Salvar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (valor_total < 0.0)
            {
                MessageBox.Show("O pedido não pode possuir Total Líquido negativo!", "Salvar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private void inserirProduto()
        {
            if(string.IsNullOrWhiteSpace(tbCodProduto.Text) || string.IsNullOrWhiteSpace(tbDescricao.Text))
            {
                MessageBox.Show("Selecione um produto para inserção!", "Erro ao Inserir Produto", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    conexao.Open();
                    strSQL = "SELECT * FROM Produtos WHERE ProdutoID = @ProdutoID";
                    comando = new SqlCommand(strSQL, conexao);
                    comando.Parameters.AddWithValue("@ProdutoID", tbCodProduto.Text);
                    da = new SqlDataAdapter(comando);
                    ds = new DataSet();
                    da.Fill(ds, "dadosProduto");
                    dt = ds.Tables["dadosProduto"];

                    listPedidoItens.Items.Add(dt.Rows[0].ItemArray[0].ToString());
                    int i = listPedidoItens.Items.Count - 1;
                    listPedidoItens.Items[i].SubItems.Add(dt.Rows[0].ItemArray[1].ToString());
                    listPedidoItens.Items[i].SubItems.Add(tbQuantidade.Text);
                    listPedidoItens.Items[i].SubItems.Add(tbValorItem.Text);

                    valor_bruto += Convert.ToDouble(tbValorItem.Text) * Convert.ToDouble(tbQuantidade.Text);
                    atualizarValores();

                    tbCodProduto.Text = "";
                    tbDescricao.Text = "";
                    tbQuantidade.Text = "";
                    tbValorItem.Text = "";
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Erro ao Inserir Produto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    conexao.Close();
                    comando.Dispose();
                    comando = null;
                }
            }
        }
        private void Editando_Pedido()
        {
            editando = true;
            Text = "Alterar Pedido";
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            if (Verificar_Campos())
            {
                if (!editando)
            {
                try
                {
                    conexao.Open();

                    strSQL = "INSERT INTO PedidosVenda (ClienteKey, Acrescimo, Desconto, ValorTotal) VALUES (@ClienteKey, @Acrescimo, @Desconto, @ValorTotal)";
                    comando = new SqlCommand(strSQL, conexao);
                    comando.Parameters.AddWithValue("@ClienteKey", tbCodCliente.Text);
                    comando.Parameters.AddWithValue("@Acrescimo", tbAcres.Text.Replace(",", "."));
                    comando.Parameters.AddWithValue("@Desconto", tbDesc.Text.Replace(",", "."));
                    comando.Parameters.AddWithValue("@ValorTotal", tbLiquido.Text.Replace(",","."));
                    comando.ExecuteNonQuery();

                    strSQL = "SELECT TOP 1 * FROM PedidosVenda ORDER BY PedidoID DESC";
                    comando = new SqlCommand(strSQL, conexao);
                    dr = comando.ExecuteReader();
                    dr.Read();
                    tbCodPedido.Text = Convert.ToString(dr["PedidoID"]);
                    dr.Close();

                    strSQL = "INSERT INTO PedidosVendaItens (PedidoKey, ProdutoKey, Quantidade, ValorProduto) VALUES (@PedidoKey, @ProdutoKey, @Quantidade, @ValorProduto)";
                    int i;
                    for(i = 0; i <= listPedidoItens.Items.Count - 1; i++)
                    {
                        comando = new SqlCommand(strSQL, conexao);
                        comando.Parameters.AddWithValue("@PedidoKey", tbCodPedido.Text);
                        comando.Parameters.AddWithValue("@ProdutoKey", listPedidoItens.Items[i].SubItems[0].Text);
                        comando.Parameters.AddWithValue("@Quantidade", listPedidoItens.Items[i].SubItems[2].Text.Replace(",","."));
                        comando.Parameters.AddWithValue("@ValorProduto", listPedidoItens.Items[i].SubItems[3].Text.Replace(",","."));
                        comando.ExecuteNonQuery();
                    }

                    MessageBox.Show("Pedido salvo com sucesso!", "Registro de Pedido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        
                    Editando_Pedido();
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
                    conexao.Open();

                    strSQL = "UPDATE PedidosVenda SET ClienteKey = @ClienteKey, Acrescimo = @Acrescimo, Desconto = @Desconto, ValorTotal = @ValorTotal WHERE PedidoID = @PedidoID";
                    comando = new SqlCommand(strSQL, conexao);
                    comando.Parameters.AddWithValue("@ClienteKey", tbCodCliente.Text);
                    comando.Parameters.AddWithValue("@Acrescimo", tbAcres.Text.Replace(",", "."));
                    comando.Parameters.AddWithValue("@Desconto", tbDesc.Text.Replace(",", "."));
                    comando.Parameters.AddWithValue("@ValorTotal", tbLiquido.Text.Replace(",", "."));

                    comando.Parameters.AddWithValue("@PedidoId", tbCodPedido.Text);
                    comando.ExecuteNonQuery();

                    strSQL = "DELETE PedidosVendaItens WHERE PedidoKey = @PedidoKey";
                    comando = new SqlCommand(strSQL, conexao);
                    comando.Parameters.AddWithValue("@PedidoKey", tbCodPedido.Text);
                    comando.ExecuteNonQuery();

                    strSQL = "INSERT INTO PedidosVendaItens (PedidoKey, ProdutoKey, ValorProduto) VALUES (@PedidoKey, @ProdutoKey, @ValorProduto)";
                    
                    int i;
                    for (i = 0; i <= listPedidoItens.Items.Count - 1; i++)
                    {
                        comando = new SqlCommand(strSQL, conexao);
                        comando.Parameters.AddWithValue("@PedidoKey", tbCodPedido.Text);
                        comando.Parameters.AddWithValue("@ProdutoKey", listPedidoItens.Items[i].SubItems[0].Text);
                        comando.Parameters.AddWithValue("@Quantidade", listPedidoItens.Items[i].SubItems[2].Text.Replace(",", "."));
                        comando.Parameters.AddWithValue("@ValorProduto", listPedidoItens.Items[i].SubItems[3].Text.Replace(",", "."));
                        comando.ExecuteNonQuery();
                    }

                    MessageBox.Show("Pedido alterado com sucesso!", "Registro de Pedido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message, "Erro ao Editar", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Deseja excluir o pedido?", "Confirmar Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (res == DialogResult.Yes)
            {
                try
                {
                    conexao.Open();

                    strSQL = "DELETE PedidosVendaItens WHERE PedidoKey = @PedidoKey";
                    comando = new SqlCommand(strSQL, conexao);
                    comando.Parameters.AddWithValue("@PedidoKey", tbCodPedido.Text);
                    comando.ExecuteNonQuery();

                    strSQL = "DELETE PedidosVenda WHERE PedidoID = @Id";
                    comando = new SqlCommand(strSQL, conexao);
                    comando.Parameters.AddWithValue("@Id", tbCodPedido.Text);
                    comando.ExecuteNonQuery();

                    MessageBox.Show("Pedido excluído!", "Exclusão de Pedido", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void btnLocCliente_Click(object sender, EventArgs e)
        {
            FormBuscaCliente clientes = new FormBuscaCliente(this);
            clientes.Show();
        }

        private void btnLocProduto_Click(object sender, EventArgs e)
        {
            FormBuscaProduto produtos = new FormBuscaProduto(this);
            produtos.Show();
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            inserirProduto();
        }

        private void tbCodCliente_KeyDownEnter(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                localizarCliente(tbCodCliente.Text);
                e.SuppressKeyPress = true;
            }
        }

        private void tbCodProduto_KeyDownEnter(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && !string.IsNullOrWhiteSpace(tbCodProduto.Text))
            {
                localizarProduto(tbCodProduto.Text);
                e.SuppressKeyPress = true;
            }
        }

        private void tbAcres_KeyDownEnter(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (string.IsNullOrWhiteSpace(tbAcres.Text))
                {
                    valor_acres = 0.0;
                    atualizarValores();
                    e.SuppressKeyPress = true;
                }
                else
                {
                    valor_acres = Convert.ToDouble(tbAcres.Text);
                    atualizarValores();
                    e.SuppressKeyPress = true;
                }
            }
        }

        private void tbDesc_KeyDownEnter(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (string.IsNullOrWhiteSpace(tbDesc.Text))
                {
                    valor_desc = 0.0;
                    atualizarValores();
                    e.SuppressKeyPress = true;
                }
                else
                {
                    valor_desc = Convert.ToDouble(tbDesc.Text);
                    atualizarValores();
                    e.SuppressKeyPress = true;
                }
            }
        }

        private void tbAcres_LostFocus(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbAcres.Text))
            {
                valor_acres = 0.0;
                atualizarValores();
            }
            else
            {
                valor_acres = Convert.ToDouble(tbAcres.Text);
                atualizarValores();
            }
        }

        private void tbDesc_LostFocus(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbDesc.Text))
            {
                valor_desc = 0.0;
                atualizarValores();
            }
            else
            {
                valor_desc = Convert.ToDouble(tbDesc.Text);
                atualizarValores();
            }
        }

        private void tbValorItem_KeyDownEnter(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && !string.IsNullOrWhiteSpace(tbValorItem.Text))
            {
                inserirProduto();
                tbCodProduto.Focus();
                e.SuppressKeyPress = true;
            }
        }

        private void listPedidoItens_KeyDownDelete(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Delete)
            {
                if (isAdmin)
                {
                    if (listPedidoItens.SelectedItems.Count == 0)
                    {
                        MessageBox.Show("Selecione um produto para exclusão!", "Remover Produto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        valor_bruto -= Convert.ToDouble(listPedidoItens.SelectedItems[0].SubItems[2].Text) * Convert.ToDouble(listPedidoItens.SelectedItems[0].SubItems[3].Text);
                        listPedidoItens.Items.Remove(listPedidoItens.SelectedItems[0]);
                        atualizarValores();
                    }
                }
                else
                {
                    MessageBox.Show("Usuário logado não é administrador!", "Remover Produto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void tbQuantidade_KeyDownEnter(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && !string.IsNullOrWhiteSpace(tbQuantidade.Text))
            {
                tbValorItem.Focus();
                e.SuppressKeyPress = true;
            }
        }
    }
}
