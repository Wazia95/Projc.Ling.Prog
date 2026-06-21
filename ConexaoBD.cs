using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;

namespace e_commerce.DadosConexao
{
    public class ConexaoBD
    {
        private string connectionString = "server=localhost;database=ecommerce_db;uid=root;pwd=;";

        public MySqlConnection AbrirConexao()
        {
            MySqlConnection conn = new MySqlConnection(connectionString);
            conn.Open();
            return conn;
        }

        public void FecharConexao(MySqlConnection conn)
        {
            if (conn != null && conn.State == System.Data.ConnectionState.Open)
            {
                conn.Close();
            }
        }
    }
}
