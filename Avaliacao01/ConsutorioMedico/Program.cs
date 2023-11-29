using System.Reflection.Metadata.Ecma335;
using Controller;
using Modelos;
// See https://aka.ms/new-console-template for more information

List<Paciente> pacientes = new List<Paciente>();
List<Medico> medicos = new List<Medico>();
var appMedico = new AppMedico();
var appPacientes = new AppPaciente();
int opc;
while(true){
    switch(app.menu()){
        case 1:
            appMedico.criarMedico(medicos);
            break;
    }
}