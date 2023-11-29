namespace Controller;
public class app
{
    public static int menu(){
        Console.Clear();
        Console.WriteLine("1 - Criar Medico");
        Console.WriteLine("2 - Criar Paciente");
        Console.WriteLine("3 - Imprimir Medico");
        Console.WriteLine("4 - Imprimir Paciente");
        Console.WriteLine("5 - Relatorios");
        Console.WriteLine("0 - Sair");
        try{
            Console.WriteLine("Escolha uma opcao: ");
            return int.Parse(Console.ReadLine()!);    
        }catch(Exception){
            return -1;
        }
    }
    public static int menuRelatorio(){
        Console.Clear();
        Console.WriteLine("1. Médicos com idade entre dois valores");
        Console.WriteLine("2. Pacientes com idade entre dois valores");
        Console.WriteLine("3. Pacientes do sexo informado pelo usuário");
        Console.WriteLine("4. Pacientes em ordem alfabética");
        Console.WriteLine("5. Pacientes cujos sintomas contenha texto informado pelo usuário");
        Console.WriteLine("6. Médicos e Pacientes aniversariantes do mês informado");
        Console.WriteLine("0 - Sair");
        try{
            Console.WriteLine("Escolha uma opcao: ");
            return int.Parse(Console.ReadLine()!);    
        }catch(Exception){
            return -1;
        }

    }
}
