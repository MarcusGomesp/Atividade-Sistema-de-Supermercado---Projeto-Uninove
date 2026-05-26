using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace TrabalhoFinal
{
    public partial class Compras : Form
    {
        private List<TrabalhoFinal.Models.Produtos> produtosDoBanco = new List<TrabalhoFinal.Models.Produtos>();
        private decimal subtotalGeral = 0;

        private DataTable carrinhoTable;
        private DataTable produtosTable;

        public Compras()
        {
            InitializeComponent();

            carrinhoTable = new DataTable();
            carrinhoTable.Columns.Add("Produto", typeof(string));
            carrinhoTable.Columns.Add("Quantidade", typeof(int));
            carrinhoTable.Columns.Add("Total", typeof(decimal));

            dvgCarrinho.DataSource = carrinhoTable;

            dvgCarrinho.RowHeadersVisible = false;
            dvgCarrinho.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            if (dvgCarrinho.Columns.Contains("Produto"))
                dvgCarrinho.Columns["Produto"].FillWeight = 50;

            if (dvgCarrinho.Columns.Contains("Quantidade"))
                dvgCarrinho.Columns["Quantidade"].FillWeight = 20;

            if (dvgCarrinho.Columns.Contains("Total"))
            {
                dvgCarrinho.Columns["Total"].FillWeight = 30;
                dvgCarrinho.Columns["Total"].DefaultCellStyle.Format = "N2";
            }
        }

        private void Compras_Load(object sender, EventArgs e)
        {
            try
            {
                TrabalhoFinal.Models.Dao.ProdutosDao dao =
                    new TrabalhoFinal.Models.Dao.ProdutosDao();

                produtosTable = dao.Listar();

                cmbProdutos.Items.Clear();
                produtosDoBanco.Clear();

                dvgProdutos.DataSource = produtosTable;

                if (dvgProdutos.Columns.Contains("Imagem"))
                    dvgProdutos.Columns.Remove("Imagem");

                if (dvgProdutos.Columns.Contains("DataCadastro"))
                    dvgProdutos.Columns.Remove("DataCadastro");

                dvgProdutos.RowHeadersVisible = false;

                dvgProdutos.AutoSizeColumnsMode =
                    DataGridViewAutoSizeColumnsMode.Fill;

                if (dvgProdutos.Columns.Contains("Nome"))
                    dvgProdutos.Columns["Nome"].FillWeight = 40;

                if (dvgProdutos.Columns.Contains("Preco"))
                    dvgProdutos.Columns["Preco"].DefaultCellStyle.Format = "N2";

                int i = 0;

                while (i < produtosTable.Rows.Count)
                {
                    DataRow linha = produtosTable.Rows[i];

                    TrabalhoFinal.Models.Produtos p =
                        new TrabalhoFinal.Models.Produtos
                        {
                            Codigo = Convert.ToInt32(linha["Codigo"]),
                            Nome = linha["Nome"].ToString(),
                            Categoria = linha["Categoria"].ToString(),
                            QuantidadeEstoque =
                                Convert.ToInt32(linha["QuantidadeEstoque"]),
                            Preco = Convert.ToDecimal(linha["Preco"]),
                            Imagem = linha["Imagem"].ToString()
                        };

                    produtosDoBanco.Add(p);

                    cmbProdutos.Items.Add(p);

                    i++;
                }

                cmbProdutos.DisplayMember = "Nome";

                if (cmbProdutos.Items.Count > 0)
                    cmbProdutos.SelectedIndex = 0;
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro: " + erro.Message);
            }
        }

        private void CalcularTotal()
        {
            decimal desconto = 0;

            if (!string.IsNullOrWhiteSpace(txtDesconto.Text))
            {
                if (!decimal.TryParse(txtDesconto.Text, out desconto) ||
                    desconto < 0)
                {
                    MessageBox.Show("Insira um valor válido.");

                    txtDesconto.Text = "0";

                    desconto = 0;
                }
            }

            decimal totalFinal = subtotalGeral - desconto;

            if (totalFinal < 0)
                totalFinal = 0;

            lblSubtotal.Text = subtotalGeral.ToString("N2");

            lblTotal.Text = totalFinal.ToString("N2");
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            if (cmbProdutos.SelectedItem == null)
            {
                MessageBox.Show("Selecione um produto.");

                return;
            }

            if (string.IsNullOrEmpty(txtQuantidade.Text) ||
                !int.TryParse(txtQuantidade.Text, out int qtdDesejada) ||
                qtdDesejada <= 0)
            {
                MessageBox.Show("Digite um valor maior que zero.");

                return;
            }

            TrabalhoFinal.Models.Produtos produtoSelecionado =
                (TrabalhoFinal.Models.Produtos)cmbProdutos.SelectedItem;

            if (qtdDesejada > produtoSelecionado.QuantidadeEstoque)
            {
                MessageBox.Show(
                    $"Sem estoque. Temos {produtoSelecionado.QuantidadeEstoque} unidades de {produtoSelecionado.Nome}.");

                return;
            }

            decimal totalItem =
                produtoSelecionado.Preco * qtdDesejada;

            carrinhoTable.Rows.Add(
                produtoSelecionado.Nome,
                qtdDesejada,
                totalItem);

            subtotalGeral += totalItem;

            CalcularTotal();

            txtQuantidade.Clear();
        }

        private void txtDesconto_TextChanged(object sender, EventArgs e)
        {
            CalcularTotal();
        }

        private void LimparTela()
        {
            carrinhoTable.Rows.Clear();

            subtotalGeral = 0;

            txtDesconto.Clear();

            txtQuantidade.Clear();

            CalcularTotal();
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            if (carrinhoTable.Rows.Count == 0)
            {
                MessageBox.Show("O carrinho está vazio!");

                return;
            }

            try
            {
                TrabalhoFinal.Models.Dao.ProdutosDao dao =
                    new TrabalhoFinal.Models.Dao.ProdutosDao();

                int i = 0;

                while (i < carrinhoTable.Rows.Count)
                {
                    DataRow linhaCarrinho =
                        carrinhoTable.Rows[i];

                    string nomeProduto =
                        linhaCarrinho["Produto"].ToString();

                    int qtdVendida =
                        Convert.ToInt32(
                            linhaCarrinho["Quantidade"]);

                    TrabalhoFinal.Models.Produtos pBanco =
                        produtosDoBanco.Find(
                            p => p.Nome == nomeProduto);

                    if (pBanco != null)
                    {
                        pBanco.QuantidadeEstoque -= qtdVendida;

                        dao.Atualizar(pBanco);
                    }

                    i++;
                }

                NotaFiscal telaNota = new NotaFiscal();

                telaNota.dvgDados.Columns.Clear();
                telaNota.dvgItens.Columns.Clear();
                telaNota.dvgResumo.Columns.Clear();
                telaNota.dvgNota.Columns.Clear();



                telaNota.dvgDados.Columns.Add("Data", "Data");
                telaNota.dvgDados.Columns.Add("Hora", "Hora");
                telaNota.dvgDados.Columns.Add("Itens", "Itens");



                telaNota.dvgItens.Columns.Add("Produto", "Produto");
                telaNota.dvgItens.Columns.Add("Quantidade", "Quantidade");
                telaNota.dvgItens.Columns.Add("Total", "Total");



                telaNota.dvgResumo.Columns.Add("Subtotal", "Subtotal");
                telaNota.dvgResumo.Columns.Add("Desconto", "Desconto");
                telaNota.dvgResumo.Columns.Add("TotalFinal", "Total Final");



                telaNota.dvgNota.Columns.Add("Descricao", "Descrição");
                telaNota.dvgNota.Columns.Add("Valor", "Valor");



                telaNota.dvgDados.Rows.Add(
                    DateTime.Now.ToString("dd/MM/yyyy"),
                    DateTime.Now.ToString("HH:mm"),
                    carrinhoTable.Rows.Count
                );

                int x = 0;

                while (x < carrinhoTable.Rows.Count)
                {
                    string produto =
                        carrinhoTable.Rows[x]["Produto"].ToString();

                    string quantidade =
                        carrinhoTable.Rows[x]["Quantidade"].ToString();

                    string total =
                        carrinhoTable.Rows[x]["Total"].ToString();

                    telaNota.dvgItens.Rows.Add(
                        produto,
                        quantidade,
                        total
                    );

                    telaNota.dvgNota.Rows.Add(
                        produto,
                        "Qtd: " + quantidade
                    );

                    x++;
                }

                decimal desconto = 0;

                decimal.TryParse(txtDesconto.Text, out desconto);

                telaNota.dvgResumo.Rows.Add(
                    lblSubtotal.Text,
                    desconto.ToString("N2"),
                    lblTotal.Text
                );

                telaNota.dvgNota.Rows.Add(
                    "Subtotal",
                    lblSubtotal.Text
                );

                telaNota.dvgNota.Rows.Add(
                    "Desconto",
                    desconto.ToString("N2")
                );

                telaNota.dvgNota.Rows.Add(
                    "Total Final",
                    lblTotal.Text
                );

                this.Hide();
                telaNota.ShowDialog();
                this.Close();
            }
            catch (Exception erro)
            {
                MessageBox.Show(
                    "Erro na atualização: " + erro.Message);
            }
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            if (dvgCarrinho.SelectedRows.Count > 0)
            {
                decimal valor =
                    Convert.ToDecimal(
                        dvgCarrinho.SelectedRows[0]
                        .Cells["Total"].Value);

                subtotalGeral -= valor;

                dvgCarrinho.Rows.RemoveAt(
                    dvgCarrinho.SelectedRows[0].Index);

                CalcularTotal();

                MessageBox.Show("Item removido.");
            }
            else
            {
                MessageBox.Show("Selecione um item.");
            }
        }
    }
}