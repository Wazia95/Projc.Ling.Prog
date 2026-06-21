using e_commerce.DadosConexao;
using e_commerce.Modelos;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace e_commerce.Repositorios__DAL_
{
    public class ClienteRepository
    {
        ConexaoBD conexao = new ConexaoBD();

        // INSERT
        public void Adicionar(Cliente c)
        {
            using (var conn = conexao.AbrirConexao())
            {
                string query = @"INSERT INTO clientes (nome, email, telefone, endereco)
                                 VALUES (@nome, @email, @telefone, @endereco)";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@nome", c.Nome);
                cmd.Parameters.AddWithValue("@email", c.Email);
                cmd.Parameters.AddWithValue("@telefone", c.Telefone);
                cmd.Parameters.AddWithValue("@endereco", c.Endereco);

                cmd.ExecuteNonQuery();
            }
        }

        // SELECT
        public List<Cliente> Listar()
        {
            List<Cliente> lista = new List<Cliente>();

            using (var conn = conexao.AbrirConexao())
            {
                string query = "SELECT * FROM clientes";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                var reader = cmd.ExecuteReader();

                // ClienteRepository.Listar()
                while (reader.Read())
                {
                    var idOrdinal = reader.GetOrdinal("id");
                    var nomeOrdinal = reader.GetOrdinal("nome");
                    var emailOrdinal = reader.GetOrdinal("email");
                    var telefoneOrdinal = reader.GetOrdinal("telefone");
                    var enderecoOrdinal = reader.GetOrdinal("endereco");
                    var dataOrdinal = reader.GetOrdinal("data_registo");

                    lista.Add(new Cliente
                    {
                        Id = reader.IsDBNull(idOrdinal) ? 0 : reader.GetInt32(idOrdinal),
                        Nome = reader.IsDBNull(nomeOrdinal) ? null : reader.GetString(nomeOrdinal),
                        Email = reader.IsDBNull(emailOrdinal) ? null : reader.GetString(emailOrdinal),
                        Telefone = reader.IsDBNull(telefoneOrdinal) ? null : reader.GetString(telefoneOrdinal),
                        Endereco = reader.IsDBNull(enderecoOrdinal) ? null : reader.GetString(enderecoOrdinal),
                        DataRegisto = (DateTime)(reader.IsDBNull(dataOrdinal) ? (DateTime?)null : reader.GetDateTime(dataOrdinal))
                    });
                }
            }

            return lista;
        }

        public List<Cliente> Pesquisar(string termo)
        {
            List<Cliente> lista = new List<Cliente>();

            using (var conn = conexao.AbrirConexao())
            {
                string query = @"SELECT * FROM clientes 
                         WHERE nome LIKE @termo OR email LIKE @termo";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@termo", "%" + termo + "%");

                var reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    lista.Add(new Cliente
                    {
                        Id = reader.GetInt32("id"),
                        Nome = reader.GetString("nome"),
                        Email = reader.GetString("email"),
                        Telefone = reader.GetString("telefone"),
                        Endereco = reader.GetString("endereco"),
                        DataRegisto = reader.GetDateTime("data_registo")
                    });
                }
            }

            return lista;
        }

        // UPDATE
        public void Atualizar(Cliente c)
        {
            using (var conn = conexao.AbrirConexao())
            {
                string query = @"UPDATE clientes 
                                 SET nome=@nome, email=@email, telefone=@telefone, endereco=@endereco
                                 WHERE id=@id";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", c.Id);
                cmd.Parameters.AddWithValue("@nome", c.Nome);
                cmd.Parameters.AddWithValue("@email", c.Email);
                cmd.Parameters.AddWithValue("@telefone", c.Telefone);
                cmd.Parameters.AddWithValue("@endereco", c.Endereco);

                cmd.ExecuteNonQuery();
            }
        }

        // DELETE
        public void Remover(int id)
        {
            using (var conn = conexao.AbrirConexao())
            {
                string query = "DELETE FROM clientes WHERE id=@id";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", id);

                cmd.ExecuteNonQuery();
            }
        }
    }
}
