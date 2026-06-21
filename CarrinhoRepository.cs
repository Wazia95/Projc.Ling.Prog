using e_commerce.DadosConexao;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace e_commerce.Repositorios__DAL_
{
    public class CarrinhoRepository
    {
        private ConexaoBD conexao = new ConexaoBD();

        // Criar carrinho para cliente
        public int CriarCarrinho(int clienteId)
        {
            using (var conn = conexao.AbrirConexao())
            {
                string query = "INSERT INTO carrinhos (cliente_id) VALUES (@cliente_id)";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@cliente_id", clienteId);

                cmd.ExecuteNonQuery();
                return (int)cmd.LastInsertedId;
            }
        }

        // Buscar carrinho do cliente
        public int ObterCarrinhoPorCliente(int clienteId)
        {
            using (var conn = conexao.AbrirConexao())
            {
                string query = "SELECT id FROM carrinhos WHERE cliente_id=@cliente_id";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@cliente_id", clienteId);

                var result = cmd.ExecuteScalar();

                if (result == null)
                    return CriarCarrinho(clienteId);

                return int.Parse(result.ToString());
            }
        }
    }
}
