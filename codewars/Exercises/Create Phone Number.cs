namespace codewars.Exercises;
// (123) 456-7890
// "(" + xxx + ") " + xxx + "-" + xxxx 

public class Create_Phone_Number
{
    public static string CreatePhoneNumber(int[] numbers)
    {
        string number = $"({numbers[0]}{numbers[1]}{numbers[2]}) {numbers[3]}{numbers[4]}{numbers[5]}-{numbers[6]}{numbers[7]}{numbers[8]}{numbers[9]}";
        return number;
    }
}