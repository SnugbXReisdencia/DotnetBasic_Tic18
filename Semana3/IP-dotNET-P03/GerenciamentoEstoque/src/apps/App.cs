using Microsoft.VisualBasic.CompilerServices;
namespace apps;
using utils;

public class App
{
    public int menuPrincipal()
    {
        Util.limpar_tela();
        Console.WriteLine("############# MENU PRINCIPAL #############");
        Console.WriteLine("1 - Gerenciar Estoque");
        Console.WriteLine("2 - Relatorio");
        Console.WriteLine("0 - Sair");
        Console.Write("Opção: ");
        try{
            var opc = int.Parse(Console.ReadLine()!);
            return opc;
        }catch(Exception){
            Util.limpar_tela();
            Console.WriteLine("Opção inválida!!");
            Util.pausar();
            return menuPrincipal();
        }
    }
    public int menuProduto()
    {
        Util.limpar_tela();
        Console.WriteLine("############# MENU ESTOQUE #############");
        Console.WriteLine("1 - Cadastrar Produto no Estoque");
        Console.WriteLine("2 - Atualizar Produto no Estoque");
        Console.WriteLine("3 - Excluir Produto do Estoque");
        Console.WriteLine("0 - Voltar");
        Console.Write("Opção: ");
        try{
            var opc = int.Parse(Console.ReadLine()!);
            return opc;
        }catch(Exception){
            Util.limpar_tela();
            Console.WriteLine("Opção inválida!!");
            Util.pausar();
            return menuProduto();
        }
    }

    public int menuRelatorio(){
        Util.limpar_tela();
        Console.WriteLine("############# MENU RELATORIO #############");
        Console.WriteLine("1 - Lista de produtos com quantidade em estoque abaixo de um determinado limite");
        Console.WriteLine("2 - Lista de produtos com valor entre um mínimo e um máximo");
        Console.WriteLine("3 - Relatorio geral de estoque");
        Console.WriteLine("0 - Voltar");
        Console.Write("Opção: ");
        try{
            var opc = int.Parse(Console.ReadLine()!);
            return opc;
        }catch(Exception){
            Util.limpar_tela();
            Console.WriteLine("\nValor informado inválida!! Tente novamente.\n");
            Util.pausar();
            return menuRelatorio();
        }
    }
}
