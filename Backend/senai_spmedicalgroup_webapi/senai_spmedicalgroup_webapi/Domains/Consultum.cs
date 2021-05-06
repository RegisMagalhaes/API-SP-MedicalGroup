using System;
using System.Collections.Generic;

#nullable disable

namespace senai_spmedicalgroup_webapi.Domains
{
    public partial class Consultum
    {
        public int Idconsulta { get; set; }
        public int? Idmedico { get; set; }
        public int? Idpaciente { get; set; }
        public int? Idsituacao { get; set; }
        public DateTime? DataConsulta { get; set; }
        public string Medico { get; set; }
        public string Prontuario { get; set; }
        public string Situacao { get; set; }

        public virtual Medico IdmedicoNavigation { get; set; }
        public virtual Paciente IdpacienteNavigation { get; set; }
        public virtual Situacao IdsituacaoNavigation { get; set; }
    }
}
