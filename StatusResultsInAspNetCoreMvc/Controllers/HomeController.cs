using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using StatusResultsInAspNetCoreMvc.Models;

namespace StatusResultsInAspNetCoreMvc.Controllers;

public class HomeController : Controller
{
    public IActionResult NotFoundExample()
    {
        // Return a 404 Not Found response
        // return new StatusCodeResult(404);

        // Helper Method
        // return StatusCode(404);

        // Return a 404 Not Found response
        return new NotFoundResult();
        // Or use the shorthand:
        // return NotFound();
    }
    public IActionResult CustomStatusCodeExample()
    {
        // Return a custom status code
        // return new StatusCodeResult(403);

        // Helper Method
        return StatusCode(403);
    }

    public IActionResult UnauthorizedExample()
    {
        // Return a 401 Unauthorized response
        return new UnauthorizedResult();
        // Or use the shorthand helper method:
        //return Unauthorized();
    }

    public IActionResult OkExample()
    {
        // Return a 200 OK response
        return new OkResult();
        // Or use the shorthand:
        // return Ok(); 
    }
}
