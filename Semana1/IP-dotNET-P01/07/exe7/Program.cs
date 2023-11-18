// See https://aka.ms/new-console-template for more information
Console.Clear();

/*
* Problema: Suponha que você tenha duas variáveis booleanas,
* bool condicao1 = true e bool condicao2 = false.
* Escreva código para verificar se ambas as condições são 
* verdadeiras e exiba o resultado.
*/

bool condicao1 = true;
bool condicao2 = false;

Console.WriteLine($"Condicao 1: {condicao1}");
Console.WriteLine($"Condicao 2: {condicao2}\n");

if (condicao1 && condicao2)
{
    Console.WriteLine("As duas condicoes sao verdadeiras");
}else if (condicao1)
{
    Console.WriteLine("A primeira condicao e verdadeira");
    Console.WriteLine("A segunda condicao e falsa");
}else if (condicao2){
    Console.WriteLine("A primeira condicao e falsa");
    Console.WriteLine("A segunda condicao e verdadeira");
}
else
{
    Console.WriteLine("As duas condicoes sao falsas");
}

