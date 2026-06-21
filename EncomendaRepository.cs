using e_commerce.DadosConexao;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace e_commerce.Repositorios__DAL_
{
    public class EncomendaRepository
    {
        private ConexaoBD conexao = new ConexaoBD();
        private string selectItens;

        public void CriarEncomenda(int clienteId, int carrinhoId)
        {
            using (var conn = conexao.AbrirConexao())
            using (var transaction = conn.BeginTransaction())
            {
                try
                {
                    // 1. Criar encomenda
                    string insertEncomenda = @"INSERT INTO encomendas (cliente_id, estado, total)
                                      VALUES (@cliente, 'PENDENTE', 0)";

                    MySqlCommand cmd = new MySqlCommand(insertEncomenda, conn, transaction);
                    cmd.Parameters.AddWithValue("@cliente", clienteId);
                    cmd.ExecuteNonQuery();

                    int encomendaId = (int)cmd.LastInsertedId;

                    // 2. Buscar itens do carrinho (CORRETO)
                    string queryItens = @"
                                        SELECT ic.produto_id, ic.quantidade, p.preco
                                        FROM itens_carrinho ic
                                        JOIN produtos p ON p.id = ic.produto_id
                                        WHERE ic.carrinho_id = @carrinho";

                    cmd = new MySqlCommand(queryItens, conn, transaction);
                    cmd.Parameters.AddWithValue("@carrinho", carrinhoId);

                    decimal total = 0;

                    // 🧠 LISTA TEMPORÁRIA
                    var listaItens = new List<(int produtoId, int qtd, decimal preco)>();

                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int produtoId = reader.GetInt32("produto_id");
                            int qtd = reader.GetInt32("quantidade");
                            decimal preco = reader.GetDecimal("preco");

                            listaItens.Add((produtoId, qtd, preco));
                        }
                    }

                    // ✅ AGORA PODE EXECUTAR COMANDOS
                    foreach (var item in listaItens)
                    {
                        decimal subtotal = item.qtd * item.preco;
                        total += subtotal;

                        // inserir item encomenda
                        string insertItem = @"INSERT INTO itens_encomenda 
                                            (encomenda_id, produto_id, quantidade, preco_unitario, subtotal)
                                            VALUES (@enc, @prod, @qtd, @preco, @sub)";

                        var cmdItem = new MySqlCommand(insertItem, conn, transaction);
                        cmdItem.Parameters.AddWithValue("@enc", encomendaId);
                        cmdItem.Parameters.AddWithValue("@prod", item.produtoId);
                        cmdItem.Parameters.AddWithValue("@qtd", item.qtd);
                        cmdItem.Parameters.AddWithValue("@preco", item.preco);
                        cmdItem.Parameters.AddWithValue("@sub", subtotal);

                        cmdItem.ExecuteNonQuery();

                        // atualizar stock
                        string updateStock = @"UPDATE produtos 
                                               SET stock = stock - @qtd 
                                               WHERE id = @prod";

                        var cmdStock = new MySqlCommand(updateStock, conn, transaction);
                        cmdStock.Parameters.AddWithValue("@qtd", item.qtd);
                        cmdStock.Parameters.AddWithValue("@prod", item.produtoId);

                        cmdStock.ExecuteNonQuery();
                    }

                    // 3. Atualizar total
                    string updateTotal = "UPDATE encomendas SET total=@total WHERE id=@id";
                    cmd = new MySqlCommand(updateTotal, conn, transaction);
                    cmd.Parameters.AddWithValue("@total", total);
                    cmd.Parameters.AddWithValue("@id", encomendaId);
                    cmd.ExecuteNonQuery();

                    // 4. Limpar carrinho
                    string limpar = "DELETE FROM itens_carrinho WHERE carrinho_id=@carrinho";
                    cmd = new MySqlCommand(limpar, conn, transaction);
                    cmd.Parameters.AddWithValue("@carrinho", carrinhoId);
                    cmd.ExecuteNonQuery();

                    transaction.Commit();
                }
                catch (Exception)
                {
                    transaction.Rollback();
                    throw;
                }
            }
        }

        public void AtualizarEstado(int id, string estado)
        {
            using (var conn = conexao.AbrirConexao())
            {
                string query = "UPDATE encomendas SET estado=@estado WHERE id=@id";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@estado", estado);
                cmd.Parameters.AddWithValue("@id", id);

                cmd.ExecuteNonQuery();
            }
        }

    }
}
