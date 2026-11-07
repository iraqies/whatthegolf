using System;
using System.Collections.Generic;
using Core;
using Il2CppDummyDll;
using UnityEngine;

[Serializable]
[Token(Token = "0x20004C0")]
public class LevelDataContainerWithChallenge : LevelDataContainerBase
{
	[Serializable]
	[Token(Token = "0x20004C1")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3FE14", Offset = "0x3FE14")]
	private sealed class _003C_003Ec
	{
		[Token(Token = "0x40018EC")]
		[FieldOffset(Offset = "0x0")]
		public static readonly _003C_003Ec _003C_003E9;

		[Token(Token = "0x40018ED")]
		[FieldOffset(Offset = "0x8")]
		public static Func<LevelDataAndChallenge, LevelData> _003C_003E9__2_0;

		[Token(Token = "0x60015F4")]
		[Address(RVA = "0x17D27E8", Offset = "0x17D27E8", VA = "0x17D27E8")]
		public _003C_003Ec()
		{
		}

		[Token(Token = "0x60015F5")]
		[Address(RVA = "0x17D27F0", Offset = "0x17D27F0", VA = "0x17D27F0")]
		internal LevelData _003CGetLevelDatas_003Eb__2_0(LevelDataAndChallenge ld)
		{
			return null;
		}
	}

	[Token(Token = "0x40018EB")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private LevelDataListWithChallenge levels;

	[Token(Token = "0x60015EF")]
	[Address(RVA = "0x152A14C", Offset = "0x152A14C", VA = "0x152A14C", Slot = "5")]
	public override List<LevelDataAndChallenge> GetLevelDatasWithChallenges()
	{
		return null;
	}

	[Token(Token = "0x60015F0")]
	[Address(RVA = "0x152A1A0", Offset = "0x152A1A0", VA = "0x152A1A0", Slot = "4")]
	public override List<LevelData> GetLevelDatas()
	{
		return null;
	}

	[Token(Token = "0x60015F1")]
	[Address(RVA = "0x152A314", Offset = "0x152A314", VA = "0x152A314")]
	public LevelDataAndChallenge GetLevel(string id)
	{
		return null;
	}

	[Token(Token = "0x60015F2")]
	[Address(RVA = "0x152A610", Offset = "0x152A610", VA = "0x152A610")]
	public LevelDataContainerWithChallenge()
	{
	}
}
