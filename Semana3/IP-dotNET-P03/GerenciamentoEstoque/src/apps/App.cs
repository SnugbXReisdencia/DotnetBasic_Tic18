using Microsoft.VisualBasic.CompilerServices;
namespace apps;
using utils;

public class App
{
    public int menuPrincipal()
    {
        Util.limpar_tela();
        Console.WriteLine("############# MENU PRINCIPAL #############");
        Console.WriteLine("1 - Gerenciar Estoque");
        Console.WriteLine("2 - Relatorio");
        Console.WriteLine("0 - Sair");
        Console.Write("Opção: ");
        try
        {
            var opc = int.Parse(Console.ReadLine()!);
            return opc;
        }
        catch (Exception)
        {
            Util.limpar_tela();
            Console.WriteLine("Opção inválida!!");
            Util.pausar();
            return menuPrincipal();
        }
    }
    public int menuProduto()
    {
        Util.limpar_tela();
        Console.WriteLine("############# MENU ESTOQUE #############");
        Console.WriteLine("1 - Cadastrar Produto no Estoque");
        Console.WriteLine("2 - Atualizar Estoque do Produto ");
        Console.WriteLine("3 - Excluir Produto do Estoque");
        Console.WriteLine("0 - Voltar");
        Console.Write("Opção: ");
        try
        {
            var opc = int.Parse(Console.ReadLine()!);
            return opc;
        }
        catch (Exception)
        {
            Util.limpar_tela();
            Console.WriteLine("Opção inválida!!");
            Util.pausar();
            return menuProduto();
        }
    }
    public void cadastrarProduto(List<(int cod, string nome, int qtd, double preco)> estoque)
    {
        Util.limpar_tela();
        try
        {
            Console.WriteLine("############# CADASTRO DE PRODUTO #############");
            var cod = estoque.Count + 1;
            Console.Write("Nome do produto: ");
            var nome = Console.ReadLine()!;
            Console.Write("Quantidade em estoque: ");
            var qtd = int.Parse(Console.ReadLine()!);
            Console.Write("Preço unitário: ");
            var preco = double.Parse(Console.ReadLine()!);
            estoque.Add((cod, nome, qtd, preco));
            Console.WriteLine("Produto cadastrado com sucesso!!");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Aconteceu o seguinte erro: " + ex.Message);
        }
        Util.pausar();
    }

    public void excluirProduto(List<(int cod, string nome, int qtd, double preco)> estoque)
    {
        Util.limpar_tela();

        Console.WriteLine("############# EXCLUIR PRODUTO #############");
        var produto = buscaProduto(estoque);
        if (produto != default)
        {
            estoque.Remove(produto);
            Console.WriteLine("Produto excluido com sucesso!!");

        }
        else
        {
            Console.WriteLine("Produto Não Encontrado !!");
        }

        Util.pausar();
    }

    public (int cod, string nome, int qtd, double preco) buscaProduto(List<(int cod, string nome, int qtd, double preco)> estoque)
    {
        try
        {
            Console.WriteLine("############# BUSCA DE PRODUTO #############");
            Console.Write("Código do Produto: ");

            if (int.TryParse(Console.ReadLine(), out var codigo))
            {
                var produto = estoque.FirstOrDefault(x => x.cod == codigo);

                if (produto != default)
                {
                    return produto;
                }
            }

            Console.WriteLine("Valor informado inválido ou inexistente! Tente novamente.\n");
            return default;
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Ocorreu um erro: {ex.Message}");
            return default;
        }
    }


    public int menuAtualizarProduto((int cod, string nome, int qtd, double preco) produto)
    {
        Util.limpar_tela();
        try
        {
            Console.WriteLine($"############# MENU DE ATUALIZACAO DE ESTOQUE DO PRODUTO {produto.nome} #############");
            Console.WriteLine("Estoque atual: " + produto.qtd);
            Console.WriteLine("1 - Adicionar quantidade em estoque");
            Console.WriteLine("2 - Remover quantidade em estoque");
            Console.WriteLine("0 - Voltar");
            return int.Parse(Console.ReadLine()!);
        }
        catch (Exception)
        {
            Console.WriteLine("Valor informado inválido!! Tente novamente.\n");
            Util.pausar();
            return -1;
        }
    }
    public List<(int cod, string nome, int qtd, double preco)> add_Qtd((int cod, string nome, int qtd, double preco) produto, List<(int cod, string nome, int qtd, double preco)> estoque)
    {
        Util.limpar_tela();
        Console.WriteLine($"############## ATUALIZAÇÃO DE ESTOQUE DO PRODUTO {produto.nome} ##############");

        var indiceProduto = estoque.FindIndex(x => x.cod == produto.cod);

        if (indiceProduto != -1)
        {
            Console.Write("Quantidade a ser adicionada: ");
            try
            {
                if (int.TryParse(Console.ReadLine(), out var quantidade))
                {
                    var produtoAtual = estoque[indiceProduto];
                    produtoAtual.qtd += quantidade;
                    estoque[indiceProduto] = produtoAtual;
                    Console.WriteLine("Quantidade adicionada com sucesso!!");
                    Util.pausar();
                    return estoque;
                }
                else
                {
                    Console.WriteLine("O valor informado é inválido!");
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("O valor informado é inválido!");
            }
        }
        else
        {
            Console.WriteLine("Produto não encontrado no estoque!");
        }

        Console.WriteLine("Tente novamente!!");
        Util.pausar();
        return estoque;
    }


    public List<(int cod, string nome, int qtd, double preco)> remove_Qtd((int cod, string nome, int qtd, double preco) produto, List<(int cod, string nome, int qtd, double preco)> estoque)
    {

        Util.limpar_tela();
        Console.WriteLine($"############## ATUALIZAÇÃO DE ESTOQUE DO PRODUTO {produto.nome} ##############");

        var indiceProduto = estoque.IndexOf(produto);
        if (indiceProduto != -1)
        {
            Console.Write("Quantidade a ser removida: ");
            try
            {
                if (int.TryParse(Console.ReadLine(), out var quantidade))
                {
                    if (quantidade > produto.qtd)
                    {
                        Console.WriteLine("Quantidade informada maior que a existente!!");
                        Console.WriteLine("Tente novamente!!");
                        return estoque;
                    }

                    var produtoAtualizado = produto;

                    produtoAtualizado.qtd -= quantidade;

                    estoque[indiceProduto] = produtoAtualizado;

                    Console.WriteLine("Quantidade removida com sucesso!!");
                }
                else
                {
                    Console.WriteLine("O valor informado é inválido!");
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("O valor informado é inválido!");
            }
        }
        else
        {
            Console.WriteLine("Produto não encontrado no estoque!");
        }

        Console.WriteLine("Tente novamente!!");
        Util.pausar();
        return estoque;
    }


    public int menuRelatorio()
    {
        Util.limpar_tela();
        Console.WriteLine("############# MENU RELATORIO #############");
        Console.WriteLine("1 - Lista de produtos com quantidade em estoque abaixo de um determinado limite");
        Console.WriteLine("2 - Lista de produtos com valor entre um mínimo e um máximo");
        Console.WriteLine("3 - Relatorio geral de estoque");
        Console.WriteLine("0 - Voltar");
        Console.Write("Opção: ");
        try
        {
            var opc = int.Parse(Console.ReadLine()!);
            return opc;
        }
        catch (Exception)
        {
            Util.limpar_tela();
            Console.WriteLine("\nValor informado inválida!! Tente novamente.\n");
            Util.pausar();
            return menuRelatorio();
        }
    }
}
