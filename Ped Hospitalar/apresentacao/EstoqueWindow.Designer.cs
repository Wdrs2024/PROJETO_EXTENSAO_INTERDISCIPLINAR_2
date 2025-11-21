using System;

namespace Ped_Hospitalar.apresentacao
{
    partial class EstoqueWindow
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        private void InitializeComponent()
        {
            this.cbProdutos = new System.Windows.Forms.ComboBox();
            this.txtQuantidade = new System.Windows.Forms.TextBox();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.btnRemover = new System.Windows.Forms.Button();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.btnListar = new System.Windows.Forms.Button();
            this.dgEstoque = new System.Windows.Forms.DataGridView();
            this.IblProduto = new System.Windows.Forms.Label();
            this.IblQuantidade = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgEstoque)).BeginInit();
            this.SuspendLayout();
            // 
            // cbProdutos
            // 
            this.cbProdutos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbProdutos.FormattingEnabled = true;
            this.cbProdutos.Location = new System.Drawing.Point(108, 43);
            this.cbProdutos.Name = "cbProdutos";
            this.cbProdutos.Size = new System.Drawing.Size(200, 21);
            this.cbProdutos.TabIndex = 0;
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.Location = new System.Drawing.Point(108, 70);
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Size = new System.Drawing.Size(100, 20);
            this.txtQuantidade.TabIndex = 1;
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Location = new System.Drawing.Point(56, 113);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(75, 23);
            this.btnAdicionar.TabIndex = 2;
            this.btnAdicionar.Text = "ADICIONAR";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // btnRemover
            // 
            this.btnRemover.Location = new System.Drawing.Point(218, 113);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(75, 23);
            this.btnRemover.TabIndex = 3;
            this.btnRemover.Text = "REMOVER";
            this.btnRemover.UseVisualStyleBackColor = true;
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Location = new System.Drawing.Point(137, 113);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(75, 23);
            this.btnAtualizar.TabIndex = 4;
            this.btnAtualizar.Text = "ATUALIZAR";
            this.btnAtualizar.UseVisualStyleBackColor = true;
            // 
            // btnListar
            // 
            this.btnListar.Location = new System.Drawing.Point(299, 113);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(75, 23);
            this.btnListar.TabIndex = 5;
            this.btnListar.Text = "LISTAR";
            this.btnListar.UseVisualStyleBackColor = true;
            // 
            // dgEstoque
            // 
            this.dgEstoque.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgEstoque.Location = new System.Drawing.Point(12, 152);
            this.dgEstoque.Name = "dgEstoque";
            this.dgEstoque.Size = new System.Drawing.Size(476, 236);
            this.dgEstoque.TabIndex = 6;
            // 
            // IblProduto
            // 
            this.IblProduto.AutoSize = true;
            this.IblProduto.Location = new System.Drawing.Point(21, 46);
            this.IblProduto.Name = "IblProduto";
            this.IblProduto.Size = new System.Drawing.Size(64, 13);
            this.IblProduto.TabIndex = 7;
            this.IblProduto.Text = "PRODUTO:";
            // 
            // IblQuantidade
            // 
            this.IblQuantidade.AutoSize = true;
            this.IblQuantidade.Location = new System.Drawing.Point(21, 73);
            this.IblQuantidade.Name = "IblQuantidade";
            this.IblQuantidade.Size = new System.Drawing.Size(81, 13);
            this.IblQuantidade.TabIndex = 8;
            this.IblQuantidade.Text = "QUANTIDADE:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calisto MT", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(248, 31);
            this.label1.TabIndex = 9;
            this.label1.Text = "Controle de Estoque";
            // 
            // EstoqueWindow
            // 
            this.ClientSize = new System.Drawing.Size(500, 400);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.IblQuantidade);
            this.Controls.Add(this.IblProduto);
            this.Controls.Add(this.dgEstoque);
            this.Controls.Add(this.btnListar);
            this.Controls.Add(this.btnAtualizar);
            this.Controls.Add(this.btnRemover);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.txtQuantidade);
            this.Controls.Add(this.cbProdutos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "EstoqueWindow";
            this.Text = "Controle de Estoque";
            ((System.ComponentModel.ISupportInitialize)(this.dgEstoque)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbProdutos;
        private System.Windows.Forms.TextBox txtQuantidade;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.Button btnRemover;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.DataGridView dgEstoque;
        private System.Windows.Forms.Label IblProduto;
        private System.Windows.Forms.Label IblQuantidade;
        private System.Windows.Forms.Label label1;

        public EventHandler BtnAdicionar_Click { get; private set; }
        public EventHandler BtnRemover_Click { get; private set; }
        public EventHandler BtnListar_Click { get; private set; }
        public EventHandler BtnAtualizar_Click { get; private set; }
    }
}
