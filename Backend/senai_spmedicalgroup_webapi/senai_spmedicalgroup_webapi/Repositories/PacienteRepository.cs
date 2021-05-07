using senai_spmedicalgroup_webapi.Contexts;
using senai_spmedicalgroup_webapi.Domains;
using senai_spmedicalgroup_webapi.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai_spmedicalgroup_webapi.Repositories
{
    public class PacienteRepository : IPacienteRepository
    {
        spmedicalgroupContext ctx = new spmedicalgroupContext();
        public void Atualizar(int id, Paciente novoPacienteAtual)
        {
            throw new NotImplementedException();
        }

        public Paciente BuscarPorId(int id)
        {
            throw new NotImplementedException();
        }

        public void Cadastrar(Paciente novoPaciente)
        {
            throw new NotImplementedException();
        }

        public void Deletar(int id)
        {
            throw new NotImplementedException();
        }

        public List<Paciente> ListarTodos()
        {
            throw new NotImplementedException();
        }
    }
}
