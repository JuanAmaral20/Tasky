using System.Diagnostics;
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
    public IActionResult Index()
    {
        return View();
    }

    [HttpPost]
    public async Task<IActionResult> CriarTarefas([FromBody]Tarefa tarefa)
    {
            
            await _tarefaRepository.CriarTarefa(tarefa);
            return Ok();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
