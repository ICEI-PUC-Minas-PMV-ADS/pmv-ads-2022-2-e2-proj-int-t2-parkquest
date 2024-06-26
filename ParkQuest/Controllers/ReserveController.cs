﻿using System;
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
    public class ReserveController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ReserveController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Reserve
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.Reserva.Include(r => r.Estacionamento);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: Reserve/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var reserve = await _context.Reserva
                .Include(r => r.Estacionamento)
                .FirstOrDefaultAsync(m => m.id == id);
            if (reserve == null)
            {
                return NotFound();
            }

            return View(reserve);
        }

        // GET: Reserve/Create
        public IActionResult Create()
        {
            ViewData["EstacionamentoID"] = new SelectList(_context.Estacionamentos, "id", "nome");
            return View();
        }

        // POST: Reserve/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("id,dataEntrada,horarioEntrada,dataSaida,horarioSaida,custoDia,custoTotal,EstacionamentoID")] Reserve reserve)
        {
            if (ModelState.IsValid)
            {
                _context.Add(reserve);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["EstacionamentoID"] = new SelectList(_context.Estacionamentos, "id", "cidade", reserve.EstacionamentoID);
            return View(reserve);
        }

        // GET: Reserve/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var reserve = await _context.Reserva.FindAsync(id);
            if (reserve == null)
            {
                return NotFound();
            }
            ViewData["EstacionamentoID"] = new SelectList(_context.Estacionamentos, "id", "cidade", reserve.EstacionamentoID);
            return View(reserve);
        }

        // POST: Reserve/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("id,dataEntrada,horarioEntrada,dataSaida,horarioSaida,custoDia,custoTotal,EstacionamentoID")] Reserve reserve)
        {
            if (id != reserve.id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(reserve);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ReserveExists(reserve.id))
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
            ViewData["EstacionamentoID"] = new SelectList(_context.Estacionamentos, "id", "cidade", reserve.EstacionamentoID);
            return View(reserve);
        }

        // GET: Reserve/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var reserve = await _context.Reserva
                .Include(r => r.Estacionamento)
                .FirstOrDefaultAsync(m => m.id == id);
            if (reserve == null)
            {
                return NotFound();
            }

            return View(reserve);
        }

        // POST: Reserve/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var reserve = await _context.Reserva.FindAsync(id);
            _context.Reserva.Remove(reserve);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ReserveExists(int id)
        {
            return _context.Reserva.Any(e => e.id == id);
        }
    }
}
