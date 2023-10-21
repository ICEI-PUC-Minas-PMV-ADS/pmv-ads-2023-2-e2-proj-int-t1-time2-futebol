using FutScout_2023.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FutScout_2023.Controllers
{
 
        public class ClubesController : Controller
        {
            private readonly AppDbcontext _context;
            public ClubesController(AppDbcontext context)
            {
                _context = context;
            }

            public async Task<IActionResult> Index()
            {
                var dados = await _context.Clubes.ToListAsync();

                return View(dados);
            }
            public IActionResult Create()
            {
                return View();
            }

            [HttpPost]
            public async Task<IActionResult> Create(Clube clube)
            {
                if (ModelState.IsValid)
                {
                    _context.Clubes.Add(clube);
                    await _context.SaveChangesAsync();
                    return RedirectToAction("Index");
                }

                return View(clube);
            }

            public async Task<IActionResult> Edit(int? id)
            {
                if (id == null)
                    return NotFound();

                var dados = await _context.Clubes.FindAsync(id);

                if (dados == null)
                    return NotFound();


                return View(dados);
            }

            [HttpPost]
            public async Task<IActionResult> Edit(int id, Clube clube)
            {
                if (id != clube.Id)
                    return NotFound();

                if (ModelState.IsValid)
                {
                    _context.Clubes.Update(clube);

                    _context.Clubes.Add(clube);
                    await _context.SaveChangesAsync();
                    return RedirectToAction("Index");
                }

                return View();
            }

            public async Task<IActionResult> Details(int? id)
            {
                if (id == null)
                    return NotFound();

                var dados = await _context.Clubes.FindAsync(id);

                if (dados == null)
                    return NotFound();


                return View(dados);

            }

            public async Task<IActionResult> Delete(int? id)
            {
                if (id == null)
                    return NotFound();

                var dados = await _context.Clubes.FindAsync(id);

                if (dados == null)
                    return NotFound();


                return View(dados);
            }

            [HttpPost, ActionName("Delete")]
            public async Task<IActionResult> DeleteConfirmed(int? id)
            {
                if (id == null)
                    return NotFound();

                var dados = await _context.Clubes.FindAsync(id);

                if (dados == null)
                    return NotFound();

                _context.Clubes.Remove(dados);
                await _context.SaveChangesAsync();

                return RedirectToAction("Index");
            }
        }
}
