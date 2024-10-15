using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ContentResultInAspNetCoreMvc.Models;

namespace ContentResultInAspNetCoreMvc.Controllers;

public class HomeController : Controller
{
    // Define an action method named Index that returns a ContentResult
    public ContentResult Index()
    {
        // // Declare a string variable to hold the plain text content
        // string plainText = "This is plain text content.";
        // // Create and return a new ContentResult object
        // return new ContentResult
        // {
        //     // Set the ContentType property to "text/plain" to indicate the MIME type of the content
        //     ContentType = "text/plain",
        //     // Set the Content property to the plainText string, which contains the content to be returned
        //     Content = plainText
        // };


        // Declare a string variable to hold the plain text content
        string plainText = "This is plain text content.";
        // Return a ContentResult using the Content method of the base Controller class
        // The Content method is a helper method that creates a ContentResult with the specified content and content type
        return Content(plainText, "text/plain");
    }
}
