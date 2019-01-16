using System;

namespace ApiCajaAhorro.Models
    {
    public partial class EAhorro
        {
        public int IdAhorro { get; set; }
        public int? Monto { get; set; }
        public DateTime? Fecha { get; set; }
        public int? FkTrabajador { get; set; }

        public ETrabajador FkTrabajadorNavigation { get; set; }
        }
    }
