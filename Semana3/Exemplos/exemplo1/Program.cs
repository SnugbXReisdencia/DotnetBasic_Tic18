// See https://aka.ms/new-console-template for more information
using System.Globalization;

CultureInfo.CurrentCulture = new CultureInfo("pt-BR");

Limpar();

var tuple3 = (id: 1, nome: "João", sobrenome: "da Silva", born: new DateTime(2000, 1, 1));

List<(int id, string nome, string sobrenome, DateTime born)> list = new();

list.Add(tuple3);

list.Add((1, "João", "da Silva", new DateTime(1995, 1, 1)));

list.Add((2,"juca","soares", born: new DateTime(2023, 2, 27)));

// list.ForEach(x => Console.WriteLine(x.id + " " + x.nome + " " + x.sobrenome + " " + x.born));

// list.Where(x => x.nome == "juca").ToList().ForEach(x => Console.WriteLine(x.id + " " + x.nome + " " + x.sobrenome + " " + x.born));

pausar();
Limpar();

List<string> nomes = new();

nomes.Add("João");

nomes.Add("Juca");

nomes.Add("maria");

// Console.WriteLine("Todos os nomes: ");
// nomes.ForEach(x => Console.Write(x+" "));

// Console.WriteLine("\nNomes que começam com j: ");

// nomes.Where( x => x.StartsWith("J"))
// .ToList()
// .ForEach(x => Console.WriteLine(x));

Console.WriteLine(list.First(x => x.nome.Contains("J")));

pausar();


void Limpar(){
    Console.Clear();
}
void pausar()
{
    Console.WriteLine("Pressione qualquer tecla para continuar...");
    Console.ReadKey();
    Console.Clear();
}
