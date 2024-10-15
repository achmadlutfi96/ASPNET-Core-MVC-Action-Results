using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ObjectResultInAspNetCoreMvc.Models;

namespace ObjectResultInAspNetCoreMvc.Controllers;

public class HomeController : Controller
{
    // public IActionResult GetPerson()
    // {
    //     var person = new { FirstName = "Pranaya", LastName = "Rout", Age = 35 };
    //     // Return an ObjectResult with JSON serialization
    //     return new ObjectResult(person);
    //     // Or use the shorthand:
    //     // return Ok(person);
    // }

    // public IActionResult GetPerson()
    // {
    //     var person = new { FirstName = "Pranaya", LastName = "Rout", Age = 35 };
    //     var result = new ObjectResult(person)
    //     {
    //         StatusCode = 200, // HTTP status code
    //         ContentTypes = new Microsoft.AspNetCore.Mvc.Formatters.MediaTypeCollection
    //             {
    //                 "application/json" // Content type(s)
    //             }
    //     };
    //     return result;
    // }

    public IActionResult GetPerson()
    {
        var person = new { FirstName = "Pranaya", LastName = "Rout", Age = 35 };
        // Return a 200 OK response with JSON serialization
        return Ok(person);
    }
}
