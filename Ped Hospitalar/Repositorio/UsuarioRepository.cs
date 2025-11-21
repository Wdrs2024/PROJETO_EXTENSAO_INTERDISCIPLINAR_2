using MySql.Data.MySqlClient;
using Ped_Hospitalar.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ped_Hospitalar.Repositorio
{
    public class UsuarioRepository
    {
        // LOGIN → retorna o usuário autenticado (ou null)
        public Usuario Login(string username, string senha)
        {
            
            {
                var cmd = new MySqlCommand("SELECT * FROM usuarios WHERE username = @username AND senha = @senha");
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@senha", senha);

                var reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    return new Usuario
                    {
                        Id = reader.GetInt32("id"),
                        Nome = reader.GetString("username"),
                        Login = reader.GetString("username"),
                        Senha = reader.GetString("senha"),
                        Perfil = "" // ajuste se houver a coluna 'perfil' no banco
                    };
                }
            }

            return null;
        }

        // VALIDA LOGIN → retorna true se login existir com senha correta
        public bool ValidarLogin(string username, string senha)
        {
            
            {
                var cmd = new MySqlCommand("SELECT COUNT(*) FROM usuarios WHERE username = @username AND senha = @senha");
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@senha", senha);

                var count = Convert.ToInt32(cmd.ExecuteScalar());
                return count > 0;
            }
        }

        // ADICIONAR NOVO USUÁRIO
        public void Adicionar(Usuario usuario)
        {
            
            {
                var cmd = new MySqlCommand("INSERT INTO usuarios (username, senha) VALUES (@username, @senha)");
                cmd.Parameters.AddWithValue("@username", usuario.Login);
                cmd.Parameters.AddWithValue("@senha", usuario.Senha);
                cmd.ExecuteNonQuery();
            }
        }

        // ATUALIZAR USUÁRIO EXISTENTE
        public void Atualizar(Usuario usuario)
        {
            
            {
                var cmd = new MySqlCommand("UPDATE usuarios SET username = @username, senha = @senha WHERE id = @id");
                cmd.Parameters.AddWithValue("@username", usuario.Login);
                cmd.Parameters.AddWithValue("@senha", usuario.Senha);
                cmd.Parameters.AddWithValue("@id", usuario.Id);
                cmd.ExecuteNonQuery();
            }
        }

        // EXCLUIR USUÁRIO POR ID
        public void Excluir(int id)
        {
            
            {
                var cmd = new MySqlCommand("DELETE FROM usuarios WHERE id = @id");
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
            }
        }

        // LISTAR TODOS OS USUÁRIOS
        public List<Usuario> ListarTodos()
        {
            var lista = new List<Usuario>();

            
            {
                var cmd = new MySqlCommand("SELECT * FROM usuarios");
                var reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    lista.Add(new Usuario
                    {
                        Id = reader.GetInt32("id"),
                        Nome = reader.GetString("username"),
                        Login = reader.GetString("username"),
                        Senha = reader.GetString("senha"),
                        Perfil = "" // ajuste se houver coluna 'perfil'
                    });
                }
            }

            return lista;
        }
    }
}
