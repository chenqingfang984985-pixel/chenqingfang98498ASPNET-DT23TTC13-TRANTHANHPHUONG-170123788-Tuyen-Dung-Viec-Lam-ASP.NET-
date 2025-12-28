using Microsoft.AspNetCore.Mvc;
using TuyenDungViecLam.Services;
using TuyenDungViecLam.Models;

namespace TuyenDungViecLam.Controllers
{
    public class JobsController : Controller
    {
        private readonly IDataService _dataService;

        public JobsController(IDataService dataService)
        {
            _dataService = dataService;
        }

        public async Task<IActionResult> Index(string? keyword, string? location, string? category)
        {
            var jobs = await _dataService.SearchJobsAsync(keyword, location, category);
            var categories = await _dataService.GetCategoriesAsync();
            
            ViewBag.Categories = categories;
            ViewBag.Keyword = keyword;
            ViewBag.Location = location;
            ViewBag.Category = category;
            
            return View(jobs);
        }

        public async Task<IActionResult> Details(string id)
        {
            var job = await _dataService.GetJobByIdAsync(id);
            if (job == null)
            {
                return NotFound();
            }
            return View(job);
        }

        [HttpGet]
        public async Task<IActionResult> Apply(string id)
        {
            var job = await _dataService.GetJobByIdAsync(id);
            if (job == null)
            {
                return NotFound();
            }

            var model = new ApplyJobViewModel
            {
                JobId = job.Id,
                JobTitle = job.Title,
                Company = job.Company
            };

            // Pre-fill if user is logged in
            var userEmail = HttpContext.Session.GetString("UserEmail");
            if (!string.IsNullOrEmpty(userEmail))
            {
                model.Email = userEmail;
            }

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Apply(ApplyJobViewModel model)
        {
            if (ModelState.IsValid)
            {
                // Simulate saving application
                TempData["Success"] = $"Ứng tuyển thành công vào vị trí {model.JobTitle} tại {model.Company}!";
                return RedirectToAction("Details", new { id = model.JobId });
            }

            return View(model);
        }
    }
}