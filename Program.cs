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
                    service.Cadastro();
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