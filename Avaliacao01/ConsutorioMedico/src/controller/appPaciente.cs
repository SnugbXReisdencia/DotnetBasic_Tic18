namespace Controller;
using Modelos;
public class AppPaciente
{
    public static void  criarPaciente(List<Paciente> pacientes){
        var paciente = new Paciente();
        var xx  = true;
        try{
            Console.WriteLine("Digite o nome do paciente");
            paciente.Nome = Console.ReadLine()!;
        }catch(Exception){
            Console.WriteLine("Nome invalido");
            return;
        }
        try{
            Console.WriteLine("Digite o cpf do paciente");
            var Cpf = Console.ReadLine()!;
            pacientes.ForEach(x => {
                if(x.Cpf == Cpf){
                    Console.WriteLine("Cpf ja existe");
                    xx= false;
                }
            });
            if(xx){
                paciente.Cpf = Cpf;
            }else{
                return;
            }
        }catch(Exception){
            Console.WriteLine("CPF informado invalido");
            return;
        }
        try{
            Console.WriteLine("Digite a data de nascimento do paciente (dd/MM/yyyy): ");
            paciente.DataNascimento = DateTime.Parse(Console.ReadLine()!);
        }catch(Exception){
            Console.WriteLine("Data de nascimento invalida");
            return;
        }

        try{
            Console.WriteLine("Digite o Sexo do paciente");
            paciente.Sexo = Console.ReadLine()!;
        }catch(Exception){
            Console.WriteLine("Sexo invalido");
            return;
        }
        try{
            Console.WriteLine("Digite o sintoma do paciente");
            paciente.Sintoma = Console.ReadLine()!;
        }catch(Exception){
            Console.WriteLine("Sintoma invalido");
            return;
        }
        pacientes.Add(paciente);
    }

    public void imprimirPacientes(Paciente pacientes){
        Console.WriteLine("Nome: " + pacientes.Nome);
        Console.WriteLine("Cpf: " + pacientes.Cpf);
        Console.WriteLine("Data de Nascimento: " + pacientes.DataNascimento);
        Console.WriteLine("Sexo: " + pacientes.Sexo);
        Console.WriteLine("Sintoma: " + pacientes.Sintoma);
    }
}
