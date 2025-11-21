using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace Ped_Hospitalar.apresentacao
{
    public partial class UsuarioWindow : Form
    {
        private string connectionString = "Server=localhost;Database=ped_hospitalar;Uid=root;Pwd=123456;";

        public UsuarioWindow()
        {
            InitializeComponent();
            this.FormClosing += new FormClosingEventHandler(this.GerenciamentoDeUsuarios_FormClosing);

            // Atachando explicitamente (seguro mesmo se o Designer estiver apontando para outro handler)
            this.dgUsuarios.CellContentClick -= dataGridView1_CellContentClick; // garante não duplicar
            this.dgUsuarios.CellContentClick += dataGridView1_CellContentClick;

            button2.Click += BuscarUsuario;  // Buscar
            button1.Click += ExcluirUsuario; // Excluir
        }

        private void UsuarioWindow_Load(object sender, EventArgs e)
        {
            CarregarUsuarios();

            // Definindo placeholders
            SetPlaceholder(textBox1, "Login");
            SetPlaceholder(textBox2, "senha", isPassword: true);
            SetPlaceholder(textBox3, "id");
        }

        // Método auxiliar para aplicar placeholder
        private void SetPlaceholder(TextBox textBox, string placeholder, bool isPassword = false)
        {
            textBox.ForeColor = System.Drawing.Color.Red;
            textBox.Text = placeholder;

            textBox.GotFocus += (s, e) =>
            {
                if (textBox.Text == placeholder)
                {
                    textBox.Text = "";
                    textBox.ForeColor = System.Drawing.Color.Black;

                    // Se for senha, ativa o password char
                    if (isPassword)
                        textBox.UseSystemPasswordChar = true;
                }
            };

            textBox.LostFocus += (s, e) =>
            {
                if (string.IsNullOrWhiteSpace(textBox.Text))
                {
                    textBox.UseSystemPasswordChar = false; // volta ao normal se vazio
                    textBox.Text = placeholder;
                    textBox.ForeColor = System.Drawing.Color.Red;
                }
            };
        }

        private void CarregarUsuarios()
        {
            string query = "SELECT id, login, senha FROM usuarios";
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                    DataTable tabela = new DataTable();
                    adapter.Fill(tabela);
                    dgUsuarios.DataSource = tabela;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao carregar usuários: " + ex.Message);
                }
            }
        }

        private void BuscarUsuario(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox3.Text) || textBox3.Text == "id")
            {
                MessageBox.Show("Digite um ID para buscar.");
                return;
            }

            string query = "SELECT login, senha FROM usuarios WHERE id = @id";
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@id", textBox3.Text);
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            textBox1.Text = reader["login"].ToString();
                            textBox1.ForeColor = System.Drawing.Color.Black;

                            textBox2.UseSystemPasswordChar = true;
                            textBox2.Text = reader["senha"].ToString();
                            textBox2.ForeColor = System.Drawing.Color.Black;
                        }
                        else
                        {
                            MessageBox.Show("Usuário não encontrado.");
                            ResetPlaceholders();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao buscar usuário: " + ex.Message);
                }
            }
        }

        private void ExcluirUsuario(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox3.Text) || textBox3.Text == "id")
            {
                MessageBox.Show("Digite um ID para excluir.");
                return;
            }

            string query = "DELETE FROM usuarios WHERE id = @id";
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@id", textBox3.Text);
                    int rows = cmd.ExecuteNonQuery();
                    if (rows > 0)
                    {
                        MessageBox.Show("Usuário excluído com sucesso.");
                        CarregarUsuarios();
                        ResetPlaceholders();
                    }
                    else
                    {
                        MessageBox.Show("Usuário não encontrado.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao excluir usuário: " + ex.Message);
                }
            }
        }

        private void ResetPlaceholders()
        {
            SetPlaceholder(textBox1, "Login");
            SetPlaceholder(textBox2, "senha", isPassword: true);
            SetPlaceholder(textBox3, "id");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            DataGridViewRow row = dgUsuarios.Rows[e.RowIndex];
            textBox3.Text = row.Cells[0].Value?.ToString();
            textBox3.ForeColor = System.Drawing.Color.Black;

            textBox1.Text = row.Cells[1].Value?.ToString();
            textBox1.ForeColor = System.Drawing.Color.Black;

            textBox2.UseSystemPasswordChar = true;
            textBox2.Text = row.Cells[2].Value?.ToString();
            textBox2.ForeColor = System.Drawing.Color.Black;
        }

        private void GerenciamentoDeUsuarios_FormClosing(object sender, FormClosingEventArgs e)
        {
            PedHospitalar telaPrincipal = new PedHospitalar();
            telaPrincipal.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
