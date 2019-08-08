using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Teste.Models;

namespace Teste.Controllers
{
    public class CaoController : Controller
    {
        private readonly TesteContext _context;

        public CaoController(TesteContext context)
        {
            _context = context;
        }

        // GET: Cao
        public async Task<IActionResult> Index()
        {
            var testeContext = _context.Cao.Include(c => c.Dono);
            return View(await testeContext.ToListAsync());
        }

        // GET: Cao/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cao = await _context.Cao
                .Include(c => c.Dono)
                .FirstOrDefaultAsync(m => m.CachorroId == id);
            if (cao == null)
            {
                return NotFound();
            }

            return View(cao);
        }

        // GET: Cao/Create
        public IActionResult Create()
        {
            ViewData["DonoId"] = new SelectList(_context.Dono, "DonoId", "Nome");
            return View();
        }

        // POST: Cao/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("CachorroId,Nome,DonoId")] Cao cao)
        {
            if (ModelState.IsValid)
            {
                _context.Add(cao);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["DonoId"] = new SelectList(_context.Dono, "DonoId", "DonoId", cao.DonoId);
            return View(cao);
        }

        // GET: Cao/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cao = await _context.Cao.FindAsync(id);
            if (cao == null)
            {
                return NotFound();
            }
            ViewData["DonoId"] = new SelectList(_context.Dono, "DonoId", "DonoId", cao.DonoId);
            return View(cao);
        }

        // POST: Cao/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("CachorroId,Nome,DonoId")] Cao cao)
        {
            if (id != cao.CachorroId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(cao);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CaoExists(cao.CachorroId))
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
            ViewData["DonoId"] = new SelectList(_context.Dono, "DonoId", "DonoId", cao.DonoId);
            return View(cao);
        }

        // GET: Cao/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cao = await _context.Cao
                .Include(c => c.Dono)
                .FirstOrDefaultAsync(m => m.CachorroId == id);
            if (cao == null)
            {
                return NotFound();
            }

            return View(cao);
        }

        // POST: Cao/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var cao = await _context.Cao.FindAsync(id);
            _context.Cao.Remove(cao);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CaoExists(int id)
        {
            return _context.Cao.Any(e => e.CachorroId == id);
        }
    }
}
