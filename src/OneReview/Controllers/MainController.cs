using Microsoft.AspNetCore.Mvc;

namespace OneReview.Controllers;

public class MainController : ControllerBase
{
    public IActionResult CreatedResponse<T>(string actionName, Guid id, T response)
    {
        return CreatedAtAction(
            actionName: actionName,
            routeValues: new { id },
            value: response
        );
    }

    public IActionResult NotFoundProblem(Guid id, string entityName = "Entity")
    {
        return Problem(
            statusCode: StatusCodes.Status404NotFound,
            detail: $"{entityName} not found (ID: {id})"
        );
    }
}
