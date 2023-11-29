namespace Controller;
using Modelos;
public class AppMedico
{
    public static void  criarMedico(List<Medico> medicos){
        var medico = new Medico();
        var xx  = true;
        try{
            Console.WriteLine("Digite o nome do medico");
            medico.Nome = Console.ReadLine()!;
        }catch(Exception){
            Console.WriteLine("Nome invalido");
            return;
        }
        try{
            Console.WriteLine("Digite o cpf do medico");
            var Cpf = Console.ReadLine()!;
            medicos.ForEach(x => {
                if(x.Cpf == Cpf){
                    Console.WriteLine("Cpf ja existe");
                    xx= false;
                }
            });
            if(xx){
                medico.Cpf = Cpf;
            }else{
                return;
            }
        }catch(Exception){
            Console.WriteLine("CPF informado invalido");
            return;
        }
        try{
            Console.WriteLine("Digite a data de nascimento do medico (dd/MM/yyyy): ");
            medico.DataNascimento = DateTime.Parse(Console.ReadLine()!);
        }catch(Exception){
            Console.WriteLine("Data de nascimento invalida");
            return;
        }
        try{
            xx = true;
            Console.WriteLine("Digite o CRM do medico");
            var Crm = Console.ReadLine()!;
            medicos.ForEach(x => {
                if(x.Crm == Crm){
                    Console.WriteLine("CRM ja existe");
                    xx = false;
                }
            });
            if(xx){
                medico.Crm = Crm;
            }else{return;}
        }catch(Exception){
            Console.WriteLine("CRM informado invalido");
            return;
        }
        medicos.Add(medico);
    }

    public void imprimirMedicos(Medico medicos){
        Console.WriteLine("Nome: " + medicos.Nome);
        Console.WriteLine("Cpf: " + medicos.Cpf);
        Console.WriteLine("Data de Nascimento: " + medicos.DataNascimento);
        Console.WriteLine("CRM: " + medicos.Crm);
    }
}