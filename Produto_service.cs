using System;

class Produto_service{
    private List<Produto> produtos = new ();
    private Verificação_nulo verificação = new Verificação_nulo();

    public void Cadastro(int id, string nome, decimal preco, int quantidade){
       
           Produto produto = new Produto();
                produto.id = id;
                produto.nome = nome;
                produto.preco = preco;
                produto.quantidade = quantidade; 
            
            produtos.Add(produto);       
        
    }
    public void Listar()
    {
        for(int i = 0; i < produtos.Count; i++)
        {
            Console.WriteLine($"ID: {produtos[i].id}");
            Console.WriteLine($"Nome: {produtos[i].nome}");
            Console.WriteLine($"Preço: {produtos[i].preco}");
            Console.WriteLine($"Quantidade: {produtos[i].quantidade}");
        }
    }
    public void BuscaPreco(string Busca)
    {
        bool encontrado = false;
        for(int i = 0; i< produtos.Count; i++)
        {
            if(produtos[i].nome == Busca)
            {
                Console.WriteLine($"o preço do produto {produtos[i].nome} é: {produtos[i].preco}");
                encontrado = true;
            }
           
        }
        if(!encontrado)
        {
            Console.WriteLine("Produto não encontrado");
        }
    }
    public void SimulacaoDes(string Busca)
    {
        bool encontrado = false;
        for(int i = 0; i< produtos.Count; i++)
        {
            if(produtos[i].nome == Busca)
            {
                encontrado = true;
                int desconto = verificação.Ler_Int("digite o valor da Porcentagem de desconto: ");
                decimal PrecoComDesconto = produtos[i].preco - (produtos[i].preco * desconto / 100);
                Console.WriteLine($"o preço do produto {produtos[i].nome} com desconto de {desconto}% é: {PrecoComDesconto}");

            }
           
        }
        if(!encontrado)
        {
            Console.WriteLine("Produto não encontrado");
    }
    }
    public void Deletar(string Busca)
    {
        bool encontrado = false;
        for(int i = 0; i< produtos.Count; i++)
        {
            if(produtos[i].nome == Busca)
            {
                produtos.RemoveAt(i);
                Console.WriteLine("Produto deletado com sucesso");
                encontrado = true;
                break;
            }
           
        }
        if(!encontrado)
        {
            Console.WriteLine("Produto não encontrado");
        }
    }
    public void Alterar(string Busca)
    {
        bool encontrado = false;
        for(int i = 0; i< produtos.Count; i++)
        {
          if(produtos[i].nome == Busca)
            {
                encontrado = true;
                Console.WriteLine("O que deseja alterar?");
                Console.WriteLine("1 - Nome");
                Console.WriteLine("2 - Preço");
                Console.WriteLine("3 - Quantidade");
                int opcao = verificação.Ler_Int("Digite sua opção: ");
                switch (opcao)
                {
                    case 1:
                        produtos[i].nome= verificação.Ler_Str("Digite o novo nome do produto: ");
                        break;
                    case 2:
                        produtos[i].preco= verificação.Ler_Dec("Digite o novo preço do produto: ");
                        break;
                    case 3:
                        produtos[i].quantidade= verificação.Ler_Int("Digite a nova quantidade do produto: ");
                        break;
                    default:
                        Console.WriteLine("Opção inválida");
                        break;
                }
                break;
            }
        }
    
        if(!encontrado)
        {
            Console.WriteLine("Produto não encontrado");
        }
    }
}