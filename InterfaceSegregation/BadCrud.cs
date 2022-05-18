namespace InterfaceSegregation;

public class BadCrud : IBadCrud
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

public interface IBadCrud
{
    void Create(int i);
    int Read();
    void Update(int i);
    void Delete();
}