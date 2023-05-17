using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Web.Data;
using Web.Models;

namespace Web.Controllers;

public class HomeController : Controller
{
    private readonly AppDbContext _context;

    public HomeController(AppDbContext context)
    {
        _context = context;
    }
    
    public IActionResult Index()
    {
        var articles = _context.Articles.ToList();
        return View(articles);
    }

    public IActionResult About()
    {

        ViewBag.PhotoUrl = "https://cdn.pixabay.com/photo/2023/03/18/09/06/railway-7860168_960_720.jpg";
        ViewBag.Text = "Bura yazidir";

        return View();
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

