using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ChrisMVC.Data;
using ChrisMVC.EF;

namespace ChrisMVC.Controllers
{
    public class EstoquesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public EstoquesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Estoques
        public async Task<IActionResult> Index()
        {
            return View(await _context.Estoques.ToListAsync());
        }

        // GET: Estoques/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var estoques = await _context.Estoques
                .FirstOrDefaultAsync(m => m.Id == id);
            if (estoques == null)
            {
                return NotFound();
            }

            return View(estoques);
        }

        // GET: Estoques/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Estoques/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,NomeProduto,Quantidade,LocalArmazenado,SaidaProduto,EntradaProduto,EntradaData,RetiradaData")] Estoques estoques)
        {
            if (ModelState.IsValid)
            {
                _context.Add(estoques);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(estoques);
        }

        // GET: Estoques/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var estoques = await _context.Estoques.FindAsync(id);
            if (estoques == null)
            {
                return NotFound();
            }
            return View(estoques);
        }

        // POST: Estoques/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,NomeProduto,Quantidade,LocalArmazenado,SaidaProduto,EntradaProduto,EntradaData,RetiradaData")] Estoques estoques)
        {
            if (id != estoques.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(estoques);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!EstoquesExists(estoques.Id))
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
            return View(estoques);
        }

        // GET: Estoques/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var estoques = await _context.Estoques
                .FirstOrDefaultAsync(m => m.Id == id);
            if (estoques == null)
            {
                return NotFound();
            }

            return View(estoques);
        }

        // POST: Estoques/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var estoques = await _context.Estoques.FindAsync(id);
            _context.Estoques.Remove(estoques);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool EstoquesExists(int id)
        {
            return _context.Estoques.Any(e => e.Id == id);
        }
    }
}
