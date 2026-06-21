using System;
using System.Collections.Generic;
using System.Text;

namespace e_commerce.Modelos
{
    public class Carrinho
    {
        public int Id { get; set; }
        public int ClienteId { get; set; }
        public int QuantidadeTotal { get; set; }
    }
}
