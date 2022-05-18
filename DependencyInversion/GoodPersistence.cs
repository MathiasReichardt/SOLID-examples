using Microsoft.Extensions.Logging;

// depend on a general interface
public class GoodPersistence
{
    private readonly IPersistence persistence;

    public GoodPersistence(IPersistence persistence)
    {
        this.persistence = persistence;
    }
    
    void PersistValues(string content)
    {
        persistence.Persist(content);
    }
}

public  interface IPersistence
{
    void Persist(string content);
}

public class GoodDbPersistence : IPersistence
{
    private const string SqlStatement = @"INSERT INTO table_name (column1, column2, column3, ...)";
    public void Persist(string content)
    {
        throw new NotImplementedException();
    }
}

public class GoodFilePersistence: IPersistence
{
    public void Persist(string content)
    {
        throw new NotImplementedException();
    }
}