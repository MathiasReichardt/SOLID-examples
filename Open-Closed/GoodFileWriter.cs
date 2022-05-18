namespace Open_Closed;

/// <summary>
/// Changing the filename would need the the class to change so better pass it
/// </summary>
public class GoodFileWriter
{
    private readonly string targetFile;

    public GoodFileWriter(string targetFile)
    {
        this.targetFile = targetFile;
    }
    
    void Write(string content)
    {
        File.WriteAllText(targetFile, content);
    }
}