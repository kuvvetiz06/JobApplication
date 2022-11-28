using Microsoft.AspNetCore.Mvc;

namespace JobApplication.Controllers
{
    public class JobController : Controller
    {
        
        public IActionResult Index()
        {
            return View();
        }

        
        public IActionResult JobDetails(int id)
        {

            ViewBag.Id = id;
            return View();
        }
    }
}
