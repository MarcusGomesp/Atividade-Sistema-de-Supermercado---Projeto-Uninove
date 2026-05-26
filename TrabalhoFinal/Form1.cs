using TrabalhoFinal.Models;
using TrabalhoFinal.Models.Dao;
using System.Data;
using System.IO;

namespace TrabalhoFinal
{
    public partial class Form1 : Form
    {

        string caminhoImagem = "";
        public Form1()
        {
            InitializeComponent();
            ListarProdutos();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }



        private void btnSelecionarImagem_Click(object sender, EventArgs e)
        {

            OpenFileDialog abrir = new OpenFileDialog(); // como usei openFileDialog https://pt.stackoverflow.com/questions/181547/upload-de-imagens-com-c-windows-forms-e-php

            abrir.Filter =
                    "Imagem (*.jpg;*.png)|*.jpg;*.png";

            if (abrir.ShowDialog() == DialogResult.OK)
            {
                caminhoImagem = abrir.FileName;

                picBImagem.ImageLocation =
                    caminhoImagem;
            }
        }

        private void btnRemoverImagem_Click(object sender, EventArgs e)
        {
            picBImagem.Image = null;

            caminhoImagem = "";
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                // VALIDAÇÕES

                if (txtNomeProduto.Text == "")
                {
                    MessageBox.Show("Digite o nome do produto");
                    return;
                }

                if (cblCategoria.Text == "")
                {
                    MessageBox.Show("Selecione uma categoria");
                    return;
                }

                if (txtQtdEstoque.Text == "")
                {
                    MessageBox.Show("Digite a quantidade");
                    return;
                }

                if (txtPreco.Text == "")
                {
                    MessageBox.Show("Digite o preço");
                    return;
                }

                // OBJETO PRODUTO

                Produtos p = new Produtos();

                p.Nome = txtNomeProduto.Text;

                p.Categoria = cblCategoria.Text;

                p.QuantidadeEstoque = Convert.ToInt32(txtQtdEstoque.Text);

                p.Preco = Convert.ToDecimal(txtPreco.Text);

                p.DataCadastro = DateTime.Now;

                p.Imagem = caminhoImagem;



                ProdutosDao dao = new ProdutosDao(); dao.Inserir(p);

                MessageBox.Show("Produto cadastrado com sucesso!");

                ListarProdutos();



                LimparCampos();
            }
            catch (Exception erro)
            {
                MessageBox.Show(
                    "Erro ao cadastrar: " + erro.Message);
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtCodigoProduto.Text == "")
                {
                    MessageBox.Show("Selecione um produto");

                    return;
                }

                DialogResult resposta =
                    MessageBox.Show("Deseja excluir o produto?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (resposta == DialogResult.Yes)
                {
                    int codigo = Convert.ToInt32(txtCodigoProduto.Text);

                    ProdutosDao dao = new ProdutosDao();

                    dao.Excluir(codigo);

                    MessageBox.Show("Produto excluído com sucesso!");

                    ListarProdutos();

                    LimparCampos();
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao excluir: " + erro.Message);
            }
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtCodigoProduto.Text == "")
                {
                    MessageBox.Show("Selecione um produto");

                    return;
                }

                Produtos p = new Produtos();

                p.Codigo = Convert.ToInt32(txtCodigoProduto.Text);

                p.Nome = txtNomeProduto.Text;

                p.Categoria = cblCategoria.Text;

                p.QuantidadeEstoque = Convert.ToInt32(txtQtdEstoque.Text);

                p.Preco = Convert.ToDecimal(txtPreco.Text);

                p.DataCadastro = DateTime.Now;

                p.Imagem = caminhoImagem;

                ProdutosDao dao = new ProdutosDao();

                dao.Atualizar(p);

                MessageBox.Show("Produto atualizado com sucesso!");

                ListarProdutos();

                LimparCampos();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao atualizar: " + erro.Message);
            }
        }

        public void ListarProdutos()
        {
            ProdutosDao dao = new ProdutosDao();

            dvgProdutos.DataSource = dao.Listar();
        }

        public void LimparCampos()
        {
            txtNomeProduto.Clear();

            txtQtdEstoque.Clear();

            txtPreco.Clear();

            cblCategoria.SelectedIndex = -1;

            picBImagem.Image = null;

            caminhoImagem = "";
        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void dvgProdutos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow linha =
                    dvgProdutos.Rows[e.RowIndex];

                txtCodigoProduto.Text = linha.Cells["Codigo"].Value.ToString();

                txtNomeProduto.Text = linha.Cells["Nome"].Value.ToString();

                cblCategoria.Text = linha.Cells["Categoria"].Value.ToString();

                txtQtdEstoque.Text = linha.Cells["QuantidadeEstoque"].Value.ToString();

                txtPreco.Text = linha.Cells["Preco"].Value.ToString();

                caminhoImagem = linha.Cells["Imagem"].Value.ToString();

                if (File.Exists(caminhoImagem))
                {
                    picBImagem.ImageLocation = caminhoImagem;
                }
                else
                {
                    picBImagem.Image = null;
                }
            }
        }

        private void btnCompras_Click(object sender, EventArgs e)
        {
            Compras telaCompras = new Compras();
            this.Hide();
            telaCompras.ShowDialog();
            this.Show();
        }
    }
}
