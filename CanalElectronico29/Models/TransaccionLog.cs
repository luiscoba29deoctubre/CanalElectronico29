using System;
using System.Collections.Generic;

namespace CanalElectronico29.Models
{
    public partial class TransaccionLog
    {
        public int IdTransaccionLog { get; set; }
        public DateTime? FechaRegistro { get; set; }
        public DateTime? FechaFinal { get; set; }
        public string Aplicacion { get; set; }
        public string ServicioWeb { get; set; }
        public string Mensaje { get; set; }
        public string Correlacion { get; set; }
    }
}
