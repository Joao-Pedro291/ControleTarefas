using ControleTarefas;

var gerenciador = new GerenciadorDeTarefas();

while (true)
{
    Console.WriteLine("\n1 - Adicionar tarefa");
    Console.WriteLine("2 - Listar tarefas");
    Console.WriteLine("3 - Marcar tarefa como concluída");
    Console.WriteLine("0 - Sair");

    var opcao = Console.ReadLine();
    Console.Clear();

    if (opcao == "1")
    {
        gerenciador.AdicionarTarefa();
    }
    else if (opcao == "2")
    {
        gerenciador.ListarTarefas();
    }
    else if (opcao == "3")
    {
        gerenciador.MarcarComoConcluida();
    }
    else if (opcao == "0")
    {
        break;
    }
}