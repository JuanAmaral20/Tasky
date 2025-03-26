using System.Diagnostics;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using to_do_list.Models;
using to_do_list.Repository;

namespace to_do_list.Controllers;

public class HomeController : Controller
{
    private readonly TarefaRepository _tarefaRepository;

    public HomeController(TarefaRepository tarefaRepository)
    {
        _tarefaRepository = tarefaRepository;
    }
    public async Task<IActionResult> Index()
    {
        var tarefas = await _tarefaRepository.ListarTarefas();

        return View(tarefas);
    }

    [HttpPost]
    public async Task<IActionResult> CriarTarefas([FromBody]Tarefa tarefa)
    {
            
            await _tarefaRepository.CriarTarefa(tarefa);
            return Ok();
    }

    [HttpPost("{tarefaId}/remover")]

    public async Task<IActionResult> ApagarTarefa(int TarefaId)
    {
        var tarefa = await _tarefaRepository.ApagarTarefa(TarefaId);
        return Ok(tarefa);
    }

    [HttpPost("{tarefaId}/alternar-conclusao")]
    public async Task<IActionResult> AlternarConclusao(int tarefaId)
    {
        var tarefa = await _tarefaRepository.AlternarConclusao(tarefaId);
        return Ok(tarefa);
    }

    [HttpPost("{tarefaId}/editar")]
    public async Task<IActionResult> EditarTarefa(int tarefaId, Tarefa tarefa)
    {
        await _tarefaRepository.EditarTarefa(tarefaId, tarefa);
        return Ok();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
