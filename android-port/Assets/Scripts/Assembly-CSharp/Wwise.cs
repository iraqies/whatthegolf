using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using WwiseData;

[Token(Token = "0x2000D3B")]
public class Wwise : MonoBehaviour
{
	[Token(Token = "0x2000D3C")]
	public enum exitType
	{
		[Token(Token = "0x4004814")]
		Immediate = 0,
		[Token(Token = "0x4004815")]
		NextBar = 1,
		[Token(Token = "0x4004816")]
		NextBeat = 2,
		[Token(Token = "0x4004817")]
		ExitCue = 3
	}

	[Token(Token = "0x400480A")]
	[FieldOffset(Offset = "0x18")]
	public TextAsset wwiseProjectFile;

	[NonSerialized]
	[Token(Token = "0x400480B")]
	[FieldOffset(Offset = "0x20")]
	public WwiseDocument document;

	[Token(Token = "0x400480C")]
	[FieldOffset(Offset = "0x0")]
	public static bool verbose;

	[Token(Token = "0x400480D")]
	[FieldOffset(Offset = "0x28")]
	public List<MusicState> musicStates;

	[Token(Token = "0x400480E")]
	[FieldOffset(Offset = "0x30")]
	public List<MusicTransition> musicTransitions;

	[Token(Token = "0x400480F")]
	[FieldOffset(Offset = "0x38")]
	public WwiseRTPC rtpc;

	[Token(Token = "0x4004810")]
	[FieldOffset(Offset = "0x40")]
	public WwiseAudioSources sourcesMusic;

	[Token(Token = "0x4004811")]
	[FieldOffset(Offset = "0x48")]
	public WwiseAudioSources sourcesTransition;

	[Token(Token = "0x4004812")]
	[FieldOffset(Offset = "0x50")]
	public WwiseAudioSources sourcesTrigger;

	[Token(Token = "0x6003E6F")]
	[Address(RVA = "0x175C8E8", Offset = "0x175C8E8", VA = "0x175C8E8")]
	[AttributeAttribute(Name = "RuntimeInitializeOnLoadMethodAttribute", RVA = "0x6C508", Offset = "0x6C508")]
	private static void Init()
	{
	}

	[Token(Token = "0x6003E70")]
	[Address(RVA = "0x175C950", Offset = "0x175C950", VA = "0x175C950")]
	public static void Log(object message)
	{
	}

	[Token(Token = "0x6003E71")]
	[Address(RVA = "0x175C9B0", Offset = "0x175C9B0", VA = "0x175C9B0")]
	public Wwise()
	{
	}
}
