using System;
class Produto{
    Verificação_nulo verificação = new Verificação_nulo();
    public string nome {get; set;}
    public decimal preco {get; set;}
    public int quantidade {get; set;}

    public string AlterarNome()
    {
        return nome = verificação.Ler_Str("Digite o novo nome do produto: ");
    }
    public decimal AlterarPreco()
    {
        return preco = verificação.Ler_Dec("Digite o novo preço do produto: ");
    }
    public int AlterarQuantidade()
    {
        return quantidade = verificação.Ler_Int("Digite a nova quantidade do produto: ");
    }

}
