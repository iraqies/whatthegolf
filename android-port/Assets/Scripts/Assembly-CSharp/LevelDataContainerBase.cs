using System.Collections.Generic;
using Core;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20004BB")]
public abstract class LevelDataContainerBase : ScriptableObject
{
	[Token(Token = "0x40018E5")]
	[FieldOffset(Offset = "0x18")]
	public LeaderboardBoard leaderboard;

	[Token(Token = "0x17000266")]
	public bool hasLeaderboard
	{
		[Token(Token = "0x60015E1")]
		[Address(RVA = "0x1529DEC", Offset = "0x1529DEC", VA = "0x1529DEC")]
		get
		{
			return default;
		}
	}

	[Token(Token = "0x60015E2")]
	public abstract List<LevelData> GetLevelDatas();

	[Token(Token = "0x60015E3")]
	public abstract List<LevelDataAndChallenge> GetLevelDatasWithChallenges();

	[Token(Token = "0x60015E4")]
	[Address(RVA = "0x1529DDC", Offset = "0x1529DDC", VA = "0x1529DDC")]
	protected LevelDataContainerBase()
	{
	}
}
