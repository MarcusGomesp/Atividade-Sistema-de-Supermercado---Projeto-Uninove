using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoFinal.Models.Dao
{
    public class ConexaoSqlServer
    {

        private string conexao =
         @"Server=(localdb)\MSSQLLocalDB;Database=Supermercado;Integrated Security=true;"; // Sabryna crie o seu banco de dados e coloque o nome dele aqui, sua string de conexao 


        /* Codigo do banco de dados para criar a tabela Produtos, caso queira criar manualmente no SQL Server Management Studio
        USE Supermercado;
        GO

        CREATE TABLE Produtos
        (
            Codigo INT PRIMARY KEY IDENTITY(1,1),
        Nome VARCHAR(150),
        Categoria VARCHAR(100),
        QuantidadeEstoque INT,
        Preco DECIMAL(10,2),
        DataCadastro DATETIME,
        Imagem VARCHAR(255)
                            );
         GO*/

        public SqlConnection ConectarSqlServer()
        {
            SqlConnection conn = new SqlConnection(conexao);
            conn.Open();

            return conn;
        }
    }
}
