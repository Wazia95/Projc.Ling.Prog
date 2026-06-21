using System;
using System.Collections.Generic;
using System.Text;

namespace e_commerce.Modelos
{
    public class Encomenda
    {
        public int Id { get; set; }
        public int ClienteId { get; set; }
        public DateTime DataEncomenda { get; set; }
        public required string Estado { get; set; }
        public decimal Total { get; set; }
    }
}
