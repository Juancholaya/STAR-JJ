﻿using System;
using System.Collections.Generic;

namespace Muebles_JJ.Core.Domain
{
    public partial class Pedido
    {
        public int IdPedido { get; set; }
        public string DireccionEntrega { get; set; }
        public int? IdVentaFk { get; set; }
        public DateTime Fecha_Entrega { get; set; }

        public virtual Venta IdVentaFkNavigation { get; set; }
    }
}
