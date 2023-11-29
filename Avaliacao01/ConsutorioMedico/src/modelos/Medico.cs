namespace Modelos;
public class Medico: Pessoa
{
    public String Crm { get; set; } = "";

    public void imprimirMedicos(Medico medicos){
        Console.WriteLine("Nome: " + medicos.Nome);
        Console.WriteLine("Cpf: " + medicos.Cpf);
        Console.WriteLine("Data de Nascimento: " + medicos.DataNascimento);
        Console.WriteLine("CRM: " + medicos.Crm);
    }

}
