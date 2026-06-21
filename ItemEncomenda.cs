using System;
using System.Collections.Generic;
using System.Text;

namespace e_commerce.Modelos
{
    public class ItemEncomenda
    {
        public int Id { get; set; }
        public int EncomendaId { get; set; }
        public int ProdutoId { get; set; }
        public int Quantidade { get; set; }
        public decimal PrecoUnitario { get; set; }
        public decimal Subtotal { get; set; }
    }
}
