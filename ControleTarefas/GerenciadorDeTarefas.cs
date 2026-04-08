
using System.Xml;
using static System.Runtime.InteropServices.JavaScript.JSType;

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
        Console.Clear();
    }

    public void ListarTarefas()
    {
        for (int i = 0; i < _tarefas.Count; i++)
        {
            var tarefa = _tarefas[i];
            var status = tarefa.Concluida ? "[X]" : "[ ]";

            Console.WriteLine($"{i + 1} - {status} {tarefa.Titulo}");
        }
    }

    public void MarcarComoConcluida()
    {
        Console.WriteLine("Digite o número da tarefa que deseja marcar como concluida: ");
        var numeroTarefaEscolhida = int.Parse( Console.ReadLine()!);
        if (numeroTarefaEscolhida > 0 && numeroTarefaEscolhida <= _tarefas.Count)
        {
        _tarefas[numeroTarefaEscolhida - 1].Concluida = true;
        }
        else
        {
            Console.WriteLine("Número inválido");
            Console.WriteLine("Digite qualquer tecla para voltar ao menu");
            Console.Read();
        }
        Console.Clear();
    }
}
