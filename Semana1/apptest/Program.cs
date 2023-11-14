// See https://aka.ms/new-console-template for more information
Console.Clear();
Console.WriteLine("Digite seu nome:");
string nome = Console.ReadLine() ?? "";
Console.WriteLine("Olá, " + nome + "!");
Console.WriteLine("Presione qualquer tecla !");
Console.ReadKey();
Console.WriteLine("\nSeu nome tem " + nome.Length + " letras.");
Console.WriteLine("Seu nome em maiúsculas é " + nome.ToUpper() + ".");
Console.WriteLine("Seu nome em minúsculas é " + nome.ToLower() + ".");
nome.Split(' ');

string[] vet = nome.Split(' ');
foreach(string i in vet)
{
    Console.WriteLine(i);
}

Console.WriteLine(string.IsNullOrWhiteSpace(nome));
