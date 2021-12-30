using Microsoft.AspNetCore.Mvc;

namespace api1.Controllers;

[ApiController]
[Route("[controller]")]
public class TestController : ControllerBase
{
    [HttpPost]
    public IActionResult Get([FromBody] IEnumerable<string> values)
    {
        return values is null ? BadRequest() : Ok(values);
    }
}
