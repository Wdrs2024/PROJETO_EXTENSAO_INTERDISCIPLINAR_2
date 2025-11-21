using Ped_Hospitalar.Conexao;
using System;
using System.Windows.Forms;

namespace Ped_Hospitalar.Modelo
{
    public class Controle
    {
        public bool tem;
        public string mensagem = "";

        public bool acessar(string login, string senha)
        {
            LoginComandos loginPed = new LoginComandos();
            tem = loginPed.verificarLogin(login, senha);

            // Se houve mensagem de erro vinda do banco
            if (!string.IsNullOrEmpty(loginPed.mensagem))
            {
                this.mensagem = loginPed.mensagem;
            }

            return tem;
        }

        public string cadastrar(string email, string senha, string confSenha)
        {
            LoginComandos loginPed = new LoginComandos();
            this.mensagem = loginPed.cadastrar(email, senha, confSenha);

            if (loginPed.tem) // cadastro realizado com sucesso
            {
                this.tem = true;
            }

            return this.mensagem;
        }

        internal void acessar(TextBox txbLogin, TextBox txbSenha, TextBox txbconfsenha)
        {
            throw new NotImplementedException();
        }

        internal void cadastrar(string text1, string text2, object text3)
        {
            throw new NotImplementedException();
        }
    }
}
