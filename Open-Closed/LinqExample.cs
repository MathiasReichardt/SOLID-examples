namespace Open_Closed;

/// <summary>
///  High extendability because of clever design and generics
/// </summary>
public class LinqExample
{
    void AccessNumbers()
    {
        List<int> numbers = new() { 1, 2, 3, 4, 5, 6 };
        
        var result = numbers
            .Where(n => n > 2)
            .Where(n => n < 6)
            .OrderBy(n => n);
    }
    
    void AccessStrings()
    {
        List<string> strings = new() { "A", "AA", "AB", "AAB", "ABC" };
        
        var result = strings
            .Where(s => s.Length > 2)
            .Where(s => s.Length < 6)
            .OrderBy(n => n);
    }
}