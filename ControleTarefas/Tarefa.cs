namespace ControleTarefas;

internal class Tarefa
{
    public Tarefa(string titulo, bool concluida)
    {
        Titulo = titulo;
        Concluida = false;
    }

    public string? Titulo { get; set; }
    public bool Concluida { get; set; }

}
    