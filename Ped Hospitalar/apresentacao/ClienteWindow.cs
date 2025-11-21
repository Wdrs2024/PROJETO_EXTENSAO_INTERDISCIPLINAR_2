using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Ped_Hospitalar.apresentacao
{
    public partial class ClienteWindow : Form
    {
        private string connectionString = "Server=localhost;Database=ped_hospitalar;Uid=root;Pwd=123456"; // Atualize conforme necessário

        public ClienteWindow()
        {
            InitializeComponent();
        }

        // Método para conectar ao banco de dados
        private MySqlConnection GetConnection()
        {
            return new MySqlConnection(connectionString);
        }

        // Botão Salvar - Adiciona um novo cliente ao banco de dados
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            string nome = txtNome.Text;
            string endereco = txtEndereco.Text;
            string telefone = txtTelefone.Text;
            string email = txtEmail.Text;

            string query = "INSERT INTO clientes (Nome, Endereco, Telefone, Email) VALUES (@Nome, @Endereco, @Telefone, @Email)";

            using (MySqlConnection conn = GetConnection())
            {
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Nome", nome);
                cmd.Parameters.AddWithValue("@Endereco", endereco);
                cmd.Parameters.AddWithValue("@Telefone", telefone);
                cmd.Parameters.AddWithValue("@Email", email);

                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Cliente cadastrado com sucesso!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao salvar: " + ex.Message);
                }
            }
        }

        // Botão Atualizar - Atualiza um cliente existente no banco de dados
        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            string nome = txtNome.Text;
            string endereco = txtEndereco.Text;
            string telefone = txtTelefone.Text;
            string email = txtEmail.Text;

            if (string.IsNullOrWhiteSpace(txtId.Text) || !int.TryParse(txtId.Text.Trim(), out int idCliente))
            {
                MessageBox.Show("Por favor, forneça um ID válido.");
                return;
            }

            string query = "UPDATE clientes SET Nome = @Nome, Endereco = @Endereco, Telefone = @Telefone, Email = @Email WHERE Id = @Id";

            using (MySqlConnection conn = GetConnection())
            {
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Nome", nome);
                cmd.Parameters.AddWithValue("@Endereco", endereco);
                cmd.Parameters.AddWithValue("@Telefone", telefone);
                cmd.Parameters.AddWithValue("@Email", email);
                cmd.Parameters.AddWithValue("@Id", idCliente);

                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Cliente atualizado com sucesso!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao atualizar: " + ex.Message);
                }
            }
        }

        // Botão Excluir - Exclui um cliente do banco de dados
        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtId.Text) || !int.TryParse(txtId.Text.Trim(), out int idCliente))
            {
                MessageBox.Show("Por favor, forneça um ID válido.");
                return;
            }

            string query = "DELETE FROM clientes WHERE Id = @Id";

            using (MySqlConnection conn = GetConnection())
            {
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Id", idCliente);

                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Cliente excluído com sucesso!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao excluir: " + ex.Message);
                }
            }
        }

        // Botão Listar - Exibe todos os clientes cadastrados
       

        // Botão Buscar - Realiza a busca do cliente no banco de dados
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM clientes WHERE Id = @Id";
            int idCliente;

            if (string.IsNullOrWhiteSpace(txtId.Text) || !int.TryParse(txtId.Text, out idCliente))
            {
                MessageBox.Show("Por favor, forneça um ID válido.");
                return;
            }

            using (MySqlConnection conn = GetConnection())
            {
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Id", idCliente);

                try
                {
                    conn.Open();
                    MySqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        // Preenche os campos do formulário com os dados encontrados
                        txtNome.Text = reader["Nome"].ToString();
                        txtEndereco.Text = reader["Endereco"].ToString();
                        txtTelefone.Text = reader["Telefone"].ToString();
                        txtEmail.Text = reader["Email"].ToString();
                    }
                    else
                    {
                        MessageBox.Show("Cliente não encontrado.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao buscar: " + ex.Message);
                }
            }
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);

            PedHospitalar pedHospitalarForm = new PedHospitalar();
            pedHospitalarForm.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
