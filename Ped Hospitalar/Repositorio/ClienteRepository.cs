using Ped_Hospitalar.Modelo;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Ped_Hospitalar.Repositorio
{
    public class ClienteRepository
    {
        private string connectionString = "sua string de conexão";

        public void Inserir(Cliente cliente)
        {
            using (var conn = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO Clientes (Nome, Endereco, Telefone, Email) VALUES (@Nome, @Endereco, @Telefone, @Email)";
                using (var cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Nome", cliente.Nome);
                    cmd.Parameters.AddWithValue("@Endereco", cliente.Endereco);
                    cmd.Parameters.AddWithValue("@Telefone", cliente.Telefone);
                    cmd.Parameters.AddWithValue("@Email", cliente.Email);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void Atualizar(Cliente cliente)
        {
            using (var conn = new SqlConnection(connectionString))
            {
                string query = "UPDATE Clientes SET Nome = @Nome, Endereco = @Endereco, Telefone = @Telefone, Email = @Email WHERE Id = @Id";
                using (var cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Nome", cliente.Nome);
                    cmd.Parameters.AddWithValue("@Endereco", cliente.Endereco);
                    cmd.Parameters.AddWithValue("@Telefone", cliente.Telefone);
                    cmd.Parameters.AddWithValue("@Email", cliente.Email);
                    cmd.Parameters.AddWithValue("@Id", cliente.Id);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void Excluir(int clienteId)
        {
            using (var conn = new SqlConnection(connectionString))
            {
                string query = "DELETE FROM Clientes WHERE Id = @Id";
                using (var cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Id", clienteId);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public List<Cliente> ListarTodos()
        {
            List<Cliente> clientes = new List<Cliente>();

            using (var conn = new SqlConnection(connectionString))
            {
                string query = "SELECT Id, Nome, Endereco, Telefone, Email FROM Clientes";
                using (var cmd = new SqlCommand(query, conn))
                {
                    conn.Open();
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            clientes.Add(new Cliente
                            {
                                Id = reader.GetInt32(0),
                                Nome = reader.GetString(1),
                                Endereco = reader.GetString(2),
                                Telefone = reader.GetString(3),
                                Email = reader.GetString(4)
                            });
                        }
                    }
                }
            }

            return clientes;
        }
    }
}
