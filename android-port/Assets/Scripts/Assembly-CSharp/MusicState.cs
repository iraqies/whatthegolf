using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000D32")]
public class MusicState : MonoBehaviour
{
	[Token(Token = "0x40047BF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x51924", Offset = "0x51924")]
	private Action<MusicState, bool, Action, bool> m_OnPlay;

	[Token(Token = "0x40047C0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public string id;

	[Token(Token = "0x40047C1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public string stateRefId;

	[Token(Token = "0x40047C2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public uint shortID;

	[Token(Token = "0x40047C3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public MusicPlaylist playlist;

	[Token(Token = "0x40047C4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public float lastStart;

	[Token(Token = "0x14000079")]
	public event Action<MusicState, bool, Action, bool> OnPlay
	{
		[Token(Token = "0x6003E4B")]
		[Address(RVA = "0x1589374", Offset = "0x1589374", VA = "0x1589374")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6C4D8", Offset = "0x6C4D8")]
		add
		{
		}
		[Token(Token = "0x6003E4C")]
		[Address(RVA = "0x1589418", Offset = "0x1589418", VA = "0x1589418")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6C4E8", Offset = "0x6C4E8")]
		remove
		{
		}
	}

	[Token(Token = "0x6003E4D")]
	[Address(RVA = "0x15894BC", Offset = "0x15894BC", VA = "0x15894BC")]
	public void UpdatePlaying()
	{
	}

	[Token(Token = "0x6003E4E")]
	[Address(RVA = "0x15894D4", Offset = "0x15894D4", VA = "0x15894D4")]
	public void Play(bool fromLoading, [Optional] Action onLoaded, bool ignoreTransition = false)
	{
	}

	[Token(Token = "0x6003E4F")]
	[Address(RVA = "0x1589570", Offset = "0x1589570", VA = "0x1589570")]
	public MusicState()
	{
	}
}
