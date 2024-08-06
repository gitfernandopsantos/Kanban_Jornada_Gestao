Configuração do Front-End com Angular
Este guia explica como instalar e configurar o Angular para o seu projeto front-end usando o Node.js versão 18.18.2.

Pré-requisitos
Node.js: Certifique-se de ter o Node.js versão 18.18.2 instalado no seu sistema. Se ainda não o tiver, siga estas etapas para instalar:

Baixe o Instalador: Acesse o site oficial do Node.js e baixe o instalador para a versão 18.18.2.

Instale o Node.js: Execute o instalador e siga as instruções para completar a instalação.

Verifique a Instalação: Abra o terminal e execute o seguinte comando para verificar se o Node.js foi instalado corretamente:

node -v
O comando deve retornar v18.18.2.

Instale o npm: O npm (Node Package Manager) geralmente é instalado automaticamente com o Node.js. Verifique sua instalação com:

npm -v
Instalação do Angular CLI
O Angular CLI (Command Line Interface) é a ferramenta de linha de comando para Angular. Para instalá-lo, siga estes passos:

Abra o Terminal: Acesse o terminal ou prompt de comando no seu ambiente de desenvolvimento.

Instale o Angular CLI: Execute o comando abaixo para instalar o Angular CLI globalmente.

npm install -g @angular/cli
Verifique a Instalação: Após a instalação, verifique se o Angular CLI foi instalado corretamente com:

ng version
O comando deve mostrar a versão do Angular CLI instalada.

Configuração do Projeto Angular
Para configurar e iniciar o projeto Angular, siga estas etapas:

Clone o Repositório do Projeto: Se ainda não tiver o código do projeto, clone o repositório do projeto:

git clone https://seu-repositorio-url.git
Navegue até o Diretório do Projeto: Use o comando cd para acessar o diretório do projeto.

cd /caminho/para/seu/projeto
Instale as Dependências: Execute o comando abaixo para instalar todas as dependências do projeto.

npm install
Inicie o Servidor de Desenvolvimento: Para iniciar o servidor de desenvolvimento Angular, use o comando:

ng serve
Acesse a Aplicação: Abra seu navegador e vá para http://localhost:4200 para ver a aplicação em execução.