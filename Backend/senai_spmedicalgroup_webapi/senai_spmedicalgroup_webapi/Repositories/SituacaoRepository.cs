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
            Situacao situacaoBuscada = BuscarPorId(id);

            if (novaSituacaoAtual.Situacao1 != null)
            {
                situacaoBuscada.Situacao1 = novaSituacaoAtual.Situacao1;
            }
            ctx.Situacaos.Update(situacaoBuscada);

            ctx.SaveChanges();
        }

        public Situacao BuscarPorId(int id)
        {
            return ctx.Situacaos.FirstOrDefault(esp => esp.Idsituacao == id);
        }

        public void Cadastrar(Situacao novaSituacao)
        {
            ctx.Situacaos.Add(novaSituacao);

            ctx.SaveChanges();
        }

        public void Deletar(int id)
        {
            Situacao situacaoBuscada = BuscarPorId(id);

            ctx.Situacaos.Remove(situacaoBuscada);

            ctx.SaveChanges();

        }

        public List<Situacao> Listar()
        {
            return ctx.Situacaos.ToList();
        }
    }
}
