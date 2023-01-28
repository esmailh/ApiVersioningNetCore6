using Microsoft.AspNetCore.Mvc;

namespace ApiVersioningNetCore6.Controllers;

//Route For Query String parameter versioning
//[Route("api/user/[action]")]
//Route for URI versioning
[Route(("api/v{version:apiVersion}/user/[action]"))]
//[Route("api/user")]
[ApiController]
public class UserV1Controller : ControllerBase
{
    [HttpGet(Name = "Get")]
    public IActionResult Get()
    {
        return Ok("asd");
    }
}