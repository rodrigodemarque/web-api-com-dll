# 🚗 Web API - Sistema de Gestão de Carros

API REST desenvolvida em **C#** no **.NET Framework 4.3**, com **SQL Server Express** e uso de **DLLs** para organização e reutilização de código.

---

## 📌 Tecnologias Utilizadas
- **C#**  
- **.NET Framework 4.3**  
- **SQL Server Express**  
- **Visual Studio 2022**  
- **Postman** (para testes)  

---

## ⚙️ Requisitos para Rodar
Antes de executar o projeto, certifique-se de ter instalado:
1. **Visual Studio 2022** com suporte a `.NET Framework`  
2. **SQL Server Express** ou versão compatível  
3. **Postman** para testes de requisições (opcional)  

---

## 🚀 Executando a Solução
1. Clone o repositório:
   ```bash
   git clone https://github.com/rodrigodemarque/web-api-com-dll.git
Abra a solução no Visual Studio 2022

Configure a string de conexão no arquivo Web.config apontando para seu banco local

Pressione F5 para iniciar o servidor local

📡 Endpoints Disponíveis
Método	Endpoint	Descrição  
GET	/api/carros	Retorna todos os carros  
GET	/api/carros/{id}	Retorna carro pelo ID  
GET	/api/carros/nome	Retorna carros pelo Nome  
POST	/api/carros	Cria um novo carro  
PUT	/api/carros/{id}	Atualiza um carro existente  
DELETE	/api/carros/{id}	Remove um carro  

📂 Estrutura do Projeto  
bash
Copiar
Editar
/web-api-com-dll  
│── /Controllers       → Controladores da API  
│── /Models            → Modelos de dados  
│── /DAL               → Data Access Layer (DLL)  
│── /BLL               → Business Logic Layer (DLL)  
│── /bin               → Arquivos compilados  
│── Web.config         → Configurações da aplicação  
│── web-api.sln        → Arquivo da solução  
🛠 Boas Práticas no Repositório  
O arquivo .gitignore foi configurado para ignorar binários, arquivos temporários e configurações locais do Visual Studio.

Apenas código-fonte e arquivos essenciais estão versionados.

As DLLs estão no repositório para garantir execução em qualquer ambiente.

✨ Autor
Rodrigo Demarque da Silva
📧 rodrigodemarque@gmail.com
🔗 www.linkedin.com/in/rodrigodemarque

ℹ️ Este projeto foi desenvolvido para fins acadêmicos.
