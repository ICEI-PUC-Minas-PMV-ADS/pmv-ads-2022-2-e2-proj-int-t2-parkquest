# Programação de Funcionalidades

Nesta seção são apresentadas as telas desenvolvidas para cada uma das funcionalidades do sistema.

Abra um navegador de Internet e informe a seguinte URL: 


## Cadastre-se (RF-01)

A Tela Inicial do sistema apresenta apresenta um buscador centralizado, no qual o usuário deverá digitar seu endereço e a fim de direcionar a busca de medicamentos à Unidade Básica de Saúde mais próxima. Esta tela ainda permite que o usuário faça cadastro ou login, bem como acesso à Área do Farmacêutico. Também dispõe dos icones "sobre" e "como funciona o medicamento fácil". Para facilidade de acesso foi incorporado a função de autocompletar o endereço enquanto o usuário digita.

![Inicial](img/principalautocomplete1.png)

### Requisitos atendidos 

RF-01 -  O site deve apresentar na página principal um buscador no qual o usuário irá digitar seu endereço.

### Artefatos da funcionalidade 

- index.html
- index.js
- template.css
- logo.png

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

# Programação de Funcionalidades

Nesta seção são apresentadas as telas desenvolvidas para cada uma das funcionalidades do sistema.

Abra um navegador de Internet e informe a seguinte URL: https://icei-puc-minas-pmv-ads.github.io/pmv-ads-2022-1-e1-proj-web-t5-medicamento-facil/src/index


## Anuncie seu empreendimento (RF-01)
### Desenvolvedor(a): Fagner Vieira Pereira

A Tela Inicial do sistema apresenta apresenta um buscador centralizado, no qual o usuário deverá digitar seu endereço e a fim de direcionar a busca de medicamentos à Unidade Básica de Saúde mais próxima. Esta tela ainda permite que o usuário faça cadastro ou login, bem como acesso à Área do Farmacêutico. Também dispõe dos icones "sobre" e "como funciona o medicamento fácil". Para facilidade de acesso foi incorporado a função de autocompletar o endereço enquanto o usuário digita.

![Inicial](img/principalautocomplete1.png)

### Requisitos atendidos 

RF-01 -  O site deve apresentar na página principal um buscador no qual o usuário irá digitar seu endereço.

### Artefatos da funcionalidade 

- index.html
- index.js
- template.css
- logo.png

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

