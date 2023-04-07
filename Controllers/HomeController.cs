using System.Web.Mvc;

namespace Sistema_Cadastro_Produtos.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Cafe Coado Experience";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Contato.";

            return View();
        }
    }
}