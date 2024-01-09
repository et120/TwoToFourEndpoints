namespace TwoToFourEndpoints.Services.Compare;

public class CompareService : ICompareService
{
    public string CompareNums(int numberOne, int numberTwo)
    {
        if(numberOne > numberTwo){
            return $"{numberOne} is greater than {numberTwo}. Also, {numberTwo} is less than {numberOne}.";
        } else if(numberOne < numberTwo){
            return $"{numberOne} is less than {numberTwo}. Also, {numberTwo} is greater than {numberOne}.";
        } else{
            return $"{numberOne} is equal to {numberTwo}. Also, {numberTwo} is equal to {numberOne}.";
        }
    }
}
