using GerenciadorTarefas.Communication.Responses;

namespace GerenciadorTarefas.Application.UseCases.Tarefa;

public class GetByIdTarefaUserCase
{
  public ResponseTarefaJson Execute(int id)
  {
    return new ResponseTarefaJson
    {
      Id = id,
      Nome = "Teste",
      Descricao = "Teste de tarefa",
      Prioridade = Communication.Enums.EnumPrioridade.Media,
      DataPrazo = DateTime.Now,
      Status = Communication.Enums.EnumStatus.Pendente
    };
  }
}
