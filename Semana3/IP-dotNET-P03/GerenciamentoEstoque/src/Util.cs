namespace utils;

public class Util
{
    public static void limpar_tela(){
        Console.Clear();
    }
    public static void pausar(){
    Console.WriteLine("Pressione qualquer tecla para continuar...");
    Console.ReadKey();
}
}
