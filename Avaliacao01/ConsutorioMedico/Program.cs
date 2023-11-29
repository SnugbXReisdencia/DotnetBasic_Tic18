using System.Reflection.Metadata.Ecma335;
using Controller;
using Modelos;
// See https://aka.ms/new-console-template for more information

List<Paciente> pacientes = new List<Paciente>();
List<Medico> medicos = new List<Medico>();



int opc;
do{
    opc = Controller.app.menu();
    switch(opc){
        case 1:
            Controller.AppMedico.criarMedico(medicos);
            break;
        case 2:
            Controller.AppPaciente.criarPaciente(pacientes);
            break;
        case 3:
            foreach(var medico in medicos){
                medico.imprimirMedicos(medico);    
            }
            break;
        case 4:
            foreach (var paciente in pacientes){
                paciente.imprimirPacientes(paciente);
            }
            break;
        case 5:
            Controller.app.menuRelatorio();
            break;
        case 0:
            Console.WriteLine("Saindo...");
            break;
        default:
            Console.WriteLine("Opcao invalida");
            break;
    }
}while(opc != 0);