// See https://aka.ms/new-console-template for more information
Console.Clear();
List<int> lista = new List<int>();

for(var i = 0; i <= 10; i++)
{
    lista.Add(i);
}

Console.WriteLine("Lista");

foreach(var item in lista)
{
    Console.WriteLine(item);
}

Console.WriteLine("Fim");
Console.WriteLine("Lista dentro de uma Lista");

List<List<int>> lista2 = new List<List<int>>();
List<int> lista3 = new List<int>();
List<int> lista4 = new List<int>();
for(var i = 0; i <= 20; i++)
{
    lista3.Add(i);
    lista4.Add(i+2);
}
lista2.Add(lista3);
lista2.Add(lista4);

foreach(List<int> item in lista2)
{
    foreach(var item2 in item){
        Console.WriteLine(item2);
    }
    Console.WriteLine("\n=============\n");
}
