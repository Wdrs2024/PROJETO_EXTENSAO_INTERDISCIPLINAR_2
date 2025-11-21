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

namespace Ped_Hospitalar.apresentacao
{
    public partial class CadastreSe : Form
    {
        public CadastreSe()
        {
            InitializeComponent();
        }

        private void BtnCadastrar_Click(object sender, EventArgs e)
        {
            Controle controle = new Controle(); // Cria uma nova instância do controle
            // Chamando o método cadastrar através da instância do controle
            string mensagem = controle.cadastrar(txbLogin.Text, txbSenha.Text, confSenha.Text);

            // Exibindo a mensagem com base no sucesso ou falha do cadastro
            if (controle.tem)
            {
                MessageBox.Show(mensagem, "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(controle.mensagem, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Os métodos abaixo não estão sendo usados, você pode removê-los se não tiver necessidade.
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        // Esse método também não está sendo utilizado
        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
