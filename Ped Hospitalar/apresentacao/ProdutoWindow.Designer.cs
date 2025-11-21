namespace Ped_Hospitalar.apresentacao
{
    partial class ProdutoWindow
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

        private void InitializeComponent()
        {
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.IblNome = new System.Windows.Forms.Label();
            this.IblDescricao = new System.Windows.Forms.Label();
            this.IblPreco = new System.Windows.Forms.Label();
            this.IblCusto = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtPreco = new System.Windows.Forms.TextBox();
            this.txtCusto = new System.Windows.Forms.TextBox();
            this.Banco = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descrição = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Preço = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Custo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textnome = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.Banco)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(97, 54);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(100, 20);
            this.txtNome.TabIndex = 0;
            // 
            // txtDescricao
            // 
            this.txtDescricao.Font = new System.Drawing.Font("Calisto MT", 20.25F);
            this.txtDescricao.Location = new System.Drawing.Point(261, 168);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(551, 39);
            this.txtDescricao.TabIndex = 1;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Font = new System.Drawing.Font("Calisto MT", 12F);
            this.btnSalvar.Location = new System.Drawing.Point(293, 379);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(146, 30);
            this.btnSalvar.TabIndex = 4;
            this.btnSalvar.Text = "SALVAR";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Font = new System.Drawing.Font("Calisto MT", 12F);
            this.btnAtualizar.Location = new System.Drawing.Point(460, 379);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(146, 30);
            this.btnAtualizar.TabIndex = 5;
            this.btnAtualizar.Text = "ATUALIZAR";
            this.btnAtualizar.UseVisualStyleBackColor = true;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Font = new System.Drawing.Font("Calisto MT", 12F);
            this.btnExcluir.Location = new System.Drawing.Point(624, 379);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(146, 30);
            this.btnExcluir.TabIndex = 6;
            this.btnExcluir.Text = "EXCLUIR";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // IblNome
            // 
            this.IblNome.AutoSize = true;
            this.IblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.IblNome.Location = new System.Drawing.Point(41, 103);
            this.IblNome.Name = "IblNome";
            this.IblNome.Size = new System.Drawing.Size(122, 37);
            this.IblNome.TabIndex = 9;
            this.IblNome.Text = "NOME:";
            // 
            // IblDescricao
            // 
            this.IblDescricao.AutoSize = true;
            this.IblDescricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.IblDescricao.Location = new System.Drawing.Point(41, 170);
            this.IblDescricao.Name = "IblDescricao";
            this.IblDescricao.Size = new System.Drawing.Size(214, 37);
            this.IblDescricao.TabIndex = 9;
            this.IblDescricao.Text = "DESCRIÇÃO:";
            // 
            // IblPreco
            // 
            this.IblPreco.AutoSize = true;
            this.IblPreco.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.IblPreco.Location = new System.Drawing.Point(41, 244);
            this.IblPreco.Name = "IblPreco";
            this.IblPreco.Size = new System.Drawing.Size(138, 37);
            this.IblPreco.TabIndex = 10;
            this.IblPreco.Text = "PREÇO:";
            // 
            // IblCusto
            // 
            this.IblCusto.AutoSize = true;
            this.IblCusto.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.IblCusto.Location = new System.Drawing.Point(41, 316);
            this.IblCusto.Name = "IblCusto";
            this.IblCusto.Size = new System.Drawing.Size(138, 37);
            this.IblCusto.TabIndex = 11;
            this.IblCusto.Text = "CUSTO:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calisto MT", 36F);
            this.label1.Location = new System.Drawing.Point(22, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(463, 55);
            this.label1.TabIndex = 12;
            this.label1.Text = "Cadastro de Produtos";
            // 
            // txtId
            // 
            this.txtId.Font = new System.Drawing.Font("Calisto MT", 14.25F);
            this.txtId.Location = new System.Drawing.Point(965, 97);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(41, 29);
            this.txtId.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calisto MT", 15.75F);
            this.label2.Location = new System.Drawing.Point(971, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 24);
            this.label2.TabIndex = 15;
            this.label2.Text = "ID";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Font = new System.Drawing.Font("Calisto MT", 12F);
            this.btnBuscar.Location = new System.Drawing.Point(1024, 85);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 32);
            this.btnBuscar.TabIndex = 16;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtPreco
            // 
            this.txtPreco.Font = new System.Drawing.Font("Calisto MT", 20.25F);
            this.txtPreco.Location = new System.Drawing.Point(261, 245);
            this.txtPreco.Name = "txtPreco";
            this.txtPreco.Size = new System.Drawing.Size(551, 39);
            this.txtPreco.TabIndex = 2;
            // 
            // txtCusto
            // 
            this.txtCusto.Font = new System.Drawing.Font("Calisto MT", 20.25F);
            this.txtCusto.Location = new System.Drawing.Point(261, 317);
            this.txtCusto.Name = "txtCusto";
            this.txtCusto.Size = new System.Drawing.Size(551, 39);
            this.txtCusto.TabIndex = 3;
            // 
            // Banco
            // 
            this.Banco.AllowUserToOrderColumns = true;
            this.Banco.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Banco.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Banco.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Banco.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Nome,
            this.Descrição,
            this.Preço,
            this.Custo});
            this.Banco.Location = new System.Drawing.Point(189, 448);
            this.Banco.Name = "Banco";
            this.Banco.Size = new System.Drawing.Size(946, 271);
            this.Banco.TabIndex = 18;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            // 
            // Nome
            // 
            this.Nome.HeaderText = "Nome";
            this.Nome.Name = "Nome";
            this.Nome.Width = 250;
            // 
            // Descrição
            // 
            this.Descrição.HeaderText = "Descrição";
            this.Descrição.Name = "Descrição";
            this.Descrição.Width = 250;
            // 
            // Preço
            // 
            this.Preço.HeaderText = "Preço";
            this.Preço.Name = "Preço";
            this.Preço.Width = 150;
            // 
            // Custo
            // 
            this.Custo.HeaderText = "Custo";
            this.Custo.Name = "Custo";
            this.Custo.Width = 150;
            // 
            // textnome
            // 
            this.textnome.Font = new System.Drawing.Font("Calisto MT", 20.25F);
            this.textnome.Location = new System.Drawing.Point(261, 101);
            this.textnome.Name = "textnome";
            this.textnome.Size = new System.Drawing.Size(551, 39);
            this.textnome.TabIndex = 19;
            this.textnome.TextChanged += new System.EventHandler(this.textnome_TextChanged);
            // 
            // ProdutoWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.Color.LightGreen;
            this.ClientSize = new System.Drawing.Size(1145, 729);
            this.Controls.Add(this.textnome);
            this.Controls.Add(this.Banco);
            this.Controls.Add(this.txtPreco);
            this.Controls.Add(this.txtCusto);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.IblCusto);
            this.Controls.Add(this.IblPreco);
            this.Controls.Add(this.IblDescricao);
            this.Controls.Add(this.IblNome);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnAtualizar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.txtId);
            this.MaximumSize = new System.Drawing.Size(1920, 768);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "ProdutoWindow";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Text = "Cadastro de Produtos";
            ((System.ComponentModel.ISupportInitialize)(this.Banco)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Label IblNome;
        private System.Windows.Forms.Label IblDescricao;
        private System.Windows.Forms.Label IblPreco;
        private System.Windows.Forms.Label IblCusto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtPreco;
        private System.Windows.Forms.TextBox txtCusto;
        private System.Windows.Forms.DataGridView Banco;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descrição;
        private System.Windows.Forms.DataGridViewTextBoxColumn Preço;
        private System.Windows.Forms.DataGridViewTextBoxColumn Custo;
        private System.Windows.Forms.TextBox textnome;
    }
}
