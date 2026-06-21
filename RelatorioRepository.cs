using e_commerce.DadosConexao;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace e_commerce.Repositorios__DAL_
{
    public class RelatorioRepository
    {
        ConexaoBD conexao = new ConexaoBD();

        // TOTAL VENDAS
        public decimal TotalVendas()
        {
            using (var conn = conexao.AbrirConexao())
            {
                string query = "SELECT SUM(total) FROM encomendas WHERE estado='ENTREGUE'";
                MySqlCommand cmd = new MySqlCommand(query, conn);

                var result = cmd.ExecuteScalar();
                return result != DBNull.Value ? Convert.ToDecimal(result) : 0;
            }
        }

        // PRODUTOS MAIS VENDIDOS
        public DataTable ProdutosMaisVendidos()
        {
            using (var conn = conexao.AbrirConexao())
            {
                string query = @"
            SELECT p.nome, SUM(i.quantidade) AS total_vendido
            FROM itens_encomenda i
            JOIN produtos p ON p.id = i.produto_id
            GROUP BY p.nome
            ORDER BY total_vendido DESC";

                MySqlDataAdapter da = new MySqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                return dt;
            }
        }
    }
}
