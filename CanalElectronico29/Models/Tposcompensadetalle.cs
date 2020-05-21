using System;
using System.Collections.Generic;

namespace CanalElectronico29.Models
{
    public partial class Tposcompensadetalle
    {
        public int Id { get; set; }
        public int? Idcompensacabecera { get; set; }
        public DateTime Fproceso { get; set; }
        public int Convenio { get; set; }
        public decimal Secuencia { get; set; }
        public string Cestado { get; set; }
        public string Cerror { get; set; }
        public string Archivo { get; set; }
        public string Mid { get; set; }
        public string Terminal { get; set; }
        public string Tarjeta { get; set; }
        public string Ccuenta { get; set; }
        public DateTime? Ftransaccion { get; set; }
        public DateTime? Fcarga { get; set; }
        public DateTime? Fcompensacion { get; set; }
        public string Lote { get; set; }
        public string Numerotransaccion { get; set; }
        public string Numeroaprobacion { get; set; }
        public decimal? Valorliquidado { get; set; }
        public decimal? Valortransaccion { get; set; }
        public decimal? Valoriva { get; set; }
        public decimal? Valortarifa0 { get; set; }
        public decimal? Valortarifaiva { get; set; }
        public decimal? Valorcomision { get; set; }
        public decimal? Valorivacomision { get; set; }
        public decimal? Valorretencionfuente { get; set; }
        public decimal? Valorretencioniva { get; set; }
        public string Derror { get; set; }
        public string Linea { get; set; }
        public string Numeromensaje { get; set; }

        public virtual Tposcompensacabecera IdcompensacabeceraNavigation { get; set; }
    }
}
