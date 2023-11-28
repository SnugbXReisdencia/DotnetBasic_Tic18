// See https://aka.ms/new-console-template for more information
using System.Globalization;
using utils;
using apps;

CultureInfo.CurrentCulture = new CultureInfo("pt-BR");

Util.limpar_tela();

// Crie uma tupla representando um produto no estoque, contendo os 
// seguintes elementos: código do produto, nome do produto, quantidade 
// em estoque e preço unitário.

List<(int cod, string nome, int qtd, double preco)> estoque = new();
var app = new App();
while (true)
{
    var op = app.menuPrincipal();
    switch (op)
    {
        case 0:
            Environment.Exit(0);
            break;
        case 1:
            app.menuProduto();
            break;
        case 2:
            app.menuRelatorio();
            break;
        default:
            Console.WriteLine("Opção inválida!!!");
            Util.pausar();
            break;
    }
}
