
# Metodologia

<span style="color:red">Pré-requisitos: <a href="2-Especificação do Projeto.md"> Documentação de Especificação</a></span>

A metodologia deste trabalho consiste em apresentar o grupo de ferramentas presentes no projeto e a maneira pela qual tais recursos foram utilizados. Foram utilizados tanto recursos para a manutenção do código fonte, quanto ferramentas de gestão e organização de equipe na execução das etapas do projeto.

## Relação de Ambientes de Trabalho

A tabela abaixo demonstra as plataformas nas quais foram desenvolvidos os respectivos artefatos do projeto, além do link para acessá-los:

|Ambiente|Plataforma|Link de Acesso|
|--------|----------|--------------|
|Repositório de código fonte|GitHub|https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2022-2-e2-proj-int-t2-parkquest.git|
|Documentos do projeto|Google Drive|https://docs.google.com/document/d/1XOPhgaiDVECNWLgBvE_L-eR4rTQZ4_Yu/edit#|
|Documentos do projeto|GitHub|https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2022-2-e2-proj-int-t2-parkquest/tree/main/docs|
|Projeto de Interface e  Wireframes|MVC|https://dotnet.microsoft.com/en-us/apps/aspnet| 
|Projeto de Interface e  Wireframes|Visual Studio Code|https://code.visualstudio.com/| 
|Gerenciamento do Projeto|GitHub|https://github.com/orgs/ICEI-PUC-Minas-PMV-ADS/projects/54|
|Comunicação e Reuniões|Microsoft Teams|https://teams.microsoft.com/_#/school/conversations/Grupo%2004?threadId=19:e2f75941b6964dd3abc41bc9ef30f166@thread.tacv2&ctx=channel|


## Controle de Versão

A ferramenta de controle de versão adotada no projeto foi o
[Git](https://git-scm.com/), sendo que o [Github](https://github.com)
foi utilizado para hospedagem do repositório.

O projeto segue a seguinte convenção para o nome de branches:

- `main`: versão estável já testada do software
- `unstable`: versão já testada do software, porém instável
- `testing`: versão em testes do software
- `dev`: versão de desenvolvimento do software

Quanto à gerência de issues, o projeto adota a seguinte convenção para
etiquetas:

- `documentation`: melhorias ou acréscimos à documentação
- `bug`: uma funcionalidade encontra-se com problemas
- `enhancement`: uma funcionalidade precisa ser melhorada
- `feature`: uma nova funcionalidade precisa ser introduzida



## Gerenciamento de Projeto

O gerenciamento e organização do projeto se baseia na metodologia ágil Scrum, que prioriza a entrega de valor e o proporcionamento de uma maior adaptabilidade da equipe. Isso ocorre em função da facilidade desse método em lidar com imprevistos e mudanças no planejamento ao longo do percurso.
A partir dessa metodologia, a equipe está organizada da seguinte maneira:

- **Scrum Master**: Gabriela Barbosa Caetano Abran
- **Product Owner**: Fabiana Alkmim Avelar
- **Equipe de Desenvolvimento**:
     - Herbert Nordson Silva dos Santos 
     - Samuel de Jesus Santos
     - Letícia Alves dos Santos Rosolem
- **Equipe de Design**:
     - Ramon Bicalho Cruz Magalhães 
     
Como já dito, para o gerenciamento, organização e distribuição das tarefas, utiliza-se a ferramenta do Github. As Sprints estão estruturadas no formato de marcos, conforme demonstrado abaixo:

![](/docs/img/milestone.png)

Além disso, temos o Backlog do Produto elaborado pelo grupo no GitHub, cujo acesso é possível através da URL:
 
 - [ https://github.com/orgs/ICEI-PUC-Minas-PMV-ADS/projects/54](https://github.com/orgs/ICEI-PUC-Minas-PMV-ADS/projects/54)


Os entregáveis estão dispostos no “Product Backlog” e apresentados em método Kanban conforme andamento da atividade:
- **Recursos**: esta lista mantém um template de tarefas recorrentes com as configurações padronizadas que todos devem seguir. O objetivo é permitir a cópia destes templates para agilizar a criação de novos cartões. 
- **Backlog**: recebe as tarefas a serem trabalhadas e representa o Product Backlog. Todas as atividades identificadas no decorrer do projeto também devem ser incorporadas a esta lista. 
- **To Do**: Esta lista representa o Sprint Backlog. Este é o Sprint atual que estamos trabalhando. 
- **In Progress**: Quando uma tarefa tiver sido iniciada, ela é movida para cá. 
- **Test**: Checagem de Qualidade. Quando as tarefas são concluídas, eles são movidas para o “CQ”. No final da semana, eu revejo essa lista para garantir que tudo saiu perfeito. 
- **Locked**: Quando alguma coisa impede a conclusão da tarefa, ela é movida para esta lista juntamente com um comentário sobre o que está travando a tarefa. 
- **Done**: nesta lista são colocadas as tarefas que passaram pelos testes e controle de qualidade e estão prontos para ser entregues ao usuário. Não há mais edições ou revisões necessárias, ele está agendado e pronto para a ação. 

Abaixo, figura demonstrando a disposição dos entregáveis:

![](/docs/img/kanban.png)

As tarefas são, ainda, etiquetadas em função da urgência da atividade e seguem o seguinte esquema de cores/categorias: 
 
          - Vermelha: prioridade alta 
          - Amarela: prioridade média 
          - Verde: prioridade baixa 

As tarefas serão livres para qualquer membro do time poder executá-las ou direcionadas a determinado membro do time, que tenha mais experiência em determinada área de conhecimento. Com relação a livre escolha de tarefas, obrigatoriamente, deve ser respeitada a hierarquia de prioridades. Enquanto tiverem tarefas de maiores prioridades disponíveis, não poderão ser iniciadas as tarefas de menor prioridade, a prioridade padrão é a amarela, devendo ser vermelhas as prioridades urgentes que surgirem ao longo do projeto.  

Abaixo, figura demonstrando a disposição das etiquetas:

![](/docs/img/Labels.png)

Adicionalmente, a ferramenta conta com um diretório para a criação de “Issues” que são pendências e problemas ainda não resolvidas, devendo ser tratadas e analisadas ao longo do projeto, conforme imagem abaixo:

![](/docs/img/issues.png)

