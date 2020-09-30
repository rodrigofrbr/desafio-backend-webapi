## O Projeto:
O projeto foi criado a partir do donet core 3.1 com Entity Framework e PomeloFramework para fazer a persistência no banco de dados MySQL.
O model Tarefa contém: Id, Título e Descrição e herda do Model Entity os seguintes conteúdos: Data de criação e Data de atualização.
A visualização das tuplas de cada tarefa contém, para o usuário, apenas: Título, Descrição, Data de criação e Data de atualização. O conteúdo Id fica restrito ao responsável pela manipulação do banco de dados.
## Inicialização do projeto:
Para rodar o projeto localmente: 
1) Não esquecer de configurar o servidor do banco de dados MySQL da sua máquina no arquivo "appsettings.json"
2) Deletar pasta Migrations
3) Comunicar com o banco de dados MySQL e criar as tabelas a partir do gerenciador de pacotes com o comando Add-Migration (nome da tabela) e, após, atualizar com o comando Update-Database
4) Rodar a API
OBS: Projeto feito rodando a IDE Visual Studio...
## Principal dificuldade:
Quando uma tarefa for criada ou atualizada é necessário guardar a data de criação e atualização. Quando criado apenas um model, esses dois conteúdos seriam manipulados pelo usuário não sendo feitos de forma automática.
## Solução:
Criar outro model de base para qualquer model da aplicação, nesse caso Entity que possuirá os seguintes conteúdos: dataCriar e dataUpdate que serão responsáveis reespectivamente pela data de criação e atualização.
O TarefasController utiliza para o relacionamento com o banco de dados o metodo SaveChangesAsync(). Toda vez que é feita a criacao ou update no banco de dados esse método é obrigatoriamente chamado para o sucesso da persistência no banco de dados. 
Podemos utilizar esse comportamento a fim de, no momento que for chamado, pausa-lo para a execuçãoao de um método que será responsavel por preencher o dataCriar e dataUpdate do Entity.
## Considerações finais:
Inicialmente houve certa dificuldade com relação a linguagem C#, visto que, como disse, havia conhecimento em desenvolvimento Back-End, principalmente, utilizando NodeJS e JavaScript. Naturalmente, devido ao uso mais constante de outro paradigma e sintaxe houve demora em relação a aplicação de lógia.
A organização e arquitetura de projeto Web que levava do NodeJS me permitiu entender sem muitas dificuldades o dot net core e Entity Framework com apenas algumas consultas à documentação e boas práticas na internet.
Como estou iniciando com essas tecnologias, meu primeiro contato impediu que, naturalmente, a aplicação ficasse ainda melhor devido ao desconhecimento de métodos e funcionalidades presentes nessa tecnologia mas acredito que entreguei um projeto sólido e responsivo de acordo com os requisitos do desafio.
