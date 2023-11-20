namespace gerenciadorTarefas;
using tarefa;
public class GerenciarTarefas
{
    List<Tarefa> tarefas = new List<Tarefa>();

    public List<Tarefa> Tarefas { get => tarefas; }

    public void CadastrarTarefa()
    {
        Console.Clear();
        Console.WriteLine("####### Cadastrar Tarefa #######\n");

        Tarefa tarefa = new Tarefa();
        try
        {
            Console.Write("Título: ");
            tarefa.Titulo = Console.ReadLine();
            Console.Write("Descrição: ");
            tarefa.Descricao = Console.ReadLine();
            Console.Write("Data de Vencimento (dd/MM/yyyy): ");

            tarefa.Data_Vencimento = DateTime.ParseExact(Console.ReadLine()!, "dd/MM/yyyy", null);
            tarefas.Add(tarefa);
        }
        catch (Exception)
        {
            try
            {
                Console.WriteLine("Algum dado foi inserido de forma incorreta, tente novamente!");
                Console.WriteLine("Caso queira cancelar, digite 0 para voltar ao menu principal: ");
                if (int.Parse(Console.ReadLine()!) == 0)
                    return;
                CadastrarTarefa();
            }
            catch (Exception)
            {
                CadastrarTarefa();
            }
        }
    }
    public int qtd_TarefasPendentes()
    {
        int qtd = 0;
        foreach (Tarefa tarefa in tarefas)
        {
            if (!tarefa.Status)
            {
                qtd++;
            }
        }
        return qtd;
    }

    public int qtd_TarefasConcluidas()
    {
        int qtd = 0;
        foreach (Tarefa tarefa in tarefas)
        {
            if (tarefa.Status)
            {
                qtd++;
            }
        }
        return qtd;
    }

    public void ListarTarefasPendentes()
    {
        try
        {
            Console.Clear();
            Console.WriteLine("###### Lista de Tarefas pendentes #####\n");
            Console.WriteLine("###### Tarefas pendentes #####\n");
            Console.WriteLine("Quantidade de tarefas pendentes: " + qtd_TarefasPendentes());
            Console.WriteLine("\n");
            foreach (Tarefa tarefa in tarefas)
            {
                if (!tarefa.Status)
                {
                    tarefa.Visualizar();
                    Console.WriteLine("\n---------------------------------\n");
                }
            }
        }
        catch (Exception)
        {
            Console.WriteLine("Lista de tarefas pendentes vazia!");
        }
    }

    public void ListarTarefasConcluidas()
    {
        try
        {
            Console.Clear();
            Console.WriteLine("###### Lista de Tarefas concluídas #####\n");
            Console.WriteLine("###### Tarefas concluídas #####\n");
            Console.WriteLine("Quantidade de tarefas concluídas: " + qtd_TarefasConcluidas());
            Console.WriteLine("\n");
            foreach (Tarefa tarefa in tarefas)
            {
                if (tarefa.Status)
                {
                    tarefa.Visualizar();
                    Console.WriteLine("\n---------------------------------\n");
                }
            }
        }
        catch (Exception)
        {
            Console.WriteLine("Lista de tarefas concluídas vazia!");
        }
    }

    public void ListarTarefas()
    {
        try
        {
            Console.Clear();
            Console.WriteLine("###### Estatísticas das Tarefas #####\n");
            Console.WriteLine("Quantidade de tarefas: " + tarefas.Count);
            Console.WriteLine("Quantidade de tarefas pendentes: " + qtd_TarefasPendentes());
            Console.WriteLine("Quantidade de tarefas concluídas: " + qtd_TarefasConcluidas());
            Console.WriteLine("Tarefas mais antigas: " + tarefas[0].Titulo);
            Console.WriteLine("Tarefas mais recentes: " + tarefas[tarefas.Count - 1].Titulo);
            Console.WriteLine("\nTodas as tarefas:\n");
            foreach (Tarefa tarefa in tarefas)
            {
                tarefa.Visualizar();
                Console.WriteLine("\n---------------------------------\n");
            }
        }
        catch (Exception)
        {
            Console.WriteLine("Lista de tarefas vazia!!");
        }
    }

    public int BuscarTarefa()
    {
        try
        {
            if (tarefas.Count > 0)
            {
                Console.Clear();
                Console.WriteLine("Qual tarefa deseja buscar?");
                Console.Write("Título da tarefa: ");
                string? str = Console.ReadLine();
                if (!string.IsNullOrEmpty(str))
                {

                    foreach (Tarefa tarefa in tarefas)
                    {
                        if (tarefa.Titulo!.Equals(str))
                        {
                            Console.WriteLine("\n---------------------------------");
                            tarefa.Visualizar();
                            Console.WriteLine("\n---------------------------------");
                            Console.WriteLine("É sua tarefa?(s/n)");
                            if (Console.ReadLine()!.Equals("s"))
                                return tarefas.IndexOf(tarefa);
                            else
                            {
                                Console.WriteLine("Deseja Tentar novamente? se desejar aperte enter\nCaso não desejar, digite 0 para voltar ao menu anterior: ");
                                if (int.Parse(Console.ReadLine()!) != 0)
                                {
                                    BuscarTarefa();
                                }
                                else return -2;
                            }
                        }
                    }

                }
            }
            else return -3;
        }
        catch (Exception)
        {
            try
            {
                Console.WriteLine("Algo deu errado!");
                Console.WriteLine("Deseja Tentar novamente? Caso queira cancelar, digite 0 para voltar ao menu principal: ");
                if (int.Parse(Console.ReadLine()!) != 0)
                {
                    BuscarTarefa();
                }
            }
            catch (Exception) { BuscarTarefa(); }
        }
        return -1;
    }

    public void ExcluirTarefa()
    {
        int index = BuscarTarefa();
        if (index == -1)
        {
            Console.WriteLine("Tarefa não encontrada!");
        }
        else if (index == -2)
            Console.WriteLine("Desitiu!!");
        else if (index == -3)
            Console.WriteLine("Lista de tarefas vazia!!");
        else
        {
            try
            {
                Console.Clear();
                tarefas[index].Visualizar();
                Console.WriteLine("Tem certeza que deseja excluir?(s/n)");
                if (Console.ReadLine()!.Equals("s"))
                    tarefas.RemoveAt(index);
                else
                {
                    Console.WriteLine("Desitiu!!");
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Algo deu errado! Tente novamente !!.");
            }
        }

    }
}
