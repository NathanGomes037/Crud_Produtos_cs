using System.Runtime;

class Program
{
    public static void Main(string[] args)
    {
        Produto_service service = new Produto_service();
        Verificação_nulo verificação = new Verificação_nulo();
        int opcao = 0;
        do{
            Console.WriteLine("============MENU DE OPÇÕES============");
            Console.WriteLine("1 - Cadastrar Produto");
            Console.WriteLine("2 - Listar Produtos");
            Console.WriteLine("3 - busca de preço do produto");
            Console.WriteLine("4 - Simulaçao de Desconto");
            Console.WriteLine("5 - deletar Produto");
            Console.WriteLine("6 - alterar Produto");
            Console.WriteLine("0 - Sair do Programa");
            Console.WriteLine("======================================");
            opcao = verificação.Ler_Int("Digite sua opção: ");
            switch (opcao)
            {
                case 1:
                    int quantidade_cadastro = verificação.Ler_Int("Digite a quantidade de produtos que deseja cadastrar: ");
                    for(int i = 0; i< quantidade_cadastro; i++)
                    {
                        int id = verificação.Ler_Int("Digite o ID do produto: ");
                        string nome = verificação.Ler_Str("Digite o nome do produto: ");
                        decimal preco = verificação.Ler_Dec("Digite o preço do produto: ");
                        int quantidade = verificação.Ler_Int("Digite a quantidade do produto: ");
                        service.Cadastro(id, nome, preco, quantidade);
                    }
                    break;
                    
                case 2:
                    bool encontrado = false;
                    for(int indice =0; indice < service.ProdutosQuantidade(); indice++)
                    {
                        
                        Produto? produto = service.Listar(indice);
                        if (produto != null)
                        {
                            encontrado = true;


                            Console.WriteLine($"ID: {produto.id}");
                            Console.WriteLine($"Nome: {produto.nome}");
                            Console.WriteLine($"Preço: {produto.preco}");
                            Console.WriteLine($"Quantidade: {produto.quantidade}");
                        }
                    }
                    if(!encontrado)
                    {
                        Console.WriteLine("Nenhum produto cadastrado.");
                    }
                    break;
                case 3:
                    string Busca_Preço = verificação.Ler_Str("Digite o nome do produto que deseja buscar o preço: ");
                    Produto? produtoPreço = service.BuscaProduto(Busca_Preço);
                    if (produtoPreço != null)
                    {
                        Console.WriteLine($"O preço do produto {produtoPreço.nome} é: {produtoPreço.preco}");
                    }
                    else
                    {
                        Console.WriteLine("Produto não encontrado");
                    }
                    break;
                case 4:
                    string Busca_simu = verificação.Ler_Str("Digite o nome do produto que deseja buscar o preço: ");
                    int desconto = verificação.Ler_Int("digite o valor da Porcentagem de desconto: ");
                    Produto? produtoSimu = service.BuscaProduto(Busca_simu);
                    if (produtoSimu != null)
                    {
                        decimal PrecoComDesconto = service.SimulacaoDes(produtoSimu, desconto);
                        Console.WriteLine($"O preço do produto {produtoSimu.nome} com desconto de {desconto}% é: {PrecoComDesconto}");
                    }
                    else
                    {
                        Console.WriteLine("Produto não encontrado");
                    }
                    break;
                case 5:
                    string Busca_Deletar = verificação.Ler_Str("Digite o nome do produto que deseja deletar: ");
                    Produto? produtoDeletar = service.BuscaProduto(Busca_Deletar);
                    if (produtoDeletar != null)
                    {
                        service.Deletar(produtoDeletar);
                        Console.WriteLine($"Produto {produtoDeletar.nome} deletado com sucesso.");
                    }
                    else
                    {
                        Console.WriteLine("Produto não encontrado");
                    }
                    break;
                case 6:
                    string Busca_alterar = verificação.Ler_Str("Digite o nome do produto que deseja alterar: ");
                    Produto? produtoAlterar = service.BuscaProduto(Busca_alterar);
                    if (produtoAlterar != null)
                    {
                    Console.WriteLine("O que deseja alterar?");
                    Console.WriteLine("1 - Nome");
                    Console.WriteLine("2 - Preço");
                    Console.WriteLine("3 - Quantidade");
                    Console.WriteLine("4 - ID");
                    Console.WriteLine("5 - Voltar ao menu");
                    int opcao_alterar = verificação.Ler_Int("Digite sua opção: ");
                    service.Alterar(produtoAlterar, opcao_alterar);
                    }
                    else
                    {
                        Console.WriteLine("Produto não encontrado");
                    }
                    break;
                case 0:
                    Console.WriteLine("fechando o Programa");
                    break;
                default:
                    Console.WriteLine("Opção inválida");
                    break;
            }
        }while(opcao != 0);
    }
}