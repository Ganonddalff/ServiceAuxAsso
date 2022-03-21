using Microsoft.AspNetCore.Mvc;

namespace AssoFlexV1.Controllers
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