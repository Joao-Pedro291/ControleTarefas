public class Tarefa
{
    public string Titulo { get; set; }
    public bool Concluida { get; set; }

    public Tarefa(string titulo)
    {
        Titulo = titulo;
        Concluida = false;
    }
}