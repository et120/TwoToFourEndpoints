using Microsoft.AspNetCore.Mvc;
using TwoToFourEndpoints.Services.Question;

namespace TwoToFourEndpoints.Controllers;

[ApiController]
[Route("[controller]")]
public class QuestionController : ControllerBase
{   
    private readonly IQuestionService _questionService;
    public QuestionController(IQuestionService questionService)
    {
        _questionService = questionService;
    }

    [HttpGet]
    [Route("GetAnswers/Whatisyourfirst{name}/What{time}didyouwakeuptoday")]
    public string GetAnswers(string name, string time)
    {
        return _questionService.GetAnswers(name, time);
    }
}
