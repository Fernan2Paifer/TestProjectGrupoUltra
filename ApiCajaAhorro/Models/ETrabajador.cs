using System;
using System.Collections.Generic;

namespace ApiCajaAhorro.Models
    {
    public partial class ETrabajador
        {
        public ETrabajador()
            {
            EAhorro = new HashSet<EAhorro>();
            EPrestamo = new HashSet<EPrestamo>();
            }

        public int IdTrabajador { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public int? MontoAinicial { get; set; }
        public DateTime? FechaInicioRl { get; set; }
        public bool? Inscrito { get; set; }
        public string FkUser { get; set; }

        public AspNetUsers FkUserNavigation { get; set; }
        public ICollection<EAhorro> EAhorro { get; set; }
        public ICollection<EPrestamo> EPrestamo { get; set; }
        }
    }
