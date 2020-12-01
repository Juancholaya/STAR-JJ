using System;
using System.Collections.Generic;

namespace Muebles_JJ.Core.Domain
{
    public partial class ComprobantePago
    {
        public int IdComprobante { get; set; }
        public int? IdVentaFk { get; set; }
        public DateTime Fecha { get;set; }

        public virtual Venta IdVentaFkNavigation { get; set; }
    }
}
