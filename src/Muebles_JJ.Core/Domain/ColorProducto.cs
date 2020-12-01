using System;
using System.Collections.Generic;

namespace Muebles_JJ.Core.Domain
{
    public partial class ColorProducto
    {
        public ColorProducto()
        {
            Producto = new HashSet<Producto>();
        }

        public int ID_Color { get; set; }
        public string Nombre { get; set; }

        public virtual ICollection<Producto> Producto { get; set; }
    }
}
