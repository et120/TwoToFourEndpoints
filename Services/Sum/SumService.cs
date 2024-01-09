namespace TwoToFourEndpoints.Services.Sum;

public class SumService : ISumService
{
    public string GetSum(string numOne, string numTwo)
    {
        int numOneInt;
        bool isOneTrue = int.TryParse(numOne, out numOneInt);

        int numTwoInt;
        bool isTwoTrue = int.TryParse(numTwo, out numTwoInt);

        if(isOneTrue && isTwoTrue){
            return $"The sum of {numOneInt} and {numTwoInt} is {numOneInt + numTwoInt}.";
        }else{
            return "Please try again. You need to enter in an integer number in both fields.";
        }
    }
}
