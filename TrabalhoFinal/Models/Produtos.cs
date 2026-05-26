using System;

namespace TrabalhoFinal.Models
{
    public class Produtos
    {
        public int Codigo { get; set; }
        public string Nome { get; set; } = string.Empty;
        public string Categoria { get; set; } = string.Empty;
        public int QuantidadeEstoque { get; set; }
        public decimal Preco { get; set; }
        public DateTime DataCadastro { get; set; }
        public string Imagem { get; set; } = string.Empty;
    }
}