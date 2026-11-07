using System;

public class SaveSystemsManager
{
	public static void SaveData(string path, byte[] data, Action done)
	{
	}

	public static byte[] LoadData(string path, bool streaming = false, Action<byte[]> done = null)
	{
		return null;
	}

	public static void DeleteData(string path, Action done)
	{
	}

	public static string GetPlatformSpecificPath()
	{
		return null;
	}
}
