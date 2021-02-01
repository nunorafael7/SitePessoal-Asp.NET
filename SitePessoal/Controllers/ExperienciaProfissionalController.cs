using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SitePessoal.Data;
using SitePessoal.Models;

namespace SitePessoal.Controllers
{
    public class ExperienciaProfissionalController : Controller
    {
        private readonly SitePessoalDbContext _context;

        public ExperienciaProfissionalController(SitePessoalDbContext context)
        {
            _context = context;
        }

        // GET: ExperienciaProfissional
        public async Task<IActionResult> Index()
        {
            return View(await _context.ExperienciaProfissional.ToListAsync());
        }

        // GET: ExperienciaProfissional/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var experienciaProfissional = await _context.ExperienciaProfissional
                .FirstOrDefaultAsync(m => m.ExperienciaProfissionalId == id);
            if (experienciaProfissional == null)
            {
                return NotFound();
            }

            return View(experienciaProfissional);
        }

        // GET: ExperienciaProfissional/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: ExperienciaProfissional/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ExperienciaProfissionalId,Trabalho,Duracao,Funcao")] ExperienciaProfissional experienciaProfissional)
        {
            if (ModelState.IsValid)
            {
                _context.Add(experienciaProfissional);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(experienciaProfissional);
        }

        // GET: ExperienciaProfissional/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var experienciaProfissional = await _context.ExperienciaProfissional.FindAsync(id);
            if (experienciaProfissional == null)
            {
                return NotFound();
            }
            return View(experienciaProfissional);
        }

        // POST: ExperienciaProfissional/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ExperienciaProfissionalId,Trabalho,Duracao,Funcao")] ExperienciaProfissional experienciaProfissional)
        {
            if (id != experienciaProfissional.ExperienciaProfissionalId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(experienciaProfissional);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ExperienciaProfissionalExists(experienciaProfissional.ExperienciaProfissionalId))
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
            return View(experienciaProfissional);
        }

        // GET: ExperienciaProfissional/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var experienciaProfissional = await _context.ExperienciaProfissional
                .FirstOrDefaultAsync(m => m.ExperienciaProfissionalId == id);
            if (experienciaProfissional == null)
            {
                return NotFound();
            }

            return View(experienciaProfissional);
        }

        // POST: ExperienciaProfissional/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var experienciaProfissional = await _context.ExperienciaProfissional.FindAsync(id);
            _context.ExperienciaProfissional.Remove(experienciaProfissional);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ExperienciaProfissionalExists(int id)
        {
            return _context.ExperienciaProfissional.Any(e => e.ExperienciaProfissionalId == id);
        }
    }
}
