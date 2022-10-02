# Plano de Testes de Software

Os requisitos para realização dos testes de software são:
•	Aplicação publicada na Internet
•	Navegador da Internet - Chrome, Firefox ou Edge
•	Conectividade de Internet para acesso às plataformas (APIs)

 
| **Caso de Teste** 	| **CT-01 – Localização no mapa** 	|
|:---:	|:---:	|
|	Requisito Associado 	| RF-01 – A aplicação deve apresentar na página principal um buscador no qual o usuário irá digitar o endereço que pretende ir e a data de entrada e de saída. RF-17 – A aplicação deve confirmar a localização do usuário no mapa|
| Objetivo do Teste 	| Verificar se a localização do usuário está corretamente indicada no mapa. |
| Passos 	| - 1) Acessar o Navegador 2) Informar o endereço da aplicação 3) Visualizar a página inicial 4) Inserir o endereço a ser buscado 5) Clicar em pesquisar 6) Visualizar mapa com a localização informada no passo 2.|
|Critério de Êxito | - A tela inicial deve abrir corretamente - Ao digitar o endereço, o usuário deve ser direcionado à tela de confirmação do endereço - O endereço digitado deve ser corretamente indicado no mapa..|
|  	|  	|
| **Caso de Teste** 	| **CT-02 – Busca de estacionamentos por proximidade** 	|
|:---:	|:---:	|
|	Requisito Associado 	| RF-17 – A aplicação deve apresentar uma página com a lista dos estacionamentos próximos ao local que o usuário motorista pretende ir. RF-11 – A aplicação deve conter um botão para o usuário selecionar o estacionamento desejado, e quando acionado deverá apresentar uma página com fotos do local, endereço, disponibilidade, descrição, ranking de estrelas, preço e o botão reservar.|
| Objetivo do Teste 	| Verificar se o resultado da busca por estacionamentos está corretamente indicado. |
| Passos 	| 1) Acessar o Navegador 2) Informar o endereço da aplicação 3) Visualizar a página de busca 4) Selecionar o estacionamento desejado 5) Visualizar as informações do estacionamento selecionado.|
|Critério de Êxito | - A tela de busca de estacionamentos por proximidade deve abrir corretamente - Ao digitar o endereço, o usuário deve ser direcionado à tela de resultado da busca - A tela de resultado da busca deve indicar a disponibilidade de vagas em estabelecimentos próximos ao endereço buscado, a tabela de preço, a disponibilidade das vagas, com suas informações de contato.|
|  	|  	|
| **Caso de Teste** 	| **CT-03 – Login** 	|
|:---:	|:---:	|
|	Requisito Associado 	| RF-02 – A aplicação deverá ter uma tela de login, na qual o usuário motorista ou o usuário estacionamento poderão efetuar o login utilizando o usuário e a senha cadastradas na tela de cadastro.|
| Objetivo do Teste 	| Verificar se o login está funcionando corretamente. |
| Passos 	| 1) Acessar o Navegador 2) Informar o endereço da aplicação 3) Visualizar a página de login 4) Inserir o e-mail e senha cadastrados 5) Ser redirecionado para a tela de área do usuário motorista ou do usuário estacionamento.
|Critério de Êxito | - A tela de login deve abrir corretamente - O login e senha cadastrados devem direcionar o usuário para a tela de área do usuário motorista ou área do estacionamento - Login e senha incorretos devem exibir uma mensagem de login ou senha incorretos.|
|  	|  	|
| **Caso de Teste** 	| **CT-04– Área do usuário estacionamento** 	|
|:---:	|:---:	|
|	Requisito Associado 	| RF-07 – O administrador do estacionamento pode cadastrar, excluir, alterar e visualizar os dados do estacionamento.|
| Objetivo do Teste 	| Verificar se a área do estacionamento está permitindo a alteração e a atualização dos dados e corretamente.|
| Passos 	| 1) Acessar o Navegador 2) Informar o endereço da aplicação 3) Visualizar a página de área do estacionamento 4) Inserir um todas as informações daquele estabelecimento 5) Visualizar a disponibilidade de um estabelecimento 6) Alterar a disponibilidade e as informações das vagas de um estacionamento|
|Critério de Êxito | - A tela de área do estacionamento deve abrir corretamente - A página deve permitir a inclusão de vagas tanto disponíveis quanto indisponíveis - A página deve permitir que o estabelecimento visualize e altere a disponibilidade a qualquer momento. |
|  	|  	|
| **Caso de Teste** 	| **CT-01 – Cadastrar perfil** 	|
|:---:	|:---:	|
|	Requisito Associado 	| RF-00X - A aplicação deve apresentar, na página principal, a funcionalidade de cadastro de usuários para que esses consigam criar e gerenciar seu perfil. |
| Objetivo do Teste 	| Verificar se o usuário consegue se cadastrar na aplicação. |
| Passos 	| - Acessar o navegador <br> - Informar o endereço do site https://adota-pet.herokuapp.com/src/index.html<br> - Clicar em "Criar conta" <br> - Preencher os campos obrigatórios (e-mail, nome, sobrenome, celular, CPF, senha, confirmação de senha) <br> - Aceitar os termos de uso <br> - Clicar em "Registrar" |
|Critério de Êxito | - O cadastro foi realizado com sucesso. |
|  	|  	|
| **Caso de Teste** 	| **CT-01 – Cadastrar perfil** 	|
|:---:	|:---:	|
|	Requisito Associado 	| RF-00X - A aplicação deve apresentar, na página principal, a funcionalidade de cadastro de usuários para que esses consigam criar e gerenciar seu perfil. |
| Objetivo do Teste 	| Verificar se o usuário consegue se cadastrar na aplicação. |
| Passos 	| - Acessar o navegador <br> - Informar o endereço do site https://adota-pet.herokuapp.com/src/index.html<br> - Clicar em "Criar conta" <br> - Preencher os campos obrigatórios (e-mail, nome, sobrenome, celular, CPF, senha, confirmação de senha) <br> - Aceitar os termos de uso <br> - Clicar em "Registrar" |
|Critério de Êxito | - O cadastro foi realizado com sucesso. |
|  	|  	|
| **Caso de Teste** 	| **CT-01 – Cadastrar perfil** 	|
|:---:	|:---:	|
|	Requisito Associado 	| RF-00X - A aplicação deve apresentar, na página principal, a funcionalidade de cadastro de usuários para que esses consigam criar e gerenciar seu perfil. |
| Objetivo do Teste 	| Verificar se o usuário consegue se cadastrar na aplicação. |
| Passos 	| - Acessar o navegador <br> - Informar o endereço do site https://adota-pet.herokuapp.com/src/index.html<br> - Clicar em "Criar conta" <br> - Preencher os campos obrigatórios (e-mail, nome, sobrenome, celular, CPF, senha, confirmação de senha) <br> - Aceitar os termos de uso <br> - Clicar em "Registrar" |
|Critério de Êxito | - O cadastro foi realizado com sucesso. |
|  	|  	|
| **Caso de Teste** 	| **CT-01 – Cadastrar perfil** 	|
|:---:	|:---:	|
|	Requisito Associado 	| RF-00X - A aplicação deve apresentar, na página principal, a funcionalidade de cadastro de usuários para que esses consigam criar e gerenciar seu perfil. |
| Objetivo do Teste 	| Verificar se o usuário consegue se cadastrar na aplicação. |
| Passos 	| - Acessar o navegador <br> - Informar o endereço do site https://adota-pet.herokuapp.com/src/index.html<br> - Clicar em "Criar conta" <br> - Preencher os campos obrigatórios (e-mail, nome, sobrenome, celular, CPF, senha, confirmação de senha) <br> - Aceitar os termos de uso <br> - Clicar em "Registrar" |
|Critério de Êxito | - O cadastro foi realizado com sucesso. |
|  	|  	|
| **Caso de Teste** 	| **CT-01 – Cadastrar perfil** 	|
|:---:	|:---:	|
|	Requisito Associado 	| RF-00X - A aplicação deve apresentar, na página principal, a funcionalidade de cadastro de usuários para que esses consigam criar e gerenciar seu perfil. |
| Objetivo do Teste 	| Verificar se o usuário consegue se cadastrar na aplicação. |
| Passos 	| - Acessar o navegador <br> - Informar o endereço do site https://adota-pet.herokuapp.com/src/index.html<br> - Clicar em "Criar conta" <br> - Preencher os campos obrigatórios (e-mail, nome, sobrenome, celular, CPF, senha, confirmação de senha) <br> - Aceitar os termos de uso <br> - Clicar em "Registrar" |
|Critério de Êxito | - O cadastro foi realizado com sucesso. |
|  	|  	|
| **Caso de Teste** 	| **CT-01 – Cadastrar perfil** 	|
|:---:	|:---:	|
|	Requisito Associado 	| RF-00X - A aplicação deve apresentar, na página principal, a funcionalidade de cadastro de usuários para que esses consigam criar e gerenciar seu perfil. |
| Objetivo do Teste 	| Verificar se o usuário consegue se cadastrar na aplicação. |
| Passos 	| - Acessar o navegador <br> - Informar o endereço do site https://adota-pet.herokuapp.com/src/index.html<br> - Clicar em "Criar conta" <br> - Preencher os campos obrigatórios (e-mail, nome, sobrenome, celular, CPF, senha, confirmação de senha) <br> - Aceitar os termos de uso <br> - Clicar em "Registrar" |
|Critério de Êxito | - O cadastro foi realizado com sucesso. |
|  	|  	|




 

