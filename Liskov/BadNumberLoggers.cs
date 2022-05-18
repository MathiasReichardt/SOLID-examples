using Microsoft.Extensions.Logging;

namespace Liskov;

public class NumberLogger
{
    private readonly ILogger logger;

    public NumberLogger(ILogger logger)
    {
        this.logger = logger;
    }
    
    public virtual void PrintNumberToLog (int number) {
        this.logger.LogInformation("Number: {number}", number);
    }
}

public class BadDbNumberLogger : NumberLogger
{
    private readonly ILogger logger;

    public BadDbNumberLogger(ILogger logger): base(logger)
    {
        this.logger = logger;
    }
    
    public override void PrintNumberToLog (int number) {
        // store to DB
    }
}

public class LittleBetterDbNumberLogger : NumberLogger
{
    private readonly ILogger logger;

    public LittleBetterDbNumberLogger(ILogger logger): base(logger)
    {
        this.logger = logger;
    }
    
    public void PrintNumberToDb (int number) {
        // store to DB
    }
}