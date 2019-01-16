using System;
using System.Collections.Generic;

namespace ApiCajaAhorro.Models
{
    public partial class EPrestamo
    {
        public int IdPrestamo { get; set; }
        public int? Monto { get; set; }
        public DateTime? Fecha { get; set; }
        public int? FkTrabajador { get; set; }

        public ETrabajador FkTrabajadorNavigation { get; set; }
    }
}
