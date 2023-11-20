namespace tarefa;

public class Tarefa
{
    string titulo;
    string descricao;
    DateTime data_Vencimento;
    bool status;

    public Tarefa(string titulo, string descricao, DateTime data_Vencimento)
    {
        this.titulo = titulo;
        this.descricao = descricao;
        this.data_Vencimento = data_Vencimento;
        this.status = false;
    }

    public Tarefa()
    {
        this.titulo = "";
        this.descricao = "";
        this.status = false;
    }
    public string? Titulo { 
        get {return this.titulo;}
        set {this.titulo = value!;}
    }
    public string? Descricao {
        get {return this.descricao;}
        set {this.descricao = value!;}
    }

    public DateTime Data_Vencimento {
        get {return this.data_Vencimento;}
        set {this.data_Vencimento = value;}
    }

    public bool Status { 
        get { return this.status; }
        set { this.status = value; }
    }

    public void Visualizar()
    {
        Console.WriteLine("Titulo: " + this.titulo);
        Console.WriteLine("Descrição: " + this.descricao);
        Console.WriteLine("Data de Vencimento: " + this.data_Vencimento.ToString("dd/MM/yyyy"));
        Console.WriteLine("Status: " + (this.status ? "Concluido" : "Pendente"));
    }
}
