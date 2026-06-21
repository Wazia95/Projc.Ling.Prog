using e_commerce.DadosConexao;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text;
using e_commerce.Repositorios;

namespace e_commerce.Repositorios__DAL_
{
    public class DevolucaoRepository
    {
        ConexaoBD conexao = new ConexaoBD();

        public void CriarDevolucao(int encomendaId, string motivo, decimal valor)
        {
            using (var conn = conexao.AbrirConexao())
            {
                string query = @"INSERT INTO devolucoes (encomenda_id, motivo, valor_reembolso)
                             VALUES (@enc, @motivo, @valor)";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@enc", encomendaId);
                cmd.Parameters.AddWithValue("@motivo", motivo);
                cmd.Parameters.AddWithValue("@valor", valor);

                cmd.ExecuteNonQuery();
            }
        }

        public void ReporStock(int produtoId, int qtd)
        {
            using (var conn = conexao.AbrirConexao())
            {
                string query = "UPDATE produtos SET stock = stock + @qtd WHERE id=@id";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@qtd", qtd);
                cmd.Parameters.AddWithValue("@id", produtoId);

                cmd.ExecuteNonQuery();
            }
        }

    }
}
