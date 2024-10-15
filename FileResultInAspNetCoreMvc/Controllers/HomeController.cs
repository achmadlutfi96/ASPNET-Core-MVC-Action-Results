using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using FileResultInAspNetCoreMvc.Models;

using Microsoft.Net.Http.Headers;

namespace FileResultInAspNetCoreMvc.Controllers;

public class HomeController : Controller
{
    public ActionResult Index()
    {
        return View();
    }

    // Define an action method that returns a FileResult
    // public FileResult DownloadFile()
    // {
    //     // Get the current directory of the application and construct the file path for the PDF file
    //     string filePath = Directory.GetCurrentDirectory() + "\\wwwroot\\PDFFiles\\" + "Sample.pdf";
    //     // Read all the bytes of the PDF file into a byte array
    //     var fileBytes = System.IO.File.ReadAllBytes(filePath);
    //     // Create a FileResult object using the byte array and specify the content type as "application/pdf"
    //     var fileResult = File(fileBytes, "application/pdf");
    //     // Set the name of the file to be downloaded by the user
    //     fileResult.FileDownloadName = "MySampleFile.pdf";
    //     // Set the last modified date of the file
    //     fileResult.LastModified = new DateTimeOffset(System.IO.File.GetLastWriteTimeUtc(filePath));
    //     // Set the entity tag (ETag) for the file
    //     fileResult.EntityTag = new EntityTagHeaderValue("\"fileVersion1\"");
    //     // Enable range processing for the file
    //     fileResult.EnableRangeProcessing = true;
    //     // Return the FileResult object
    //     return fileResult;
    // }


    // Define an action method that returns a FileStreamResult
    // You can alsu use FileResult as the return type
    // public FileStreamResult DownloadFile()
    // {
    //     // Get the current directory of the application and construct the file path for the PDF file
    //     string filePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "PDFFiles", "Sample.pdf");
    //     // Create a FileStream to the PDF file
    //     var fileStream = new FileStream(filePath, FileMode.Open, FileAccess.Read);
    //     // Create a FileStreamResult object using the file stream and specify the content type as "application/pdf"
    //     var fileResult = new FileStreamResult(fileStream, "application/pdf")
    //     {
    //         // Set the name of the file to be downloaded by the user
    //         FileDownloadName = "MySampleFile.pdf",
    //         // Set the last modified date of the file
    //         LastModified = new DateTimeOffset(System.IO.File.GetLastWriteTimeUtc(filePath)),
    //         // Set the entity tag (ETag) for the file
    //         EntityTag = new EntityTagHeaderValue("\"fileVersion1\""),
    //         // Enable range processing for the file
    //         EnableRangeProcessing = true
    //     };
    //     // Return the FileStreamResult object
    //     return fileResult;
    // }

    // FOR WEB APPLICATION
    // Define an action method that returns a VirtualFileResult
    public VirtualFileResult DownloadFile()
    {
        // Define the virtual path for the PDF file
        string virtualFilePath = "/PDFFiles/Sample.pdf";
        // Create a VirtualFileResult object using the virtual path and specify the content type as "application/pdf"
        var fileResult = new VirtualFileResult(virtualFilePath, "application/pdf")
        {
            // Set the name of the file to be downloaded by the user
            FileDownloadName = "MySampleFile.pdf",
            // Optionally, set the last modified date of the file
            // LastModified = new DateTimeOffset(System.IO.File.GetLastWriteTimeUtc(filePath)),
            // Optionally, set the entity tag (ETag) for the file
            // EntityTag = new EntityTagHeaderValue("\"fileVersion1\""),
            // Enable range processing for the file
            // EnableRangeProcessing = true
        };
        // Return the VirtualFileResult object
        return fileResult;
    }

    // Define an action method that returns a PhysicalFileResult
    // public PhysicalFileResult DownloadFile()
    // {
    //     // Get the current directory of the application and construct the file path for the PDF file
    //     string filePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "PDFFiles", "Sample.pdf");
    //     // Create a PhysicalFileResult object using the file path and specify the content type as "application/pdf"
    //     var fileResult = new PhysicalFileResult(filePath, "application/pdf")
    //     {
    //         // Set the name of the file to be downloaded by the user
    //         FileDownloadName = "MySampleFile.pdf",
    //     };
    //     // Return the PhysicalFileResult object
    //     return fileResult;
    // }
}
