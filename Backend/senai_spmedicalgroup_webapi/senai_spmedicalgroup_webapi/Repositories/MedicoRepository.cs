using senai_spmedicalgroup_webapi.Contexts;
using senai_spmedicalgroup_webapi.Domains;
using senai_spmedicalgroup_webapi.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai_spmedicalgroup_webapi.Repositories
{
    public class MedicoRepository : IMedicoRepository
    {
        spmedicalgroupContext ctx = new spmedicalgroupContext();
        public void Atualizar(int id, Medico novoMedicoAtual)
        {
            Medico medicoBuscado = BuscarPorId(id);

            if (novoMedicoAtual.Crm != null)
            {
               medicoBuscado.Crm = novoMedicoAtual.Crm;
            }

            ctx.Medicos.Update(medicoBuscado);

            ctx.SaveChanges();
        }

        public Medico BuscarPorId(int id)
        {
            throw new NotImplementedException();
        }

        public void Cadastrar(Medico novoMedico)
        {
            throw new NotImplementedException();
        }

        public void Deletar(int id)
        {
            throw new NotImplementedException();
        }

        public List<Medico> ListarTodos()
        {
            return ctx.Medicos.ToList();
        }
    }
}
