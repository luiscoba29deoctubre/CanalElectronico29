using System;
using System.Collections.Generic;

namespace CanalElectronico29.Models
{
    public partial class Tusuariohistorico
    {
        public int Idcodigohistorico { get; set; }
        public int? Idcodigo { get; set; }
        public string Descripcion { get; set; }
        public DateTime? Fechareal { get; set; }
        public string Respuesta { get; set; }

        public virtual Tusuario IdcodigoNavigation { get; set; }
    }
}
