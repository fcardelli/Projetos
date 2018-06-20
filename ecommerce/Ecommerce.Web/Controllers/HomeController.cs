using Ecommerce.Web.Data;
using Microsoft.AspNetCore.Mvc;

namespace Ecommerce.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly IProdutoRepository _repository;
        public HomeController(IProdutoRepository repository)
        {
            _repository = repository;
        }
        public IActionResult Index()
        {
            return View(_repository.ListarProdutos());
        }

        public string Teste2()
        {
            return "Teste2";
        }
    }
}