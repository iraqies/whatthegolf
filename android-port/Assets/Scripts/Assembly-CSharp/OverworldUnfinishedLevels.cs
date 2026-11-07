using System;
using System.Collections.Generic;
using Core;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;

[Token(Token = "0x2000A66")]
public class OverworldUnfinishedLevels : MonoBehaviour
{
	[Serializable]
	[Token(Token = "0x2000A67")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x42CF0", Offset = "0x42CF0")]
	private sealed class _003C_003Ec
	{
		[Token(Token = "0x40039AF")]
		[FieldOffset(Offset = "0x0")]
		public static readonly _003C_003Ec _003C_003E9;

		[Token(Token = "0x40039B0")]
		[FieldOffset(Offset = "0x8")]
		public static Func<LevelData, bool> _003C_003E9__4_0;

		[Token(Token = "0x60031A6")]
		[Address(RVA = "0x181FBB0", Offset = "0x181FBB0", VA = "0x181FBB0")]
		public _003C_003Ec()
		{
		}

		[Token(Token = "0x60031A7")]
		[Address(RVA = "0x181FBB8", Offset = "0x181FBB8", VA = "0x181FBB8")]
		internal bool _003CUpdateThings_003Eb__4_0(LevelData l)
		{
			return default;
		}
	}

	[Token(Token = "0x2000A68")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x42D00", Offset = "0x42D00")]
	private sealed class _003C_003Ec__DisplayClass5_0
	{
		[Token(Token = "0x40039B1")]
		[FieldOffset(Offset = "0x10")]
		public LevelData.ChallengeData challenge;

		[Token(Token = "0x60031A8")]
		[Address(RVA = "0x181FBD4", Offset = "0x181FBD4", VA = "0x181FBD4")]
		public _003C_003Ec__DisplayClass5_0()
		{
		}

		[Token(Token = "0x60031A9")]
		[Address(RVA = "0x181FBDC", Offset = "0x181FBDC", VA = "0x181FBDC")]
		internal bool _003CCountUncompletedChallenges_003Eb__0(string c)
		{
			return default;
		}
	}

	[Token(Token = "0x40039AC")]
	[FieldOffset(Offset = "0x18")]
	public List<HubSection> Sections;

	[Token(Token = "0x40039AD")]
	[FieldOffset(Offset = "0x20")]
	public TextMeshPro Text;

	[Token(Token = "0x40039AE")]
	[FieldOffset(Offset = "0x28")]
	private List<LevelData> allLevels;

	[Token(Token = "0x60031A0")]
	[Address(RVA = "0x15D2EEC", Offset = "0x15D2EEC", VA = "0x15D2EEC")]
	public void Init()
	{
	}

	[Token(Token = "0x60031A1")]
	[Address(RVA = "0x15D36C8", Offset = "0x15D36C8", VA = "0x15D36C8")]
	private void UpdateThings()
	{
	}

	[Token(Token = "0x60031A2")]
	[Address(RVA = "0x15D384C", Offset = "0x15D384C", VA = "0x15D384C")]
	private void CountUncompletedChallenges()
	{
	}

	[Token(Token = "0x60031A3")]
	[Address(RVA = "0x15D3C7C", Offset = "0x15D3C7C", VA = "0x15D3C7C")]
	private void OnUpdateData(OverworldGoal overworldGoal)
	{
	}

	[Token(Token = "0x60031A4")]
	[Address(RVA = "0x15D3C80", Offset = "0x15D3C80", VA = "0x15D3C80")]
	public OverworldUnfinishedLevels()
	{
	}
}
