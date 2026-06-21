using e_commerce.DadosConexao;
using e_commerce.Modelos;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace e_commerce.Repositorios__DAL_
{
    public class ItemCarrinhoRepository
    {
        private ConexaoBD conexao = new ConexaoBD();

        // Adicionar produto ao carrinho
        public void Adicionar(ItemCarrinho item)
        {
            using (var conn = conexao.AbrirConexao())
            {
                string query = @"INSERT INTO itens_carrinho (carrinho_id, produto_id, quantidade)
                                VALUES (@carrinho_id, @produto_id, @quantidade)";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@carrinho_id", item.CarrinhoId);
                cmd.Parameters.AddWithValue("@produto_id", item.ProdutoId);
                cmd.Parameters.AddWithValue("@quantidade", item.Quantidade);

                cmd.ExecuteNonQuery();
            }
        }

        // Listar itens do carrinho
        public List<ItemCarrinho> Listar(int carrinhoId)
        {
            List<ItemCarrinho> lista = new List<ItemCarrinho>();

            using (var conn = conexao.AbrirConexao())
            {
                string query = "SELECT * FROM itens_carrinho WHERE carrinho_id=@id";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", carrinhoId);

                var reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    lista.Add(new ItemCarrinho
                    {
                        Id = reader.GetInt32("id"),
                        CarrinhoId = reader.GetInt32("carrinho_id"),
                        ProdutoId = reader.GetInt32("produto_id"),
                        Quantidade = reader.GetInt32("quantidade")
                    });
                }
            }

            return lista;
        }

        // Limpar carrinho
        public void Limpar(int carrinhoId)
        {
            using (var conn = conexao.AbrirConexao())
            {
                string query = "DELETE FROM itens_carrinho WHERE carrinho_id=@id";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", carrinhoId);

                cmd.ExecuteNonQuery();
            }
        }

        internal void AdicionarItem(int carrinhoId, int produtoId, int qtd)
        {
            using (var conn = conexao.AbrirConexao())
            {
                string query = @"INSERT INTO itens_carrinho (carrinho_id, produto_id, quantidade)
                         VALUES (@carrinho, @produto, @qtd)";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@carrinho", carrinhoId);
                cmd.Parameters.AddWithValue("@produto", produtoId);
                cmd.Parameters.AddWithValue("@qtd", qtd);

                cmd.ExecuteNonQuery();
            }
        }
    }
}
