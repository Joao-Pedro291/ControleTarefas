
namespace ControleTarefas;

internal class GerenciadorDeTarefas
{
    List<Tarefa> _tarefas = new List<Tarefa>();
    public void AdicionarTarefa()
    {
        Console.WriteLine("Digite o titulo da sua tarefa");
        var titulo = Console.ReadLine()!;
        var tarefa = new Tarefa(titulo);
        _tarefas.Add(new Tarefa(titulo));
        Console.WriteLine($"Tarefa {tarefa.Titulo} criada com sucesso");
    }

    public void ListarTarefas()
    {
        foreach (var tarefa in _tarefas)
        {
            Console.WriteLine(tarefa.Titulo);
        }
    }
}
