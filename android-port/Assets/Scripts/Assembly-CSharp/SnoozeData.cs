using System;

[Serializable]
public class SnoozeData
{
	public int Index;

	public DateTime LastShownTime;

	public SnoozeData(int index, DateTime lastShownTime)
	{
	}

	public override string ToString()
	{
		return null;
	}

	public static SnoozeData FromString(string str)
	{
		return null;
	}
}
