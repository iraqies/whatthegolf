using System;
using System.Collections.Generic;
using Core;
using Il2CppDummyDll;
using UnityEngine;

[Serializable]
[Token(Token = "0x20004B8")]
public class LevelDataContainer : LevelDataContainerBase
{
	[Serializable]
	[Token(Token = "0x20004B9")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3FDF4", Offset = "0x3FDF4")]
	private sealed class _003C_003Ec
	{
		[Token(Token = "0x40018E1")]
		[FieldOffset(Offset = "0x0")]
		public static readonly _003C_003Ec _003C_003E9;

		[Token(Token = "0x40018E2")]
		[FieldOffset(Offset = "0x8")]
		public static Func<LevelData, bool> _003C_003E9__4_0;

		[Token(Token = "0x40018E3")]
		[FieldOffset(Offset = "0x10")]
		public static Func<LevelData, LevelDataAndChallenge> _003C_003E9__6_0;

		[Token(Token = "0x40018E4")]
		[FieldOffset(Offset = "0x18")]
		public static Func<LevelData, int> _003C_003E9__10_0;

		[Token(Token = "0x60015DC")]
		[Address(RVA = "0x17D25DC", Offset = "0x17D25DC", VA = "0x17D25DC")]
		public _003C_003Ec()
		{
		}

		[Token(Token = "0x60015DD")]
		[Address(RVA = "0x17D25E4", Offset = "0x17D25E4", VA = "0x17D25E4")]
		internal bool _003CGetLevels_003Eb__4_0(LevelData l)
		{
			return default;
		}

		[Token(Token = "0x60015DE")]
		[Address(RVA = "0x17D2654", Offset = "0x17D2654", VA = "0x17D2654")]
		internal LevelDataAndChallenge _003CGetLevelDatasWithChallenges_003Eb__6_0(LevelData d)
		{
			return null;
		}

		[Token(Token = "0x60015DF")]
		[Address(RVA = "0x17D26C4", Offset = "0x17D26C4", VA = "0x17D26C4")]
		internal int _003CCalculateWeight_003Eb__10_0(LevelData l)
		{
			return default;
		}
	}

	[Token(Token = "0x40018DD")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private LevelDataList levels;

	[Token(Token = "0x40018DE")]
	[FieldOffset(Offset = "0x28")]
	public bool UseFilter;

	[Token(Token = "0x40018DF")]
	[FieldOffset(Offset = "0x29")]
	public bool UsedInDailyChallenges;

	[Token(Token = "0x40018E0")]
	[FieldOffset(Offset = "0x2C")]
	public float Weight;

	[Token(Token = "0x60015D3")]
	[Address(RVA = "0x15292D4", Offset = "0x15292D4", VA = "0x15292D4")]
	public List<LevelData> GetLevels()
	{
		return null;
	}

	[Token(Token = "0x60015D4")]
	[Address(RVA = "0x1529444", Offset = "0x1529444", VA = "0x1529444", Slot = "4")]
	public override List<LevelData> GetLevelDatas()
	{
		return null;
	}

	[Token(Token = "0x60015D5")]
	[Address(RVA = "0x1529448", Offset = "0x1529448", VA = "0x1529448", Slot = "5")]
	public override List<LevelDataAndChallenge> GetLevelDatasWithChallenges()
	{
		return null;
	}

	[Token(Token = "0x60015D6")]
	[Address(RVA = "0x15295BC", Offset = "0x15295BC", VA = "0x15295BC")]
	public void SetLevels(List<LevelData> list)
	{
	}

	[Token(Token = "0x60015D7")]
	[Address(RVA = "0x15297E0", Offset = "0x15297E0", VA = "0x15297E0")]
	public LevelData GetLevel(string id)
	{
		return null;
	}

	[Token(Token = "0x60015D8")]
	[Address(RVA = "0x1529AC8", Offset = "0x1529AC8", VA = "0x1529AC8")]
	public int Swap(LevelData oldLvlData, LevelData newLvlData)
	{
		return default;
	}

	[Token(Token = "0x60015D9")]
	[Address(RVA = "0x1529C88", Offset = "0x1529C88", VA = "0x1529C88")]
	public int CalculateWeight()
	{
		return default;
	}

	[Token(Token = "0x60015DA")]
	[Address(RVA = "0x1529DBC", Offset = "0x1529DBC", VA = "0x1529DBC")]
	public LevelDataContainer()
	{
	}
}
