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
            Paciente pacienteBuscado = BuscarPorId(id);

            if (novoPacienteAtual.Cpf != null)
            {
                pacienteBuscado.Cpf = novoPacienteAtual.Cpf;
            }
            ctx.Pacientes.Update(pacienteBuscado);

            ctx.SaveChanges();
        }

        public Paciente BuscarPorId(int id)
        {
            return ctx.Pacientes.FirstOrDefault(esp => esp.IdPaciente == id);
        }

        public void Cadastrar(Paciente novoPaciente)
        {
            ctx.Pacientes.Add(novoPaciente);

            ctx.SaveChanges();
        }

        public void Deletar(int id)
        {
            Paciente pacienteBuscado = BuscarPorId(id);

            ctx.Pacientes.Remove(pacienteBuscado);

            ctx.SaveChanges();
        }

        public List<Paciente> ListarTodos()
        {
            return ctx.Pacientes.ToList();

        }
    }
}
