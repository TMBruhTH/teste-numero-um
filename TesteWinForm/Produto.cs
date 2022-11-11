using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TesteWinForm
{
    public partial class Produto : Form
    {
        SqlConnection con = new SqlConnection("Data Source=BRUNO-PC\\BRUNOSQL;Initial Catalog=Estoque;Integrated Security=True");

        SqlCommand cmd;

        int ID = 0;

        public Produto()
        {
            InitializeComponent();

            ExibirProdutos();

            LimparDados();

            BloquearDesbloquearCampos(false);
        }

        private void VerificaRegistro()
        {
            try
            {
                SqlCommand cmd = con.CreateCommand();

                cmd.CommandText = "SELECT * FROM Produto Where NOME_PRODUTO = @NOME_PRODUTO";

                cmd.Parameters.Add(new SqlParameter("@NOME_PRODUTO", textBoxNomeProduto.Text.ToUpper()));

                con.Open();

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    ID = Convert.ToInt32(reader["COD_PRODUTO"]);
                    textBoxNomeProduto.Text = reader["NOME_PRODUTO"].ToString();
                    textBoxSaldo.Text = reader["SALDO"].ToString();
                    textBoxEntradaSaida.Text = reader["ENTRADA_SAIDA"].ToString();
                    textBoxQuantidade.Text = reader["QUANTIDADE"].ToString();
                    textBoxPosicaoEstoque.Text = reader["POSICAO_ESTOQUE"].ToString(); ;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro : " + ex.Message);
            }
            finally
            {
                con.Close();

                if (ID > 0)
                {
                    BloquearDesbloquearCampos(true);
                }
            }
        }

        private void ExibirProdutos()
        {
            try
            {
                con.Open();

                DataTable dt = new DataTable();

                string sql = "SELECT COD_PRODUTO, NOME_PRODUTO, SALDO, ENTRADA_SAIDA, QUANTIDADE, POSICAO_ESTOQUE FROM Produto " +
                    "WHERE FATIVO = @FATIVO";

                SqlDataAdapter da = new SqlDataAdapter();

                da.SelectCommand = new SqlCommand(sql, con);

                da.SelectCommand.Parameters.Add("@FATIVO", SqlDbType.Bit).Value = 1;

                dt = new DataTable();

                da.Fill(dt);

                dataGridViewProduto.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro : " + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void LimparDados()
        {
            textBoxNomeProduto.Text =
            textBoxSaldo.Text =
            textBoxEntradaSaida.Text =
            textBoxQuantidade.Text =
            textBoxPosicaoEstoque.Text = "";
            textBoxNomeProduto.Focus();
        }

        private void DeletarProduto(string tipo)
        {
            try
            {
                string sql = string.Empty;

                if (tipo.Contains("botaoDeletar"))
                {
                    sql = "Update Produto set FATIVO=@FATIVO WHERE COD_PRODUTO=@COD_PRODUTO";
                }
                else
                {
                    sql = "Update Produto set FATIVO=@FATIVO WHERE SALDO=@SALDO";
                }

                cmd = new SqlCommand(sql, con);

                con.Open();

                if (tipo.Contains("botaoDeletar"))
                {
                    cmd.Parameters.AddWithValue("@COD_PRODUTO", ID);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@SALDO", 0);
                }

                cmd.Parameters.AddWithValue("@FATIVO", false);

                cmd.ExecuteNonQuery();

                Console.Write("registro deletado com sucesso...!");
            }
            catch (Exception ex)
            {
                Console.Write("Erro : " + ex.Message);
            }
            finally
            {
                con.Close();

                ExibirProdutos();

                LimparDados();

                BloquearDesbloquearCampos(false);
            }
        }

        private void BloquearDesbloquearCampos(bool tipoBool)
        {
            if (tipoBool)
            {
                textBoxNomeProduto.Enabled = false;
                textBoxSaldo.Enabled = false;
                textBoxEntradaSaida.Enabled = false;
                textBoxQuantidade.Enabled = false;
                textBoxPosicaoEstoque.Enabled = true;

                buttonSalvar.Enabled = false;
            }
            else
            {
                textBoxNomeProduto.Enabled = true;
                textBoxSaldo.Enabled = true;
                textBoxEntradaSaida.Enabled = true;
                textBoxQuantidade.Enabled = true;
                textBoxPosicaoEstoque.Enabled = true;

                buttonSalvar.Enabled = true;
            }
        }

        private void buttonNovo_Click(object sender, EventArgs e)
        {
            LimparDados();

            BloquearDesbloquearCampos(false);

        }

        private void buttonAtualizar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBoxNomeProduto.Text) && !string.IsNullOrEmpty(textBoxSaldo.Text)
                && !string.IsNullOrEmpty(textBoxEntradaSaida.Text) && !string.IsNullOrEmpty(textBoxQuantidade.Text)
                && !string.IsNullOrEmpty(textBoxPosicaoEstoque.Text))
            {
                try
                {
                    cmd = new SqlCommand(
                        "Update Produto set POSICAO_ESTOQUE = @POSICAO_ESTOQUE " +
                        "Where COD_PRODUTO = @COD_PRODUTO"
                        , con);

                    con.Open();

                    cmd.Parameters.AddWithValue("@COD_PRODUTO", ID);
                    cmd.Parameters.AddWithValue("@POSICAO_ESTOQUE", textBoxPosicaoEstoque.Text.ToUpper());

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Posição de estoque atualizada com sucesso...");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro : " + ex.Message);
                }
                finally
                {
                    con.Close();

                    ExibirProdutos();

                    LimparDados();
                }
            }
            else
            {
                MessageBox.Show("Informe todos os dados requeridos");
            }
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBoxNomeProduto.Text) && !string.IsNullOrEmpty(textBoxSaldo.Text)
                && !string.IsNullOrEmpty(textBoxEntradaSaida.Text) && !string.IsNullOrEmpty(textBoxQuantidade.Text)
                && !string.IsNullOrEmpty(textBoxPosicaoEstoque.Text))
            {
                try
                {
                    cmd = new SqlCommand(
                        "INSERT INTO Produto(NOME_PRODUTO,SALDO,ENTRADA_SAIDA,QUANTIDADE,POSICAO_ESTOQUE,FATIVO) " +
                        "VALUES(@NOME_PRODUTO,@SALDO,@ENTRADA_SAIDA,@QUANTIDADE,@POSICAO_ESTOQUE,@FATIVO)"
                        , con);

                    con.Open();

                    cmd.Parameters.AddWithValue("@NOME_PRODUTO", textBoxNomeProduto.Text.ToUpper());
                    cmd.Parameters.AddWithValue("@SALDO", textBoxSaldo.Text.ToUpper());
                    cmd.Parameters.AddWithValue("@ENTRADA_SAIDA", textBoxEntradaSaida.Text.ToUpper());
                    cmd.Parameters.AddWithValue("@QUANTIDADE", textBoxQuantidade.Text.ToUpper());
                    cmd.Parameters.AddWithValue("@POSICAO_ESTOQUE", textBoxPosicaoEstoque.Text.ToUpper());
                    cmd.Parameters.AddWithValue("@FATIVO", true);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Registro incluído com sucesso...");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro : " + ex.Message);
                }
                finally
                {
                    con.Close();

                    ExibirProdutos();

                    LimparDados();
                }
            }
            else
            {
                MessageBox.Show("Informe todos os dados requeridos");
            }
        }

        private void buttonDeletar_Click(object sender, EventArgs e)
        {
            if (ID != 0)
            {
                if (MessageBox.Show("Deseja Deletar este registro ?", "Produtos", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    DeletarProduto("botaoDeletar");
                }
            }
            else
            {
                MessageBox.Show("Selecione um registro para deletar");
            }
        }

        private void buttonSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridViewProduto_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                ID = Convert.ToInt32(dataGridViewProduto.Rows[e.RowIndex].Cells[0].Value.ToString());
                textBoxNomeProduto.Text = dataGridViewProduto.Rows[e.RowIndex].Cells[1].Value.ToString();
                textBoxSaldo.Text = dataGridViewProduto.Rows[e.RowIndex].Cells[2].Value.ToString();
                textBoxEntradaSaida.Text = dataGridViewProduto.Rows[e.RowIndex].Cells[3].Value.ToString();
                textBoxQuantidade.Text = dataGridViewProduto.Rows[e.RowIndex].Cells[4].Value.ToString();
                textBoxPosicaoEstoque.Text = dataGridViewProduto.Rows[e.RowIndex].Cells[5].Value.ToString();
                BloquearDesbloquearCampos(true);
            }
            catch { }
        }

        private void textBoxNomeProduto_Validated(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBoxNomeProduto.Text))
            {
                VerificaRegistro();
            }
        }

        private void buttonSaldo_Click(object sender, EventArgs e)
        {
            DeletarProduto("botaoSaldo");
        }
    }
}
