using System;
using System.Collections.Generic;

delegate void LogMessage(string message);

public class Test
{
    static void LogToConsole(string message) => Console.WriteLine("Console: " + message);
    static void LogToFile(string message) => Console.WriteLine("File: " + message);
    static void LogToDebug(string message) => Console.WriteLine("Debug: " + message);
    
    public static void Main()
	{
	    LogMessage logger = LogToConsole;
	    logger += LogToFile;
	    logger += LogToDebug;
	    
	    logger("System started successfully");
	}
}
