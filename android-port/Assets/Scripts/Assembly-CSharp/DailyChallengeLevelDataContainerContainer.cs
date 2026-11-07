using System;
using System.Collections.Generic;
using Core;
using Il2CppDummyDll;
using UnityEngine;

[Serializable]
[Token(Token = "0x20004B5")]
public class DailyChallengeLevelDataContainerContainer : LevelDataContainerBase
{
	[Serializable]
	[Token(Token = "0x20004B6")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3FDE4", Offset = "0x3FDE4")]
	private sealed class _003C_003Ec
	{
		[Token(Token = "0x40018D6")]
		[FieldOffset(Offset = "0x0")]
		public static readonly _003C_003Ec _003C_003E9;

		[Token(Token = "0x40018D7")]
		[FieldOffset(Offset = "0x8")]
		public static Func<DailyChallengeLevelDataContainer, IEnumerable<LevelData>> _003C_003E9__3_0;

		[Token(Token = "0x40018D8")]
		[FieldOffset(Offset = "0x10")]
		public static Func<DailyChallengeLevelDataContainer, IEnumerable<LevelDataAndChallenge>> _003C_003E9__4_0;

		[Token(Token = "0x60015CC")]
		[Address(RVA = "0x1794DA4", Offset = "0x1794DA4", VA = "0x1794DA4")]
		public _003C_003Ec()
		{
		}

		[Token(Token = "0x60015CD")]
		[Address(RVA = "0x1794DAC", Offset = "0x1794DAC", VA = "0x1794DAC")]
		internal IEnumerable<LevelData> _003CGetLevelDatas_003Eb__3_0(DailyChallengeLevelDataContainer c)
		{
			return null;
		}

		[Token(Token = "0x60015CE")]
		[Address(RVA = "0x1794DC8", Offset = "0x1794DC8", VA = "0x1794DC8")]
		internal IEnumerable<LevelDataAndChallenge> _003CGetLevelDatasWithChallenges_003Eb__4_0(DailyChallengeLevelDataContainer c)
		{
			return null;
		}
	}

	[Token(Token = "0x40018D4")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private DailyChallengeLevelContainerList levelContainers;

	[Token(Token = "0x40018D5")]
	[FieldOffset(Offset = "0x28")]
	public DailyChallengeLevelDataContainer DebugContainer;

	[Token(Token = "0x60015C7")]
	[Address(RVA = "0x18CAF48", Offset = "0x18CAF48", VA = "0x18CAF48")]
	public List<DailyChallengeLevelDataContainer> GetContainers()
	{
		return null;
	}

	[Token(Token = "0x60015C8")]
	[Address(RVA = "0x18CAF9C", Offset = "0x18CAF9C", VA = "0x18CAF9C", Slot = "4")]
	public override List<LevelData> GetLevelDatas()
	{
		return null;
	}

	[Token(Token = "0x60015C9")]
	[Address(RVA = "0x18CB0EC", Offset = "0x18CB0EC", VA = "0x18CB0EC", Slot = "5")]
	public override List<LevelDataAndChallenge> GetLevelDatasWithChallenges()
	{
		return null;
	}

	[Token(Token = "0x60015CA")]
	[Address(RVA = "0x18CB288", Offset = "0x18CB288", VA = "0x18CB288")]
	public DailyChallengeLevelDataContainerContainer()
	{
	}
}
