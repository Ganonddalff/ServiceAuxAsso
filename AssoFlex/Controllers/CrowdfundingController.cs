using Microsoft.AspNetCore.Mvc;

namespace AssoFlex.Controllers
{
    public class CrowdfundingController : Controller
    {
        // GET
        public IActionResult Index()
        {
            
            return View();
        }
    }
}