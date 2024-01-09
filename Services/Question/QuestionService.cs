namespace TwoToFourEndpoints.Services.Question;

public class QuestionService : IQuestionService
{
    public string GetAnswers(string name, string time)
    {
        return $"{name} woke up today at {time}.";
    }
}
