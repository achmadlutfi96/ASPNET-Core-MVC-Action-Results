using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using RedirectResultsInAspNetCoreMvc.Models;

namespace RedirectResultsInAspNetCoreMvc.Controllers;

public class HomeController : Controller
{
    // public RedirectResult Index()
    // {
    //     // return new RedirectResult("https://dotnettutorials.net");

    //     // Helper Method
    //     return Redirect("https://dotnettutorials.net");
    // }


    // Defining the Index action method which returns a RedirectResult
    // public RedirectResult Index()
    // {
    //     // Creating a new RedirectResult object with the URL to redirect to
    //     var redirectResult = new RedirectResult("https://dotnettutorials.net")
    //     {
    //         // Setting the Permanent property to false, meaning the redirection is temporary
    //         Permanent = false,
    //         // Setting the PreserveMethod property to true, meaning the HTTP method used (GET, POST, etc.) will be preserved in the redirect
    //         PreserveMethod = true
    //     };
    //     // Returning the RedirectResult object to the client, causing the browser to redirect to the specified URL
    //     return redirectResult;
    // }

    public RedirectToRouteResult Index()
        {
            // Perform some logic
            // Redirect to a different route
            // You need to specify the Route Name, not the Route Pattern
            // return RedirectToRoute("AboutRoute", new { name = "Index" });

            return RedirectToRoute(new { controller = "Home", action = "About", name="Index" });
        }
        public string About(string name)
        {
            return "Hello and Welcome to Dot Net Tutorials " + name;
        }
}
