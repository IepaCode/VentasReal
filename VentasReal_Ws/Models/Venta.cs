using System;
using System.Collections.Generic;

namespace VentasReal_Ws.Models
{
    public partial class Venta
    {
        public Venta()
        {
            Conceptos = new HashSet<Concepto>();
        }

        public int Id { get; set; }
        public DateTime Fecha { get; set; }
        public decimal? Total { get; set; }
        public int? IdCliente { get; set; }

        public virtual Cliente? IdClienteNavigation { get; set; }
        public virtual ICollection<Concepto> Conceptos { get; set; }
    }
}
