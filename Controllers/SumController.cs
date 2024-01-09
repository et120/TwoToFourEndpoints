using Microsoft.AspNetCore.Mvc;
using TwoToFourEndpoints.Services.Sum;

namespace TwoToFourEndpoints.Controllers;

[ApiController]
[Route("[controller]")]
public class SumController : ControllerBase
{
    private readonly ISumService _sumService;
    public SumController(ISumService sumService)
    {
        _sumService = sumService;
    }

    [HttpGet]
    [Route("GetSum/Entera{numOne}/Entera{numTwo}")]
    public string GetSum(int numOne, int numTwo)
    {
        return _sumService.GetSum(numOne, numTwo);
    }
}
