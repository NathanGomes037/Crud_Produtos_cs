using System;
class Produto_service{
    private List<Produto> produtos = new ();
    private Verificação_nulo verificação = new Verificação_nulo();

    public int ProdutosQuantidade()
    {
        return produtos.Count;
    }

    public void Cadastro(string nome, decimal preco, int quantidade){
       
           Produto produto = new Produto();
                produto.id = produtos.Count + 1;
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
    public void Deletar(Produto produtoDel)
    {
         produtos.Remove(produtoDel);
         for(int i= 0; i < produtos.Count; i++)
        {
            produtos[i].id = i + 1;
        }
           
        
    }
    public void AlterarNome( Produto produto, string NovoNome)
    {           
        produto.nome= NovoNome;          
    }
    public void AlterarPreço(Produto produto, decimal NovoPreço)
    {
        produto.preco= NovoPreço;
    }
    public void AlterarQuantidade(Produto produto, int NovaQuantidade)
    {
        produto.quantidade= NovaQuantidade;
    }
}
   