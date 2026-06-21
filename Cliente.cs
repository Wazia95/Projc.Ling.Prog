using System;
using System.Collections.Generic;
using System.Text;

namespace e_commerce.Modelos
{
    public class Cliente
    {
        public int Id { get; set; }
        public required string Nome { get; set; }
        public required string Email { get; set; }
        public required string Telefone { get; set; }
        public required string Endereco { get; set; }
        public DateTime DataRegisto { get; set; }
    }
}
