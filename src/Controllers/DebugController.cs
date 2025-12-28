using Microsoft.AspNetCore.Mvc;

namespace TuyenDungViecLam.Controllers
{
    public class DebugController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.UserEmail = HttpContext.Session.GetString("UserEmail");
            ViewBag.UserRole = HttpContext.Session.GetString("UserRole");
            ViewBag.SessionId = HttpContext.Session.Id;
            ViewBag.SessionKeys = HttpContext.Session.Keys.ToList();
            
            return View();
        }
        
        [HttpPost]
        public IActionResult SetSession(string email, string role)
        {
            HttpContext.Session.SetString("UserEmail", email);
            HttpContext.Session.SetString("UserRole", role);
            
            return RedirectToAction("Index");
        }
        
        public IActionResult ClearSession()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Index");
        }
    }
}