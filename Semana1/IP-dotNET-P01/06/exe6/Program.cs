// See https://aka.ms/new-console-template for more information
Console.Clear();

/*
* Problema: Você tem duas strings,
* string str1 = "Hello" e string str2 = "World". Escreva 
* código para verificar se as duas strings são iguais e exibir o resultado.
*/

string str1 = "Hello";
string str2 = "World";

Console.WriteLine($"String 1: {str1}");
Console.WriteLine($"String 2: {str2}\n");

if (str1 == str2)
{
    Console.WriteLine("As duas strings sao iguais");
}
else
{
    Console.WriteLine("As duas strings sao diferentes");
}
