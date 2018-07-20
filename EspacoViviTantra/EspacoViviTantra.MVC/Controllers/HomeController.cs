using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using EspacoViviTantra.MVC.Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace EspacoViviTantra.MVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly IUsuarioRepository _usuarioRepository;
        public HomeController(IUsuarioRepository usuariorepository)
        {
            _usuarioRepository = usuariorepository;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Get()
        {
            try
            {
                return Ok(_usuarioRepository.ListarUsuarios());
            }
            catch (Exception ex)
            {
                return BadRequest("Error: " + ex.Message);
            }
        }
        
        /*public IActionResult Error()
        {
            ViewData["RequestId"] = Activity.Current?.Id ?? HttpContext.TraceIdentifier;
            return View();
        }*/
    }
}
