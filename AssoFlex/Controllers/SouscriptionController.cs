using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AssoFlex.Controllers
{
    public class SouscriptionController : Controller
    {
        [Authorize(Roles = "Admin, Admin-Asso, Basic")]
        // GET
        public IActionResult Index()
        {
            return View();
        }
    }
}