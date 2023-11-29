namespace Modelos;
public class Paciente : Pessoa
{
    public String Sexo { get; set; } = "";
    public String Sintoma { get; set; } = "";

    public void imprimirPacientes(Paciente pacientes){
        Console.WriteLine("Nome: " + pacientes.Nome);
        Console.WriteLine("Cpf: " + pacientes.Cpf);
        Console.WriteLine("Data de Nascimento: " + pacientes.DataNascimento);
        Console.WriteLine("Sexo: " + pacientes.Sexo);
        Console.WriteLine("Sintoma: " + pacientes.Sintoma);
    }
}
