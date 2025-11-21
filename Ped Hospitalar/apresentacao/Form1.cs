using Ped_Hospitalar.apresentacao;
using Ped_Hospitalar.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ped_Hospitalar
{
    public partial class Form1 : Form
    {
        // Alterei o tipo para TextBox em vez de object
        public TextBox TxbLogin { get; private set; }
        public TextBox TxbSenha { get; private set; }
        public TextBox txbconfsenha { get; private set; } // Confirmei como TextBox também
        public CadastreSe cad { get; private set; }  // Alterei o tipo de 'object' para 'CadastreSe', que é o formulário que você está exibindo

        public Form1()
        {
            InitializeComponent();
            cad = new CadastreSe();  // Inicialize o formulário de cadastro
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            Modelo.Controle controle = new Controle();
            controle.acessar(txbLogin.Text, txbSenha.Text);

            if (controle.mensagem.Equals(""))
            {
                if (controle.tem)
                {
                    MessageBox.Show("Logado com sucesso", "Entrando", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    PedHospitalar bv = new PedHospitalar();
                    bv.Show();
                }
                else
                {
                    MessageBox.Show("Login não encontrado, verifique login e senha", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show(controle.mensagem);
            }
        }

        private void btnCadrastreSe_Click(object sender, EventArgs e)
        {
            CadastreSe cad = new CadastreSe(); // Cria nova instância do formulário de cadastro
            cad.ShowDialog(); // Abre o formulário de cadastro como janela modal
        }


        private void BtnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnEntrar_Click_1(object sender, EventArgs e)
        {
            // Adicionei esta função de "btnEntrar_Click_1" para garantir que a funcionalidade de login funcione corretamente.
        }
    }
}
