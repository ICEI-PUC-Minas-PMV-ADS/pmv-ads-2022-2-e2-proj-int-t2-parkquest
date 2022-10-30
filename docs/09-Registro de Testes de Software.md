# Registro de Testes de Software

<span style="color:red">Pré-requisitos: <a href="3-Projeto de Interface.md"> Projeto de Interface</a></span>, <a href="8-Plano de Testes de Software.md"> Plano de Testes de Software</a>

Para cada caso de teste definido no Plano de Testes de Software, realize o registro das evidências dos testes feitos na aplicação pela equipe, que comprovem que o critério de êxito foi alcançado (ou não!!!). Para isso, utilize uma ferramenta de captura de tela que mostre cada um dos casos de teste definidos (obs.: cada caso de teste deverá possuir um vídeo do tipo _screencast_ para caracterizar uma evidência do referido caso).

## Avaliação

Discorra sobre os resultados do teste. Ressaltando pontos fortes e fracos identificados na solução. Comente como o grupo pretende atacar esses pontos nas próximas iterações. Apresente as falhas detectadas e as melhorias geradas a partir dos resultados obtidos nos testes.

> **Links Úteis**:
> - [Ferramentas de Test para Java Script](https://geekflare.com/javascript-unit-testing/)

Abaixo, listamos cada tópico referente ao Plano de Testes de Software. Uma vez que a aplicação encontra-se em etpa inicial de desenvolvimento, algumas das funções não foram testadas e encontram-se com a legenda "- EM DESENVOLVIMENTO". 

| **Caso de Teste** 	| **CT-01 – Localização no mapa** - EM DESENVOLVIMENTO	|
|:---:	|:---:	|
|	Requisito Associado 	| RF-01 – A aplicação deve apresentar na página principal um buscador no qual o usuário irá digitar o endereço que pretende ir e a data de entrada e de saída. RF-17 – A aplicação deve confirmar a localização do usuário no mapa|
| Objetivo do Teste 	| Verificar se a localização do usuário está corretamente indicada no mapa. |
| Passos 	| - 1) Acessar o Navegador 2) Informar o endereço da aplicação 3) Visualizar a página inicial 4) Inserir o endereço a ser buscado 5) Clicar em pesquisar 6) Visualizar mapa com a localização informada no passo 2.|
|Critério de Êxito | - A tela inicial deve abrir corretamente - Ao digitar o endereço, o usuário deve ser direcionado à tela de confirmação do endereço - O endereço digitado deve ser corretamente indicado no mapa..|
|  	|  	|
| **Caso de Teste** 	| **CT-02 – Busca de estacionamentos por proximidade** - EM DESENVOLVIMENTO	|
|:---:	|:---:	|
|	Requisito Associado 	| RF-17 – A aplicação deve apresentar uma página com a lista dos estacionamentos próximos ao local que o usuário motorista pretende ir. RF-11 – A aplicação deve conter um botão para o usuário selecionar o estacionamento desejado, e quando acionado deverá apresentar uma página com fotos do local, endereço, disponibilidade, descrição, ranking de estrelas, preço e o botão reservar.|
| Objetivo do Teste 	| Verificar se o resultado da busca por estacionamentos está corretamente indicado. |
| Passos 	| 1) Acessar o Navegador 2) Informar o endereço da aplicação 3) Visualizar a página de busca 4) Selecionar o estacionamento desejado 5) Visualizar as informações do estacionamento selecionado.|
|Critério de Êxito | - A tela de busca de estacionamentos por proximidade deve abrir corretamente - Ao digitar o endereço, o usuário deve ser direcionado à tela de resultado da busca - A tela de resultado da busca deve indicar a disponibilidade de vagas em estabelecimentos próximos ao endereço buscado, a tabela de preço, a disponibilidade das vagas, com suas informações de contato.|
|  	|  	|
| **Caso de Teste** 	| **CT-03 – Login** - EM DESENVOLVIMENTO	|
|:---:	|:---:	|
|	Requisito Associado 	| RF-02 – A aplicação deverá ter uma tela de login, na qual o usuário motorista ou o usuário estacionamento poderão efetuar o login utilizando o usuário e a senha cadastradas na tela de cadastro.|
| Objetivo do Teste 	| Verificar se o login está funcionando corretamente. |
| Passos 	| 1) Acessar o Navegador 2) Informar o endereço da aplicação 3) Visualizar a página de login 4) Inserir o e-mail e senha cadastrados 5) Ser redirecionado para a tela de área do usuário motorista ou do usuário estacionamento.
|Critério de Êxito | - A tela de login deve abrir corretamente - O login e senha cadastrados devem direcionar o usuário para a tela de área do usuário motorista ou área do estacionamento - Login e senha incorretos devem exibir uma mensagem de login ou senha incorretos.|
|  	|  	|
| **Caso de Teste** 	| **CT-04– Área do usuário empreendimento** 	|
|:---:	|:---:	|
|	Requisito Associado 	| RF-07 – O administrador do estacionamento pode cadastrar, excluir, alterar e visualizar os dados do estacionamento.|
| Objetivo do Teste 	| Verificar se a área do empreendimento está permitindo a alteração e a atualização dos dados e corretamente.|
| Passos 	| 1) Acessar o Navegador 2) Informar o endereço da aplicação 3) Visualizar a página de área do empreendimento 4) Inserir um todas as informações 5) Visualizar a disponibilidade de um estabelecimento 6) Alterar a disponibilidade e as informações das vagas de um estacionamento|
|Critério de Êxito | - A tela de área do usuário motorista deve abrir corretamente e todas as funcionalidades de gestão da reserva devem funcionar corretamente
|  	|  	|

Os vídeos abaixo apresentam as funções de editar, visualizar detalhes e deletar cadastros de estacionamentos. A tela em questão ainda será aperfeiçoada pelo grupo a fim de corresponder ao template idealizado no front end. Além disso, após o desenvolvimento da função login, o usuário só poderá visualizar os estabelecimentos pertencentes à sua conta.

https://user-images.githubusercontent.com/100328619/198901875-a008e1bd-9b51-4eb0-aa17-667a1947227d.mp4


https://user-images.githubusercontent.com/100328619/198901892-d7f5deb0-bca8-4e35-96c5-80bb8a141125.mp4


https://user-images.githubusercontent.com/100328619/198901915-4d15037d-5aa3-40db-80d6-75c1de017897.mp4


| **Caso de Teste** 	| **CT-05 – Área do usuário motorista** - EM DESENVOLVIMENTO	|
|:---:	|:---:	|
|	Requisito Associado 	| RF-08 - O usuário motorista pode cancelar, alterar e visualizar os dados de sua reserva. |
| Objetivo do Teste 	| Verificar se a área do motorista está permitindo a alteração e a atualização dos dados e corretamente. |
| Passos 	| 1) Acessar o Navegador 2) Informar o endereço do Site 3) Visualizar a página de área do usuário motorista 4) Inserir todos os dados de cadastrado 5) Ser redirecionado para a tela de login do usuário |
|Critério de Êxito | - A tela de área do usuário motorista deve abrir corretamente e todas as funcionalidades de gestão da reserva devem funcionar corretamente |
|  	|  	|
| **Caso de Teste** 	| **CT-06 – Esqueci a senha** - EM DESENVOLVIMENTO	|
|:---:	|:---:	|
|	Requisito Associado 	| RF-14 – A aplicação deve permitir que o usuário recupere sua senha em caso de esquecimento RF-15 – Na página de “Esqueci minha senha”, o usuário irá preencher o e-mail cadastrado. Caso esse e-mail não esteja na lista de cadastros, deverá ser exibida uma mensagem informando que o e-mail não está no cadastro. RF-16 – Na página de “Esqueci minha senha”, caso o e-mail esteja cadastrado, haverá a opção de o usuário criar uma nova senha. Se a senha for válida.|
| Objetivo do Teste 	| Verificar se a alteração de cadastro está ocorrendo corretamente. |
| Passos 	| 1) Acessar o Navegador 2) Informar o endereço da aplicação 3) Ir para a página de login 4) Acessar com o login e senha 5) Clicar no botão esqueci a senha 6) O usuário será direcionado para a página de alterar o cadastro 7) Acessar o login novamente com o cadastro alterado. |
|Critério de Êxito | - A tela de novo cadastro deve abrir corretamente - Ao alterar o cadastro, o usuário deverá conseguir realizar login com o novo cadastro |
|  	|  	|
| **Caso de Teste** 	| **CT-07 – Cadastrar usuário** - EM DESENVOLVIMENTO	|
|:---:	|:---:	|
|	Requisito Associado 	| RF-2 – A aplicação deve apresentar na tela inicial um ícone de perfil para fazer login, onde o usuário irá preencher os dados de “E-mail” e “Senha” cadastrados. Caso o usuário esteja logado, apresentar o nome do usuário junto ao ícone. . |
| Objetivo do Teste 	| Verificar se o usuário consegue se cadastrar na aplicação. |
| Passos 	| ) Acessar o Navegador 2) Informar o endereço da aplicação 3) Cadastrar um novo usuário 4) Preencher os campos solicitados (nome, CPF, e-mail e senha) 5) Clique no botão cadastrar  |
|Critério de Êxito | - O cadastro foi realizado com sucesso. |
|  	|  	|
| **Caso de Teste** 	| **CT-08 – Anuncie seu empreendimento** 	|
|:---:	|:---:	|
|	Requisito Associado 	| F-5 – A aplicação deve conter uma aba no cabeçalho "Anuncie seu empreendimento" com a funcionalidade de, ao clicar nela, abrir uma nova página com um formulário para o cadastro de novos empreendimentos. RF-6 – O formulário de cadastro de novos empreendimentos deve conter: nome, e-mail, celular, estado, cidade, CNPJ, endereço, quantidade de vagas, tabela de preços e fotos do local.|
| Objetivo do Teste 	| Verificar se o usuário consegue cadastrar seu empreendimento na na aplicação. |
| Passos 	| 1) Acessar o Navegador 2) Informar o endereço da aplicação 3) Clicar no botão Anuncie seu empreendimento4) Preencher os campos solicitados (nome, e-mail, celular, estado, cidade, CNPJ, endereço, quantidade de vagas, tabela de preços e fotos do local.) 5) Clicar no botão anunciar |
|Critério de Êxito | - O anuncio  foi realizado com sucesso. |
|  	|  	|

As imagens abaixo apresentam o template da tela "Anuncie seu empreendimento", tela a qual os usuários administradores de estacionamentos irão cadastrar seus estabelecimentos.

![image](https://user-images.githubusercontent.com/100328619/198901502-16994454-790b-4849-ae7f-8121ca562375.png)

![image](https://user-images.githubusercontent.com/100328619/198901561-23109385-a41b-4dbb-a71d-306cc42313a0.png)

O vídeo abaixo demostra o processo de cadastro de um estacionamento. A tela em questão ainda será aperfeiçoada pelo grupo a fim de corresponder totalemnte ao template idealizado no front end.

https://user-images.githubusercontent.com/100328619/198901689-2f84683d-488a-448a-995a-28aea074d5e9.mp4


| **Caso de Teste** 	| **CT-09 – Avaliação da reserva** - EM DESENVOLVIMENTO	|
|:---:	|:---:	|
|	Requisito Associado 	| RF-11 - A aplicação deve conter um botão para o usuário selecionar o estacionamento desejado, e quando acionado deverá apresentar uma página com fotos do local, endereço, disponibilidade, descrição, ranking de estrelas, preço e o botão reservar. |
| Objetivo do Teste 	| Verificar se a avaliação está acontecendo corretamente |
| Passos 	| 1) Acessar o Navegador 2) Informar o endereço da aplicação 3) Efetuar o login 4) na área do usuário motorista ir em avaliar 5) Realizar a avaliação |
|Critério de Êxito | - A tela de avaliação deve abrir corretamente - Após a finalização desta, deve ser apresentada uma mensagem de envio com êxito. |
|  	|  	|
| **Caso de Teste** 	| **CT-10 – Contato com o administrador** - EM DESENVOLVIMENTO	|
|:---:	|:---:	|
|	Requisito Associado 	| RF-13 - A aplicação deve permitir visualizar as informações de contatos da(s) pessoa(s) que criaram o site e o mantém e permitir envio de mensagens para contato com os mesmos, informando nome, e-mail e texto da mensagem. |
| Objetivo do Teste 	| Verificar se as mensagens de contato estão acontecendo corretamente. |
| Passos 	| - A tela de contato deve abrir corretamente - Após a finalização desta, deve ser apresentada uma mensagem de envio com êxito. |
|Critério de Êxito | -- A tela de contato deve abrir corretamente - Após a finalização desta, deve ser apresentada uma mensagem de envio com êxito. |
|  	|  	|
