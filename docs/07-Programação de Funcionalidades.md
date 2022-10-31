# Programação de Funcionalidades

Nesta seção são apresentadas as telas desenvolvidas para cada uma das funcionalidades do sistema.

Abra um navegador de Internet e informe a seguinte URL: 


## Cadastre-se (RF-01)

A Tela Inicial do sistema apresenta apresenta um buscador centralizado, no qual o usuário deverá digitar seu endereço e a fim de direcionar a busca de medicamentos à Unidade Básica de Saúde mais próxima. Esta tela ainda permite que o usuário faça cadastro ou login, bem como acesso à Área do Farmacêutico. Também dispõe dos icones "sobre" e "como funciona o medicamento fácil". Para facilidade de acesso foi incorporado a função de autocompletar o endereço enquanto o usuário digita.

![Inicial](img/principalautocomplete1.png)

### Requisitos atendidos 

- RF-01 -  O site deve apresentar na página principal um buscador no qual o usuário irá digitar seu endereço.

### Artefatos da funcionalidade 

- cadastro.html
- template.html
- main.js
- main.css
- Usuario.cs
- UsuarioController.cs
- ApplicationDbContext.cs


### Estrutura de Dados 

        namespace ParkQuest.Controllers
{
    public class UsuarioController : Controller
    {
        private readonly ApplicationDbContext _context;

        public UsuarioController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Usuario
        public async Task<IActionResult> Index()
        {
            return View(await _context.Usuarios.ToListAsync());
        }

        // GET: Usuario/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var usuario = await _context.Usuarios
                .FirstOrDefaultAsync(m => m.id == id);
            if (usuario == null)
            {
                return NotFound();
            }

            return View(usuario);
        }


### Instruções de acesso 

A Tela Inicial é a primeira funcionalidade exibida pelo aplicativo. 


## Anuncie seu empreendimento (RF-05, 06)


A Tela Inicial do sistema apresenta apresenta um buscador centralizado, no qual o usuário deverá digitar seu endereço e a fim de direcionar a busca de medicamentos à Unidade Básica de Saúde mais próxima. Esta tela ainda permite que o usuário faça cadastro ou login, bem como acesso à Área do Farmacêutico. Também dispõe dos icones "sobre" e "como funciona o medicamento fácil". Para facilidade de acesso foi incorporado a função de autocompletar o endereço enquanto o usuário digita.

![Inicial](img/principalautocomplete1.png)

### Requisitos atendidos 

- RF-05 -  A aplicação deve conter uma aba no cabeçalho "Anuncie seu empreendimento" com a funcionalidade de, ao clicar nela, abrir uma nova página com um formulário para o cadastro de novos empreendimentos.
- RF - 06 - O formulário de cadastro de novos empreendimentos deve conter: nome, e-mail, celular, estado, cidade, CNPJ, endereço, quantidade de vagas, tabela de preços e fotos do local.

### Artefatos da funcionalidade 

- anuncie.html
- template.html
- main.js
- main.css
- Estacionamento.cs
- EstacionamentoController.cs
- ApplicationDbContext.cs

### Estrutura de Dados 

       namespace ParkQuest.Controllers
{
    public class EstacionamentoController : Controller
    {
        private readonly ApplicationDbContext _context;

        public EstacionamentoController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Estacionamento
        public async Task<IActionResult> Index()
        {
            return View(await _context.Estacionamentos.ToListAsync());
        }

        // GET: Estacionamento/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var estacionamento = await _context.Estacionamentos
                .FirstOrDefaultAsync(m => m.id == id);
            if (estacionamento == null)
            {
                return NotFound();
            }

            return View(estacionamento);
        }


### Instruções de acesso 

A Tela Inicial é a primeira funcionalidade exibida pelo aplicativo. 

