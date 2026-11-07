using System;
using System.Collections.Generic;
using Core;
using Il2CppDummyDll;

[Token(Token = "0x2000136")]
public class MultiplayerPlayList : LevelDataContainerBase
{
	[Token(Token = "0x2000137")]
	public enum LevelSelectionTypes
	{
		[Token(Token = "0x4000575")]
		Random = 0,
		[Token(Token = "0x4000576")]
		Ordered = 1
	}

	[Token(Token = "0x2000138")]
	public enum MatchTypes
	{
		[Token(Token = "0x4000578")]
		FewestStrokes = 0,
		[Token(Token = "0x4000579")]
		FirstToFlag = 1
	}

	[Serializable]
	[Token(Token = "0x2000139")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3DBE0", Offset = "0x3DBE0")]
	private sealed class _003C_003Ec
	{
		[Token(Token = "0x400057A")]
		[FieldOffset(Offset = "0x0")]
		public static readonly _003C_003Ec _003C_003E9;

		[Token(Token = "0x400057B")]
		[FieldOffset(Offset = "0x8")]
		public static Func<LevelData, LevelDataAndChallenge> _003C_003E9__6_0;

		[Token(Token = "0x6000552")]
		[Address(RVA = "0x1803444", Offset = "0x1803444", VA = "0x1803444")]
		public _003C_003Ec()
		{
		}

		[Token(Token = "0x6000553")]
		[Address(RVA = "0x180344C", Offset = "0x180344C", VA = "0x180344C")]
		internal LevelDataAndChallenge _003CGetLevelDatasWithChallenges_003Eb__6_0(LevelData d)
		{
			return null;
		}
	}

	[Token(Token = "0x400056C")]
	[FieldOffset(Offset = "0x20")]
	public LevelDataContainer IntroLevels;

	[Token(Token = "0x400056D")]
	[FieldOffset(Offset = "0x28")]
	public List<LevelDataContainer> Levels;

	[Token(Token = "0x400056E")]
	[FieldOffset(Offset = "0x30")]
	public LevelDataContainer OutroLevels;

	[Token(Token = "0x400056F")]
	[FieldOffset(Offset = "0x38")]
	public LevelDataContainer NextBatch;

	[Token(Token = "0x4000570")]
	[FieldOffset(Offset = "0x40")]
	public LevelDataContainer UnusedLevels;

	[Token(Token = "0x4000571")]
	[FieldOffset(Offset = "0x48")]
	public int LevelsToPlay;

	[Token(Token = "0x4000572")]
	[FieldOffset(Offset = "0x4C")]
	public LevelSelectionTypes LevelSelection;

	[Token(Token = "0x4000573")]
	[FieldOffset(Offset = "0x50")]
	public MatchTypes MatchType;

	[Token(Token = "0x600054B")]
	[Address(RVA = "0x1582B40", Offset = "0x1582B40", VA = "0x1582B40")]
	public bool HasNextBatch()
	{
		return default;
	}

	[Token(Token = "0x600054C")]
	[Address(RVA = "0x1582BBC", Offset = "0x1582BBC", VA = "0x1582BBC")]
	public List<LevelData> GetNextBatch()
	{
		return null;
	}

	[Token(Token = "0x600054D")]
	[Address(RVA = "0x1582DA8", Offset = "0x1582DA8", VA = "0x1582DA8")]
	public List<LevelData> GetAllLevels()
	{
		return null;
	}

	[Token(Token = "0x600054E")]
	[Address(RVA = "0x1583544", Offset = "0x1583544", VA = "0x1583544", Slot = "4")]
	public override List<LevelData> GetLevelDatas()
	{
		return null;
	}

	[Token(Token = "0x600054F")]
	[Address(RVA = "0x1583548", Offset = "0x1583548", VA = "0x1583548", Slot = "5")]
	public override List<LevelDataAndChallenge> GetLevelDatasWithChallenges()
	{
		return null;
	}

	[Token(Token = "0x6000550")]
	[Address(RVA = "0x15836BC", Offset = "0x15836BC", VA = "0x15836BC")]
	public MultiplayerPlayList()
	{
	}
}
