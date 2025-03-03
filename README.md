# 📌 Math API - ASP.NET Core

API RESTful para operações matemáticas, incluindo soma e média aritmética.

---

## 🚀 **Tecnologias Utilizadas**
- **.NET 8.0** – Plataforma de desenvolvimento para construção da API.
- **ASP.NET Core Web API** – Framework para criação de APIs RESTful.
- **xUnit** – Framework de testes unitários.
- **Swagger** – Ferramenta de documentação e interface interativa da API.

---

## 🔧 **Como Executar o Projeto**

### **1️⃣ Pré-requisitos**
Antes de iniciar, certifique-se de que você tem as seguintes ferramentas instaladas:

- [**.NET 8 SDK**](https://dotnet.microsoft.com/en-us/download/dotnet/8.0)
- [**Git**](https://git-scm.com/)

### **2️⃣ Clonar o Repositório**
Clone o repositório em sua máquina local com os seguintes comandos:
```sh
git clone https://github.com/seu-usuario/math-api-dotnet.git
cd math-api-dotnet
```

### **3️⃣ Executar a API**
Após clonar o repositório e navegar até a pasta do projeto, execute o comando abaixo para iniciar a API:
```sh
dotnet run
```
A API estará rodando localmente em seu computador, e você poderá acessar a documentação interativa através do Swagger na URL:

[http://localhost:5172/swagger](http://localhost:5172/swagger)

---

## 📌 **Endpoints Disponíveis**

### **1️⃣ Soma (`POST /math/operations/sum`)**

#### 📌 **Requisição:**
```json
POST /math/operations/sum
Content-Type: application/json

{
  "numbers": [1, 2, 3, 4]
}
```

#### 📌 **Resposta Esperada:**
```json
{
  "result": 10
}
```

---

### **2️⃣ Média Aritmética (`GET /math/operations/average`)**

#### 📌 **Requisição:**
```sh
GET /math/operations/average?numbers=10,20,30
```

#### 📌 **Resposta Esperada:**
```json
{
  "result": 20
}
```

---

## **Executar Testes Unitários**
Para garantir que todos os testes estão passando, execute o seguinte comando no terminal:
```sh
dotnet test
```

---

## 👨‍💻 **Autor**
- [Wesley Canaam](https://github.com/Canaam)


