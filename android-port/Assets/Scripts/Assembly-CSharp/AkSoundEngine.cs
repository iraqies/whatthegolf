using System;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000D24")]
public class AkSoundEngine : MonoBehaviour
{
	[Token(Token = "0x6003DFD")]
	[Address(RVA = "0x140CDBC", Offset = "0x140CDBC", VA = "0x140CDBC")]
	public static void PostTrigger(uint triggerID, GameObject gameObject)
	{
	}

	[Token(Token = "0x6003DFE")]
	[Address(RVA = "0x140CE24", Offset = "0x140CE24", VA = "0x140CE24")]
	public static void SetRTPCValue(uint id, float value, GameObject gameObject)
	{
	}

	[Token(Token = "0x6003DFF")]
	[Address(RVA = "0x140CE9C", Offset = "0x140CE9C", VA = "0x140CE9C")]
	public static void SetRTPCValue(uint id, float value, GameObject gameObject, int timeInMs)
	{
	}

	[Token(Token = "0x6003E00")]
	[Address(RVA = "0x140CF1C", Offset = "0x140CF1C", VA = "0x140CF1C")]
	public static void GetRTPCValue(uint rtcp, GameObject gameObject, uint playingId, out float rtpc, ref int type)
	{
	}

	[Token(Token = "0x6003E01")]
	[Address(RVA = "0x140CF90", Offset = "0x140CF90", VA = "0x140CF90")]
	public static void StopAll()
	{
	}

	[Token(Token = "0x6003E02")]
	[Address(RVA = "0x140CF94", Offset = "0x140CF94", VA = "0x140CF94")]
	public static uint PostEvent(uint pLAY_INGAMEMUSIC, GameObject gameObject)
	{
		return default;
	}

	[Token(Token = "0x6003E03")]
	[Address(RVA = "0x140CF9C", Offset = "0x140CF9C", VA = "0x140CF9C")]
	public static void SeekOnEvent(uint pLAY_INGAMEMUSIC, GameObject gameObject, float percent, bool v, uint playingId)
	{
	}

	[Token(Token = "0x6003E04")]
	[Address(RVA = "0x140CFA0", Offset = "0x140CFA0", VA = "0x140CFA0")]
	public static void SetState(uint group, uint wwiseState, bool fromLoading, Action onLoaded, bool ignoreTransition = false)
	{
	}

	[Token(Token = "0x6003E05")]
	[Address(RVA = "0x140D028", Offset = "0x140D028", VA = "0x140D028")]
	public static void ResetRTPCValue(uint rtpc, GameObject gameObject, int timeInMs)
	{
	}

	[Token(Token = "0x6003E06")]
	[Address(RVA = "0x140D098", Offset = "0x140D098", VA = "0x140D098")]
	public AkSoundEngine()
	{
	}
}
