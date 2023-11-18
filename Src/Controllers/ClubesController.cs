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

        public async Task<IActionResult> Index(string sortBy, string sortDirection, string série)
        {
            // Obtenha os dados sem aplicar nenhum filtro
            var dados = _context.Clubes.AsQueryable();

            // Obtenha a lista completa de séries antes de aplicar o filtro
            var todasAsSéries = await dados.Select(x => x.Série).Distinct().ToListAsync();

            // Filtrar por Série, se especificado
            if (!string.IsNullOrEmpty(série))
            {
                // Aplique o filtro por série
                dados = dados.Where(x => x.Série == série);
            }

            // Realize a classificação dos dados com base no valor de sortBy.
            if (!string.IsNullOrEmpty(sortBy))
            {
                dados = SortData(dados, sortBy, sortDirection);
            }

            // Converta os dados para uma lista depois de aplicar o filtro e a ordenação
            var dadosList = await dados.ToListAsync();

            // Adicione as séries no ViewBag para serem acessadas na view
            ViewBag.TodasAsSéries = todasAsSéries;
            ViewBag.SérieSelecionada = série;

            // Retorne os dados filtrados e ordenados
            return View(dadosList);
        }

        private IOrderedQueryable<Clube> SortData(IQueryable<Clube> data, string sortBy, string sortDirection)
        {
            switch (sortBy)
            {
                case "Nome":
                    return (sortDirection == "asc") ? data.OrderBy(item => item.Nome) : data.OrderByDescending(item => item.Nome);
                case "Estado":
                    return (sortDirection == "asc") ? data.OrderBy(item => item.Estado) : data.OrderByDescending(item => item.Estado);
                case "Série":
                    return (sortDirection == "asc") ? data.OrderBy(item => item.Série) : data.OrderByDescending(item => item.Série);
                case "gols2021":
                    return (sortDirection == "asc") ? data.OrderBy(item => item.gols2021) : data.OrderByDescending(item => item.gols2021);
                case "gols2022":
                    return (sortDirection == "asc") ? data.OrderBy(item => item.gols2022) : data.OrderByDescending(item => item.gols2022);
                case "gols2023":
                    return (sortDirection == "asc") ? data.OrderBy(item => item.gols2023) : data.OrderByDescending(item => item.gols2023);
                default:
                    return data.OrderBy(item => item.Nome); // Ordenação padrão
            }
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
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(clube); 
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
        private object GetPropertyValueByColumnName(Atacante item, string columnName)
        {
            var prop = typeof(Atacante).GetProperty(columnName);
            if (prop != null)
            {
                return prop.GetValue(item, null);
            }
            return null;
        }
    }
}

