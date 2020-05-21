using System;
using System.Collections.Generic;

namespace CanalElectronico29.Models
{
    public partial class Vposconvenio
    {
        public decimal Convenio { get; set; }
        public string Identificacion { get; set; }
        public string Nombre { get; set; }
        public string Compensa { get; set; }
        public string Notifica { get; set; }
        public decimal Comision { get; set; }
        public string Archivoorigen { get; set; }
        public string Archivoretrono { get; set; }
        public string Notificatipo { get; set; }
        public string Notificaparametros { get; set; }
        public string Tipoliquidacion { get; set; }
        public string Tipopago { get; set; }
        public string Cuentadebito { get; set; }
        public string Cuentacredito { get; set; }
        public string Cuentacreditotipo { get; set; }
        public decimal Cuentacreditobanco { get; set; }
        public string Cuentacreditobanconombre { get; set; }
        public string Cuentacreditobancobce { get; set; }
        public decimal Existearchivo { get; set; }
        public string Comandocalculo { get; set; }
        public string Comandotransaccion { get; set; }
        public string Comandoarchivo { get; set; }
    }
}
