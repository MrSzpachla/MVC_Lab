using Microsoft.AspNetCore.Mvc;
using MVC_Lab.Models;

namespace MVC_Lab.Controllers
{
    public class TestController : Controller
    {
        public IActionResult Index()
        {
            var model = new TestModel();
            model.Imie = "Kamil";
            model.Nazwisko = "Paszkiet";
            model.NrAlbum = 49750;
            return View(model);
        }
    }
}
