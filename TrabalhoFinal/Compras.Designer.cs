namespace TrabalhoFinal
{
    partial class Compras
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dvgProdutos = new DataGridView();
            lblQuantidade = new Label();
            lblProduto = new Label();
            cmbProdutos = new ComboBox();
            dvgCarrinho = new DataGridView();
            lblSubtotalTitulo = new Label();
            lblDesconto = new Label();
            lblTotalTitulo = new Label();
            btnFinalizar = new Button();
            txtDesconto = new TextBox();
            txtQuantidade = new TextBox();
            btnAdicionar = new Button();
            lblSubtotal = new Label();
            lblTotal = new Label();
            btnCompras = new Button();
            btnProdutos = new Button();
            ((System.ComponentModel.ISupportInitialize)dvgProdutos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dvgCarrinho).BeginInit();
            SuspendLayout();
            // 
            // dvgProdutos
            // 
            dvgProdutos.BackgroundColor = SystemColors.ButtonHighlight;
            dvgProdutos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dvgProdutos.Location = new Point(291, 183);
            dvgProdutos.Margin = new Padding(2);
            dvgProdutos.Name = "dvgProdutos";
            dvgProdutos.RowHeadersWidth = 62;
            dvgProdutos.Size = new Size(557, 613);
            dvgProdutos.TabIndex = 25;
            // 
            // lblQuantidade
            // 
            lblQuantidade.AutoSize = true;
            lblQuantidade.BackColor = Color.Transparent;
            lblQuantidade.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            lblQuantidade.Location = new Point(902, 679);
            lblQuantidade.Margin = new Padding(2, 0, 2, 0);
            lblQuantidade.Name = "lblQuantidade";
            lblQuantidade.Size = new Size(110, 25);
            lblQuantidade.TabIndex = 26;
            lblQuantidade.Text = "Quantidade";
            // 
            // lblProduto
            // 
            lblProduto.AutoSize = true;
            lblProduto.BackColor = Color.Transparent;
            lblProduto.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            lblProduto.Location = new Point(902, 598);
            lblProduto.Margin = new Padding(2, 0, 2, 0);
            lblProduto.Name = "lblProduto";
            lblProduto.Size = new Size(81, 25);
            lblProduto.TabIndex = 24;
            lblProduto.Text = "Produto";
            // 
            // cmbProdutos
            // 
            cmbProdutos.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbProdutos.FormattingEnabled = true;
            cmbProdutos.Location = new Point(902, 636);
            cmbProdutos.Margin = new Padding(2);
            cmbProdutos.Name = "cmbProdutos";
            cmbProdutos.Size = new Size(522, 31);
            cmbProdutos.TabIndex = 25;
            cmbProdutos.Text = "Todas os Produtos";
            // 
            // dvgCarrinho
            // 
            dvgCarrinho.BackgroundColor = SystemColors.ButtonHighlight;
            dvgCarrinho.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dvgCarrinho.Location = new Point(902, 190);
            dvgCarrinho.Margin = new Padding(2);
            dvgCarrinho.Name = "dvgCarrinho";
            dvgCarrinho.RowHeadersWidth = 62;
            dvgCarrinho.Size = new Size(522, 205);
            dvgCarrinho.TabIndex = 27;
            // 
            // lblSubtotalTitulo
            // 
            lblSubtotalTitulo.AutoSize = true;
            lblSubtotalTitulo.BackColor = Color.Transparent;
            lblSubtotalTitulo.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            lblSubtotalTitulo.Location = new Point(902, 406);
            lblSubtotalTitulo.Margin = new Padding(2, 0, 2, 0);
            lblSubtotalTitulo.Name = "lblSubtotalTitulo";
            lblSubtotalTitulo.Size = new Size(83, 25);
            lblSubtotalTitulo.TabIndex = 28;
            lblSubtotalTitulo.Text = "Subtotal";
            // 
            // lblDesconto
            // 
            lblDesconto.AutoSize = true;
            lblDesconto.BackColor = Color.Transparent;
            lblDesconto.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            lblDesconto.Location = new Point(902, 438);
            lblDesconto.Margin = new Padding(2, 0, 2, 0);
            lblDesconto.Name = "lblDesconto";
            lblDesconto.Size = new Size(91, 25);
            lblDesconto.TabIndex = 29;
            lblDesconto.Text = "Desconto";
            // 
            // lblTotalTitulo
            // 
            lblTotalTitulo.AutoSize = true;
            lblTotalTitulo.BackColor = Color.Transparent;
            lblTotalTitulo.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            lblTotalTitulo.Location = new Point(902, 469);
            lblTotalTitulo.Margin = new Padding(2, 0, 2, 0);
            lblTotalTitulo.Name = "lblTotalTitulo";
            lblTotalTitulo.Size = new Size(52, 25);
            lblTotalTitulo.TabIndex = 30;
            lblTotalTitulo.Text = "Total";
            // 
            // btnFinalizar
            // 
            btnFinalizar.BackColor = Color.LightGreen;
            btnFinalizar.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnFinalizar.ForeColor = Color.DarkGreen;
            btnFinalizar.Location = new Point(1239, 406);
            btnFinalizar.Name = "btnFinalizar";
            btnFinalizar.Size = new Size(185, 88);
            btnFinalizar.TabIndex = 31;
            btnFinalizar.Text = "Finalizar Compra";
            btnFinalizar.UseVisualStyleBackColor = false;
            btnFinalizar.Click += btnFinalizar_Click;
            // 
            // txtDesconto
            // 
            txtDesconto.Location = new Point(998, 436);
            txtDesconto.Name = "txtDesconto";
            txtDesconto.Size = new Size(215, 27);
            txtDesconto.TabIndex = 32;
            txtDesconto.TextChanged += txtDesconto_TextChanged;
            // 
            // txtQuantidade
            // 
            txtQuantidade.Location = new Point(902, 716);
            txtQuantidade.Name = "txtQuantidade";
            txtQuantidade.Size = new Size(157, 27);
            txtQuantidade.TabIndex = 33;
            // 
            // btnAdicionar
            // 
            btnAdicionar.BackColor = Color.PaleVioletRed;
            btnAdicionar.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdicionar.ForeColor = SystemColors.Window;
            btnAdicionar.Location = new Point(1239, 688);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(185, 55);
            btnAdicionar.TabIndex = 34;
            btnAdicionar.Text = "Adicionar";
            btnAdicionar.UseVisualStyleBackColor = false;
            btnAdicionar.Click += btnAdicionar_Click;
            // 
            // lblSubtotal
            // 
            lblSubtotal.AutoSize = true;
            lblSubtotal.BackColor = Color.Transparent;
            lblSubtotal.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            lblSubtotal.Location = new Point(1167, 406);
            lblSubtotal.Margin = new Padding(2, 0, 2, 0);
            lblSubtotal.Name = "lblSubtotal";
            lblSubtotal.Size = new Size(46, 25);
            lblSubtotal.TabIndex = 35;
            lblSubtotal.Text = "0,00";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.BackColor = Color.Transparent;
            lblTotal.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            lblTotal.Location = new Point(1167, 469);
            lblTotal.Margin = new Padding(2, 0, 2, 0);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(46, 25);
            lblTotal.TabIndex = 36;
            lblTotal.Text = "0,00";
            // 
            // btnCompras
            // 
            btnCompras.BackColor = Color.LightPink;
            btnCompras.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCompras.ForeColor = SystemColors.ActiveCaptionText;
            btnCompras.Location = new Point(11, 302);
            btnCompras.Margin = new Padding(2);
            btnCompras.Name = "btnCompras";
            btnCompras.Size = new Size(234, 65);
            btnCompras.TabIndex = 37;
            btnCompras.Text = "Compras";
            btnCompras.UseVisualStyleBackColor = false;
            // 
            // btnProdutos
            // 
            btnProdutos.BackColor = Color.LavenderBlush;
            btnProdutos.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnProdutos.ForeColor = SystemColors.ActiveCaptionText;
            btnProdutos.Location = new Point(11, 233);
            btnProdutos.Margin = new Padding(2);
            btnProdutos.Name = "btnProdutos";
            btnProdutos.Size = new Size(234, 65);
            btnProdutos.TabIndex = 38;
            btnProdutos.Text = "Produtos";
            btnProdutos.UseVisualStyleBackColor = false;
            // 
            // Compras
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.novacompra;
            ClientSize = new Size(1485, 836);
            Controls.Add(btnProdutos);
            Controls.Add(btnCompras);
            Controls.Add(lblTotal);
            Controls.Add(lblSubtotal);
            Controls.Add(btnAdicionar);
            Controls.Add(txtQuantidade);
            Controls.Add(txtDesconto);
            Controls.Add(btnFinalizar);
            Controls.Add(lblTotalTitulo);
            Controls.Add(lblDesconto);
            Controls.Add(lblSubtotalTitulo);
            Controls.Add(dvgCarrinho);
            Controls.Add(lblQuantidade);
            Controls.Add(cmbProdutos);
            Controls.Add(lblProduto);
            Controls.Add(dvgProdutos);
            Margin = new Padding(2);
            Name = "Compras";
            Text = "Compras";
            Load += Compras_Load;
            ((System.ComponentModel.ISupportInitialize)dvgProdutos).EndInit();
            ((System.ComponentModel.ISupportInitialize)dvgCarrinho).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView dvgProdutos;
        private Label lblQuantidade;
        private Label lblProduto;
        private ComboBox cmbProdutos;
        private DataGridView dvgCarrinho;
        private Label lblSubtotalTitulo;
        private Label lblDesconto;
        private Label lblTotalTitulo;
        private Button btnFinalizar;
        private TextBox txtDesconto;
        private TextBox txtQuantidade;
        private Button btnAdicionar;
        private Label lblSubtotal;
        private Label lblTotal;
        private Button btnCompras;
        private Button btnProdutos;
    }
}