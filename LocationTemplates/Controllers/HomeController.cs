using LocationTemplates.Models;
using System.Web.Mvc;

namespace LocationTemplates.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            var model = new LocationViewModel();
            //model.Country = "ATA"; would set the selected country to Antartica
            //model.State = "TX"; would set the selected state to Texas

            return View(model);
        }
    }
}