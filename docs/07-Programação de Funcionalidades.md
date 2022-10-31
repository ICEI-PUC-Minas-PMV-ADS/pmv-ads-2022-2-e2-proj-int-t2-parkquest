# Programação de Funcionalidades

Nesta seção são apresentadas as telas desenvolvidas para cada uma das funcionalidades do sistema.

Abra um navegador de Internet e informe a seguinte URL: 


## Cadastre-se (RF-03/ RFN-01,02,03,04)

A Tela Inicial do sistema apresenta apresenta um buscador centralizado, no qual o usuário deverá digitar seu endereço e a fim de direcionar a busca de medicamentos à Unidade Básica de Saúde mais próxima. Esta tela ainda permite que o usuário faça cadastro ou login, bem como acesso à Área do Farmacêutico. Também dispõe dos icones "sobre" e "como funciona o medicamento fácil". Para facilidade de acesso foi incorporado a função de autocompletar o endereço enquanto o usuário digita.

![Inicial](img/principalautocomplete1.png)

### Requisitos atendidos 

RNF-03 - A aplicação deverá ter uma página de cadastro do motorista, com os campos, nome, e-mail, senha, cadastro e CPF. 
RNF-01 - A aplicação deve ser publicada em um ambiente acessível publicamente na Internet.	
RNF-02 - A aplicação deve ser responsiva, permitindo a visualização em um celular, desktop, tablet de forma adequada.	
RNF-03 - A aplicação deve ser compatível com os principais navegadores do mercado (Google Chrome, Firefox, Microsoft Edge).	
RNF-04 - O desenvolvimento deve ser em HTML, CSS, Javascript, BD SQL, C# podendo utilizar frameworks.	

### Artefatos da funcionalidade 

- cadastro.html
- template.html
- main.js
- main.css


### Estrutura de Dados 

        let endereco_google;
        function initAutocomplete(){
        endereco_google = new google.maps.places.Autocomplete(
            document.getElementById('autocomplete'),
            {
                types: ['address'],
                componentRestrictions: {'country': ['BR']},
                fields: ['address_components']
            })   ;
        }


### Instruções de acesso 

A Tela Inicial é a primeira funcionalidade exibida pelo aplicativo. 


## Anuncie seu empreendimento (RF-05,06/ RFN-01,02,03,04)


A Tela Inicial do sistema apresenta apresenta um buscador centralizado, no qual o usuário deverá digitar seu endereço e a fim de direcionar a busca de medicamentos à Unidade Básica de Saúde mais próxima. Esta tela ainda permite que o usuário faça cadastro ou login, bem como acesso à Área do Farmacêutico. Também dispõe dos icones "sobre" e "como funciona o medicamento fácil". Para facilidade de acesso foi incorporado a função de autocompletar o endereço enquanto o usuário digita.

![Inicial](img/principalautocomplete1.png)

### Requisitos atendidos 

RF-05 -  A aplicação deve conter uma aba no cabeçalho "Anuncie seu empreendimento" com a funcionalidade de, ao clicar nela, abrir uma nova página com um formulário para o cadastro de novos empreendimentos.
RF - 06 - O formulário de cadastro de novos empreendimentos deve conter: nome, e-mail, celular, estado, cidade, CNPJ, endereço, quantidade de vagas, tabela de preços e fotos do local.
RNF-01 - A aplicação deve ser publicada em um ambiente acessível publicamente na Internet.	
RNF-02 - A aplicação deve ser responsiva, permitindo a visualização em um celular, desktop, tablet de forma adequada.	
RNF-03 - A aplicação deve ser compatível com os principais navegadores do mercado (Google Chrome, Firefox, Microsoft Edge).	
RNF-04 - O desenvolvimento deve ser em HTML, CSS, Javascript, BD SQL, C# podendo utilizar frameworks.	

### Artefatos da funcionalidade 

- anuncie.html
- template.html
- main.js
- main.css

### Estrutura de Dados 

        let endereco_google;
        function initAutocomplete(){
        endereco_google = new google.maps.places.Autocomplete(
            document.getElementById('autocomplete'),
            {
                types: ['address'],
                componentRestrictions: {'country': ['BR']},
                fields: ['address_components']
            })   ;
        }


### Instruções de acesso 

A Tela Inicial é a primeira funcionalidade exibida pelo aplicativo. 

