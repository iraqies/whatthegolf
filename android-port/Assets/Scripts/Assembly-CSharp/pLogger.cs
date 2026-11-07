using System;
using UnityEngine;

public class pLogger
{
	public bool logEnabled;

	private ILogHandler logHandler;

	public pLogger(ILogHandler logHandler)
	{
	}

	public void Log(string tag, Func<string> messageFunc)
	{
	}

	public void LogWarning(string tag, Func<string> messageFunc)
	{
	}

	private void Log(LogType logType, string tag, Func<string> messageFunc)
	{
	}
}
