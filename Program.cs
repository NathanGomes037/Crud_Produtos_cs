using System.Runtime;

class Program
{
    static string [] nome_produto = new string[30];
    static int [] preco_produto = new int[30];
    static int CadastroControle = 0;
    static int [] quantidade_produtos = new int[30];
    //jogar um menu em todas as funções 
    static int LerInteiro(string mensagem)
    {
        Console.WriteLine(mensagem);
        if(int.TryParse(Console.ReadLine(), out int valor))
        {
            return valor;
        }
        else
        {
            Console.WriteLine("Entrada inválida. Por favor, digite um número inteiro.");
            return LerInteiro(mensagem);
        }
    }
        static string Lerlinha(string mensagem)
    {
        Console.WriteLine(mensagem);
        string vlr;
        do
        {
            vlr = Console.ReadLine();

        }while(string.IsNullOrWhiteSpace(vlr));
        return vlr;
    }
    static void Cadastro()
    {
        int Quantidade = LerInteiro("Digite a quantidade de produtos a cadastrar: ");
        if(CadastroControle + Quantidade <= nome_produto.Length)
        {
            int fim = CadastroControle + Quantidade;
            for(int i= CadastroControle; i<fim; i++)
            {
                nome_produto[i]= Lerlinha("Digite o nome do produto: ");
                preco_produto[i] = LerInteiro("Digite o preço do produto: ");
                quantidade_produtos[i]= LerInteiro("Digite a quantidade do produto: ");
                
            }
            CadastroControle = fim;
        }
        else
        {
            Console.WriteLine("excedeu o limite de cadastro, o maximo é 30");
        }
        
    }
    static void Listar()
    {
        Console.WriteLine("Lista de Produtos Cadastrados: ");
        Console.WriteLine("------------------------------");
        for(int i= 0; i< CadastroControle; i++)
        {
            Console.WriteLine("**************************************");
            Console.WriteLine("Nome do Produto: " + nome_produto[i]);
            Console.WriteLine("Preço do Produto: " + preco_produto[i]);
            Console.WriteLine("Quantidade do Produto: " + quantidade_produtos[i]);
            Console.WriteLine("**************************************");
        }
    }
    static void BuscaPreco()
    {
        string busca = Lerlinha("digite o nome do produto que deseja consultar o preço: ");
        bool encontrado = false;
        for(int i= 0; i< CadastroControle ; i++){
            if(busca.ToLower()== nome_produto[i].ToLower())
            {
                Console.WriteLine("**************************************");
                Console.WriteLine("nome: " + nome_produto[i]);
                Console.WriteLine("preço: " + preco_produto[i] + " Reais");
                Console.WriteLine("**************************************");
                encontrado=true;
            }
        }
        if (encontrado == false)
        {
            Console.WriteLine("Produto não encontrado");
        }
    }
    static void SimulacaoDes()
    {
        double per = LerInteiro("Digite a quantidade de desconto em porcentagem: ");
        string busca = Lerlinha("digite o nome do produto que deseja aplicar o desconto: ");
        bool encontrado = false;
        for(int i= 0; i< CadastroControle ; i++){
            if(busca.ToLower() == nome_produto[i].ToLower())
            {
                double calculo= preco_produto[i]-(preco_produto[i]*per/100);
                double desconto= preco_produto[i]*per/100;
                Console.WriteLine("o preço do produto é: " + preco_produto[i] +" o desconto é de: "+ desconto + " o preço após a aplicção do desconto é: "+ calculo);
                encontrado = true;
            }
        }
        if (encontrado == false)
        {
            Console.WriteLine("Produto não encontrado, não é possivel fazer a simulaçao de desconto");
        }

    }
    static void Deletar()
    {
        string busca = Lerlinha("digite o nome do produto que deseja deletar: ");
        bool encontrado = false;
        for(int i=0; i<CadastroControle; i++)
        {
            if(busca.ToLower() == nome_produto[i].ToLower())
            {
                for(int j=i; j<CadastroControle - 1; j++)
                {
                    nome_produto[j]= nome_produto[j+1];
                    preco_produto[j]= preco_produto[j+1];   
                    quantidade_produtos[j]= quantidade_produtos[j+1];
                }
                CadastroControle--;
                encontrado = true;
                Console.WriteLine("produto deletado com sucesso!!");
            }
        }
        if (encontrado == false)
        {
            Console.WriteLine("Produto não encontrado.");
        }
    }
    static void Alterar()
    {
        string Busca = Lerlinha("Digite o nome do produto que deseja Alterar: ");
        bool encontrado = false;
        int op = 0;
        for(int i=0; i<CadastroControle; i++)
        {
            if (Busca.ToLower() == nome_produto[i].ToLower())
            {
                int n = i;
                encontrado = true;
                do
                {
                Console.WriteLine("*************************************************");
                Console.WriteLine("menu de atualização do produto");
                Console.WriteLine("1- atualizar Nome do Produto");
                Console.WriteLine("2- atualizar Preço do Produto");
                Console.WriteLine("3- atualizar quantidade do produto");
                Console.WriteLine("4- atualizar tudo ");
                Console.WriteLine("0- fechar menu de atualizaçaõ");
                Console.WriteLine("*************************************************");
                op= LerInteiro("selecione uma opção");

                switch (op)
                    {
                    case 1:
                        nome_produto[n] = Lerlinha("qual seria o novo nome do produto?");
                        break;
                    case 2:
                        preco_produto[n] = LerInteiro("qual seria o novo preço do produto?");
                        break;
                    case 3:
                        quantidade_produtos[n] = LerInteiro("qual seria a nova quantidae de produtos no estoque? ");
                        break;
                    case 4:
                        nome_produto[n] = Lerlinha("qual seria o novo nome do produto?");
                        preco_produto[n] = LerInteiro("qual seria o novo preço do produto?");
                        quantidade_produtos[n] = LerInteiro("qual seria o nova quantidade de produtos no estoque?");
                        break;
                    case 0:
                        Console.WriteLine("fechando o menu de atualização de produto");
                        break;
                    default:
                        Console.WriteLine("opção invalida");
                        break;
                }

                }while(op != 0);
            }
        }
        if(encontrado == false)
        {
            Console.WriteLine("Produto não encontrado");
        }
}


    public static void Main(string[] args)
    {
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
            opcao = LerInteiro("Digite sua opção: ");
            switch (opcao)
            {
                case 1:
                    Cadastro();
                    break;
                case 2:
                    Listar();
                    break;
                case 3:
                    BuscaPreco();
                    break;
                case 4:
                    SimulacaoDes();
                    break;
                case 5:
                    Deletar();
                    break;
                case 6:
                    Alterar();
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