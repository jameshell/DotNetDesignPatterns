namespace Singleton;
/// <summary>
/// Singleton
/// </summary>

public class Logger
{
    /// <summary>
    /// Making the implementation threadsafe using the Lazy class.
    /// </summary>
    private static readonly Lazy<Logger> _lazyLogger =
        new Lazy<Logger>(()=> new Logger());
    
    // private static Logger? _instance;

    /// <summary>
    ///  Instance: It is ensured that only one instance is created.
    /// </summary>
    public static Logger Instance
    {
        get
        {
            return _lazyLogger.Value;
            // if (_instance == null)
            // {
            //     _instance = new Logger();
            // }
            //
            // return _instance;
        }
    }
    protected Logger()
    {
    }

    public void Log(string message)
    {
        Console.WriteLine($"Message to log: {message}");
    }
}