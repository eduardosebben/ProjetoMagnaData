# ProjetoMagnaData
# 📝 Controle de Tarefas (.NET 8 - Windows Forms)

Aplicação desktop desenvolvida em **C# (.NET 8)** com **Windows Forms** e **Entity Framework Core (Code First)** para gerenciamento de tarefas.

O sistema permite criar, editar e concluir tarefas, armazenando os dados em um banco de dados SQL Server.

---

## 🚀 Funcionalidades

- ✔ Cadastro de tarefas
- ✏️ Edição de tarefas
-  X Excluir tarefas
- ✅ Conclusão de tarefas via data de conclusão
- 📋 Listagem de tarefas em grid
- 🔒 Bloqueio de edição para tarefas concluídas
- 🎨 Destaque visual para tarefas concluídas
- ⏱ Controle de data de criação e conclusão

---

## 🧱 Tecnologias utilizadas

- .NET 8
- Windows Forms
- Entity Framework Core (Code First)
- SQL Server
- LINQ

---

## 🗂 Estrutura do Projeto

- `Models` → Entidades (Tarefa)
- `Data` → DbContext (Entity Framework)
- `Form1` → Interface e regras de negócio

---

## ⚙️ Como executar o projeto

### 1. Clonar o repositório

```bash
git clone https://github.com/eduardosebben/ProjetoMagnaData.git

2. Configurar a connection string

No arquivo:

AppDbContext.cs

Altere para o seu SQL Server:

options.UseSqlServer(
    "Server=SEU_SERVIDOR;Database=ControleListaTarefas;Trusted_Connection=True;TrustServerCertificate=True;");

 3. Criar o banco de dados

No terminal (na pasta do projeto):

dotnet ef database update   

4. Executar o projeto

No Visual Studio:

Definir como projeto inicial
Pressionar F5 ou Ctrl + F5
🧠 Regras de Negócio
A data de criação é obrigatória e não pode ser alterada após o salvamento
A data de conclusão é opcional
Uma tarefa é considerada concluída quando possui data de conclusão
Após concluída:
❌ Não pode ser editada
❌ Campos são bloqueados
A data de conclusão não pode ser menor que a data de criação
