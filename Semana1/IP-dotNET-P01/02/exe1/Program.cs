// See https://aka.ms/new-console-template for more information

using System.Numerics;

// O .NET oferece vários tipos de dados numéricos inteiros que você pode usar em seus programas. 
// Os tipos numéricos inteiros são utilizados para representar números inteiros, números positivos ou números negativos.
// O tipo inteiro de 8 bits (byte) pode conter valores entre 0 e 255.
// O tipo inteiro de 8 bits (sbyte) pode conter valores entre -128 e 127.
// O tipo inteiro de 16 bits (short) pode conter valores entre -32,768 e 32,767.
// O tipo inteiro de 16 bits (ushort) pode conter valores entre 0 e 65,535.
// O tipo inteiro de 32 bits (int) pode conter valores entre -2,147,483,648 e 2,147,483,647.
// O tipo inteiro de 32 bits (uint) pode conter valores entre 0 e 4,294,967,295.
// O tipo inteiro de 64 bits (long) pode conter valores entre -9,223,372,036,854,775,808 e 9,223,372,036,854,775,807.
// O tipo inteiro de 64 bits (ulong) pode conter valores entre 0 e 18,446,744,073,709,551,615.
// O tipo inteiro de 128 bits (BigInteger) pode conter valores entre -2,147,483,648 e 2,147,483,647 Obs: BigInteger esta disponível no namespace System.Numerics.
// Exemplos:

// byte e sbyte
byte idade = 25;
sbyte temperatura = -10;

Console.WriteLine("Idade: " + idade);
Console.WriteLine("Temperatura: " + temperatura);

// Short e ushort
short populacaoCidade = 30000;
ushort numeroEstudantes = 6000;

Console.WriteLine("População da Cidade: " + populacaoCidade);
Console.WriteLine("Número de Estudantes: " + numeroEstudantes);

// int e uint
int saldoConta = -500;
uint quantidadeItens = 1500;

Console.WriteLine("Saldo da Conta: " + saldoConta);
Console.WriteLine("Quantidade de Itens: " + quantidadeItens);

// Long e ulong
long populacaoMundial = 7800000000;
ulong distanciaEstrela = 150000000000;

Console.WriteLine("População Mundial: " + populacaoMundial);
Console.WriteLine("Distância até a Estrela: " + distanciaEstrela);

// BigInteger
BigInteger numeroMuitoGrande = BigInteger.Pow(2, 100);

Console.WriteLine("Número Muito Grande: " + numeroMuitoGrande);


