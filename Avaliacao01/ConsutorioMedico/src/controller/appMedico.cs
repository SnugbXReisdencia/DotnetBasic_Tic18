namespace Controller;
using Modelos;
public class appMedico
{
    public static bool  criarMedico(List<Medico> medicos){
        var medico = new Medico();
        var xx  = true;
        try{
            Console.WriteLine("Digite o nome do medico");
            var Nome = Console.ReadLine()!;
        }catch(Exception){
            Console.WriteLine("Nome invalido");
            return false;
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
                return false;
            }
        }catch(Exception){
            Console.WriteLine("CPF informado invalido");
        }
        
        Console.WriteLine("Digite o nome do medico");
        try{
            var Nome = Console.ReadLine()!;
        }catch(Exception){
            Console.WriteLine("Nome invalido");
            return false;
        }
        try{
            Console.WriteLine("Digite o cpf do medico");
            var Cpf = Console.ReadLine()!;
            medicos.ForEach(x => {
                if(x.Cpf == Cpf){
                    Console.WriteLine("Cpf ja existe");
                }else{
                    medico.Cpf = Cpf;
                }
            });
        }catch(Exception){
            Console.WriteLine("CPF informado invalido");
            return false;
        }
        try{
            Console.WriteLine("Digite a data de nascimento do medico (dd/MM/yyyy): ");
            var DataNascimento = DateTime.Parse(Console.ReadLine()!);
        }catch(Exception){
            Console.WriteLine("Data de nascimento invalida");
            return false;
        }
        try{
            xx = true;
            Console.WriteLine("Digite o crm do medico");
            var Crm = Console.ReadLine()!;
            medicos.ForEach(x => {
                if(x.Crm == Crm){
                    Console.WriteLine("Crm ja existe");
                    xx = false;
                }
            });
            if(xx){
                medico.Crm = Crm;
            }
        }catch(Exception){
            Console.WriteLine("CRM informado invalido");
            return false;
        }
        medicos.Add(new Medico());
        return true;
        }
    }
}