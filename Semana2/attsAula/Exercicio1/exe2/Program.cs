// See https://aka.ms/new-console-template for more information

Console.WriteLine("Fibonacci");
int n1 = 0;
int n2 = 1;
int n3 = 0;
for(var i = 0; i <= 10; i++)
{
    n3 = n1 + n2;
    Console.WriteLine(n3);
    n1 = n2;
    n2 = n3;
}
