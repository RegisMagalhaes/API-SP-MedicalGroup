using senai_spmedicalgroup_webapi.Contexts;
using senai_spmedicalgroup_webapi.Domains;
using senai_spmedicalgroup_webapi.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai_spmedicalgroup_webapi.Repositories
{
    public class EspecialidadeRepository : IEspecialidadeRepository
    {
        spmedicalgroupContext ctx = new spmedicalgroupContext();
        public void Atualizar(int id, Especialidade novaEspecialidadeAtual)
        {
            Especialidade especialidadeBuscada = BuscarPorId(id);

            if (novaEspecialidadeAtual.NomeEspecialidade != null)
            {
                especialidadeBuscada.NomeEspecialidade = novaEspecialidadeAtual.NomeEspecialidade;
            }

            ctx.Especialidades.Update(especialidadeBuscada);

            ctx.SaveChanges();
        }

        public Especialidade BuscarPorId(int id)
        {
            return ctx.Especialidades.FirstOrDefault(esp => esp.IdEspecialidade==id);
        }

        public void Cadastrar(Especialidade novaEspecialidade)
        {
            ctx.Especialidades.Add(novaEspecialidade);

            ctx.SaveChanges();
        }

        public void Deletar(int id)
        {
            Especialidade especialidadeBuscada = BuscarPorId(id);

            ctx.Especialidades.Remove(especialidadeBuscada);

            ctx.SaveChanges();
        }

        public List<Especialidade> ListaTodas()
        {
            return ctx.Especialidades.ToList();
        }
    }
}
