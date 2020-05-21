using System;
using System.Collections.Generic;

namespace CanalElectronico29.Models
{
    public partial class Vposcompensacabecera
    {
        public int Id { get; set; }
        public DateTime Fproceso { get; set; }
        public int Convenio { get; set; }
        public string Nombre { get; set; }
        public DateTime? Fautorizacion { get; set; }
        public string Cusuarioautorizacion { get; set; }
        public string Usuarioautorizacion { get; set; }
        public string Error { get; set; }
        public string Transferencia { get; set; }
        public string Comision { get; set; }
        public string Retencionfte { get; set; }
        public string Retencioniva { get; set; }
        public string Cestado { get; set; }
        public string Estado { get; set; }
        public int? Registros { get; set; }
        public int? Compensados { get; set; }
        public int? Rechazados { get; set; }
        public decimal Totaltransaccion { get; set; }
        public decimal Totalliquidado { get; set; }
        public decimal Totalcomision { get; set; }
        public decimal Totalivacomision { get; set; }
        public decimal Totalretencionfte { get; set; }
        public decimal Totalretencioniva { get; set; }
    }
}
