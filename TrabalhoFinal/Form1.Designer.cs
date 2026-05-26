namespace TrabalhoFinal
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnLimpar = new Button();
            btnExcluir = new Button();
            btnAtualizar = new Button();
            btnCadastrar = new Button();
            picBImagem = new PictureBox();
            lblImagem = new Label();
            btnSelecionarImagem = new Button();
            btnRemoverImagem = new Button();
            cblCategoria = new ComboBox();
            txtNomeProduto = new TextBox();
            txtCodigoProduto = new TextBox();
            txtQtdEstoque = new TextBox();
            txtPreco = new TextBox();
            lblPReco = new Label();
            lblQtdeEstoque = new Label();
            lblCategoria = new Label();
            lblNome = new Label();
            lblCodigo = new Label();
            dvgProdutos = new DataGridView();
            btnAtualizarT = new Button();
            btnCompras = new Button();
            btnProdutos = new Button();
            ((System.ComponentModel.ISupportInitialize)picBImagem).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dvgProdutos).BeginInit();
            SuspendLayout();
            // 
            // btnLimpar
            // 
            btnLimpar.BackColor = SystemColors.ActiveCaptionText;
            btnLimpar.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLimpar.ForeColor = SystemColors.ButtonHighlight;
            btnLimpar.Location = new Point(1139, 463);
            btnLimpar.Margin = new Padding(2);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(299, 64);
            btnLimpar.TabIndex = 18;
            btnLimpar.Text = " \U0001fa8c Limpar";
            btnLimpar.UseVisualStyleBackColor = false;
            btnLimpar.Click += btnLimpar_Click;
            // 
            // btnExcluir
            // 
            btnExcluir.BackColor = Color.MistyRose;
            btnExcluir.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExcluir.ForeColor = Color.DarkRed;
            btnExcluir.Location = new Point(831, 463);
            btnExcluir.Margin = new Padding(2);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(304, 64);
            btnExcluir.TabIndex = 17;
            btnExcluir.Text = "🗑️ Excluir";
            btnExcluir.UseVisualStyleBackColor = false;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // btnAtualizar
            // 
            btnAtualizar.BackColor = Color.LightSkyBlue;
            btnAtualizar.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAtualizar.ForeColor = Color.RoyalBlue;
            btnAtualizar.Location = new Point(554, 463);
            btnAtualizar.Margin = new Padding(2);
            btnAtualizar.Name = "btnAtualizar";
            btnAtualizar.Size = new Size(273, 64);
            btnAtualizar.TabIndex = 16;
            btnAtualizar.Text = "✏️ Atualizar";
            btnAtualizar.UseVisualStyleBackColor = false;
            btnAtualizar.Click += btnAtualizar_Click;
            // 
            // btnCadastrar
            // 
            btnCadastrar.BackColor = Color.LightGreen;
            btnCadastrar.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCadastrar.ForeColor = Color.ForestGreen;
            btnCadastrar.Location = new Point(293, 463);
            btnCadastrar.Margin = new Padding(2);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(257, 64);
            btnCadastrar.TabIndex = 15;
            btnCadastrar.Text = "+  Cadastrar";
            btnCadastrar.UseVisualStyleBackColor = false;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // picBImagem
            // 
            picBImagem.BackColor = Color.Transparent;
            picBImagem.Location = new Point(1105, 202);
            picBImagem.Margin = new Padding(2);
            picBImagem.Name = "picBImagem";
            picBImagem.Size = new Size(184, 141);
            picBImagem.SizeMode = PictureBoxSizeMode.StretchImage;
            picBImagem.TabIndex = 21;
            picBImagem.TabStop = false;
            // 
            // lblImagem
            // 
            lblImagem.AutoSize = true;
            lblImagem.BackColor = Color.Transparent;
            lblImagem.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblImagem.Location = new Point(1109, 166);
            lblImagem.Margin = new Padding(2, 0, 2, 0);
            lblImagem.Name = "lblImagem";
            lblImagem.Size = new Size(180, 25);
            lblImagem.TabIndex = 19;
            lblImagem.Text = "Imagem do Produto";
            // 
            // btnSelecionarImagem
            // 
            btnSelecionarImagem.BackColor = Color.PaleTurquoise;
            btnSelecionarImagem.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            btnSelecionarImagem.ForeColor = Color.Teal;
            btnSelecionarImagem.Location = new Point(1068, 358);
            btnSelecionarImagem.Margin = new Padding(2);
            btnSelecionarImagem.Name = "btnSelecionarImagem";
            btnSelecionarImagem.Size = new Size(140, 41);
            btnSelecionarImagem.TabIndex = 19;
            btnSelecionarImagem.Text = "Selecionar Imagem";
            btnSelecionarImagem.UseVisualStyleBackColor = false;
            btnSelecionarImagem.Click += btnSelecionarImagem_Click;
            // 
            // btnRemoverImagem
            // 
            btnRemoverImagem.BackColor = Color.PaleTurquoise;
            btnRemoverImagem.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            btnRemoverImagem.ForeColor = Color.Teal;
            btnRemoverImagem.Location = new Point(1212, 358);
            btnRemoverImagem.Margin = new Padding(2);
            btnRemoverImagem.Name = "btnRemoverImagem";
            btnRemoverImagem.Size = new Size(130, 41);
            btnRemoverImagem.TabIndex = 20;
            btnRemoverImagem.Text = "Remover Imagem";
            btnRemoverImagem.UseVisualStyleBackColor = false;
            btnRemoverImagem.Click += btnRemoverImagem_Click;
            // 
            // cblCategoria
            // 
            cblCategoria.FormattingEnabled = true;
            cblCategoria.Items.AddRange(new object[] { "Alimento", "Produto Limpeza", "Biscoito", "Carne", "Fruta", "Verduta" });
            cblCategoria.Location = new Point(421, 282);
            cblCategoria.Margin = new Padding(2);
            cblCategoria.Name = "cblCategoria";
            cblCategoria.Size = new Size(500, 28);
            cblCategoria.TabIndex = 14;
            // 
            // txtNomeProduto
            // 
            txtNomeProduto.Location = new Point(484, 223);
            txtNomeProduto.Margin = new Padding(2);
            txtNomeProduto.Multiline = true;
            txtNomeProduto.Name = "txtNomeProduto";
            txtNomeProduto.Size = new Size(437, 36);
            txtNomeProduto.TabIndex = 13;
            // 
            // txtCodigoProduto
            // 
            txtCodigoProduto.Location = new Point(484, 178);
            txtCodigoProduto.Margin = new Padding(2);
            txtCodigoProduto.Multiline = true;
            txtCodigoProduto.Name = "txtCodigoProduto";
            txtCodigoProduto.Size = new Size(437, 36);
            txtCodigoProduto.TabIndex = 12;
            // 
            // txtQtdEstoque
            // 
            txtQtdEstoque.Location = new Point(503, 321);
            txtQtdEstoque.Margin = new Padding(2);
            txtQtdEstoque.Multiline = true;
            txtQtdEstoque.Name = "txtQtdEstoque";
            txtQtdEstoque.Size = new Size(418, 31);
            txtQtdEstoque.TabIndex = 11;
            // 
            // txtPreco
            // 
            txtPreco.Location = new Point(421, 372);
            txtPreco.Margin = new Padding(2);
            txtPreco.Multiline = true;
            txtPreco.Name = "txtPreco";
            txtPreco.Size = new Size(500, 36);
            txtPreco.TabIndex = 10;
            // 
            // lblPReco
            // 
            lblPReco.AutoSize = true;
            lblPReco.BackColor = Color.Transparent;
            lblPReco.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            lblPReco.Location = new Point(309, 376);
            lblPReco.Margin = new Padding(2, 0, 2, 0);
            lblPReco.Name = "lblPReco";
            lblPReco.Size = new Size(90, 23);
            lblPReco.TabIndex = 6;
            lblPReco.Text = "Preço (R$)";
            // 
            // lblQtdeEstoque
            // 
            lblQtdeEstoque.AutoSize = true;
            lblQtdeEstoque.BackColor = Color.Transparent;
            lblQtdeEstoque.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            lblQtdeEstoque.Location = new Point(309, 329);
            lblQtdeEstoque.Margin = new Padding(2, 0, 2, 0);
            lblQtdeEstoque.Name = "lblQtdeEstoque";
            lblQtdeEstoque.Size = new Size(190, 23);
            lblQtdeEstoque.TabIndex = 5;
            lblQtdeEstoque.Text = "Quantidade de Estoque";
            // 
            // lblCategoria
            // 
            lblCategoria.AutoSize = true;
            lblCategoria.BackColor = Color.Transparent;
            lblCategoria.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            lblCategoria.Location = new Point(309, 282);
            lblCategoria.Margin = new Padding(2, 0, 2, 0);
            lblCategoria.Name = "lblCategoria";
            lblCategoria.Size = new Size(84, 23);
            lblCategoria.TabIndex = 4;
            lblCategoria.Text = "Categoria";
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.BackColor = Color.Transparent;
            lblNome.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            lblNome.Location = new Point(309, 236);
            lblNome.Margin = new Padding(2, 0, 2, 0);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(149, 23);
            lblNome.TabIndex = 3;
            lblNome.Text = "Nome do Produto";
            // 
            // lblCodigo
            // 
            lblCodigo.AutoSize = true;
            lblCodigo.BackColor = Color.Transparent;
            lblCodigo.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            lblCodigo.Location = new Point(309, 191);
            lblCodigo.Margin = new Padding(2, 0, 2, 0);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Size = new Size(157, 23);
            lblCodigo.TabIndex = 2;
            lblCodigo.Text = "Código do Produto";
            // 
            // dvgProdutos
            // 
            dvgProdutos.BackgroundColor = SystemColors.ButtonHighlight;
            dvgProdutos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dvgProdutos.Location = new Point(309, 603);
            dvgProdutos.Margin = new Padding(2);
            dvgProdutos.Name = "dvgProdutos";
            dvgProdutos.RowHeadersWidth = 62;
            dvgProdutos.Size = new Size(1129, 182);
            dvgProdutos.TabIndex = 0;
            dvgProdutos.CellContentClick += dvgProdutos_CellContentClick;
            // 
            // btnAtualizarT
            // 
            btnAtualizarT.BackColor = Color.PaleTurquoise;
            btnAtualizarT.ForeColor = Color.Teal;
            btnAtualizarT.Location = new Point(1305, 54);
            btnAtualizarT.Margin = new Padding(2);
            btnAtualizarT.Name = "btnAtualizarT";
            btnAtualizarT.Size = new Size(150, 43);
            btnAtualizarT.TabIndex = 20;
            btnAtualizarT.Text = "✏️ Atualizar";
            btnAtualizarT.UseVisualStyleBackColor = false;
            // 
            // btnCompras
            // 
            btnCompras.BackColor = Color.LavenderBlush;
            btnCompras.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCompras.ForeColor = Color.Black;
            btnCompras.Location = new Point(21, 312);
            btnCompras.Margin = new Padding(2);
            btnCompras.Name = "btnCompras";
            btnCompras.Size = new Size(223, 65);
            btnCompras.TabIndex = 21;
            btnCompras.Text = "Compras";
            btnCompras.UseVisualStyleBackColor = false;
            btnCompras.Click += btnCompras_Click;
            // 
            // btnProdutos
            // 
            btnProdutos.BackColor = Color.LightPink;
            btnProdutos.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnProdutos.ForeColor = Color.Black;
            btnProdutos.Location = new Point(21, 240);
            btnProdutos.Margin = new Padding(2);
            btnProdutos.Name = "btnProdutos";
            btnProdutos.Size = new Size(223, 65);
            btnProdutos.TabIndex = 39;
            btnProdutos.Text = "Produtos";
            btnProdutos.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.imagem_fundo_cadastro_1__1_;
            ClientSize = new Size(1482, 818);
            Controls.Add(btnProdutos);
            Controls.Add(dvgProdutos);
            Controls.Add(btnLimpar);
            Controls.Add(btnRemoverImagem);
            Controls.Add(btnExcluir);
            Controls.Add(btnSelecionarImagem);
            Controls.Add(btnAtualizar);
            Controls.Add(picBImagem);
            Controls.Add(btnCadastrar);
            Controls.Add(btnAtualizarT);
            Controls.Add(lblImagem);
            Controls.Add(btnCompras);
            Controls.Add(lblCodigo);
            Controls.Add(txtPreco);
            Controls.Add(txtQtdEstoque);
            Controls.Add(cblCategoria);
            Controls.Add(lblNome);
            Controls.Add(txtNomeProduto);
            Controls.Add(lblCategoria);
            Controls.Add(txtCodigoProduto);
            Controls.Add(lblQtdeEstoque);
            Controls.Add(lblPReco);
            Margin = new Padding(2);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)picBImagem).EndInit();
            ((System.ComponentModel.ISupportInitialize)dvgProdutos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtNomeProduto;
        private TextBox txtCodigoProduto;
        private TextBox txtQtdEstoque;
        private TextBox txtPreco;
        private Label lblPReco;
        private Label lblQtdeEstoque;
        private Label lblCategoria;
        private Label lblNome;
        private Label lblCodigo;
        private ComboBox cblCategoria;
        private Button btnLimpar;
        private Button btnExcluir;
        private Button btnAtualizar;
        private Button btnCadastrar;
        private Label lblImagem;
        private Button btnRemoverImagem;
        private Button btnSelecionarImagem;
        private PictureBox picBImagem;
        private DataGridView dvgProdutos;
        private Button btnAtualizarT;
        private Button btnCompras;
        private Button btnProdutos;
    }
}
