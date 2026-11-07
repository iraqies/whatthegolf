using System;
using System.Collections.Generic;
using Core;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20003B1")]
public abstract class OverworldMusicChanger : MonoBehaviour
{
	[Token(Token = "0x4001458")]
	[FieldOffset(Offset = "0x18")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4D0B0", Offset = "0x4D0B0")]
	private Action<OverworldMusicData, List<OverworldGoal>> m_OnMusicTriggered;

	[Token(Token = "0x14000014")]
	public event Action<OverworldMusicData, List<OverworldGoal>> OnMusicTriggered
	{
		[Token(Token = "0x6001186")]
		[Address(RVA = "0x15C5C58", Offset = "0x15C5C58", VA = "0x15C5C58")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x619AC", Offset = "0x619AC")]
		add
		{
		}
		[Token(Token = "0x6001187")]
		[Address(RVA = "0x15C641C", Offset = "0x15C641C", VA = "0x15C641C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x619BC", Offset = "0x619BC")]
		remove
		{
		}
	}

	[Token(Token = "0x6001188")]
	[Address(RVA = "0x15C64C0", Offset = "0x15C64C0", VA = "0x15C64C0", Slot = "4")]
	public virtual void Init()
	{
	}

	[Token(Token = "0x6001189")]
	[Address(RVA = "0x15C64C4", Offset = "0x15C64C4", VA = "0x15C64C4")]
	public void TriggerMusic(OverworldMusicData data, List<OverworldGoal> goals)
	{
	}

	[Token(Token = "0x600118A")]
	[Address(RVA = "0x15C653C", Offset = "0x15C653C", VA = "0x15C653C")]
	protected OverworldMusicChanger()
	{
	}
}
