# Sistema de Supermercado Strawberry

Sistema de gerenciamento de estoque e de vendas desenvolvido em **Windows Forms com C# e MySQL**, criado para facilitar o controle de produtos, a realização de vendas com aplicação de descontos e a emissão de notas fiscais digitais.

---

## Integrantes:

- Sabryna Rodrigues - RA: 924204851
- Marcus Vinicius Gomes Pereira - RA:925104391


---

# Descrição do Sistema:

O **Sistema de Supermercado Strawberry** é dividido em três módulos principais, cobrindo desde o gerenciamento de estoque até o fechamento da venda.

---

# 1. Página de Cadastro (Gerenciamento de Estoque)

Interface completa de **CRUD (Create, Read, Update e Delete)** para administração dos produtos.

## Funcionalidades

- Cadastro de produtos com:
  - Código
  - Nome
  - Categoria
  - Quantidade em estoque
  - Preço
  - Imagem do produto

- Controle de mídia:
  - Seleção de imagem
  - Remoção de imagem

- Listagem em tempo real dos produtos cadastrados no banco de dados.

## Regras de Negócio

### Exclusão de Produto
A exclusão exige obrigatoriamente a inserção do código do produto.

### Atualização de Produto
Para atualizar um item, é necessário informar:
- Nome
- Categoria
- Código correspondente

---

# 2. Página de Compras (Carrinho)

Ambiente responsável pela operação das vendas.

## Funcionalidades

- Visualização dos produtos disponíveis
- Seleção de itens para o carrinho
- Definição da quantidade desejada
- Aplicação de desconto sobre o valor total da compra
- Finalização da compra

---

# 3. Página de Nota Fiscal

Após a conclusão da venda, o sistema gera automaticamente uma nota fiscal digital contendo:

- Informações institucionais
- Dados da transação
- Resumo da compra:
  - Produtos
  - Quantidades
  - Preços
  - Descontos aplicados

## Recursos adicionais

- Download da nota fiscal em formato `.txt`
- Botão para iniciar uma nova compra
- Opção para fechar a página

---

# Tecnologias Utilizadas

| Tecnologia | Descrição |
|---|---|
| Linguagem | C# |
| Framework | Windows Forms |
| IDE | Visual Studio |
| Banco de Dados | MySQL |
| Driver de Conexão | MySql.Data |

---

# Configuração do Banco de Dados

Certifique-se de possuir o **MySQL Server** e o **MySQL Workbench** (ou ferramenta similar) instalados.

Execute o script abaixo para criar o banco de dados e a tabela necessária:

```sql
-- 1. Criação do Banco de Dados
CREATE DATABASE supermercado
/*!40100 DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci */
/*!80016 DEFAULT ENCRYPTION='N' */;

USE supermercado;

-- 2. Criação da Tabela de Produtos
CREATE TABLE produtos (
  Codigo INT NOT NULL AUTO_INCREMENT,
  Nome VARCHAR(150) NOT NULL,
  Categoria VARCHAR(100) DEFAULT NULL,
  QuantidadeEstoque INT DEFAULT '0',
  Preco DECIMAL(10,2) DEFAULT NULL,
  DataCadastro DATETIME DEFAULT CURRENT_TIMESTAMP,
  Imagem VARCHAR(255) DEFAULT NULL,
  PRIMARY KEY (Codigo)
) ENGINE=InnoDB
AUTO_INCREMENT=8
DEFAULT CHARSET=utf8mb4
COLLATE=utf8mb4_0900_ai_ci;
```

---

# Como Executar o Projeto

## 1. Clonar ou Baixar o Projeto

Faça o download dos arquivos do projeto para sua máquina.

---

## 2. Configurar a Conexão com o Banco

Localize o arquivo de conexão do projeto (exemplo: `Conexao.cs`, `App.config` ou similar).

Atualize a string de conexão com os dados do seu MySQL:

```csharp
server=localhost;
uid=seu_usuario;
pwd=sua_senha;
database=supermercado;
```

---

## 3. Abrir no Visual Studio

Abra o arquivo da solução (`.sln`) no Visual Studio.

---

## 4. Restaurar Dependências

Caso existam pacotes NuGet instalados (como o driver do MySQL), o Visual Studio realizará a restauração automaticamente ao compilar o projeto.

---

## 5. Executar o Sistema

Clique em **Start / Iniciar** ou pressione:

```text
F5
```

para executar a aplicação.

---

# Usuário e Senha

Atualmente, o sistema não possui autenticação de usuários.

O acesso é liberado após a configuração correta da conexão com o banco de dados.

---

# 📂 Estrutura do Projeto

O projeto contém:

- Sistema de cadastro de produtos
- Controle de estoque
- Sistema de vendas (PDV)
- Carrinho de compras
- Aplicação de descontos
- Emissão de nota fiscal digital
- Exportação de nota fiscal em `.txt`

---

# Observações

- As imagens dos produtos são armazenadas via caminho/localização.
- O sistema foi desenvolvido para fins acadêmicos e de aprendizado em:
  - Desenvolvimento Desktop
  - Banco de Dados
  - Integração C# + MySQL
  - CRUD
  - Manipulação de arquivos

---
