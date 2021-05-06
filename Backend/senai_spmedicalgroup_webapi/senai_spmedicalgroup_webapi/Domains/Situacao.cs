using System;
using System.Collections.Generic;

#nullable disable

namespace senai_spmedicalgroup_webapi.Domains
{
    public partial class Situacao
    {
        public Situacao()
        {
            Consulta = new HashSet<Consultum>();
        }

        public int Idsituacao { get; set; }
        public string Situacao1 { get; set; }

        public virtual ICollection<Consultum> Consulta { get; set; }
    }
}
