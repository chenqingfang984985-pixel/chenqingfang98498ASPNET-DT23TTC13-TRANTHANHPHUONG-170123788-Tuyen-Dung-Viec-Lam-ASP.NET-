using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using TuyenDungViecLam.Models;
using TuyenDungViecLam.Services;

namespace TuyenDungViecLam.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly IDataService _dataService;

    public HomeController(ILogger<HomeController> logger, IDataService dataService)
    {
        _logger = logger;
        _dataService = dataService;
    }

    public async Task<IActionResult> Index()
    {
        var jobs = await _dataService.GetJobsAsync();
        var categories = await _dataService.GetCategoriesAsync();
        
        ViewBag.Categories = categories;
        return View(jobs.Take(6).ToList());
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
