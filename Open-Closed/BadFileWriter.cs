namespace Open_Closed;

public class BadFileWriter
{
    void Write(string content)
    {
        File.WriteAllText(Path.GetTempPath()+"myfile.txt", content);
    }
}