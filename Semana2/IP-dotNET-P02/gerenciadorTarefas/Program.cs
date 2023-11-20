// See https://aka.ms/new-console-template for more information
using System.ComponentModel.Design;
using System.Reflection.Emit;
using gerenciadorTarefas;

Console.Clear();
/*
* Objetivo:
* Desenvolver um sistema de gerenciamento de tarefas
* que permita aos usuários criar, 
* visualizar e gerenciar tarefas.
*/

int opc, opc2;
GerenciarTarefas ger_Tarefas = new GerenciarTarefas();
do{
    Console.Clear();
    opc = menu();
    switch(opc){
        case 1:
            ger_Tarefas.CadastrarTarefa();
            break;
        case 2:
            break;
        case 3:
            do{
                Console.Clear();
                opc2 = menu_Listar();
                switch(opc2){
                    case 1:
                        ger_Tarefas.ListarTarefas();
                        pausar();
                        break;
                    case 2:
                        ger_Tarefas.ListarTarefasPendentes();
                        pausar();
                        break;
                    case 3:
                        ger_Tarefas.ListarTarefasConcluidas();
                        pausar();
                        break;
                    case 0:
                        break;
                    default:
                        Console.WriteLine("Opção inválida!");
                        pausar();
                        break;
                }
            }while(opc2 != 0);
            break;
        case 4:
            ger_Tarefas.ExcluirTarefa();
            pausar();
            break;
        case 0:
            break;
        default:
            Console.WriteLine("Opção inválida!");
            break;
    }
}while(opc != 0);

int menu(){
    Console.WriteLine("1 - Cadastrar Tarefa");
    Console.WriteLine("2 - Concluir Tarefa");
    Console.WriteLine("3 - Dados das Tarefas");
    Console.WriteLine("4 - Excluir Tarefa");
    Console.WriteLine("0 - Sair");
    Console.Write("Opção: ");
    return int.Parse(Console.ReadLine()!);
}

int menu_Listar(){
    Console.WriteLine("1 - Estadisticas das Tarefas");
    Console.WriteLine("2 - Tarefas pendentes");
    Console.WriteLine("3 - Tarefas concluídas");
    Console.WriteLine("0 - Sair");
    Console.Write("Opção: ");
    return int.Parse(Console.ReadLine()!);
}

void pausar(){
    Console.WriteLine("Pressione qualquer tecla para continuar...");
    Console.ReadKey();
}