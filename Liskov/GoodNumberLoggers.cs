using Microsoft.Extensions.Logging;

namespace Liskov;

// Better use of abstract class: can not use it wrong (in overloading)
// also better for open / close principle
public abstract class GoodNumberLogger
{
    protected Action<string> LogAction = s => { };
    public void LogNumber (int number) {
        LogAction($"Number: {number}" );
    }
}

public class LogWriter : GoodNumberLogger
{
    public LogWriter(ILogger logger)
    {
        LogAction = message => logger.LogInformation(message);
    }
} 

// usage
public class Usage
{
    private readonly ILogger logger;

    protected Usage(ILogger logger)
    {
        this.logger = logger;
    }
    
    void LogNumber()
    {
        var writer = new LogWriter(logger);
        writer.LogNumber(1);
    }
} 