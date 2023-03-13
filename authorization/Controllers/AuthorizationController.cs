using Microsoft.AspNetCore.Mvc;

namespace authorization.Controllers;
[ApiController]
[Route("[controller]")]
public class AuthorizationController:ControllerBase
{
    [HttpGet("login")]
    public ActionResult Auth()
    {
        
        return Ok();
    }

}