namespace InterfaceSegregation;

// separate read and write interfaces because not all users of the interfaces need all functionality
public class BetterCrud : IReadCrud, IWriteCrud
{
    public void Create(int i)
    {
        throw new NotImplementedException();
    }

    public int Read()
    {
        throw new NotImplementedException();
    }

    public void Update(int i)
    {
        throw new NotImplementedException();
    }

    public void Delete()
    {
        throw new NotImplementedException();
    }
}

public interface IReadCrud
{
    int Read();
}

public interface IWriteCrud
{
    void Create(int i);
    void Update(int i);
    void Delete();
}