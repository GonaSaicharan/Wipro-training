public class Logger
{
    private static Logger instance;
    private static readonly object lockObj = new object();

    private Logger() { }

    public static Logger Instance
    {
        get
        {
            lock (lockObj)
            {
                if (instance == null)
                    instance = new Logger();
                return instance;
            }
        }
    }

    public void Log(string message)
    {
        System.IO.File.AppendAllText("log.txt", message + "\n");
    }
}
