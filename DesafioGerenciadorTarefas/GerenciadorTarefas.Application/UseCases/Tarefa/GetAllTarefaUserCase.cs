using GerenciadorTarefas.Communication.Responses;
using System.Runtime.InteropServices;

namespace GerenciadorTarefas.Application.UseCases.Tarefa;

public class GetAllTarefaUserCase
{
  public ResponseAllTarefaJson Execute()
  {
    var lista = new ResponseAllTarefaJson();

    var tarefa1 = new ResponseShortTarefaJson
    {
      Id = 1,
      Nome = "Teste 1",
      Prioridade = Communication.Enums.EnumPrioridade.Alta,
      DataPrazo = DateTime.Now,
      Status = Communication.Enums.EnumStatus.Pendente
    };

    var tarefa2 = new ResponseShortTarefaJson
    {
      Id = 1,
      Nome = "Teste 2",
      Prioridade = Communication.Enums.EnumPrioridade.Baixa,
      DataPrazo = DateTime.Now,
      Status = Communication.Enums.EnumStatus.Concluida
    };

    lista.Tarefas.Add(tarefa1);
    lista.Tarefas.Add(tarefa2);

    return lista;
  }
}
