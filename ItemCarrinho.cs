using System;
using System.Collections.Generic;
using System.Text;

namespace e_commerce.Modelos
{
    public class ItemCarrinho
    {
        public int Id { get; set; }
        public int ClienteID { get; set; }
        public int CarrinhoId { get; set; }
        public int ProdutoId { get; set; }
        public int Quantidade { get; set; }
    }
}
