using Microsoft.AspNetCore.Mvc;

namespace AssoFlexV1.Controllers
{
    public class EvenementController : Controller
    {
        // GET
        public IActionResult Index()
        {
            return View();
        }
    }
}