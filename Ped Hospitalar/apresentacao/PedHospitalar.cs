using System;
using System.Windows.Forms;
using Ped_Hospitalar.apresentacao;

namespace Ped_Hospitalar.apresentacao
{
    public partial class PedHospitalar : Form
    {
        public PedHospitalar()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            // Pode deixar vazio ou colocar algum comportamento adicional, se necessário.
        }

        // Botão CLIENTES
        private void button1_Click(object sender, EventArgs e)
        {
            // Exibe a tela de clientes
            ClienteWindow clientesForm = new ClienteWindow();
            clientesForm.Show();
            this.Hide(); // Opcional: Ocultar a tela principal
        }

        // Botão PRODUTOS
        private void button2_Click(object sender, EventArgs e)
        {
            // Exibe a tela de produtos, passando a referência da tela principal
            ProdutoWindow produtosForm = new ProdutoWindow(this);  // Passando a tela principal como parâmetro
            produtosForm.Show();
            this.Hide(); // Ocultar a tela principal
        }

        // Botão USUÁRIOS
        private void button4_Click(object sender, EventArgs e)
        {
            // Exibe a tela de usuários
            UsuarioWindow usuariosForm = new UsuarioWindow();
            usuariosForm.Show();
            this.Hide(); // Opcional: Ocultar a tela principal
        }

        // Botão SAIR
        private void button5_Click(object sender, EventArgs e)
        {
            // Fecha o aplicativo (logout ou saída)
            Application.Exit(); // Fecha o aplicativo
        }
    }
}
