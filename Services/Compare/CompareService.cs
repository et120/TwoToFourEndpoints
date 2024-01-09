namespace TwoToFourEndpoints.Services.Compare;

public class CompareService : ICompareService
{
    public string CompareNums(string numberOne, string numberTwo)
    {   
        int numberOneInt;
        int numberTwoInt;
        bool isOneTrue = int.TryParse(numberOne, out numberOneInt);
        bool isTwoTrue = int.TryParse(numberTwo, out numberTwoInt);

        if(isOneTrue && isTwoTrue){
            if(numberOneInt > numberTwoInt){
            return $"{numberOneInt} is greater than {numberTwoInt}. Also, {numberTwoInt} is less than {numberOneInt}.";
        } else if(numberOneInt < numberTwoInt){
            return $"{numberOneInt} is less than {numberTwoInt}. Also, {numberTwoInt} is greater than {numberOneInt}.";
        } else{
            return $"{numberOneInt} is equal to {numberTwoInt}. Also, {numberTwoInt} is equal to {numberOneInt}.";
        }
        }else{
            return "Please try again. You need to enter in an integer number in both fields.";
        }
        
    }
}
