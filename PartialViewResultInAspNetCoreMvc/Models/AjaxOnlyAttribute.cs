using Microsoft.AspNetCore.Mvc.Abstractions;
using Microsoft.AspNetCore.Mvc.ActionConstraints;
using Microsoft.Extensions.Primitives;

namespace PartialViewResultInAspNetCoreMvc.Models
{
    // Define a custom attribute that inherits from ActionMethodSelectorAttribute
    public class AjaxOnlyAttribute : ActionMethodSelectorAttribute
    {
        // Override the IsValidForRequest method to provide custom logic for request validation
        // routeContext: Provides information about the current routing context.
        // actionDescriptor: Provides information about the action method.
        public override bool IsValidForRequest(RouteContext routeContext, ActionDescriptor actionDescriptor)
        {
            // Check if the request headers are not null and contain the "X-Requested-With" header
            if (routeContext.HttpContext.Request.Headers != null &&
                routeContext.HttpContext.Request.Headers.ContainsKey("X-Requested-With") &&
                routeContext.HttpContext.Request.Headers.TryGetValue("X-Requested-With", out StringValues requestedWithHeader))
            {
                // Check if the "X-Requested-With" header contains the value "XMLHttpRequest" indicating an AJAX request
                if (requestedWithHeader.Contains("XMLHttpRequest"))
                {
                    // If the condition is met, return true to indicate the request is valid for AJAX
                    return true;
                }
            }

            // If the conditions are not met, return false to indicate the request is not valid for AJAX
            return false;
        }
    }
}