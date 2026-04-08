
namespace ControleTarefas;

internal class GerenciadorDeTarefas
{
    List<Tarefa> _tarefas = new List<Tarefa>();
    public void AdicionarTarefa()
    {
        Console.WriteLine("Digite o titulo da sua tarefa");
        var titulo = Console.ReadLine()!;
        var tarefa = new Tarefa(titulo);
        _tarefas.Add(tarefa);
        Console.WriteLine($"Tarefa {tarefa.Titulo} criada com sucesso");
    }

    public void ListarTarefas()
    {
        foreach (var tarefa in _tarefas)
        {
            var status = tarefa.Concluida ? "[X]" : "[ ]";
            Console.WriteLine($"{tarefa.Titulo} {status}");   
        }
    }

    public void MarcarComoConcluida()
    {
        Console.WriteLine("Digite o nome da tarefa que deseja marcar como concluida: ");
        var tarefaEscolhida = Console.ReadLine()!;
        foreach (var tarefa in _tarefas)
        {
            if (tarefa.Titulo == tarefaEscolhida)
            {
                tarefa.Concluida = true;
            }
        }
    }
}
