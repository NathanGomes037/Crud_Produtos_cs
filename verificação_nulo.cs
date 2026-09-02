class Verificação_nulo{
    public int Ler_Int(string mensagem)
    {
        Console.WriteLine(mensagem);
        if (int.TryParse(Console.ReadLine(), out int valor) && valor >= 0)
        {
           return valor;
        }
        else
        {
            Console.WriteLine("Valor inválido. Digite um número inteiro.");
            return Ler_Int(mensagem);
        }
    }
     public decimal Ler_Dec(string mensagem)
    {
        Console.WriteLine(mensagem);
        if (decimal.TryParse(Console.ReadLine(), out decimal valor) && valor >= 0)
        {
           return valor;
        }
        else
        {
            Console.WriteLine("Valor inválido. Digite um número decimal.");
            return Ler_Dec(mensagem);
        }
    }
     public string Ler_Str(string mensagem)
    {
        Console.WriteLine(mensagem);
        string input = Console.ReadLine();
        if (!string.IsNullOrWhiteSpace(input))
        {
            return input;
        }
        else
        {
            Console.WriteLine("Valor inválido. Digite uma string válida.");
            return Ler_Str(mensagem);
        }
    }
}
     