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
int op, opc, opc1;
while (true)
{
    Util.limpar_tela();
    op = app.menuPrincipal();
    switch (op)
    {
        case 0:
            Environment.Exit(0);
            break;
        case 1:
            do
            {
                Util.limpar_tela();
                opc = app.menuProduto();
                switch (opc)
                {
                    case 0:
                        break;
                    case 1:
                        Util.limpar_tela();
                        app.cadastrarProduto(estoque);
                        break;
                    case 2:
                        Util.limpar_tela();
                        var produto = app.buscaProduto(estoque);
                        if (produto == default)
                        {
                            Util.pausar();
                            break;
                        }
                        do
                        {
                            opc1 = app.menuAtualizarProduto(produto);
                            
                            switch (opc1)
                            {
                                case 0:
                                    break;
                                case 1:
                                    estoque = app.add_Qtd(produto, estoque);
                                    produto = estoque.Find(x => x.cod == produto.cod)!;
                                    break;
                                case 2:
                                    estoque = app.remove_Qtd(produto, estoque);
                                    produto = estoque.Find(x => x.cod == produto.cod)!;
                                    break;
                                case 3:
                                    Util.limpar_tela();
                                    Console.WriteLine("############# DETALHES DO PRODUTO #############");
                                    app.verProduto(produto);
                                    Util.pausar();
                                    break;
                                default:
                                    Console.WriteLine("Opção inválida!!!");
                                    Util.pausar();
                                    break;
                            }
                        } while (opc1 != 0);
                        
                        break;
                    case 3:
                        Util.limpar_tela();
                        app.excluirProduto(estoque);
                        break;
                    default:
                        Console.WriteLine("Opção inválida!!!");
                        Util.pausar();
                        break;
                }
            } while (opc != 0);
            break;
        case 2:
            do{
                opc = app.menuRelatorio();
                switch (opc){
                    case 0:
                        break;
                    case 1:
                        app.rela_Filtrado_estoque(estoque);
                        break;
                    case 2:
                        app.rela_Filtrado_Valor(estoque);
                        break;
                    case 3:
                        app.relatorio_Geral(estoque);
                        break;
                    default:
                        Console.WriteLine("Opção inválida!!!");
                        Util.pausar();
                        break;
                }
            }while(opc != 0);
            break;
        default:
            Console.WriteLine("Opção inválida!!!");
            Util.pausar();
            break;
    }
}
