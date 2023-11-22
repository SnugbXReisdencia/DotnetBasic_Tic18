// See https://aka.ms/new-console-template for more information

Limpar();

int num;

Console.WriteLine("digite um numero");
try{
    num = int.Parse(Console.ReadLine()!);
}catch(Exception){
    Console.WriteLine("Valor passado invalido !!");
}
pausar();
Limpar();


void Limpar()
{
    Console.Clear();
}

void pausar()
{
    Console.ReadKey();
}
