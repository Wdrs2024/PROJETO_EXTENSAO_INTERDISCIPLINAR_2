using MySql.Data.MySqlClient;
using System;

namespace Ped_Hospitalar.Conexao
{
    class LoginComandos
    {
        public bool tem = false;
        public string mensagem = "";
        MySqlCommand cmd = new MySqlCommand();

        public bool verificarLogin(string login, string senha)
        {
            cmd.CommandText = "SELECT * FROM usuarios WHERE Login = @login AND Senha = @senha";
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@login", login);
            cmd.Parameters.AddWithValue("@senha", senha);

            Conexao con = new Conexao();

            try
            {
                cmd.Connection = con.Conectar();
                using (MySqlDataReader dr = cmd.ExecuteReader())
                {
                    tem = dr.HasRows;
                }
            }
            catch (MySqlException)
            {
                this.mensagem = "Erro com Banco de Dados";
            }
            finally
            {
                con.Desconectar();
            }

            return tem;
        }

        public string cadastrar(string email, string senha, string confSenha)
        {
            if (senha.Equals(confSenha))
            {
                cmd.CommandText = "INSERT INTO ped_hospitalar.usuarios (Login, Senha) VALUES (@e, @s)";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@e", email);
                cmd.Parameters.AddWithValue("@s", senha);

                Conexao con = new Conexao();

                try
                {
                    cmd.Connection = con.Conectar();
                    cmd.ExecuteNonQuery();
                    this.mensagem = "Cadastrado com sucesso!";
                }
                catch (MySqlException)
                {
                    this.mensagem = "Erro com Banco de Dados ao cadastrar.";
                }
                finally
                {
                    con.Desconectar();
                }
            }
            else
            {
                this.mensagem = "As senhas não correspondem.";
            }

            return mensagem;
        }
    }
}
