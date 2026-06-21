using System;
using System.Collections.Generic;
using System.Text;

namespace e_commerce.Modelos
{
    public class Produto
    {
        public int Id { get; set; }
        public required string Nome { get; set; }
        public required string Categoria { get; set; }
        public decimal Preco { get; set; }
        public int Stock { get; set; }
        public decimal Peso { get; set; }
    }
}
