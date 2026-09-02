using System;

class Produto_service{
    private List<Produto> produtos = new ();
    private Verificação_nulo verificação = new Verificação_nulo();

    public void Cadastro(){
        int quantidade = verificação.Ler_Int("Digite a quantidade de produtos que deseja cadastrar: ");
        for(int i = 0; i < quantidade; i++)
        {
            produtos.Add(new Produto{
                nome = verificação.Ler_Str("Digite o nome do produto: "),
                preco = verificação.Ler_Dec("Digite o preço do produto: "),
                quantidade = verificação.Ler_Int("Digite a quantidade do produto: ")
            });
        }
    }
    public void Listar()
    {
        for(int i = 0; i < produtos.Count; i++)
        {
            Console.WriteLine($"Nome: {produtos[i].nome}");
            Console.WriteLine($"Preço: {produtos[i].preco}");
            Console.WriteLine($"Quantidade: {produtos[i].quantidade}");
            Console.WriteLine();
        }
    }
    public void BuscaPreco()
    {
        string Busca = verificação.Ler_Str("Digite o nome do produto que deseja buscar o preço: ");
        for(int i = 0; i< produtos.Count; i++)
        {
            if(produtos[i].nome == Busca)
            {
                Console.WriteLine($"o preço do produto {produtos[i].nome} é: {produtos[i].preco}");
            }
            else
            {
                Console.WriteLine("Produto não encontrado");
            }
        }
    }
    public void SimulacaoDes()
    {
        string Busca = verificação.Ler_Str("Digite o nome do produto que deseja buscar o preço: ");
        for(int i = 0; i< produtos.Count; i++)
        {
            if(produtos[i].nome == Busca)
            {
                int desconto = verificação.Ler_Int("digite o valor da Porcentagem de desconto: ");
                decimal PrecoComDesconto = produtos[i].preco - (produtos[i].preco * desconto / 100);
                Console.WriteLine($"o preço do produto {produtos[i].nome} com desconto de {desconto}% é: {PrecoComDesconto}");

            }
            else
            {
                Console.WriteLine("produto não encontrado");
            }
        }
    }
    public void Deletar()
    {
        string Busca = verificação.Ler_Str("Digite o nome do produto que deseja deletar: ");
        for(int i = 0; i< produtos.Count; i++)
        {
            if(produtos[i].nome == Busca)
            {
                produtos.RemoveAt(i);
                Console.WriteLine("Produto deletado com sucesso");
            }
            else
            {
                Console.WriteLine("produto não encontrado");
            }
        }
    }
    public void Alterar()
    {
        string Busca = verificação.Ler_Str("Digite o nome do produto que deseja alterar: ");
        for(int i = 0; i< produtos.Count; i++)
        {
          if(produtos[i].nome == Busca)
            {
                Console.WriteLine("O que deseja alterar?");
                Console.WriteLine("1 - Nome");
                Console.WriteLine("2 - Preço");
                Console.WriteLine("3 - Quantidade");
                int opcao = verificação.Ler_Int("Digite sua opção: ");
                switch (opcao)
                {
                    case 1:
                        produtos[i].AlterarNome();
                        break;
                    case 2:
                        produtos[i].AlterarPreco();
                        break;
                    case 3:
                        produtos[i].AlterarQuantidade();
                        break;
                    default:
                        Console.WriteLine("Opção inválida");
                        break;
                }
            }
        }
    }
}