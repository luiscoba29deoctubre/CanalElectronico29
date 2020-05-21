using System;
using System.Collections.Generic;

namespace CanalElectronico29.Models
{
    public partial class Tposmovimientosdenarius
    {
        public int Id { get; set; }
        public DateTime Ftransaccion { get; set; }
        public decimal? Convenio { get; set; }
        public string Cestado { get; set; }
        public string Mid { get; set; }
        public string Numerotransaccion { get; set; }
        public string Numeroaprobacion { get; set; }
        public decimal? Valortransaccion { get; set; }
        public DateTime? Fcompensacion { get; set; }
    }
}
