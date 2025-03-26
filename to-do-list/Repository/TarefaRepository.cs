using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using to_do_list.Data;
using to_do_list.Models;

namespace to_do_list.Repository
{
    public class TarefaRepository
    {
        private readonly AppDbContext _context;

        public TarefaRepository(AppDbContext context)
        {
            _context = context;
        }
    
        public async Task CriarTarefa(Tarefa tarefa)
        {
            await _context.Tarefas.AddAsync(tarefa);
            await _context.SaveChangesAsync();
        }

        public async Task<List<Tarefa>> ListarTarefas()
        {
            return await _context.Tarefas.ToListAsync();
        }

        public async Task<Tarefa> ApagarTarefa(int TarefaId)
        {
            var tarefa = await _context.Tarefas.FindAsync(TarefaId);
            _context.Tarefas.Remove(tarefa);
            await _context.SaveChangesAsync();
            return tarefa;
        }

       public async Task<Tarefa> AlternarConclusao(int tarefaId)
        {
            var tarefa = await _context.Tarefas.FindAsync(tarefaId);

            if (tarefa == null)
                throw new Exception("Tarefa não encontrada!");

            tarefa.Concluida = !tarefa.Concluida;

            _context.Tarefas.Update(tarefa);
            await _context.SaveChangesAsync();

            return tarefa;
        }
        public async Task EditarTarefa(int tarefaId, Tarefa tarefa)
        {
            var tarefaDb = await _context.Tarefas.FindAsync(tarefaId);
            tarefaDb.Descricao = tarefa.Descricao;
            tarefaDb.Urgencia = tarefa.Urgencia;

            _context.Tarefas.Update(tarefaDb);
            await _context.SaveChangesAsync();
        }
    }
}