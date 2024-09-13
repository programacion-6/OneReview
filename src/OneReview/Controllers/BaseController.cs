namespace OneReview.Controllers;

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;

public abstract class BaseController : ControllerBase
{
    protected IActionResult HandleNotFound(string message)
    {
        return NotFound(new { Error = message });
    }

    protected IActionResult HandleError(string message, int statusCode = StatusCodes.Status500InternalServerError)
    {
        return StatusCode(statusCode, new { Error = message });
    }

    protected IActionResult ValidateRequest(object request)
    {
        if (request is null)
            return BadRequest("Invalid request");
        return null;
    }
}
