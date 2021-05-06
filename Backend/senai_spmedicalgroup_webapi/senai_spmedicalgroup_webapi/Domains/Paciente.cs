using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace senai_spmedicalgroup_webapi.Domains
{
    public partial class Paciente
    {
        public Paciente()
        {
            Consulta = new HashSet<Consultum>();
        }

        public int IdPaciente { get; set; }
        public int? Idusuario { get; set; }
        public int? Idade { get; set; }
        public string Rg { get; set; }
        //Data Annotation notifica que o campo é obrigatório
        [Required(ErrorMessage ="Insira o CPF, complete os campos obrigatórios")]
        public string Cpf { get; set; }
        public string Telefone { get; set; }
        public string Endereço { get; set; }
        public string Email { get; set; }

        public virtual Usuario IdusuarioNavigation { get; set; }
        public virtual ICollection<Consultum> Consulta { get; set; }
    }
}
