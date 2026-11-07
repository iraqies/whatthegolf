using UnityEngine;

public class GyroHelper
{
	private static bool isRemote;

	public static void InitGyro()
	{
		if (SystemInfo.supportsGyroscope)
		{
			Input.gyro.enabled = true;
			Input.gyro.updateInterval = 1f / 60f;
		}
	}

	[RuntimeInitializeOnLoadMethod]
	private static void Init()
	{
		InitGyro();
	}

	public static void UpdateEditorRemoteGyroState() { }

	public static void SetGyroFPS(float fps)
	{
		if (SystemInfo.supportsGyroscope && fps > 0f)
			Input.gyro.updateInterval = 1f / fps;
	}
}
