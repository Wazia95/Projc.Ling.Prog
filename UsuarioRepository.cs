using e_commerce.DadosConexao;
using e_commerce.Modelos;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace e_commerce.Repositorios__DAL_
{
    public class UsuarioRepository
    {
        ConexaoBD conexao = new ConexaoBD();

        public Usuario Login(string email, string senha)
        {
            using (var conn = conexao.AbrirConexao())
            {
                string query = "SELECT * FROM usuarios WHERE email=@e AND senha=@s";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@e", email);
                cmd.Parameters.AddWithValue("@s", senha);

                var reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    return new Usuario
                    {
                        Id = reader.GetInt32("id"),
                        Nome = reader.GetString("nome"),
                        Tipo = reader.GetString("tipo")
                    };
                }
            }

            return null;
        }

        public void Adicionar(Usuario c)
        {
            using (var conn = conexao.AbrirConexao())
            {
                string query = @"INSERT INTO usuarios (nome, email, senha, tipo)
                                 VALUES (@nome, @email, @senha, @tipo)";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@nome", c.Nome);
                cmd.Parameters.AddWithValue("@email", c.Email);
                cmd.Parameters.AddWithValue("@senha", c.Senha);
                cmd.Parameters.AddWithValue("@tipo", c.Tipo);

                cmd.ExecuteNonQuery();
            }
        }

        // SELECT
        public List<Usuario> Listar()
        {
            List<Usuario> lista = new List<Usuario>();

            using (var conn = conexao.AbrirConexao())
            {
                string query = "SELECT * FROM usuarios";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                var reader = cmd.ExecuteReader();

                // UsuarioRepository.Listar()
                while (reader.Read())
                {
                    var idOrdinal = reader.GetOrdinal("id");
                    var nomeOrdinal = reader.GetOrdinal("nome");
                    var emailOrdinal = reader.GetOrdinal("email");
                    var telefoneOrdinal = reader.GetOrdinal("senha");
                    var enderecoOrdinal = reader.GetOrdinal("tipo");

                    lista.Add(new Usuario
                    {
                        Id = reader.IsDBNull(idOrdinal) ? 0 : reader.GetInt32(idOrdinal),
                        Nome = reader.IsDBNull(nomeOrdinal) ? null : reader.GetString(nomeOrdinal),
                        Email = reader.IsDBNull(emailOrdinal) ? null : reader.GetString(emailOrdinal),
                        Senha = reader.IsDBNull(telefoneOrdinal) ? null : reader.GetString(telefoneOrdinal),
                        Tipo = reader.IsDBNull(enderecoOrdinal) ? null : reader.GetString(enderecoOrdinal)
                    });
                }
            }

            return lista;
        }

        public List<Usuario> Pesquisar(string termo)
        {
            List<Usuario> lista = new List<Usuario>();

            using (var conn = conexao.AbrirConexao())
            {
                string query = @"SELECT * FROM usuarios 
                         WHERE nome LIKE @termo OR email LIKE @termo";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@termo", "%" + termo + "%");

                var reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    lista.Add(new Usuario
                    {
                        Id = reader.GetInt32("id"),
                        Nome = reader.GetString("nome"),
                        Email = reader.GetString("email"),
                        Senha = reader.GetString("senha"),
                        Tipo = reader.GetString("tipo")
                    });
                }
            }

            return lista;
        }

        // UPDATE
        public void Atualizar(Usuario c)
        {
            using (var conn = conexao.AbrirConexao())
            {
                string query = @"UPDATE usuarioss 
                                 SET nome=@nome, email=@email, senha=@senha, tipo=@tipo
                                 WHERE id=@id";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", c.Id);
                cmd.Parameters.AddWithValue("@nome", c.Nome);
                cmd.Parameters.AddWithValue("@email", c.Email);
                cmd.Parameters.AddWithValue("@senha", c.Senha);
                cmd.Parameters.AddWithValue("@tipo", c.Tipo);

                cmd.ExecuteNonQuery();
            }
        }

        // DELETE
        public void Remover(int id)
        {
            using (var conn = conexao.AbrirConexao())
            {
                string query = "DELETE FROM usuarios WHERE id=@id";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", id);

                cmd.ExecuteNonQuery();
            }
        }

    }
}
