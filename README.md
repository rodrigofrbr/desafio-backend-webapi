# Inforce: Desafio Backend Developer
Este documento descreve o desafio que será utilizado para avaliar os candidatos à vaga de backend na Inforce. Caso você tenha chegado aqui por acaso, sinta-se à vontade em realizar o teste, e logo após, contar um pouco mais sobre você através do formulário de RH do nosso site (http://inforce.com.br/rh).

# O desafio:
A equipe de produtos da Inforce descobriu que uma das solicitações mais recorrentes dos nossos clientes, a construção de um ferramenta de tarefas, onde o cliente acessará um link e informará as tarefas à serem feitas. A medida que a pessoa for realizando a tarefa, a mesma irá excluir a tarefa para tirar da lista e dar sequência para as próximas.

Desta forma, conversando com o time descobrimos que você será o responsável por criar criar a API que faça um CRUD das tarefas, ou seja:

- Crie um projeto webapi; 

- Crie uma base de dados com os dados informados abaixo;

- Faça um CRUD de tarefas. Será necessário gerar 5 endpoints para atender à esta finalidade, à saber:
  - Listar todas as tarefas
  - Buscar uma tarefa em especifico;
  - Criar uma tarefa nova;
  - Excluir uma tarefa;
  - Editar uma tarefa;

**O que não fazer:**
Vamos manter o desafio simples, ou seja, não crie tarefas diferentes para cada usuário ou coisas do gênero. A ideia é saber se você consegue criar uma API seguindo boas práticas e que faça persistência no banco de dados.

# Requisitos técnicos (para vaga de C#):
- Utilizar a base de dados mysql;
- Você pode utilizar o .NET Framework. Entranto, seria um diferencial construir a API com dotnet core 3.1.
- Utilizar o Entity Framework para a camada de persistência;
- Adotar as melhores práticas do mercado para construção de APIs;

# O que será avaliado:
- **Organização do código**: Como você organiza os arquivos que compõem a solução;
- **Estruturação do código**: Como você estrutura o código e a solução do projeto (arquitetura adotada, etc);
- **Criatividade/Inovação:** Capacidade de sugerir melhorias no contexto descrito no desafio;
- **Nomenclatura/padrões:** A nomenclatura e padrões adotados para as propriedades, atributos, endpoints e nome do projeto;
- **Utilização do Git:** O readme do repositório e a descrição dos commit deverão ser claros e de fácil entendimento;

# Entrega:
O candidato deverá criar um fork deste projeto, e a partir deste fork, realizar o desenvolvimento. Favor utilizar o "Readme" do seu fork para descrever as dificuldades técnicas encontradas, como você as superou e, principalmente, como subir o projeto. Ao finalizar, você deverá responder ao e-mail que te enviou esse desafio, com o link do seu fork.
