using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000D51")]
public class WwiseRTPC : MonoBehaviour
{
	[Token(Token = "0x400487A")]
	[FieldOffset(Offset = "0x18")]
	public TextAsset wwiseRTPCfile;

	[Token(Token = "0x400487B")]
	[FieldOffset(Offset = "0x20")]
	public List<RTPC> rtpcs;

	[Token(Token = "0x6003EBC")]
	[Address(RVA = "0x17610F8", Offset = "0x17610F8", VA = "0x17610F8")]
	public WwiseRTPC()
	{
	}
}
