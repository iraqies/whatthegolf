using UnityEngine;

public class AkSoundEngine
{
	public static void PostEvent(string eventName, GameObject gameObject)
	{
		WwisePlayer.Instance?.PostEvent(eventName);
	}

	public static void PostEvent(uint eventID, GameObject gameObject)
	{
		WwisePlayer.Instance?.PostEvent(eventID);
	}

	public static void PostTrigger(string triggerName, GameObject gameObject)
	{
		WwisePlayer.Instance?.PostTrigger(triggerName);
	}

	public static void PostTrigger(uint triggerID, GameObject gameObject)
	{
		WwisePlayer.Instance?.PostTrigger(triggerID);
	}

	public static void SetRTPCValue(string rtpcName, float value)
	{
		WwisePlayer.Instance?.SetRTPC(rtpcName, value);
	}

	public static void SetRTPCValue(uint rtpcID, float value)
	{
		WwisePlayer.Instance?.SetRTPC(rtpcID, value);
	}

	public static void SetState(string stateGroup, string state)
	{
		WwisePlayer.Instance?.SetState(stateGroup, state);
	}

	public static void SetState(uint stateGroup, uint state)
	{
		WwisePlayer.Instance?.SetState(stateGroup, state);
	}

	public static void ResetRTPCValue(string rtpcName, GameObject gameObject, int value, float time, int curve)
	{
		WwisePlayer.Instance?.ResetRTPC(rtpcName, time);
	}

	public static void ResetRTPCValue(uint rtpcID)
	{
		WwisePlayer.Instance?.ResetRTPC(rtpcID, 0f);
	}

	public static void ResetRTPCValue(uint rtpcID, int value)
	{
		WwisePlayer.Instance?.ResetRTPC(rtpcID, 0f);
	}

	public static void ResetRTPCValue(uint rtpcID, GameObject gameObject, int value, float time, int curve)
	{
		WwisePlayer.Instance?.ResetRTPC(rtpcID, time);
	}

	public static uint GetIDFromString(string str)
	{
		if (string.IsNullOrEmpty(str)) return 0u;
		uint hash = 2166136261u;
		string lower = str.ToLowerInvariant();
		for (int i = 0; i < lower.Length; i++)
		{
			hash *= 16777619u;
			hash ^= lower[i];
		}
		return hash;
	}
}
