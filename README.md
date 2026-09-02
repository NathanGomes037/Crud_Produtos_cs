# CRUD de Produtos em C#

Aplicação de gerenciamento de produtos desenvolvida em **C#** com o objetivo de praticar fundamentos de programação, estruturas de controle, funções, arrays e validação de entrada de dados.

Este projeto representa uma evolução de um CRUD desenvolvido anteriormente em **C++**, permitindo aplicar os mesmos conceitos em C# e aprofundar o conhecimento na linguagem.

---

## Sobre o projeto

O sistema consiste em uma aplicação executada via terminal para gerenciamento de produtos.

A aplicação permite realizar as principais operações de um CRUD:

- **Create** — cadastrar produtos
- **Read** — listar e consultar produtos
- **Update** — atualizar informações
- **Delete** — remover produtos

Além das operações básicas, o sistema possui funcionalidades adicionais para consulta de preços e simulação de descontos.

---

## Funcionalidades

### Gerenciamento de produtos

- Cadastrar novos produtos
- Listar produtos cadastrados
- Buscar o preço de um produto pelo nome
- Atualizar informações de um produto
- Excluir produtos cadastrados

### Operações com preços

- Consultar preço de um produto
- Simular descontos utilizando uma porcentagem informada pelo usuário

### Atualização

A atualização dos produtos possui um menu específico, permitindo que o usuário escolha qual característica deseja modificar sem precisar alterar todas as informações do produto.

---

## Tecnologias

| Tecnologia | Utilização |
|------------|------------|
| C# | Desenvolvimento da aplicação |
| .NET | Execução e gerenciamento do projeto |
| Visual Studio Code | Ambiente de desenvolvimento |
| Git | Controle de versão |
| GitHub | Hospedagem do código |

---

## Conceitos praticados

Durante o desenvolvimento foram aplicados conceitos fundamentais de programação:

- Variáveis e tipos de dados
- Operadores
- Estruturas condicionais
- Estruturas de repetição
- Funções e reutilização de código
- Arrays
- Manipulação de strings
- Validação de entrada de dados
- Conversão de tipos
- `TryParse`
- Organização e fluxo de execução de um programa

---

## Validação de dados

Um dos pontos trabalhados durante o desenvolvimento foi a validação das entradas fornecidas pelo usuário.

Para evitar erros durante a conversão de valores, foi utilizado o método `TryParse`.

Exemplo:

```csharp
if (int.TryParse(Console.ReadLine(), out int opcao))
{
    // Processamento da opção
}
else
{
    Console.WriteLine("Valor inválido.");
}
