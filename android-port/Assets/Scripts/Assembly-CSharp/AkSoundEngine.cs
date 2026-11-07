using System;
using UnityEngine;

public class AkSoundEngine : MonoBehaviour
{
	public static void PostTrigger(uint triggerID, GameObject gameObject)
	{
	}

	public static void SetRTPCValue(uint id, float value, GameObject gameObject)
	{
	}

	public static void SetRTPCValue(uint id, float value, GameObject gameObject, int timeInMs)
	{
	}

	public static void GetRTPCValue(uint rtcp, GameObject gameObject, uint playingId, out float rtpc, ref int type)
	{
		rtpc = default;
	}

	public static void StopAll()
	{
	}

	public static uint PostEvent(uint pLAY_INGAMEMUSIC, GameObject gameObject)
	{
		return 0u;
	}

	public static void SeekOnEvent(uint pLAY_INGAMEMUSIC, GameObject gameObject, float percent, bool v, uint playingId)
	{
	}

	public static void SetState(uint group, uint wwiseState, bool fromLoading, Action onLoaded, bool ignoreTransition = false)
	{
	}

	public static void ResetRTPCValue(uint rtpc, GameObject gameObject, int timeInMs)
	{
	}
}
