using Microsoft.Extensions.Logging;

public class BadPersistence
{
    private readonly DbPersistence dbPersistence;

    public BadPersistence(DbPersistence dbPersistence)
    {
        this.dbPersistence = dbPersistence;
    }
    
    void PersistValues(string content)
    {
        dbPersistence.WriteToDb(@"INSERT INTO table_name (column1, column2, column3, ...)");
    }
}

public class DbPersistence
{
    public void WriteToDb(string sqlStatemen)
    {
        throw new NotImplementedException();
    }
}

public class FilePersistence
{
    public void WriteToFile(string filename, string content)
    {
        throw new NotImplementedException();
    }
}