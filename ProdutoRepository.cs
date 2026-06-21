using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using e_commerce.Modelos;
using e_commerce.DadosConexao;

namespace e_commerce.Repositorios
{
    public class ProdutoRepository
    {
        private ConexaoBD conexao = new ConexaoBD();

        // INSERT
        public void Adicionar(Produto p)
        {
            using (var conn = conexao.AbrirConexao())
            {
                string query = "INSERT INTO produtos (nome, categoria, preco, stock, peso) VALUES (@nome, @categoria, @preco, @stock, @peso)";
                MySqlCommand cmd = new MySqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@nome", p.Nome);
                cmd.Parameters.AddWithValue("@categoria", p.Categoria);
                cmd.Parameters.AddWithValue("@preco", p.Preco);
                cmd.Parameters.AddWithValue("@stock", p.Stock);
                cmd.Parameters.AddWithValue("@peso", p.Peso);

                cmd.ExecuteNonQuery();
            }
        }

        // SELECT
        public List<Produto> Listar()
        {
            List<Produto> lista = new List<Produto>();

            using (var conn = conexao.AbrirConexao())
            {
                string query = "SELECT * FROM produtos";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Produto p = new Produto()
                    {
                        Id = reader.GetInt32("id"),
                        Nome = reader.GetString("nome"),
                        Categoria = reader.GetString("categoria"),
                        Preco = reader.GetDecimal("preco"),
                        Stock = reader.GetInt32("stock"),
                        Peso = reader.GetDecimal("peso")
                    };

                    lista.Add(p);
                }
            }

            return lista;
        }

        // UPDATE
        public void Atualizar(Produto p)
        {
            using (var conn = conexao.AbrirConexao())
            {
                string query = "UPDATE produtos SET nome=@nome, categoria=@categoria, preco=@preco, stock=@stock, peso=@peso WHERE id=@id";
                MySqlCommand cmd = new MySqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@id", p.Id);
                cmd.Parameters.AddWithValue("@nome", p.Nome);
                cmd.Parameters.AddWithValue("@categoria", p.Categoria);
                cmd.Parameters.AddWithValue("@preco", p.Preco);
                cmd.Parameters.AddWithValue("@stock", p.Stock);
                cmd.Parameters.AddWithValue("@peso", p.Peso);

                cmd.ExecuteNonQuery();
            }
        }

        // DELETE
        public void Remover(int id)
        {
            using (var conn = conexao.AbrirConexao())
            {
                string query = "DELETE FROM produtos WHERE id=@id";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", id);

                cmd.ExecuteNonQuery();
            }
        }
    }
}
