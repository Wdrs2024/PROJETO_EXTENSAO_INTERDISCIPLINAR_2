using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Ped_Hospitalar.apresentacao
{
    public partial class ProdutoWindow : Form
    {
        private Form telaPrincipal;  // Referência à tela principal
        private string connectionString = "Server=localhost;Database=ped_hospitalar;Uid=root;Pwd=123456";

        // Construtor modificado para aceitar a tela principal como parâmetro
        public ProdutoWindow(Form principal)
        {
            InitializeComponent();
            this.telaPrincipal = principal;
            this.FormClosing += ProdutoWindow_FormClosing;  // Registra o evento de fechamento
        }

        private MySqlConnection GetConnection()
        {
            return new MySqlConnection(connectionString);
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            string nome = textnome.Text;
            string descricao = txtDescricao.Text;
            decimal preco = Convert.ToDecimal(txtPreco.Text);
            decimal custo = Convert.ToDecimal(txtCusto.Text);

            string query = "INSERT INTO produtos (nome, descricao, preco, custo) VALUES (@Nome, @Descricao, @Preco, @Custo)";

            using (MySqlConnection conn = GetConnection())
            {
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Nome", nome);
                cmd.Parameters.AddWithValue("@Descricao", descricao);
                cmd.Parameters.AddWithValue("@Preco", preco);
                cmd.Parameters.AddWithValue("@Custo", custo);

                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Produto cadastrado com sucesso!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao salvar: " + ex.Message);
                }
            }
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtId.Text) || !int.TryParse(txtId.Text.Trim(), out int idProduto))
            {
                MessageBox.Show("Por favor, forneça um ID válido.");
                return;
            }

            string nome = textnome.Text;
            string descricao = txtDescricao.Text;
            decimal preco = Convert.ToDecimal(txtPreco.Text);
            decimal custo = Convert.ToDecimal(txtCusto.Text);

            string query = "UPDATE produtos SET nome=@Nome, descricao=@Descricao, preco=@Preco, custo=@Custo WHERE id=@Id";

            using (MySqlConnection conn = GetConnection())
            {
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Nome", nome);
                cmd.Parameters.AddWithValue("@Descricao", descricao);
                cmd.Parameters.AddWithValue("@Preco", preco);
                cmd.Parameters.AddWithValue("@Custo", custo);
                cmd.Parameters.AddWithValue("@Id", idProduto);

                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Produto atualizado com sucesso!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao atualizar: " + ex.Message);
                }
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtId.Text) || !int.TryParse(txtId.Text.Trim(), out int idProduto))
            {
                MessageBox.Show("Por favor, forneça um ID válido.");
                return;
            }

            string query = "DELETE FROM produtos WHERE id = @Id";

            using (MySqlConnection conn = GetConnection())
            {
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Id", idProduto);

                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Produto excluído com sucesso!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao excluir: " + ex.Message);
                }
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtId.Text) || !int.TryParse(txtId.Text.Trim(), out int idProduto))
            {
                MessageBox.Show("Por favor, forneça um ID válido.");
                return;
            }

            string query = "SELECT nome, descricao, preco, custo FROM produtos WHERE id = @Id";

            using (MySqlConnection conn = GetConnection())
            {
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Id", idProduto);

                try
                {
                    conn.Open();
                    MySqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        textnome.Text = reader["nome"].ToString();
                        txtDescricao.Text = reader["descricao"].ToString();
                        txtPreco.Text = reader["preco"].ToString();
                        txtCusto.Text = reader["custo"].ToString();
                    }
                    else
                    {
                        MessageBox.Show("Produto não encontrado.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao buscar: " + ex.Message);
                }
            }
        }

        // Evento de fechamento para exibir a tela principal novamente
        private void ProdutoWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                this.telaPrincipal.Show();  // Exibe a tela principal quando o ProdutoWindow for fechado
            }
        }

        private void textnome_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
