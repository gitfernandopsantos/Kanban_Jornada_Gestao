Projeto KanbanGestao
Atualização do Banco de Dados
Para atualizar o banco de dados com o contexto KanbanGestaoDbContext, siga estas etapas:

Abra o Terminal: Acesse o terminal ou prompt de comando no seu ambiente de desenvolvimento.

Navegue até o Diretório do Projeto: Use o comando cd para acessar o diretório do projeto onde o DbContext está localizado.

bash
Copiar código
cd /caminho/para/seu/projeto
Execute o Comando de Atualização: Use o comando update-database para aplicar as migrações ao banco de dados.

Console do Gerenciador de Pacotes
update-database -context KanbanGestaoDbContext

Configuração da Conexão PostgreSQL
Para configurar uma conexão PostgreSQL local, siga estas etapas:

Instale o PostgreSQL: Se ainda não tiver o PostgreSQL instalado, faça o download e a instalação a partir do site oficial do PostgreSQL.

Crie um Banco de Dados: Após a instalação, crie um banco de dados chamado postgres (ou outro nome de sua escolha) usando o pgAdmin ou a linha de comando do PostgreSQL.

Configure a String de Conexão: No arquivo de configuração do seu projeto (por exemplo, appsettings.json), adicione a string de conexão para o PostgreSQL:

{
  "ConnectionStrings": {
    "Postgres": "Host=localhost;Database=postgres;Username=postgres;Password=TesteKanban@2345;Port=5432;Pooling=true;"
  }
}

Esta string de conexão contém as seguintes informações:

Host: localhost (endereço do servidor PostgreSQL, geralmente localhost para conexão local)
Database: postgres (nome do banco de dados que você criou)
Username: postgres (nome de usuário do PostgreSQL)
Password: TesteKanban@2345 (senha do usuário do PostgreSQL)
Port: 5432 (porta padrão do PostgreSQL)
Pooling: true (habilita o pool de conexões para melhorar o desempenho)
Verifique a Conexão: Teste a conexão para garantir que tudo está configurado corretamente. Você pode fazer isso executando o projeto ou usando ferramentas como pgAdmin para verificar a conexão.