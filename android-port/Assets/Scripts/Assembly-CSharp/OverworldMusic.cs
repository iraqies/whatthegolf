using System;
using System.Collections.Generic;
using Core;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20003AF")]
public class OverworldMusic : MonoBehaviour
{
	[Serializable]
	[Token(Token = "0x20003B0")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3F794", Offset = "0x3F794")]
	private sealed class _003C_003Ec
	{
		[Token(Token = "0x4001455")]
		[FieldOffset(Offset = "0x0")]
		public static readonly _003C_003Ec _003C_003E9;

		[Token(Token = "0x4001456")]
		[FieldOffset(Offset = "0x8")]
		public static Func<OverworldGoal, bool> _003C_003E9__6_0;

		[Token(Token = "0x4001457")]
		[FieldOffset(Offset = "0x10")]
		public static Func<OverworldGoal, bool> _003C_003E9__7_0;

		[Token(Token = "0x6001183")]
		[Address(RVA = "0x181B890", Offset = "0x181B890", VA = "0x181B890")]
		public _003C_003Ec()
		{
		}

		[Token(Token = "0x6001184")]
		[Address(RVA = "0x181B898", Offset = "0x181B898", VA = "0x181B898")]
		internal bool _003CZone_OnMusicTriggered_003Eb__6_0(OverworldGoal f)
		{
			return default;
		}

		[Token(Token = "0x6001185")]
		[Address(RVA = "0x181B93C", Offset = "0x181B93C", VA = "0x181B93C")]
		internal bool _003CGetCurrentValue_003Eb__7_0(OverworldGoal f)
		{
			return default;
		}
	}

	[Token(Token = "0x4001450")]
	[FieldOffset(Offset = "0x18")]
	public OverworldMusicData current;

	[Token(Token = "0x4001451")]
	[FieldOffset(Offset = "0x20")]
	private AudioManager audioManager;

	[Token(Token = "0x4001452")]
	[FieldOffset(Offset = "0x28")]
	private List<OverworldGoal> currentFlags;

	[Token(Token = "0x4001453")]
	[FieldOffset(Offset = "0x30")]
	private bool isUsingTransition;

	[Token(Token = "0x4001454")]
	[FieldOffset(Offset = "0x34")]
	private float flagCount;

	[Token(Token = "0x6001178")]
	[Address(RVA = "0x15C5A18", Offset = "0x15C5A18", VA = "0x15C5A18")]
	public void Init()
	{
	}

	[Token(Token = "0x6001179")]
	[Address(RVA = "0x15C5CFC", Offset = "0x15C5CFC", VA = "0x15C5CFC")]
	private void Zone_OnMusicTriggered(OverworldMusicData newMusic, List<OverworldGoal> flags)
	{
	}

	[Token(Token = "0x600117A")]
	[Address(RVA = "0x15C5FDC", Offset = "0x15C5FDC", VA = "0x15C5FDC")]
	public float GetCurrentValue()
	{
		return default;
	}

	[Token(Token = "0x600117B")]
	[Address(RVA = "0x15C5F68", Offset = "0x15C5F68", VA = "0x15C5F68")]
	public void UpdatePercentageFromFlags()
	{
	}

	[Token(Token = "0x600117C")]
	[Address(RVA = "0x15C2500", Offset = "0x15C2500", VA = "0x15C2500")]
	public void StartWithoutTransition()
	{
	}

	[Token(Token = "0x600117D")]
	[Address(RVA = "0x15C2C9C", Offset = "0x15C2C9C", VA = "0x15C2C9C")]
	public void StartWithoutTransition(OverworldMusicData newCurrent)
	{
	}

	[Token(Token = "0x600117E")]
	[Address(RVA = "0x15C5F24", Offset = "0x15C5F24", VA = "0x15C5F24")]
	public void SwitchToWithTransition()
	{
	}

	[Token(Token = "0x600117F")]
	[Address(RVA = "0x15C6164", Offset = "0x15C6164", VA = "0x15C6164")]
	public void SetPercentage(float pct, bool fromMenu = false)
	{
	}

	[Token(Token = "0x6001180")]
	[Address(RVA = "0x15C62B4", Offset = "0x15C62B4", VA = "0x15C62B4")]
	public void SetValue(float value)
	{
	}

	[Token(Token = "0x6001181")]
	[Address(RVA = "0x15C6414", Offset = "0x15C6414", VA = "0x15C6414")]
	public OverworldMusic()
	{
	}
}
