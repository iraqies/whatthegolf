using System.Collections.Generic;
using UnityEngine;

public class CommandLineArguments : MonoBehaviour
{
	private static CommandLineArguments _instance;

	private Dictionary<string, string> arguments;

	public static CommandLineArguments Instance => null;

	private string[] GetCommandLineArgs()
	{
		return null;
	}

	private void ParseCommandlineArgs()
	{
	}

	public string GetValue(string key, string ifNotFound)
	{
		return null;
	}
}
