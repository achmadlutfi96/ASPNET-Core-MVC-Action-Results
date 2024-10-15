using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using PartialViewResultInAspNetCoreMvc.Models;

namespace PartialViewResultInAspNetCoreMvc.Controllers;

public class HomeController : Controller
{
    // public ViewResult Index()
    // {
    //     return View();
    // }

    // [AjaxOnly]
    // public PartialViewResult Details(int ProductId)
    // {
    //     Product product = new Product()
    //     {
    //         Id = ProductId,
    //         Name = "Test Product",
    //     };
    //     return PartialView("_ProductDetailsPartialView", product);
    // }

    // Define the Index action method which returns a ViewResult
    public ViewResult Index()
    {
        // Return the default view associated with this action
        return View();
    }
    
    // Define the Details action method which returns a PartialViewResult
    public PartialViewResult Details(int ProductId)
    {
        // Get the HTTP method of the current request (e.g., GET, POST)
        string method = HttpContext.Request.Method;
        // Get the value of the "X-Requested-With" header from the current request
        string? requestedWith = HttpContext?.Request?.Headers.XRequestedWith;
        // Check if the HTTP method is either POST or GET
        if (method == "POST" || method == "GET")
        {
            // Check if the request was made via AJAX (i.e., the "X-Requested-With" header is "XMLHttpRequest")
            if (requestedWith == "XMLHttpRequest")
            {
                // Create a new Product object with the provided ProductId and a sample name
                Product product = new Product()
                {
                    Id = ProductId,
                    Name = "Test Product",
                };
                // Return the partial view "_ProductDetailsPartialView" with the product model
                return PartialView("_ProductDetailsPartialView", product);
            }
        }
        // If the request is not valid (not an AJAX request), return the "_InvalidRequestPartialView" partial view
        return PartialView("_InvalidRequestPartialView");
    }
}
