using System;
using System.Collections.Generic;

namespace CanalElectronico29.Models
{
    public partial class Tswterminalespos
    {
        public int Id { get; set; }
        public int? Idconvenio { get; set; }
        public int Convenio { get; set; }
        public string Mid { get; set; }
        public string Codigoalterno { get; set; }
        public string Nombre { get; set; }
        public string Ctacontable { get; set; }
        public string Direccion { get; set; }
        public string Ciudad { get; set; }
        public string Estado { get; set; }

        public virtual Tposconvenio IdconvenioNavigation { get; set; }
    }
}
