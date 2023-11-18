// See https://aka.ms/new-console-template for more information
Console.Clear();
/* Suponha que você tenha uma variável do tipo double e deseja convertê-la 
em um tipo int. Como você faria essa conversão e o que aconteceria se a parte 
fracionária da variável double não pudesse ser convertida em um int? */
/*R: A parte fracionária da variável double não pode ser convertida em um int.
    Pois, o número double pode conter valores entre,
    -2,147,483,648 e 2,147,483,647, com precisão de 15 a 17 dígitos decimais significativos.
    E o tipo inteiro de 32 bits (int) pode conter valores entre,
    -2,147,483,648 e 2,147,483,647 sem precisão de casas decimais.
    Ou seja, para contornar isso usa valor aproximado. Por padrao o arredondamento
    sempre ocorre em direção a zero, como mostra o exemplo 1.
    Caso precisar de  um comportamento diferente,
    como arredondamento para o número inteiro mais próximo,
    você pode usar funções como 'Math.Round' ou 'Math.Floor' antes de fazer a conversão.
    como mostra o exemplo 2 e 3.
 */
// exemplo 1:
double numeroDouble = 10.99;
// Convertendo o número double para um número inteiro
int numeroInteiro = (int)numeroDouble;

Console.WriteLine("Número Double: " + numeroDouble);
Console.WriteLine("Número Inteiro (após conversão): " + numeroInteiro);

// exemplo 2:
double numeroDouble2 = 10.99;
// Convertendo o número double para um número inteiro
int numeroInteiro2 = (int)Math.Round(numeroDouble2);

Console.WriteLine("Usando Math.Round (Arredonda para cima): ");
Console.WriteLine("Número Double: " + numeroDouble2);
Console.WriteLine("Número Inteiro (após conversão): " + numeroInteiro2);

double numeroDouble3 = 10.99;
// Convertendo o número double para um número inteiro
int numeroInteiro4 = (int)Math.Floor(numeroDouble3);

Console.WriteLine("Usando Math.Floor (Arredonda para baixo): ");
Console.WriteLine("Número Double: " + numeroDouble3);
Console.WriteLine("Número Inteiro (após conversão): " + numeroInteiro4);

