using System;
using System.Collections;

public static class SaveSystem
{
	public static readonly byte[] EmptyData;

	private static byte[] loadData;

	private static void InternalSave(string path, byte[] data, Action done)
	{
	}

	private static void InternalDelete(string path, Action done)
	{
	}

	private static void InternalLoad(string path, bool streaming, Action<byte[]> done)
	{
	}

	public static void Save(string filePath, byte[] data, Action done)
	{
	}

	public static void Delete(string filePath, Action done)
	{
	}

	public static byte[] Load(string filePath, bool streaming = false, Action<byte[]> done = null)
	{
		return null;
	}

	private static IEnumerator InternalLoadCR(string path, Action<byte[]> done)
	{
		return null;
	}

	private static void DoInternalLoad(string path, Action<byte[]> done)
	{
	}
}
