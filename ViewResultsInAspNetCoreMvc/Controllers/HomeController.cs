using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ViewResultsInAspNetCoreMvc.Models;

namespace ViewResultsInAspNetCoreMvc.Controllers;

public class HomeController : Controller
{
    public ViewResult Index()
    {
        Product product = new Product()
        {
            Id = 1,
            Name = "Test",
        };
        return View(product);
    }
}
