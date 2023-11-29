namespace Controller;
using Modelos;
public class appMedico
{
    public static Medico  criarMedico(List<Medico> medicos){
        var medico = new Medico();
        Console.WriteLine("Digite o nome do medico");
        try{
            medico.Nome = Console.ReadLine()!;
        }catch(Exception){
            Console.WriteLine("Nome invalido");
        }
        try{
            Console.WriteLine("Digite o cpf do medico");
            medico.Cpf = Console.ReadLine()!;
            medicos.ForEach(x => {
                if(x.Cpf == medico.Cpf){
                    throw new Exception("Cpf ja existe");
                }
            });
        }catch(Exception e){
            Console.WriteLine(e.Message);
        }
        try{
            Console.WriteLine("Digite a data de nascimento do medico (dd/MM/yyyy): ");
            medico.DataNascimento = DateTime.Parse(Console.ReadLine()!);
        }catch(Exception){
            Console.WriteLine("Data de nascimento invalida");
        }
        try{
            Console.WriteLine("Digite o crm do medico");
            medico.Crm = Console.ReadLine()!;
        }catch(Exception){
            Console.WriteLine("CRM informado invalido");
        }
        return new Medico();
    }
}
