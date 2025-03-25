🚀 Tasky - To-Do List MVC Application
Este é um projeto de uma aplicação de lista de tarefas desenvolvida com ASP.NET MVC. Abaixo estão as instruções para rodar o código localmente e configurar o banco de dados.

🛠️ Pré-requisitos
Antes de começar, verifique se você tem os seguintes softwares instalados:

Visual Studio, com suporte para desenvolvimento .NET

SQL Server ou um banco de dados equivalente

.NET SDK versão 6 ou superior

⚙️ Configuração do Ambiente
1. Clone o Repositório
Primeiro, clone o repositório para o seu ambiente local:

bash
Copiar
git clone https://github.com/seu_usuario/tasky.git
2. Restaurar Dependências
No Visual Studio ou terminal, navegue até o diretório do projeto e execute:

bash
Copiar
dotnet restore
3. Configuração do Banco de Dados
A aplicação usa o Entity Framework para se comunicar com o banco de dados. Para configurar o banco de dados, siga os passos abaixo:

3.1. Configuração da String de Conexão
No arquivo appsettings.json, localize a chave ConnectionStrings e configure-a para o seu banco de dados local ou servidor. Exemplo:

json
Copiar
"ConnectionStrings": {
    "DefaultConnection": "Server=(localdb)\\mssqllocaldb;Database=TaskyDb;Trusted_Connection=True;MultipleActiveResultSets=true"
}
3.2. Criar o Banco de Dados
Use o Entity Framework para criar as tabelas no banco de dados. Execute o seguinte comando no terminal dentro da pasta do projeto:

bash
Copiar
dotnet ef database update
Este comando irá aplicar as migrações e criar o banco de dados com todas as tabelas necessárias.

4. Rodar a Aplicação
4.1. Executando a Aplicação no Visual Studio
Abra o projeto MVC-to-do-list.sln no Visual Studio e clique em "Run" ou pressione Ctrl+F5 para iniciar a aplicação.

4.2. Executando no Terminal
Se preferir usar o terminal, navegue até a pasta do projeto e execute o seguinte comando:

bash
Copiar
dotnet run
Isso iniciará o servidor localmente. Abra seu navegador e acesse:

arduino
Copiar
http://localhost:5000

🛠️ Solução de Problemas Comuns
1. Erro ao Conectar ao Banco de Dados
Verifique a string de conexão no appsettings.json para garantir que os detalhes do seu servidor de banco de dados estão corretos.

Certifique-se de que o SQL Server está em execução e acessível.

2. Problemas ao Rodar as Migrations
Se ocorrer um erro relacionado à migração, tente executar o comando novamente:

bash
Copiar
dotnet ef database update
Verifique se o Entity Framework está corretamente instalado e configurado.

3. Acesso à Aplicação
Se o servidor não estiver respondendo, certifique-se de que o projeto está rodando na porta correta. Por padrão, a aplicação deve rodar em http://localhost:5000.
