namespace TrabalhoFinal
{
    partial class NotaFiscal
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
            btnCompras = new Button();
            btnProdutos = new Button();
            btnNovaCompra = new Button();
            btnBaixar = new Button();
            btnFechar = new Button();
            dvgDados = new DataGridView();
            dvgItens = new DataGridView();
            dvgResumo = new DataGridView();
            dvgNota = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dvgDados).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dvgItens).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dvgResumo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dvgNota).BeginInit();
            SuspendLayout();
            // 
            // btnCompras
            // 
            btnCompras.BackColor = Color.LightPink;
            btnCompras.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCompras.ForeColor = Color.Black;
            btnCompras.Location = new Point(11, 288);
            btnCompras.Margin = new Padding(2);
            btnCompras.Name = "btnCompras";
            btnCompras.Size = new Size(213, 65);
            btnCompras.TabIndex = 38;
            btnCompras.Text = "Compras";
            btnCompras.UseVisualStyleBackColor = false;
            // 
            // btnProdutos
            // 
            btnProdutos.BackColor = Color.LavenderBlush;
            btnProdutos.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnProdutos.ForeColor = SystemColors.ActiveCaptionText;
            btnProdutos.Location = new Point(11, 230);
            btnProdutos.Margin = new Padding(2);
            btnProdutos.Name = "btnProdutos";
            btnProdutos.Size = new Size(213, 54);
            btnProdutos.TabIndex = 39;
            btnProdutos.Text = "Produtos";
            btnProdutos.UseVisualStyleBackColor = false;
            // 
            // btnNovaCompra
            // 
            btnNovaCompra.BackColor = Color.LightPink;
            btnNovaCompra.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNovaCompra.ForeColor = Color.Crimson;
            btnNovaCompra.Location = new Point(279, 650);
            btnNovaCompra.Margin = new Padding(2);
            btnNovaCompra.Name = "btnNovaCompra";
            btnNovaCompra.Size = new Size(177, 113);
            btnNovaCompra.TabIndex = 40;
            btnNovaCompra.Text = "Nova Compra";
            btnNovaCompra.UseVisualStyleBackColor = false;
            btnNovaCompra.Click += btnNovaCompra_Click;
            // 
            // btnBaixar
            // 
            btnBaixar.BackColor = Color.LightSkyBlue;
            btnBaixar.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBaixar.ForeColor = SystemColors.Highlight;
            btnBaixar.Location = new Point(460, 650);
            btnBaixar.Margin = new Padding(2);
            btnBaixar.Name = "btnBaixar";
            btnBaixar.Size = new Size(177, 113);
            btnBaixar.TabIndex = 41;
            btnBaixar.Text = "Baixar arquivo";
            btnBaixar.UseVisualStyleBackColor = false;
            btnBaixar.Click += btnBaixar_Click;
            // 
            // btnFechar
            // 
            btnFechar.BackColor = Color.PowderBlue;
            btnFechar.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnFechar.ForeColor = Color.Teal;
            btnFechar.Location = new Point(910, 650);
            btnFechar.Margin = new Padding(2);
            btnFechar.Name = "btnFechar";
            btnFechar.Size = new Size(177, 113);
            btnFechar.TabIndex = 42;
            btnFechar.Text = "X Fechar";
            btnFechar.UseVisualStyleBackColor = false;
            btnFechar.Click += btnFechar_Click;
            // 
            // dvgDados
            // 
            dvgDados.BackgroundColor = SystemColors.ButtonHighlight;
            dvgDados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dvgDados.GridColor = Color.PaleVioletRed;
            dvgDados.Location = new Point(266, 168);
            dvgDados.Margin = new Padding(2);
            dvgDados.Name = "dvgDados";
            dvgDados.RowHeadersWidth = 62;
            dvgDados.Size = new Size(246, 407);
            dvgDados.TabIndex = 43;
            // 
            // dvgItens
            // 
            dvgItens.BackgroundColor = SystemColors.ButtonHighlight;
            dvgItens.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dvgItens.GridColor = Color.PaleVioletRed;
            dvgItens.Location = new Point(569, 168);
            dvgItens.Margin = new Padding(2);
            dvgItens.Name = "dvgItens";
            dvgItens.RowHeadersWidth = 62;
            dvgItens.Size = new Size(246, 407);
            dvgItens.TabIndex = 44;
            // 
            // dvgResumo
            // 
            dvgResumo.BackgroundColor = SystemColors.ButtonHighlight;
            dvgResumo.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dvgResumo.GridColor = Color.PaleVioletRed;
            dvgResumo.Location = new Point(866, 168);
            dvgResumo.Margin = new Padding(2);
            dvgResumo.Name = "dvgResumo";
            dvgResumo.RowHeadersWidth = 62;
            dvgResumo.Size = new Size(246, 407);
            dvgResumo.TabIndex = 45;
            // 
            // dvgNota
            // 
            dvgNota.BackgroundColor = SystemColors.ButtonHighlight;
            dvgNota.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dvgNota.GridColor = Color.PaleVioletRed;
            dvgNota.Location = new Point(1153, 168);
            dvgNota.Margin = new Padding(2);
            dvgNota.Name = "dvgNota";
            dvgNota.RowHeadersWidth = 62;
            dvgNota.Size = new Size(284, 620);
            dvgNota.TabIndex = 46;
            // 
            // NotaFiscal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.notafiscal;
            ClientSize = new Size(1485, 814);
            Controls.Add(dvgNota);
            Controls.Add(dvgResumo);
            Controls.Add(dvgItens);
            Controls.Add(dvgDados);
            Controls.Add(btnFechar);
            Controls.Add(btnBaixar);
            Controls.Add(btnNovaCompra);
            Controls.Add(btnProdutos);
            Controls.Add(btnCompras);
            Name = "NotaFiscal";
            Text = "Nota";
            Load += NotaFiscal_Load;
            ((System.ComponentModel.ISupportInitialize)dvgDados).EndInit();
            ((System.ComponentModel.ISupportInitialize)dvgItens).EndInit();
            ((System.ComponentModel.ISupportInitialize)dvgResumo).EndInit();
            ((System.ComponentModel.ISupportInitialize)dvgNota).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnCompras;
        private Button btnProdutos;
        private Button btnNovaCompra;
        private Button btnBaixar;
        private Button btnFechar;
        public DataGridView dvgDados;
        public DataGridView dvgItens;
        public DataGridView dvgResumo;
        public DataGridView dvgNota;
    }
}