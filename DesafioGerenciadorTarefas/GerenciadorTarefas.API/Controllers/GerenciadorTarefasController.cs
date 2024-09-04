using GerenciadorTarefas.Application.UseCases.Tarefa;
using GerenciadorTarefas.Communication.Requests;
using GerenciadorTarefas.Communication.Responses;
using Microsoft.AspNetCore.Mvc;

namespace GerenciadorTarefas.API.Controllers;
[Route("api/[controller]")]
[ApiController]
public class GerenciadorTarefasController : ControllerBase
{
  [HttpPost]
  [ProducesResponseType(typeof(ResponseTarefaJson), StatusCodes.Status201Created)]
  [ProducesResponseType(typeof(ResponseErrorsJson), StatusCodes.Status400BadRequest)]
  public IActionResult Create([FromBody] RequestTarefaJson request)
  {
    var response = new CreateTarefaUseCase().Execute(request);
    return Created(string.Empty, response);
  }

  [HttpPut]
  [Route("{id}")]
  [ProducesResponseType(StatusCodes.Status200OK)]
  [ProducesResponseType(typeof(ResponseErrorsJson), StatusCodes.Status400BadRequest)]
  public IActionResult Update([FromRoute] int id, [FromBody] RequestTarefaJson request)
  {
    var response = new UpdateTarefaUserCase().Execute(id, request);
    return Ok(response);
  }

  [HttpDelete]
  [Route("{id}")]
  [ProducesResponseType(StatusCodes.Status200OK)]
  [ProducesResponseType(typeof(ResponseErrorsJson), StatusCodes.Status400BadRequest)]
  public IActionResult Delete([FromRoute] int id)
  {
    var response = new DeleteTarefaUserCase().Execute(id);
    return Ok(response);
  }

  [HttpGet]
  [ProducesResponseType(typeof(ResponseAllTarefaJson), StatusCodes.Status200OK)]
  [ProducesResponseType(typeof(ResponseErrorsJson), StatusCodes.Status400BadRequest)]
  [ProducesResponseType(StatusCodes.Status404NotFound)]
  public IActionResult GetAll()
  {
    var response = new GetAllTarefaUserCase().Execute();
    return Ok(response);
  }

  [HttpGet]
  [Route("{id}")]
  [ProducesResponseType(typeof(ResponseTarefaJson), StatusCodes.Status200OK)]
  [ProducesResponseType(typeof(ResponseErrorsJson), StatusCodes.Status400BadRequest)]
  [ProducesResponseType(StatusCodes.Status404NotFound)]
  public IActionResult GetById([FromRoute] int id)
  {
    var response = new GetByIdTarefaUserCase().Execute(id);
    return Ok(response);
  }
}
