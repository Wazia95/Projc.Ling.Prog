using System;
using System.Collections.Generic;
using System.Text;

namespace e_commerce.Modelos
{
    public class Devolucao
    {
        public int Id { get; set; }
        public int EncomendaId { get; set; }
        public DateTime DataDevolucao { get; set; }
        public required string Motivo { get; set; }
        public decimal ValorReembolso { get; set; }
    }
}
