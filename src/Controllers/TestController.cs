using Microsoft.AspNetCore.Mvc;

namespace TuyenDungViecLam.Controllers
{
    public class TestController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.UserEmail = HttpContext.Session.GetString("UserEmail");
            ViewBag.UserRole = HttpContext.Session.GetString("UserRole");
            ViewBag.SessionId = HttpContext.Session.Id;
            
            return View();
        }
        
        [HttpPost]
        public IActionResult SetAdmin()
        {
            HttpContext.Session.SetString("UserEmail", "admin@test.com");
            HttpContext.Session.SetString("UserRole", "Admin");
            return RedirectToAction("Index");
        }
        
        [HttpPost]
        public IActionResult SetEmployer()
        {
            HttpContext.Session.SetString("UserEmail", "employer@test.com");
            HttpContext.Session.SetString("UserRole", "Employer");
            return RedirectToAction("Index");
        }
        
        [HttpPost]
        public IActionResult SetCandidate()
        {
            HttpContext.Session.SetString("UserEmail", "phuongtran84@test.com");
            HttpContext.Session.SetString("UserRole", "phuongtran84");
            return RedirectToAction("Index");
        }
        
        public IActionResult Clear()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Index");
        }
    }
}