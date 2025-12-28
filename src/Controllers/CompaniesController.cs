using Microsoft.AspNetCore.Mvc;
using TuyenDungViecLam.Services;

namespace TuyenDungViecLam.Controllers
{
    public class CompaniesController : Controller
    {
        private readonly IDataService _dataService;

        public CompaniesController(IDataService dataService)
        {
            _dataService = dataService;
        }

        public async Task<IActionResult> Index()
        {
            var employers = await _dataService.GetEmployersAsync();
            return View(employers);
        }

        public async Task<IActionResult> Details(string id)
        {
            var employer = await _dataService.GetEmployerByIdAsync(id);
            if (employer == null)
            {
                return NotFound();
            }
            
            var jobs = await _dataService.GetJobsAsync();
            var companyJobs = jobs.Where(j => j.EmployerId == id).ToList();
            
            ViewBag.Jobs = companyJobs;
            return View(employer);
        }
    }
}