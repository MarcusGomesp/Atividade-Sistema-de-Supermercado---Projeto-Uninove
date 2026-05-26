using Microsoft.Data.SqlClient;
using MySql.Data.MySqlClient;
using System;
using System.Data;

namespace TrabalhoFinal.Models.Dao
{
    public class ProdutosDao
    {
        public void Inserir(Produtos p)
        {
            ConexaoSqlServer conexao = new ConexaoSqlServer();
            using (SqlConnection conn = conexao.ConectarSqlServer()) // Corrigido para usar ConectarSqlServer
            {
                string sql = @"INSERT INTO Produtos (Nome, Categoria, QuantidadeEstoque, Preco, DataCadastro, Imagem) 
                               VALUES (@Nome, @Categoria, @Quantidade, @Preco, @Data, @Imagem)";

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@Nome", p.Nome);
                    cmd.Parameters.AddWithValue("@Categoria", p.Categoria);
                    cmd.Parameters.AddWithValue("@Quantidade", p.QuantidadeEstoque);
                    cmd.Parameters.AddWithValue("@Preco", p.Preco);
                    cmd.Parameters.AddWithValue("@Data", p.DataCadastro);
                    cmd.Parameters.AddWithValue("@Imagem", p.Imagem);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        public DataTable Listar()
        {
            ConexaoSqlServer conexao = new ConexaoSqlServer();
            using (SqlConnection conn = conexao.ConectarSqlServer())
            {
                string sql = "SELECT * FROM Produtos";
                using (SqlDataAdapter da = new SqlDataAdapter(sql, conn))
                {
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    return dt;
                }
            }
        }

        public void Excluir(int codigo)
        {
            ConexaoSqlServer conexao = new ConexaoSqlServer();
            using (SqlConnection conn = conexao.ConectarSqlServer())
            {
                string sql = "DELETE FROM Produtos WHERE Codigo = @Codigo";
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@Codigo", codigo);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void Update(Produtos p) // Corrigido bug de duplicidade de execução
        {
            // Nota: No Form1 você chamou 'dao.Atualizar(p)', mantenha o nome idêntico
        }

        public void Atualizar(Produtos p)
        {
            ConexaoSqlServer conexao = new ConexaoSqlServer();
            using (SqlConnection conn = conexao.ConectarSqlServer())
            {
                // Removido o DataCadastro do UPDATE para evitar alterar a data original de criação
                string sql = @"UPDATE Produtos SET Nome = @Nome, Categoria = @Categoria, 
                               QuantidadeEstoque = @Quantidade, Preco = @Preco, Imagem = @Imagem 
                               WHERE Codigo = @Codigo";

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@Codigo", p.Codigo);
                    cmd.Parameters.AddWithValue("@Nome", p.Nome);
                    cmd.Parameters.AddWithValue("@Categoria", p.Categoria);
                    cmd.Parameters.AddWithValue("@Quantidade", p.QuantidadeEstoque);
                    cmd.Parameters.AddWithValue("@Preco", p.Preco);
                    cmd.Parameters.AddWithValue("@Imagem", p.Imagem);

                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}