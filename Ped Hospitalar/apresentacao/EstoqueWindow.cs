using System;
using System.Windows.Forms;

namespace Ped_Hospitalar.apresentacao
{
    public partial class EstoqueWindow : Form
    {
        public EstoqueWindow()
        {
            InitializeComponent();
        }

        // Método do evento BtnAdicionar_Click
        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            // Lógica para adicionar um produto no estoque
            MessageBox.Show("Produto adicionado ao estoque!");
        }

        // Método do evento BtnRemover_Click
        private void btnRemover_Click(object sender, EventArgs e)
        {
            // Lógica para remover um produto do estoque
            MessageBox.Show("Produto removido do estoque!");
        }

        // Método do evento BtnAtualizar_Click
        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            // Lógica para atualizar a quantidade de um produto no estoque
            MessageBox.Show("Estoque atualizado!");
        }

        // Método do evento BtnListar_Click
        private void btnListar_Click(object sender, EventArgs e)
        {
            // Lógica para listar os produtos no estoque
            MessageBox.Show("Produtos listados!");
        }
    }
}
