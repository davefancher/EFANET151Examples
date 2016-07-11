using System;

// Static classes cannot be instantiated
// All members must be static

// .NET Framework examples:
// - Console
// - Math

public static class Debug
{
	// Note difference between const and readonly
	private const string ErrorPrefix = "DEBUG";
	private const string WarningPrefix = "WARN";
	private const string InfoPrefix = "INFO";
	
	private static void WriteLogMessage(string prefix, string message)
	{
		Console.WriteLine("[{0} - {1:O}] {2}", prefix, DateTime.UtcNow, message);
	}
	
	public static void LogError(string message)
	{
		WriteLogMessage(ErrorPrefix, message);
	}
	
	public static void LogWarning(string message)
	{
		WriteLogMessage(WarningPrefix, message);
	}
	
	public static void LogInfo(string message)
	{
		WriteLogMessage(InfoPrefix, message);
	}
}

Debug.LogInfo("Information message");
Debug.LogWarning("Something might be wrong");
Debug.LogError("Something is definitely wrong");
