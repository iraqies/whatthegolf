using System.Collections.Generic;
using Core;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000143")]
public class PersistentScoreTracker : MonoBehaviour
{
	[Token(Token = "0x40005A9")]
	[FieldOffset(Offset = "0x18")]
	private Dictionary<int, int> PlayerScores;

	[Token(Token = "0x40005AA")]
	[FieldOffset(Offset = "0x20")]
	private readonly int MAXPLAYERS;

	[Token(Token = "0x6000579")]
	[Address(RVA = "0x15DFE24", Offset = "0x15DFE24", VA = "0x15DFE24")]
	private void Start()
	{
	}

	[Token(Token = "0x600057A")]
	[Address(RVA = "0x15E002C", Offset = "0x15E002C", VA = "0x15E002C")]
	private void OnLevelWillUnload()
	{
	}

	[Token(Token = "0x600057B")]
	[Address(RVA = "0x15E0030", Offset = "0x15E0030", VA = "0x15E0030")]
	private void OnLevelLoaded(LevelData levelData)
	{
	}

	[Token(Token = "0x600057C")]
	[Address(RVA = "0x15E0034", Offset = "0x15E0034", VA = "0x15E0034")]
	private void OnGoal(GolfBallController controller, string obj)
	{
	}

	[Token(Token = "0x600057D")]
	[Address(RVA = "0x15E00D0", Offset = "0x15E00D0", VA = "0x15E00D0")]
	public PersistentScoreTracker()
	{
	}
}
