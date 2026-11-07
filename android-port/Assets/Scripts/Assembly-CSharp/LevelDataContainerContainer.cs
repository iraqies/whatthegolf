using System;
using System.Collections.Generic;
using Core;
using Il2CppDummyDll;
using UnityEngine;

[Serializable]
[Token(Token = "0x20004BC")]
public class LevelDataContainerContainer : LevelDataContainerBase
{
	[Serializable]
	[Token(Token = "0x20004BD")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3FE04", Offset = "0x3FE04")]
	private sealed class _003C_003Ec
	{
		[Token(Token = "0x40018E8")]
		[FieldOffset(Offset = "0x0")]
		public static readonly _003C_003Ec _003C_003E9;

		[Token(Token = "0x40018E9")]
		[FieldOffset(Offset = "0x8")]
		public static Func<LevelDataContainer, IEnumerable<LevelData>> _003C_003E9__3_0;

		[Token(Token = "0x40018EA")]
		[FieldOffset(Offset = "0x10")]
		public static Func<LevelDataContainer, IEnumerable<LevelDataAndChallenge>> _003C_003E9__4_0;

		[Token(Token = "0x60015EA")]
		[Address(RVA = "0x17D2740", Offset = "0x17D2740", VA = "0x17D2740")]
		public _003C_003Ec()
		{
		}

		[Token(Token = "0x60015EB")]
		[Address(RVA = "0x17D2748", Offset = "0x17D2748", VA = "0x17D2748")]
		internal IEnumerable<LevelData> _003CGetLevelDatas_003Eb__3_0(LevelDataContainer c)
		{
			return null;
		}

		[Token(Token = "0x60015EC")]
		[Address(RVA = "0x17D2764", Offset = "0x17D2764", VA = "0x17D2764")]
		internal IEnumerable<LevelDataAndChallenge> _003CGetLevelDatasWithChallenges_003Eb__4_0(LevelDataContainer c)
		{
			return null;
		}
	}

	[Token(Token = "0x40018E6")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private LevelContainerList levelContainers;

	[Token(Token = "0x40018E7")]
	[FieldOffset(Offset = "0x28")]
	public LevelDataContainer DebugContainer;

	[Token(Token = "0x60015E5")]
	[Address(RVA = "0x1529DFC", Offset = "0x1529DFC", VA = "0x1529DFC")]
	public List<LevelDataContainer> GetContainers()
	{
		return null;
	}

	[Token(Token = "0x60015E6")]
	[Address(RVA = "0x1529E50", Offset = "0x1529E50", VA = "0x1529E50", Slot = "4")]
	public override List<LevelData> GetLevelDatas()
	{
		return null;
	}

	[Token(Token = "0x60015E7")]
	[Address(RVA = "0x1529FA0", Offset = "0x1529FA0", VA = "0x1529FA0", Slot = "5")]
	public override List<LevelDataAndChallenge> GetLevelDatasWithChallenges()
	{
		return null;
	}

	[Token(Token = "0x60015E8")]
	[Address(RVA = "0x152A13C", Offset = "0x152A13C", VA = "0x152A13C")]
	public LevelDataContainerContainer()
	{
	}
}
