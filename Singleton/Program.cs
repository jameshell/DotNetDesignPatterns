using System.Diagnostics;
using Singleton;

Console.Title = "Singleton Pattern";

var instance1 = Logger.Instance;
var instance2 = Logger.Instance;

// Comparing instances to know if they are the same.
if (instance1 == instance2 && instance2 == Logger.Instance)
{
    Console.WriteLine("Instances are the same");
}

// Logging few messages for examples
instance1.Log($"Message from {nameof(instance1)}");
instance1.Log($"Message from {nameof(instance2)}");
Logger.Instance.Log($"Message from {nameof(Logger.Instance)}");