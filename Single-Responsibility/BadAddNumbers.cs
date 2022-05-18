namespace Single_Responsibility;

public class BadAddNumbers
{
    void AddNumbers(int a, int b)
    {
        var result = a + b;
        
        Console.WriteLine($"The result is: {result}");
    }
}