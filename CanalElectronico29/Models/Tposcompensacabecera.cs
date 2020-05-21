using System;
using System.Collections.Generic;

namespace CanalElectronico29.Models
{
    public partial class Tposcompensacabecera
    {
        public Tposcompensacabecera()
        {
            Tposcompensadetalle = new HashSet<Tposcompensadetalle>();
        }

        public int Id { get; set; }
        public int? Idconvenio { get; set; }
        public DateTime Fproceso { get; set; }
        public int Convenio { get; set; }
        public string Cestado { get; set; }
        public DateTime? Fautorizacion { get; set; }
        public string Cusuarioautorizacion { get; set; }
        public string Transferencia { get; set; }
        public string Comision { get; set; }
        public string Retencionfte { get; set; }
        public string Retencioniva { get; set; }
        public string Error { get; set; }

        public virtual Tposconvenio IdconvenioNavigation { get; set; }
        public virtual ICollection<Tposcompensadetalle> Tposcompensadetalle { get; set; }
    }
}
