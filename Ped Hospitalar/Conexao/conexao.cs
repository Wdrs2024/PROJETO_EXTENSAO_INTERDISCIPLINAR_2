using MySql.Data.MySqlClient;

namespace Ped_Hospitalar.Conexao
{
    public class Conexao
    {
        MySqlConnection con = new MySqlConnection();

        public Conexao()
        {
            // Ajuste a porta (default 3306) se for diferente
            con.ConnectionString = "server=localhost;database=ped_hospitalar;user=root;password=123456;";
        }

        public MySqlConnection Conectar()
        {
            if (con.State == System.Data.ConnectionState.Closed)
            {
                con.Open();
            }
            return con;
        }

        public void Desconectar()
        {
            if (con.State == System.Data.ConnectionState.Open)
            {
                con.Close();
            }
        }
    }
}
