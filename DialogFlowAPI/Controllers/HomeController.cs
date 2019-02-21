using Microsoft.AspNetCore.Mvc;
 
namespace DialogFlowAPI.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public string Testing()
        {
            return "This is /home/testing";
        }
    }
}