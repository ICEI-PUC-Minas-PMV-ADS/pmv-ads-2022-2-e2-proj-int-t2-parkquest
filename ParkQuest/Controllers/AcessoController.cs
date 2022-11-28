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
    public class AcessoController : Controller
    {
        private readonly ApplicationDbContext _context;

        public AcessoController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Acesso
        public async Task<IActionResult> Index()
        {
            return View(await _context.Acessos.ToListAsync());
        }

        // GET: Acesso/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var acesso = await _context.Acessos
                .FirstOrDefaultAsync(m => m.id == id);
            if (acesso == null)
            {
                return NotFound();
            }

            return View(acesso);
        }

        // GET: Acesso/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Acesso/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("id,email,senha")] Acesso acesso)
        {
            if (ModelState.IsValid)
            {
                _context.Add(acesso);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(acesso);
        }

        // GET: Acesso/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var acesso = await _context.Acessos.FindAsync(id);
            if (acesso == null)
            {
                return NotFound();
            }
            return View(acesso);
        }

        // POST: Acesso/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("id,email,senha")] Acesso acesso)
        {
            if (id != acesso.id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(acesso);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AcessoExists(acesso.id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(acesso);
        }

        // GET: Acesso/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var acesso = await _context.Acessos
                .FirstOrDefaultAsync(m => m.id == id);
            if (acesso == null)
            {
                return NotFound();
            }

            return View(acesso);
        }

        // POST: Acesso/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var acesso = await _context.Acessos.FindAsync(id);
            _context.Acessos.Remove(acesso);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AcessoExists(int id)
        {
            return _context.Acessos.Any(e => e.id == id);
        }
    }
}
