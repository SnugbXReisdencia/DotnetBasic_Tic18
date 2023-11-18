// See https://aka.ms/new-console-template for more information
Console.Clear();

/*
* Problema: Dadas as variáveis int num1 = 7, int num2 = 3, e int num3 = 10,
* escreva código para verificar se num1 é maior do que num2 e se num3 é igual
* a num1 + num2.
*/

int num1 = 7;
int num2 = 3;
int num3 = 10;

Console.WriteLine($"Num1 = {num1}");
Console.WriteLine($"Num2 = {num2}");
Console.WriteLine($"Num3 = {num3}\n");

if(num1 > num2)
{
    Console.WriteLine($"Num1 = {num1} e maior que Num2 = {num2}");
}
else
{
    Console.WriteLine($"Num2 = {num2} e maior que Num1 = {num1}");
}

if(num3 == num1 + num2)
{
    Console.WriteLine($"Num3 = {num3} e igual a Num1 + Num2 = {num1 + num2}");
}
else
{
    Console.WriteLine($"Num3 = {num3} e diferente de Num1 + Num2 = {num1 + num2}");
}

