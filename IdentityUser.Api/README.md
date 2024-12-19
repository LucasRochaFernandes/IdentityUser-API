# Projeto ASP .NET com Implementação de Identity

## Visão Geral

Este projeto utiliza **ASP.NET Core** para implementar autenticação e autorização de usuários com **Identity**. A autenticação é baseada em **tokens JWT**, protegendo rotas e garantindo a segurança da aplicação.

---

## Funcionalidades

- Cadastro e autenticação de usuários com **ASP.NET Identity**.
- Geração de **tokens JWT** para proteger rotas.
- Integração com banco de dados PostgreSQL via **Entity Framework Core**.

---

## Estrutura do Projeto

- **Controllers**: Controladores responsáveis pelos endpoints (ex.: `UserController.cs`).
- **Services**: Contém a lógica de autenticação (`LogInService.cs`) e registro de usuários (`RegisterUserService.cs`).
- **Database**: Gerencia entidades e contexto do banco de dados (`ApplicationDbContext.cs`).
- **Docker**: Arquivo `docker-compose.yml` para criar o container PostgreSQL.

---

## Tecnologias

- **ASP.NET Core**
- **Entity Framework Core**
- **ASP.NET Identity**
- **JWT (JSON Web Token)**
- **PostgreSQL**
- **Docker**

---

## Configuração e Execução

1. **Banco de Dados**: Execute o comando abaixo para criar o container PostgreSQL:
   ```bash
   docker-compose up -d
   ```
2. **Configuração**: Atualize a **Connection String** no `appsettings.json` com os dados do container.
3. **Migrações**: Aplique as migrações:
   ```bash
   dotnet ef database update
   ```
4. **Iniciar a API**: Execute a aplicação:
   ```bash
   dotnet run
   ```

---

## Testando a API

- **Cadastro de Usuário**: `POST /api/user/register`
- **Login**: `POST /api/user/login`
  - Gera um **token JWT** para acesso às rotas protegidas.
- Use ferramentas como **Postman** ou o arquivo `IdentityUser.Api.http` para testar.

---

## Melhorias Futuras

- Integração com provedores externos (Google, Facebook).
- Políticas de autorização avançadas e roles específicas.

---
