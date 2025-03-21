using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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
    
    }
}