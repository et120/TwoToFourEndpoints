using Microsoft.AspNetCore.Mvc;
using TwoToFourEndpoints.Services.Compare;

namespace TwoToFourEndpoints.Controllers;

[ApiController]
[Route("[controller]")]
public class CompareController : ControllerBase
{
    private readonly ICompareService _compareService;
    public CompareController(ICompareService compareService)
    {
        _compareService = compareService;
    }

    [HttpGet]
    [Route("CompareNums/Enterawhole{numberOne}/Enterawhole{numberTwo}")]
    public string CompareNums(int numberOne, int numberTwo)
    {
        return _compareService.CompareNums(numberOne, numberTwo);
    }
}
