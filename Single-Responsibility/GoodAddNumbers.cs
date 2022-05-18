using Microsoft.Extensions.Logging;

namespace Single_Responsibility;

/// <summary>
///  It is not the job of the class to handle all possible output formats, targets e.t.c.
/// </summary>
public class GoodAddNumbers
{
    private readonly ILogger logger;

    public GoodAddNumbers(ILogger logger)
    {
        this.logger = logger;
    }
    
    void AddNumbers(int a, int b)
    {
        var result = a + b;
        
        logger.LogInformation($"The result is: {result}");
    }
}