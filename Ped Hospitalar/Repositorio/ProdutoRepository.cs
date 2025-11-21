using MySql.Data.MySqlClient;
using Ped_Hospitalar.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ped_Hospitalar.Repositorio
{
    public class ProdutoRepository
    {
        public void Inserir(Produto produto)
        {
            
            {
                var cmd = new MySqlCommand("INSERT INTO produtos (nome, descricao, preco) VALUES (@nome, @descricao, @preco)");
                cmd.Parameters.AddWithValue("@nome", produto.Nome);
                cmd.Parameters.AddWithValue("@descricao", produto.Descricao);
                cmd.Parameters.AddWithValue("@preco", produto.Preco);
                cmd.ExecuteNonQuery();
            }
        }

        public List<Produto> ListarTodos()
        {
            var lista = new List<Produto>();
            
            {
                var cmd = new MySqlCommand("SELECT * FROM produtos");
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    lista.Add(new Produto
                    {
                        Id = reader.GetInt32("id"),
                        Nome = reader.GetString("nome"),
                        Descricao = reader.GetString("descricao"),
                        Preco = reader.GetDecimal("preco")
                    });
                }
            }
            return lista;
        }

        public void Atualizar(Produto produto)
        {
            
            {
                var cmd = new MySqlCommand("UPDATE produtos SET nome=@nome, descricao=@descricao, preco=@preco WHERE id=@id");
                cmd.Parameters.AddWithValue("@id", produto.Id);
                cmd.Parameters.AddWithValue("@nome", produto.Nome);
                cmd.Parameters.AddWithValue("@descricao", produto.Descricao);
                cmd.Parameters.AddWithValue("@preco", produto.Preco);
                cmd.ExecuteNonQuery();
            }
        }

        public void Excluir(int id)
        {
            
            {
                var cmd = new MySqlCommand("DELETE FROM produtos WHERE id=@id");
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
            }
        }
    }
}
