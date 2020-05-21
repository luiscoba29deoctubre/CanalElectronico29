using System;
using System.Collections.Generic;

namespace CanalElectronico29.Models
{
    public partial class Tusuario
    {
        public Tusuario()
        {
            Tusuariohistorico = new HashSet<Tusuariohistorico>();
        }

        public int Idcodigo { get; set; }
        public string Usuario { get; set; }
        public string Estado { get; set; }
        public string Tipo { get; set; }
        public int Idcliente { get; set; }
        public int Intento { get; set; }
        public string Contrasenia { get; set; }
        public DateTime? Fcaducidadpassword { get; set; }
        public DateTime Fhasta { get; set; }
        public DateTime Fdesde { get; set; }

        public virtual ICollection<Tusuariohistorico> Tusuariohistorico { get; set; }
    }
}
