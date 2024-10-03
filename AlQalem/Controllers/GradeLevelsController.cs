using AlQalem.ServiceInterfaces;
using Microsoft.AspNetCore.Mvc;

[Route("api/[controller]")]
[ApiController]
public class GradeLevelsController : ControllerBase
{
    private readonly InterfaceGradeLevelService _gradeLevelService;

    public GradeLevelsController(InterfaceGradeLevelService gradeLevelService)
    {
        _gradeLevelService = gradeLevelService;
    }

    [HttpGet("/api/gradelevel")]
    public async Task<ActionResult<Object>> GetGradeLevelsListAsync()
    {
        var gradeLevels = await _gradeLevelService.GetGradeLevelsListAsync();
        return Ok(gradeLevels);
    }
}
