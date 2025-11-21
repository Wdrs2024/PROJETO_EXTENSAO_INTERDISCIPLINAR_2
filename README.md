# PROJETO EXTENSAO INTERDISCIPLINAR 2

# 🏥 Sistema de Gestão PED Hospitalar  

## 📌 Sobre o Projeto  
Este projeto foi desenvolvido como uma aplicação **desktop em C# com Windows Forms**, utilizando **MySQL** como banco de dados e preparado para consumo de **APIs REST**.  
O objetivo é oferecer à empresa **PED Hospitalar** uma solução digital para centralizar informações administrativas, reduzir falhas de comunicação e melhorar a confiabilidade na gestão de clientes, produtos e usuários.  

---

## 🚀 Funcionalidades  
- Cadastro e gerenciamento de **clientes**;  
- Cadastro e gerenciamento de **produtos hospitalares**;  
- Cadastro e controle de **usuários e acessos**;  
- Tela de **login e autenticação** segura;  
- Geração de relatórios básicos a partir do banco de dados;  
- Estrutura preparada para integração com **APIs externas** (ex.: fornecedores, autenticação).  

---

## 🛠️ Tecnologias Utilizadas  
- **C#** – linguagem principal do projeto;  
- **Windows Forms** – construção das interfaces gráficas;  
- **MySQL** – banco de dados relacional para armazenamento seguro das informações;  
- **APIs REST** – integração com serviços externos (futuro).  

---

## 🗄️ Banco de Dados  

 Criar banco de dados

- CREATE DATABASE IF NOT EXISTS ped_hospitalar;
- USE ped_hospitalar;

  Tabela: clientes

CREATE TABLE IF NOT EXISTS clientes (

    Id INT AUTO_INCREMENT PRIMARY KEY,
    Nome VARCHAR(100) NOT NULL,
    Email VARCHAR(100) NOT NULL UNIQUE,
    Telefone VARCHAR(20),
    Endereco VARCHAR(200)
);


 Tabela: produtos

CREATE TABLE IF NOT EXISTS produtos (

    id INT AUTO_INCREMENT PRIMARY KEY,
    nome VARCHAR(100) NOT NULL,
    descricao TEXT,
    preco DECIMAL(10,2) NOT NULL,
    custo DECIMAL(10,2) NOT NULL);


Tabela: usuarios
 
CREATE TABLE IF NOT EXISTS usuarios (

    ID INT AUTO_INCREMENT PRIMARY KEY,
    LOGIN VARCHAR(50) NOT NULL UNIQUE,
    SENHA VARCHAR(255) NOT NULL);

## Dados iniciais (opcional)


1 - Inserindo usuários de teste

- INSERT INTO usuarios (LOGIN, SENHA) VALUES 
- ('admin', '123456'),
- ('teste', '1234');

2 - Inserindo clientes de exemplo

- INSERT INTO clientes (Nome, Email, Telefone, Endereco) VALUES
- ('João Silva', 'joao@email.com', '27999990000', 'Rua A, Itapemirim - ES'),
- ('Maria Oliveira', 'maria@email.com', '27988887777', 'Rua B, Itapemirim - ES');

3 - Inserindo produtos de exemplo

- INSERT INTO produtos (nome, descricao, preco, custo) VALUES
- ('Luvas Cirúrgicas', 'Par de luvas esterilizadas para procedimentos cirúrgicos', 25.00, 15.00),
- ('Cadeira de Rodas', 'Cadeira de rodas hospitalar padrão', 750.00, 500.00);


---

## 📂 Estrutura do Projeto  
```bash
 
 📦 PedHospitalar
 ┣ 📂 apresentacao         # Telas do sistema (Windows Forms)
 ┃ ┣ CadastreSe.cs
 ┃ ┣ ClienteWindow.cs
 ┃ ┣ Form1.cs
 ┃ ┣ PedHospitalar.cs
 ┃ ┣ ProdutoWindow.cs
 ┃ ┗ UsuarioWindow.cs
 ┣ 📂 Conexao              # Conexão e comandos de autenticação
 ┃ ┣ conexao.cs
 ┃ ┗ LoginComados.cs
 ┣ 📂 Modelo               # Classes de entidades (dados do sistema)
 ┃ ┣ Cliente.cs
 ┃ ┣ Controle.cs
 ┃ ┣ Produto.cs
 ┃ ┗ Usuario.cs
 ┣ 📂 Repositorio          # Acesso a dados (CRUD com MySQL)
 ┃ ┣ ClienteRepository.cs
 ┃ ┣ ProdutoRepository.cs
 ┃ ┗ UsuarioRepository.cs
 ┣ App.config              # Configurações da aplicação
 ┣ packages.config         # Gerenciamento de pacotes NuGet
 ┗ Program.cs              # Arquivo principal do sistema
 ┗📜 README.md             # Documentação do projeto

```  

---

## ⚙️ Como Executar o Projeto  

1. **Clone o repositório:**  
   ```bash
   git clone https://github.com/Wdrs2024/PROJETO_EXTENSAO_INTERDISCIPLINAR_2.git
   ```  

2. **Abra o projeto no Visual Studio.**  

3. **Configure o banco de dados MySQL:**  
   - Crie um banco chamado `ped_hospitalar`;  
   - Importe as tabelas necessárias (clientes, produtos, usuários, etc.);  
   - Ajuste a string de conexão em Conexao/conexao.cs. 

   Exemplo:  
   ```csharp
   private static string connectionString = "Server=localhost;Database=ped_hospitalar;Uid=root;Pwd=123456;";
   ```  

4. **Execute o projeto (F5).**  

---

## 📷 Telas do Sistema  
- Tela de Login  
- Tela Principal (Dashboard)  
- Cadastro de Clientes  
- Cadastro de Produtos  
- Gerenciamento de Usuários  

---

## 📌 Status do Projeto  
✔️ Funcionalidades principais implementadas  
🚧 Melhorias futuras: relatórios avançados, integração com fornecedores via API, autenticação externa  

---

## 👨‍💻 Autor  
**Wesley de Souza Pereira**  
📍 Itapemirim - ES  
[GitHub](https://github.com/Wdrs2024)  

