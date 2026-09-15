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
                    int id = verificação.Ler_Int("Digite o ID do produto: ");
                    string nome = verificação.Ler_Str("Digite o nome do produto: ");
                    decimal preco = verificação.Ler_Dec("Digite o preço do produto: ");
                    int quantidade = verificação.Ler_Int("Digite a quantidade do produto: ");
                    service.Cadastro(id, nome, preco, quantidade);
                    break;
                case 2:
                    service.Listar();
                    break;
                case 3:
                    service.BuscaPreco();
                    break;
                case 4:
                    service.SimulacaoDes();
                    break;
                case 5:
                    service.Deletar();
                    break;
                case 6:
                    service.Alterar();
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