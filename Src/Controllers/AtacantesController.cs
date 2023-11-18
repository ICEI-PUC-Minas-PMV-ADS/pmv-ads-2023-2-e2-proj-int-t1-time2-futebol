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

        
        public async Task<IActionResult> Index(string sortBy, string sortDirection, string clube)

        {

            var dados = await _context.Atacantes.ToListAsync();

            // Realize a classificação dos dados com base no valor de sortBy.

            if (!string.IsNullOrEmpty(sortBy))

            {

                dados = SortData(dados, sortBy, sortDirection);

            }

            // Obtenha a lista completa de clubes antes de aplicar o filtro

            var todosOsClubes = dados.Select(x => x.Clube).Distinct().ToList();

            // Filtrar por clube, se especificado

            if (!string.IsNullOrEmpty(clube))

            {

                var atacantesDoClube = dados.Where(x => x.Clube == clube).ToList();

                // Aplicar a ordenação à lista filtrada

                if (!string.IsNullOrEmpty(sortBy))

                {

                    atacantesDoClube = SortData(atacantesDoClube, sortBy, sortDirection);

                }

                // Atualizar a variável dados com a lista filtrada e ordenada

                dados = atacantesDoClube;

            }

            // Adicione os clubes no ViewBag para serem acessados na view

            ViewBag.TodosOsClubes = todosOsClubes;

            ViewBag.ClubeSelecionado = clube;

            return View(dados);

        }



        private List<Atacante> SortData(List<Atacante> data, string sortBy, string sortDirection)

        {

            if (sortDirection == "asc")

            {

                switch (sortBy)

                {

                    case "Nome":

                        return data.OrderBy(item => item.Nome).ToList();

                    case "Idade":

                        return data.OrderBy(item => item.Idade).ToList();

                    case "Clube":

                        return data.OrderBy(item => item.Clube).ToList();

                    case "Partidas2023":

                        return data.OrderBy(item => item.Partidas2023).ToList();

                    case "Gols2023":

                        return data.OrderBy(item => item.Gols2023).ToList();

                    case "Assists2023":

                        return data.OrderBy(item => item.Assists2023).ToList();

                    case "Partidas2022":

                        return data.OrderBy(item => item.Partidas2022).ToList();

                    case "Gols2022":

                        return data.OrderBy(item => item.Gols2022).ToList();

                    case "Assists2022":

                        return data.OrderBy(item => item.Assists2022).ToList();

                    case "Partidas2021":

                        return data.OrderBy(item => item.Partidas2021).ToList();

                    case "Gols2021":

                        return data.OrderBy(item => item.Gols2021).ToList();

                    case "Assists2021":

                        return data.OrderBy(item => item.Assists2021).ToList();

                    default:

                        return data;

                }

            }

            else if (sortDirection == "desc")

            {

                switch (sortBy)

                {

                    case "Nome":

                        return data.OrderByDescending(item => item.Nome).ToList();

                    case "Idade":

                        return data.OrderByDescending(item => item.Idade).ToList();

                    case "Clube":

                        return data.OrderByDescending(item => item.Clube).ToList();

                    case "Partidas2023":

                        return data.OrderByDescending(item => item.Partidas2023).ToList();

                    case "Gols2023":

                        return data.OrderByDescending(item => item.Gols2023).ToList();

                    case "Assists2023":

                        return data.OrderByDescending(item => item.Assists2023).ToList();

                    case "Partidas2022":

                        return data.OrderByDescending(item => item.Partidas2022).ToList();

                    case "Gols2022":

                        return data.OrderByDescending(item => item.Gols2022).ToList();

                    case "Assists2022":

                        return data.OrderByDescending(item => item.Assists2022).ToList();

                    case "Partidas2021":

                        return data.OrderByDescending(item => item.Partidas2021).ToList();

                    case "Gols2021":

                        return data.OrderByDescending(item => item.Gols2021).ToList();

                    case "Assists2021":

                        return data.OrderByDescending(item => item.Assists2021).ToList();

                    default:

                        return data;

                }

            }

            else

            {

                return data;

            }

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
