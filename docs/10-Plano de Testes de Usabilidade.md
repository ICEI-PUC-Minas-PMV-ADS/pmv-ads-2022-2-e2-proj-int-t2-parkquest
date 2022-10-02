# Plano de Testes de Usabilidade

  Os testes de usabilidade permitem avaliar a qualidade da interface com o usuário da aplicação interativa. A ISO/IEC 9126 é uma norma ISO para qualidade de produto de software, e um de seus atributos principais é a usabilidade do produto de software a ser compreendido, aprendido, operado e atraente ao usuário, quando usado sob condições especificadas. Sua principais características são: Inteligibilidade, Apreensibilidade, Operacionalidade, Proteção frente à erros, Estética, Acessibilidade e Conformidade. Para a construção do plano de teste de usabilidade nos pautamos nos conceitos da ISSO/IEC 9126, apresentados abaixo:
  
Detalhamento dos Objetivos:
	O objetivo é avaliar a usabilidade do aplicativo e identificar problemas de uso visando a busca melhoria contínua, para que possamos desenvolver o aplicativo será necessário:
  * Garantir que o usuário consiga cadastrar e recuperar o seu acesso
  * Garantir que usuário consiga pesquisar vagas e realizar reserva da vaga
  * Garantir que o usuário do estacionamento faça seu cadastro, verifique e altere os dados do empreendimento
  * Garantir contato com o Administrador do sistema 
  
Participantes:
	Para participar dos testes será necessário um usuário maior de idade portador de veículo próprio, empreendedor na área de estacionamentos que gostaria de divulgar sua empresa e o perfil de usuário de compras feitas pela internet, usuário que tem o costume de realizar compras e reservas em sites de reservas. Os cincos perfis de usuário estão representados na tabela abaixo:


|Perfil de Usuário | Profissão | Dispositivo | Permissão|
|------------------|-----------|-------------|----------|
|Usuário 1 | Desenvolvedor Full- Stack | Computador |	Administrador |
|Usuário 2 | Médico |	Celular |	Usuário |
|Usuário 3 | Desenvolvedor Front- End |	Celular/ Computador |	Administrador |
|Usuário 4 | Empresário |	Computador|	Admin. Estacionamento |
|Usuário 5 | Engenheiro |	Celular |	Usuário |


Procedimentos:
Os testes deverão ocorrer de maneira remota. E as tarefas a serem executadas serão apresentadas abaixo:

1.	Abrir o site em um navegador web através de link
2.	Fazer login no sistema por meio de interface que recebe login e senha, com possibilidade de recuperação de senha, em caso de esquecimento por parte do usuário.
	* Preencher login e senha
	* Recuperar senha, em caso de esquecimento, com envio de senha por e-mail
	* Em caso de usuário não cadastrado, cadastrar de usuário no sistema
3.	Encontrar dados de reservas com seções referentes a Cadastro, Cancelamento de Reserva e Reserva de Vagas.
	* Dentro da Edição de vagas, permitir visualização, seleção de reservas e edição de reservas. 
	* Dentro do Cancelamento de Reservas, permitir a visualização, seleção e exclusão, ao efetuar a operação de exclusão deve ser enviada confirmação de cancelamento de reserva.
	* Dentro da reserva de vagas, requerer local para reserva, definição de data por meio de campo para adição de data, possibilitar uso de filtros específicos para reserva, possibilitar a seleção do estacionamento, inserção de dados de reserva e confirmação de reserva.
4.	Encontrar o campo para anúncio de estacionamento
	* Verificar se usuário está logado ao sistema
	* Possibilitar seleção entre cadastro de empreendimento, edição de empreendimento e Cancelamento de empreendimento
	* Cadastro de empreendimento – Preencher formulário de cadastro, confirmar cadastro.
	* Edição de empreendimento – Visualizar empreendimentos cadastrados, selecionar empreendimento, editar campos, confirmar edição.
	* Cancelar empreendimento – Visualizar empreendimentos cadastrados, selecionar empreendimento, clicar botão para exclusão, confirmação de exclusão

Dados a serem coletados:
 * Tempo para efetuar reserva (Quantidade de Clicks)
 * Avaliação da conclusão de tarefas (eficácia):
   * Tarefas sem erros;
   * Tarefas com erros;
   * Tarefas com erros críticos
 * Medir a satisfação do uso do aplicativo. (Questionário NPS)

Referência:

ISO/IEC 9126. Wikipedia. Disponível em: https://pt.wikipedia.org/wiki/ISO/IEC_9126 Acesso em: 30 de setembro de 2022.
