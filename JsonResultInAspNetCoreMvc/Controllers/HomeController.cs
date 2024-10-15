using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using JsonResultInAspNetCoreMvc.Models;
using System.Text.Json;

namespace JsonResultInAspNetCoreMvc.Controllers;

public class HomeController : Controller
{
    // Defining an action method named Index that returns a JsonResult
    // public JsonResult Index()
    // {
    //     // // Creating an anonymous object with properties Name, ID, and DateOfBirth
    //     // var jsonData = new
    //     // {
    //     //     Name = "Pranaya",
    //     //     ID = 4,
    //     //     DateOfBirth = new DateTime(1988, 02, 29)
    //     // };
    //     // // // Returning a JsonResult object with the jsonData as the content to be serialized to JSON
    //     // // return new JsonResult(jsonData);

    //     // // Returning a JsonResult using the Json method of the Controller class
    //     // // The Json method takes the jsonData object and serializes it to JSON format
    //     // // and sets appropriate headers for the response to indicate the content type as application/json.
    //     // return Json(jsonData);

    //     var jsonArray = new[]
    //         {
    //             new { Name = "Pranaya", Age = 25, Occupation = "Designer" },
    //             new { Name = "Ramesh", Age = 30, Occupation = "Manager" }
    //         };
    //     return Json(jsonArray);
    // }

    public ViewResult Index()
    {
        return View();
    }

    public ActionResult Details(string Category)
    {
        var options = new JsonSerializerOptions()
        {
            // Property names will remain as defined in the class
            PropertyNamingPolicy = null,
            // JSON will be formatted with indents for readability
            WriteIndented = true,
        };

        try
        {
            //Based on the Category Fetch the Data from the database 
            //Here, we have hard coded the data
            List<Product> products = new List<Product>
                {
                    new Product{ Id = 1001, Name = "Laptop",  Description = "Dell Laptop" },
                    new Product{ Id = 1002, Name = "Desktop", Description = "HP Desktop" },
                    new Product{ Id = 1003, Name = "Mobile", Description = "Apple IPhone" }
                };
            //Please uncomment the following two lines if you want see what happend when exception occurred
            //int a = 10, b = 0;
            //int c = a / b;
            return Json(products, options);
        }
        catch (Exception ex)
        {
            var errorObject = new
            {
                Message = ex.Message,
                StackTrace = ex.StackTrace,
                ExceptionType = "Internal Server Error"
            };
            return new JsonResult(errorObject, options)
            {
                StatusCode = StatusCodes.Status500InternalServerError // Status code here 
            };
        }
    }
}
