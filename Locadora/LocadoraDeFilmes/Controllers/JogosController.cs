using LocadoraDeFilmes.Models;
using LocadoraDeFilmes.Services;
using Microsoft.AspNetCore.Mvc;


namespace LocadoraDeFilmes.Controllers
{
    public class JogosController : Controller
    {
        IJogoService _service;
        public JogosController(JogoSqlService service)
        {
            _service = service;

        }

        public IActionResult Index()
        {
            return View(_service.GetAll());
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Jogo jogo)
        {
            if (!ModelState.IsValid) return View(jogo);

            return _service.Create(jogo) ?  RedirectToAction(nameof(Index)) :  View(jogo);
        }

        public IActionResult Read(int? id)
        {
            Jogo jogo = _service.Get(id);
            return jogo != null ? View(jogo) : NotFound();
        }

        [HttpGet]
        public IActionResult Update(int? id)
        {
            Jogo jogo = _service.Get(id);
            return jogo != null ? View(jogo) : NotFound();
        }

        [HttpPost]
        public IActionResult Update(Jogo jogo)
        {
            if (!ModelState.IsValid) return View(jogo);
            if (_service.Update(jogo))
            {
                return RedirectToAction(nameof(Index));
            }
            else
            {
                return View(jogo);
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
            Jogo jogo = _service.Get(id);
            if (jogo != null)
            {
                return View(nameof(Confirm));
            }
            return NotFound();
        }
    }
}
