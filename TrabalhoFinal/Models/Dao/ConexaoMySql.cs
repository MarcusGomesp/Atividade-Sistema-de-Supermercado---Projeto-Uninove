using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoFinal.Models.Dao
{
    public class ConexaoMySql
    {
 // Ajuste os valores abaixo conforme seu banco local
        private readonly string _conexaoString =
                "Server=localhost;Port=;Database=Supermercado;Uid=root;Pwd=!;";

 // CREATE TABLE `produto` (
 // `id` int NOT NULL AUTO_INCREMENT,
 // `nome` varchar(250) DEFAULT NULL,
 // `classificacao` double DEFAULT NULL,
 // `preco` double DEFAULT NULL,
 // `entrega` varchar(100) DEFAULT NULL,
 // `urlImagem` varchar(200) DEFAULT NULL,
 // PRIMARY KEY(`id`)
 //) ENGINE=InnoDB AUTO_INCREMENT = 6 DEFAULT CHARSET = utf8mb4 COLLATE=utf8mb4_0900_ai_ci;


        public MySqlConnection Conectar()
        {
            try
            {
                MySqlConnection conn = new MySqlConnection(_conexaoString);

                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }

                return conn;
            }
            catch (MySqlException ex)
            {
                // Erros específicos de MySQL (Ex: senha errada, banco não existe)
                throw new Exception("Falha na conexão com MySQL: " + ex.Message);
            }
        }
    }
}