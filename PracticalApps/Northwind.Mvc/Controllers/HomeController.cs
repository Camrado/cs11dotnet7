using System.Diagnostics; // Activity
using Microsoft.AspNetCore.Mvc; // Controller, IActionResult
using Northwind.Mvc.Models; // ErrorViewModel
using Packt.Shared; // NorthwindContext

namespace Northwind.Mvc.Controllers;

public class HomeController : Controller {
    private readonly ILogger<HomeController> _logger;
    private readonly NorthwindContext db;

    public HomeController(ILogger<HomeController> logger, NorthwindContext injectedContext) {
        _logger = logger;
        db = injectedContext;
    }

    public IActionResult Index() {
        HomeIndexViewModel model = new(Random.Shared.Next(1, 1001), db.Categories.ToList(), db.Products.ToList());
        return View(model); // pass model to view
    }

    public IActionResult Privacy() {
        return View();
    }

    public IActionResult ProductDetail(int? id) {
        if (!id.HasValue) {
            return BadRequest("You must pass a product ID in the route, forexample, /Home/ProductDetail/21");
        }

        Product? model = db.Products.SingleOrDefault(p => p.ProductId == id);

        if (model is null) {
            return NotFound($"ProductId {id} not found.");
        }

        return View(model); // pass model to view and then return result
    }

    public IActionResult ModelBinding() {
        return View(); // the page with a form to submit
    }

    [HttpPost] 
    public IActionResult ModelBinding(Thing thing) {
        return View(thing); // show the model bound thing
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error() {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}