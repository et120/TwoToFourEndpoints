namespace TwoToFourEndpoints.Services.Sum;

public class SumService : ISumService
{
    public string GetSum(int numOne, int numTwo)
    {
        return $"The sum of {numOne} and {numTwo} is {numOne + numTwo}.";
    }
}
