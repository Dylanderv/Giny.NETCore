namespace Giny.Core.Logging;

public class LogFile
{

    private object _lock = new object();

    private string Path
    {
        get;
        set;
    }
    public LogFile(string path)
    {
        this.Path = path;

        if (!File.Exists(path))
        {
            File.Create(path);
        }
    }

    public void AppendError(string message)
    {
        lock (_lock)
        {
            File.AppendAllText(Path, message );
        }
    }
       
}