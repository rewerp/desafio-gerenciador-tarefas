using GerenciadorTarefas.Communication.Requests;
using GerenciadorTarefas.Communication.Responses;

namespace GerenciadorTarefas.Application.UseCases.Tarefa;

public class CreateTarefaUseCase
{
  public ResponseTarefaJson Execute(RequestTarefaJson request)
  {
    return new ResponseTarefaJson
    {
      Id = 1,
      Nome = request.Nome,
      Descricao = request.Descricao,
      Prioridade = request.Prioridade,
      DataPrazo = request.DataPrazo,
      Status = request.Status
    };
  }
}
