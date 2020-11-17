using System;
using System.Collections.Generic;

namespace Muebles_JJ.Web
{
    public partial class Inventario
    {
        public int IdInventario { get; set; }
        public int? IdInsumoFk { get; set; }
        public int? IdProductoFk { get; set; }
        public DateTime Fecha_Entrada { get; set; }
        public DateTime Fecha_Salida { get; set; }

        public virtual Insumo IdInsumoFkNavigation { get; set; }
        public virtual Producto IdProductoFkNavigation { get; set; }
    }
}
