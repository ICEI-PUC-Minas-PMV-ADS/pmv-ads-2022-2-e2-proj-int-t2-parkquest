# Programação de Funcionalidades

Nesta seção são apresentadas as telas desenvolvidas para cada uma das funcionalidades do sistema.

Abra um navegador de Internet e informe a seguinte URL: 


## Cadastre-se (RF-01)

A Tela Inicial do sistema apresenta apresenta um buscador centralizado, no qual o usuário deverá digitar seu endereço e a fim de direcionar a busca de medicamentos à Unidade Básica de Saúde mais próxima. Esta tela ainda permite que o usuário faça cadastro ou login, bem como acesso à Área do Farmacêutico. Também dispõe dos icones "sobre" e "como funciona o medicamento fácil". Para facilidade de acesso foi incorporado a função de autocompletar o endereço enquanto o usuário digita.

![Inicial](img/principalautocomplete1.png)

### Requisitos atendidos 

RF-01 -  O site deve apresentar na página principal um buscador no qual o usuário irá digitar seu endereço.

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


## Anuncie seu empreendimento (RF-05, 06)


A Tela Inicial do sistema apresenta apresenta um buscador centralizado, no qual o usuário deverá digitar seu endereço e a fim de direcionar a busca de medicamentos à Unidade Básica de Saúde mais próxima. Esta tela ainda permite que o usuário faça cadastro ou login, bem como acesso à Área do Farmacêutico. Também dispõe dos icones "sobre" e "como funciona o medicamento fácil". Para facilidade de acesso foi incorporado a função de autocompletar o endereço enquanto o usuário digita.

![Inicial](img/principalautocomplete1.png)

### Requisitos atendidos 

RF-05 -  A aplicação deve conter uma aba no cabeçalho "Anuncie seu empreendimento" com a funcionalidade de, ao clicar nela, abrir uma nova página com um formulário para o cadastro de novos empreendimentos.
RF - 06 - O formulário de cadastro de novos empreendimentos deve conter: nome, e-mail, celular, estado, cidade, CNPJ, endereço, quantidade de vagas, tabela de preços e fotos do local.

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

