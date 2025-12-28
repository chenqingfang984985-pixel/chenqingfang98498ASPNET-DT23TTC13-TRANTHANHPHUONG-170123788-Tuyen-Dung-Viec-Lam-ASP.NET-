using Microsoft.AspNetCore.Mvc;
using TuyenDungViecLam.Models;
using TuyenDungViecLam.Services;

namespace TuyenDungViecLam.Controllers
{
    public class AccountController : Controller
    {
        private readonly IDataService _dataService;

        public AccountController(IDataService dataService)
        {
            _dataService = dataService;
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(string Email, string Password)
        {
            // Kiểm tra trực tiếp từ form
            if (string.IsNullOrEmpty(Email) || string.IsNullOrEmpty(Password))
            {
                ViewBag.Error = "Vui lòng nhập đầy đủ thông tin";
                return View();
            }
            
            // Kiểm tra tài khoản cố định
            if (Email == "employer@test.com" && Password == "123456")
            {
                HttpContext.Session.SetString("UserEmail", "employer@test.com");
                HttpContext.Session.SetString("UserRole", "Employer");
                return RedirectToAction("Index", "Home");
            }
            else if (Email == "phuongtran84@test.com" && Password == "987654")
            {
                HttpContext.Session.SetString("UserEmail", "phuongtran84@test.com");
                HttpContext.Session.SetString("UserRole", "phuongtran84");
                return RedirectToAction("Index", "Home");
            }
            else if (Email == "admin@test.com" && Password == "123456")
            {
                HttpContext.Session.SetString("UserEmail", "admin@test.com");
                HttpContext.Session.SetString("UserRole", "Admin");
                return RedirectToAction("Index", "Home");
            }
            
            ViewBag.Error = "Tài khoản hoặc mật khẩu không đúng!";
            return View();
        }

        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Register(RegisterViewModel model)
        {
            if (ModelState.IsValid)
            {
                // Simulate registration logic
                HttpContext.Session.SetString("UserEmail", model.Email);
                HttpContext.Session.SetString("UserRole", model.Role.ToString());
                
                TempData["Success"] = "Đăng ký thành công! Bạn đã được đăng nhập.";
                return RedirectToAction("Index", "Home");
            }
            return View(model);
        }

        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            TempData["Success"] = "Đã đăng xuất thành công!";
            return RedirectToAction("Index", "Home");
        }
        
        public IActionResult Test()
        {
            return View();
        }
        
        public IActionResult QuickLogin()
        {
            return View();
        }
        
        public IActionResult SimpleLogin()
        {
            return View();
        }
    }
}