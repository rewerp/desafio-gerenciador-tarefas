using GerenciadorTarefas.Communication.Enums;

namespace GerenciadorTarefas.Communication.Responses;

public class ResponseShortTarefaJson
{
  public int Id { get; set; }
  public string Nome { get; set; } = string.Empty;
  public EnumPrioridade Prioridade { get; set; }
  public DateTime DataPrazo { get; set; }
  public EnumStatus Status { get; set; }
}
