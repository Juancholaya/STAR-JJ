﻿using System;
using System.Collections.Generic;

namespace Muebles_JJ.Core.Domain
{
    public partial class Telefono
    {
        public int IdTelefono { get; set; }
        public string Tipo { get; set; }
        public int? Numero { get; set; }
        public int? Extension { get; set; }
        public int? IdUsuarioFk { get; set; }

        public virtual Usuario IdUsuarioFkNavigation { get; set; }
    }
}
