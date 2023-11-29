namespace Controller;
using Modelos;
public class appMain
{
    public static void imprimeVeiculo(Veiculo veiculo)
    {
        Console.WriteLine($"Modelo: {veiculo.Modelo}");
        Console.WriteLine($"Ano: {veiculo.Ano}");
        Console.WriteLine($"Cor: {veiculo.Cor}");
    }

    public static Veiculo geraVeiculo(){
        try{
            var veiculo = new Veiculo();
            Console.Write("Insira o modelo do veiculo: ");
            veiculo.Modelo = Console.ReadLine()!;
            Console.Write("Insira o ano do veiculo: ");
            veiculo.Ano = int.Parse(Console.ReadLine()!);
            Console.Write("Insira a cor do veiculo: ");
            veiculo.Cor = Console.ReadLine()!;
            return veiculo;
        }catch(Exception){
            Console.WriteLine("Erro ao inserir os dados do veiculo");
            return geraVeiculo();
        }
    }
    public static int menu(){
        Console.WriteLine("######## MENU  ########");
        Console.WriteLine("1 - Inserir veiculo");
        Console.WriteLine("2 - Listar veiculos");
        Console.WriteLine("0 - Sair");
        Console.Write("Escolha uma opcao: ");
        if(int.TryParse(Console.ReadLine(), out var opc)){
            return opc;
        }else{
            Console.WriteLine("Opcao invalida");
            return -1;
        }
        
    }
}
