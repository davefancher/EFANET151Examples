# BRONZE

Define an interface to represent a logging mechanism. Interface should provide methods that allow logging messages at various levels of severity (e.g.: Info, Warning, Error). Each method should indicate the corresponding severity level.

<!--
public interface ILogger
{
	void WriteInfo(string message);
	void WriteWarning(string message);
	void WriteError(string message);
}
-->

# SILVER

1. Define a class that implements the interface
2. Create an instance of the class
3. Execute the various interface methods

<!--
// Explicit Implementation

public class Logger
	: ILogger
{
	private void WriteMessage(string level, string message)
	{
		Console.WriteLine("[{0}] {1}", level, message);
	}
	
	void ILogger.WriteInfo(string message)
	{
		WriteMessage("INFO", message);
	}
	
	void ILogger.WriteWarning(string message)
	{
		WriteMessage("WARNING", message);
	}
	
	void ILogger.WriteError(string message)
	{
		WriteMessage("ERROR", message);
	}
}

ILogger logger = new ConsoleLogger();

logger.WriteInfo("Some logged text");
logger.WriteWarning("Some logged text");
logger.WriteError("Some logged text");

-->

# GOLD

1. Define a class that accepts the interface as a constructor parameter
2. Define some methods on the class and have them use the interface methods

<!--
public class Greeter
{
	private readonly ILogger _logger;
	
	public Greeter(ILogger logger)
	{
		_logger = logger;
	}
	
	public void SayHello(string name)
	{
		_logger.WriteInfo("Saying hello to " + name);
		
		Console.WriteLine("Hello, {0}", name);
	}
}

var g = new Greeter(logger);
g.SayHello("Dave");
-->
