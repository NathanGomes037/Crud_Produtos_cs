using System;
class Produto_service{
    private List<Produto> produtos = new ();
    private Verificação_nulo verificação = new Verificação_nulo();

    public int ProdutosQuantidade()
    {
        return produtos.Count;
    }

    public void Cadastro(int id, string nome, decimal preco, int quantidade){
       
           Produto produto = new Produto();
                produto.id = id;
                produto.nome = nome;
                produto.preco = preco;
                produto.quantidade = quantidade; 
            
            produtos.Add(produto);       
        
    }
    public Produto? Listar(int i)
    {
        if (i < 0 || i >= produtos.Count)
        {
            return null;
        }
        return produtos[i];
        
    }
    public Produto? BuscaProduto(string Busca)
    {
        for(int i = 0; i< produtos.Count; i++)
        {
            if(produtos[i].nome == Busca)
            {
                return produtos[i];
            }
        }
        return null;
    }
    public decimal SimulacaoDes(Produto produto, int desconto)
    {

                decimal PrecoComDesconto = produto.preco - (produto.preco * desconto / 100);
                return PrecoComDesconto;
        
    }
    public void Deletar(Produto produto)
    {
         produtos.Remove(produto);
          
    }
    public void Alterar(Produto produto, int? opcao, string? novoNome, decimal? novoPreco, int? novaQuantidade, int?novoId)
    { 
                switch (opcao)
                {
                    case 1:
                        produto.nome= novoNome;
                        break;
                    case 2:
                        produto.preco= novoPreco;
                        break;
                    case 3:
                        produto.quantidade= novaQuantidade;
                        break;
                    case 4:
                        produto.id= novoId;
                        break;
                    case 5:
                      
                        break;
                    default:
                        
                        break;
                }
             
            }

}