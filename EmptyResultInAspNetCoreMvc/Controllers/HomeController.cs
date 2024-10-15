using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using EmptyResultInAspNetCoreMvc.Models;

namespace EmptyResultInAspNetCoreMvc.Controllers;

public class HomeController : Controller
{
    public IActionResult ProcessRequest()
    {
        // Perform some processing
        // Return an empty HTTP response
        return new EmptyResult();
    }

    public IActionResult DeleteResource()
    {
        // Delete the resource
        // Return a 204 No Content response with an EmptyResult
        return NoContent();
    }
}
