using Microsoft.AspNetCore.Mvc;
using TuyenDungViecLam.Services;
using TuyenDungViecLam.Models;

namespace TuyenDungViecLam.Controllers
{
    public class EmployerController : Controller
    {
        private readonly IDataService _dataService;

        public EmployerController(IDataService dataService)
        {
            _dataService = dataService;
        }

        public async Task<IActionResult> Dashboard()
        {
            if (HttpContext.Session.GetString("UserRole") != "Employer")
            {
                return RedirectToAction("Login", "Account");
            }

            var jobs = await _dataService.GetJobsAsync();
            var myJobs = jobs.Where(j => j.Company.Contains("TechViet") || j.Company.Contains("Digital")).ToList();
            
            ViewBag.TotalJobs = myJobs.Count;
            ViewBag.ActiveJobs = myJobs.Count(j => j.IsActive);
            
            return View(myJobs);
        }

        [HttpGet]
        public IActionResult PostJob()
        {
            if (HttpContext.Session.GetString("UserRole") != "Employer")
            {
                return RedirectToAction("Login", "Account");
            }
            
            return View();
        }

        [HttpPost]
        public IActionResult PostJob(Job job)
        {
            if (HttpContext.Session.GetString("UserRole") != "Employer")
            {
                return RedirectToAction("Login", "Account");
            }

            // Simulate posting job
            TempData["Success"] = $"Đã đăng tin tuyển dụng '{job.Title}' thành công!";
            return RedirectToAction("Dashboard");
        }

        public async Task<IActionResult> Applications()
        {
            if (HttpContext.Session.GetString("UserRole") != "Employer")
            {
                return RedirectToAction("Login", "Account");
            }

            var applications = await _dataService.GetApplicationsAsync();
            return View(applications);
        }
    }
}