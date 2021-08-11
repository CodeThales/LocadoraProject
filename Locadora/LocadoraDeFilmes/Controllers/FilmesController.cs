using LocadoraDeFilmes.Models;
using LocadoraDeFilmes.Services;
using Microsoft.AspNetCore.Mvc;



namespace LocadoraDeFilmes.Controllers
{
    public class FilmesController : Controller
    {
        IFilmeService _serviceStatic, _serviceSql, _service;
        public FilmesController(FilmeSqlService serviceSql, FilmeStaticService serviceStatic)
        {
            _serviceStatic = serviceStatic;
            _serviceSql = serviceSql;
            _service = serviceSql;
        }

        private void SelectService(string service = "sql")
        {
            switch (service)
            {
                case "sql":
                    this._service = this._serviceSql;
                    break;
                case "static":
                    this._service = this._serviceStatic;
                    break;
                default:
                    this._service = this._serviceSql;
                    break;
            }
        }

        private void SetViewBag(string source = null)
        {
            ViewBag.source = source;
        }

        public IActionResult Index(string busca, bool ordenar = false, string service = "sql")
        {
            SelectService(service);
            if (service == "sql") SetViewBag(source: "sql");

            ViewBag.ordenar = ordenar;
            return View(_service.GetAll(busca, ordenar));
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Filme filme)
        {
            if (!ModelState.IsValid) return View(filme);

            return _service.Create(filme) ? RedirectToAction(nameof(Index)) : View(filme);
        }

        public IActionResult Read(int? id)
        {
            Filme filme = _service.Get(id);
            return filme != null ? View(filme) : NotFound();
        }

        [HttpGet]
        public IActionResult Update(int? id)
        {
            Filme filme = _service.Get(id);
            return filme != null ? View(filme) : NotFound();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Update(Filme filme)
        {
            if (!ModelState.IsValid) return View(filme);

            if (_service.Update(filme)) 
            {
                return RedirectToAction(nameof(Index));
            }
            else
            {
                return View(filme);
            }
        }

        public IActionResult Delete(int? id)
        {
            if (_service.Delete(id))
            {
                return RedirectToAction(nameof(Index));
            }
            else
            {
                return NotFound();
            }
        }

        public IActionResult Confirm(int? id)
        {
            Filme filme = _service.Get(id);
            if (filme != null)
            {
                return View(nameof(Confirm));
            }
            return NotFound();           
        }
    }
}
