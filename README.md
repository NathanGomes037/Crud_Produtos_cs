# CRUD de Produtos — C#

[![C#](https://img.shields.io/badge/C%23-8A2BE2?style=for-the-badge\&logo=csharp\&logoColor=white)](https://dotnet.microsoft.com/)
[![.NET](https://img.shields.io/badge/.NET-512BD4?style=for-the-badge\&logo=dotnet\&logoColor=white)](https://dotnet.microsoft.com/)
[![Git](https://img.shields.io/badge/Git-F05032?style=for-the-badge\&logo=git\&logoColor=white)](https://git-scm.com/)

## Sobre o projeto

Aplicação de **gerenciamento de produtos desenvolvida em C#**, executada via terminal, criada com o objetivo de praticar fundamentos da linguagem e consolidar conhecimentos de lógica de programação.

O projeto é uma evolução de um CRUD desenvolvido anteriormente em **C++**, permitindo aplicar conceitos já conhecidos em uma nova linguagem e compreender suas diferenças de sintaxe e recursos.

A aplicação implementa operações de **CRUD (Create, Read, Update e Delete)** para gerenciamento de produtos.

---

## Funcionalidades

### Gerenciamento de produtos

* **Cadastrar** produtos
* **Listar** produtos cadastrados
* **Consultar** o preço de um produto pelo nome
* **Atualizar** informações dos produtos
* **Excluir** produtos

### Operações com preços

* Consulta de preço por nome
* Simulação de desconto baseada em uma porcentagem informada pelo usuário

### Atualização de produtos

O sistema possui um menu específico para atualização, permitindo selecionar qual característica do produto será modificada.

---

## Conceitos aplicados

Durante o desenvolvimento foram praticados:

* Variáveis e tipos de dados
* Operadores
* Estruturas condicionais
* Estruturas de repetição
* Funções
* Arrays
* Manipulação de strings
* Conversão de tipos
* Validação de entrada
* `TryParse`
* Reutilização de código
* Organização da lógica da aplicação

---

## Tecnologias

| Tecnologia             | Utilização                    |
| ---------------------- | ----------------------------- |
| **C#**                 | Linguagem principal           |
| **.NET**               | Plataforma de desenvolvimento |
| **Visual Studio Code** | Ambiente de desenvolvimento   |
| **Git**                | Controle de versão            |
| **GitHub**             | Hospedagem do projeto         |

---

## Validação de entrada

Um dos principais pontos de aprendizado do projeto foi a utilização do `TryParse` para tratar entradas fornecidas pelo usuário.

O método permite verificar se uma conversão foi realizada corretamente antes de utilizar o valor recebido pela aplicação.

Exemplo:

```csharp
if (int.TryParse(Console.ReadLine(), out int opcao))
{
    // Processamento da opção
}
else
{
    Console.WriteLine("Opção inválida.");
}
```

Essa abordagem ajuda a evitar erros causados por entradas inválidas e torna a interação com o programa mais segura.

---

## Aprendizados

O desenvolvimento deste projeto contribuiu para meu aprofundamento em **C# e lógica de programação**.

Um dos principais desafios foi me adaptar à sintaxe do C#, especialmente por ter desenvolvido anteriormente um projeto semelhante em C++.

Também tive dificuldades inicialmente com o funcionamento do `TryParse`. Após compreender seu retorno booleano e a utilização da variável de saída (`out`), consegui aplicá-lo para validar entradas do usuário.

Outro aprendizado importante foi perceber a necessidade de **reutilização de código**. Algumas verificações estavam sendo repetidas em diferentes partes da aplicação. Para melhorar essa estrutura, foram criadas funções responsáveis por tarefas específicas.

Esse processo ajudou a desenvolver não apenas conhecimentos de C#, mas também a capacidade de identificar problemas e buscar soluções durante o desenvolvimento.

---

## Próximas melhorias

Este projeto será utilizado como base para aplicar conceitos mais avançados conforme minha evolução nos estudos.

* ☑️ Aplicar Programação Orientada a Objetos (POO)
* ☑️ Substituir arrays por `List<T>`
* ☑️ Melhorar a separação de responsabilidades
* [ ] Implementar persistência de dados
* [ ] Utilizar banco de dados
* [ ] Implementar operações assíncronas
* [ ] Criar uma API REST com ASP.NET Core
* [ ] Integrar a API com banco de dados

---

## Como executar

### Pré-requisitos

É necessário possuir o **.NET SDK** instalado.

### 1. Clone o repositório

```bash
git clone https://github.com/NathanGomes037/Crud_Produtos_cs.git
```

### 2. Acesse o diretório

```bash
cd Crud_Produtos_cs
```

### 3. Execute a aplicação

```bash
dotnet run
```

---

## Estrutura do projeto

```text
Crud_Produtos_cs/
│
├── Program.cs
├── CrudProdutos.csproj
├── .gitignore
└── README.md
```

---

## Objetivo

Este projeto faz parte da minha jornada de aprendizado em desenvolvimento de software.

O objetivo principal é consolidar fundamentos de **C# e lógica de programação** por meio da construção de uma aplicação prática, utilizando o projeto como base para posteriormente estudar **Programação Orientada a Objetos, banco de dados, APIs REST e desenvolvimento Backend com .NET**.

---

## Autor

**Nathan Gomes**

Estudante de **Desenvolvimento de Software Multiplataforma**.

Atualmente direcionando meus estudos para **desenvolvimento Backend**, com foco em **C#, .NET, SQL e desenvolvimento de APIs**.

---

⭐ Este projeto está em evolução e será atualizado conforme novos conceitos forem incorporados.
