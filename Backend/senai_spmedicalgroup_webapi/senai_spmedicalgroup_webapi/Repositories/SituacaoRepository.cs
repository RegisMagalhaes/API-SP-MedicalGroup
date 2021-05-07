using senai_spmedicalgroup_webapi.Contexts;
using senai_spmedicalgroup_webapi.Domains;
using senai_spmedicalgroup_webapi.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai_spmedicalgroup_webapi.Repositories
{
    public class SituacaoRepository : ISituacaoRepository
    {
        spmedicalgroupContext ctx = new spmedicalgroupContext();
        public void Atualizar(int id, Situacao novaSituacaoAtual)
        {
            throw new NotImplementedException();
        }

        public Situacao BuscarPorId(int id)
        {
            throw new NotImplementedException();
        }

        public void Cadastrar(Situacao novaSituacao)
        {
            throw new NotImplementedException();
        }

        public void Deletar(int id)
        {
            throw new NotImplementedException();
        }

        public List<Situacao> Listar()
        {
            throw new NotImplementedException();
        }
    }
}
