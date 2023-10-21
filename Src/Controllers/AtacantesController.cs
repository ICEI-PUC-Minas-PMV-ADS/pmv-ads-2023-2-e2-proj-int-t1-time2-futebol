using FutScout_2023.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FutScout_2023.Controllers
{
    public class AtacantesController : Controller
    {
        private readonly AppDbcontext _context;
        public AtacantesController(AppDbcontext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var dados = await _context.Atacantes.ToListAsync();

            return View(dados);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Atacante atacante)
        {
            if (ModelState.IsValid)
            {
                _context.Atacantes.Add(atacante);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }


            return View(atacante);
        }

        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
                return NotFound();

            var dados = await _context.Atacantes.FindAsync(id);

            if (id == null)
                return NotFound();

            return View(dados);


        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id, Atacante atacante)
        {
            if (id != atacante.Id)
                return NotFound();

            if (ModelState.IsValid)
            {
                _context.Atacantes.Update(atacante);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(atacante);

        }

        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
                return NotFound();

            var atacanteTask = _context.Atacantes.FindAsync(id);

            if (atacanteTask == null)
                return NotFound();

            var atacante = await atacanteTask;

            return View(atacante);
        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
                return NotFound();

            var dados = await _context.Atacantes.FindAsync(id);

            if (dados == null)
                return NotFound();

            return View(dados);
        }

        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(int? id)
        {
            if (id == null)
                return NotFound();

            var dados = await _context.Atacantes.FindAsync(id);

            if (dados == null)
                return NotFound();

            _context.Atacantes.Remove(dados);
            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }

    }
}
