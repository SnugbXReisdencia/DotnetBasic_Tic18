using System.Reflection.Metadata.Ecma335;
using Controller;
using Modelos;
// See https://aka.ms/new-console-template for more information

List<Paciente> pacientes = new List<Paciente>();
List<Medico> medicos = new List<Medico>();

int opc;
do{
    opc = appMedico.menu();
    switch(opc){
        case 1:
            appMedico.App.criarMedico(medicos);
            break;
        case 2:
            appMedico.App.criarPaciente(pacientes);
            break;
        case 3:
            appMedico.App.imprimirMedicos(medicos);
            break;
        case 4:
            appMedico.App.imprimirPacientes(pacientes);
            break;
        case 5:
            appMedico.App.menuRelatorio();
            break;
        case 0:
            Console.WriteLine("Saindo...");
            break;
        default:
            Console.WriteLine("Opcao invalida");
            break;
    }
}while(opc != 0);