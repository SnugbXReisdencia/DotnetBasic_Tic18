// See https://aka.ms/new-console-template for more information
Console.Clear();

/* Problema: Dada a variável int x = 10 e a variável int y = 3,
 * escreva código para calcular e exibir o resultado da adição,
 * subtração, multiplicação e divisão de x por y.
 */

int x = 10;
int y = 3;

int adicao = x + y;
int subtracao = x - y;
int multiplicacao = x * y;
int divisao = x / y;

Console.WriteLine($"Adição: {x} + {y} = {adicao}");
Console.WriteLine($"Subtração: {x} - {y} = {subtracao}");
Console.WriteLine($"Multiplicação: {x} * {y} = {multiplicacao}");
Console.WriteLine($"Divisão: {x} / {y} = {divisao}");
