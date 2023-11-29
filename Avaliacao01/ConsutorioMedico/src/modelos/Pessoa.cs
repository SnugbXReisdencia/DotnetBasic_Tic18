namespace Modelos;
public class Pessoa
{
    public String Nome { get; set; } = "";
    public String Cpf { 
        get { return this.Cpf;} 
        set { 
            if (ValidarCpf(Cpf)) { this.Cpf = Cpf;}
            else { throw new Exception("Cpf invalido");} 
        }
    }

    public DateTime DataNascimento { get; set; }

    public bool ValidarCpf(string cpf)
    {
        if (string.IsNullOrEmpty(cpf)){
            return false;
        }
        if (cpf.Length != 11){
            return false;
        }
        return true;
    }
}
