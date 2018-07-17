using EspacoViviTantra.App.Contexts;
using EspacoViviTantra.Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace EspacoViviTantraApp.Controllers
{
    [Route("api/[Controller]")]
    public class HomeController : Controller
    {
        /*private readonly IUsuarioRepository _usuarioRepository;
        public HomeController(IUsuarioRepository usuarioRepository)
        {
            _usuarioRepository = usuarioRepository;
        }*/
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public string Get()
        {
            return "Mensagem teste!";
        }
    }
}