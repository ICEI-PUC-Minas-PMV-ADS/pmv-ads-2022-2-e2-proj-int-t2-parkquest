# Programação de Funcionalidades

Nesta seção são apresentadas as telas desenvolvidas para cada uma das funcionalidades do sistema.

Abra um navegador de Internet e informe a seguinte URL: 


## Cadastre-se (RF-03/ RFN-01,02,03,04)

A Tela Inicial do sistema apresenta o cadastro de usuários, com os campos que devem ser preenchidos obrigatóriamente: nome, e-mail, senha e CPF. Sendo que nele possui a função de Create, Edit, Details e Delete. Para quaisquer tipos de alterações das informações, no banco de dados do SQL Server.

![image](https://user-images.githubusercontent.com/103009155/198911635-ef3f39e0-7556-49e7-afde-7195ddae75cc.png)

### Requisitos atendidos 

- RNF-03 - A aplicação deverá ter uma página de cadastro do motorista, com os campos, nome, e-mail, senha, cadastro e CPF. 
- RNF-01 - A aplicação deve ser publicada em um ambiente acessível publicamente na Internet.	
- RNF-02 - A aplicação deve ser responsiva, permitindo a visualização em um celular, desktop, tablet de forma adequada.	
- RNF-03 - A aplicação deve ser compatível com os principais navegadores do mercado (Google Chrome, Firefox, Microsoft Edge).	
- RNF-04 - O desenvolvimento deve ser em HTML, CSS, Javascript, BD SQL, C# podendo utilizar frameworks.	

### Artefatos da funcionalidade 

- cadastro.html
- template.html
- main.js
- main.css
- Usuario.cs
- UsuarioController.cs
- ApplicationDbContext.cs

### Estrutura de Dados 

        using System;
        using System.Collections.Generic;
        using System.Linq;
        using System.Threading.Tasks;
        using Microsoft.AspNetCore.Mvc;
        using Microsoft.AspNetCore.Mvc.Rendering;
        using Microsoft.EntityFrameworkCore;
        using Dominio.Entidades;
        using ParkQuest.Models;

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


## Anuncie seu empreendimento (RF-05,06/ RFN-01,02,03,04)

A Tela Inicial do sistema apresenta o cadastro de estacionamentos, com os campos que devem ser preenchidos obrigatoriamente: nome estabelecimento, endereço, quantidade de vagas, e-mail, CNPJ, cidade, valor por hora e senha. Sendo que nele possui a função de Create, Edit, Details e Delete. Para quaisquer tipos de alterações das informações, no banco de dados do SQL Server.

![image](https://user-images.githubusercontent.com/103009155/198911707-d8c27573-858a-41a6-a3ea-38b966423104.png)

### Requisitos atendidos 

- RF-05 -  A aplicação deve conter uma aba no cabeçalho "Anuncie seu empreendimento" com a funcionalidade de, ao clicar nela, abrir uma nova página com um formulário para o cadastro de novos empreendimentos.
- RF - 06 - O formulário de cadastro de novos empreendimentos deve conter: nome, e-mail, celular, estado, cidade, CNPJ, endereço, quantidade de vagas, tabela de preços e fotos do local.
- RNF-01 - A aplicação deve ser publicada em um ambiente acessível publicamente na Internet.	
- RNF-02 - A aplicação deve ser responsiva, permitindo a visualização em um celular, desktop, tablet de forma adequada.	
- RNF-03 - A aplicação deve ser compatível com os principais navegadores do mercado (Google Chrome, Firefox, Microsoft Edge).	
- RNF-04 - O desenvolvimento deve ser em HTML, CSS, Javascript, BD SQL, C# podendo utilizar frameworks.	

### Artefatos da funcionalidade 

- anuncie.html
- template.html
- main.js
- main.css
- Estacionamento.cs
- EstacionamentoController.cs
- ApplicationDbContext.cs

### Estrutura de Dados 

        using System;
        using System.Collections.Generic;
        using System.Linq;
        using System.Threading.Tasks;
        using Microsoft.AspNetCore.Mvc;
        using Microsoft.AspNetCore.Mvc.Rendering;
        using Microsoft.EntityFrameworkCore;
        using Dominio.Entidades;
        using ParkQuest.Models;

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

