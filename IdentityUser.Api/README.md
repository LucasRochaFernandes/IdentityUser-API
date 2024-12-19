# Projeto ASP .NET com Implementa��o de Identity

## Vis�o Geral

Este projeto utiliza **ASP.NET Core** para implementar autentica��o e autoriza��o de usu�rios com **Identity**. A autentica��o � baseada em **tokens JWT**, protegendo rotas e garantindo a seguran�a da aplica��o.

---

## Funcionalidades

- Cadastro e autentica��o de usu�rios com **ASP.NET Identity**.
- Gera��o de **tokens JWT** para proteger rotas.
- Integra��o com banco de dados PostgreSQL via **Entity Framework Core**.

---

## Estrutura do Projeto

- **Controllers**: Controladores respons�veis pelos endpoints (ex.: `UserController.cs`).
- **Services**: Cont�m a l�gica de autentica��o (`LogInService.cs`) e registro de usu�rios (`RegisterUserService.cs`).
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

## Configura��o e Execu��o

1. **Banco de Dados**: Execute o comando abaixo para criar o container PostgreSQL:
   ```bash
   docker-compose up -d
   ```
2. **Configura��o**: Atualize a **Connection String** no `appsettings.json` com os dados do container.
3. **Migra��es**: Aplique as migra��es:
   ```bash
   dotnet ef database update
   ```
4. **Iniciar a API**: Execute a aplica��o:
   ```bash
   dotnet run
   ```

---

## Testando a API

- **Cadastro de Usu�rio**: `POST /api/user/register`
- **Login**: `POST /api/user/login`
  - Gera um **token JWT** para acesso �s rotas protegidas.
- Use ferramentas como **Postman** ou o arquivo `IdentityUser.Api.http` para testar.

---

## Melhorias Futuras

- Integra��o com provedores externos (Google, Facebook).
- Pol�ticas de autoriza��o avan�adas e roles espec�ficas.

---
