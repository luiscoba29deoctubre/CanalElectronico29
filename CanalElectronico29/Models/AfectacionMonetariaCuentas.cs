using System;
using System.Collections.Generic;

namespace CanalElectronico29.Models
{
    public partial class AfectacionMonetariaCuentas
    {
        public string FechaHistorico { get; set; }
        public int IdAfectacionMonetaria { get; set; }
        public DateTime FechaRegistro { get; set; }
        public string FechaProceso { get; set; }
        public string Usuario { get; set; }
        public short IdSucursal { get; set; }
        public string TipoLog { get; set; }
        public int IdTransaccionLog { get; set; }
        public byte? SecuencialLog { get; set; }
        public bool Reverso { get; set; }
        public bool Reversada { get; set; }
        public bool? Inconsistencia { get; set; }
        public int IdTransaccion { get; set; }
        public int IdTransaccionContable { get; set; }
        public short IdCausal { get; set; }
        public int? IdOficial { get; set; }
        public short IdOficinaOrigen { get; set; }
        public short IdOficinaDestino { get; set; }
        public short IdAreaOrigen { get; set; }
        public short IdAreaDestino { get; set; }
        public string EstadoCuenta { get; set; }
        public byte IdMoneda { get; set; }
        public byte? IdProducto { get; set; }
        public decimal? MontoMn { get; set; }
        public decimal? SaldoContable { get; set; }
        public decimal? SaldoDisponible { get; set; }
        public decimal MontoTotal { get; set; }
        public decimal? Efectivo { get; set; }
        public decimal? PorEfectivizar { get; set; }
        public int? IdCuenta { get; set; }
        public string NumeroCuenta { get; set; }
        public string Referencia { get; set; }
        public string Referencia2 { get; set; }
        public int? Idcomprobante { get; set; }
        public string SufijoCuenta { get; set; }
    }
}
