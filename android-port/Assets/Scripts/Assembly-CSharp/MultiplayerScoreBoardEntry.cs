using System.Collections.Generic;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;

[Token(Token = "0x200013F")]
public class MultiplayerScoreBoardEntry : MonoBehaviour
{
	[Token(Token = "0x400058D")]
	[FieldOffset(Offset = "0x18")]
	public TextMeshProUGUI PlayerName;

	[Token(Token = "0x400058E")]
	[FieldOffset(Offset = "0x20")]
	public TextMeshProUGUI TotalScore;

	[Token(Token = "0x400058F")]
	[FieldOffset(Offset = "0x28")]
	public TextMeshProUGUI ScoreTemplate;

	[Token(Token = "0x4000590")]
	[FieldOffset(Offset = "0x30")]
	public List<TextMeshProUGUI> Scores;

	[Token(Token = "0x6000569")]
	[Address(RVA = "0x1584568", Offset = "0x1584568", VA = "0x1584568")]
	public void AddNewScore(int score)
	{
	}

	[Token(Token = "0x600056A")]
	[Address(RVA = "0x1583C68", Offset = "0x1583C68", VA = "0x1583C68")]
	public void ResetAll()
	{
	}

	[Token(Token = "0x600056B")]
	[Address(RVA = "0x15847D0", Offset = "0x15847D0", VA = "0x15847D0")]
	public MultiplayerScoreBoardEntry()
	{
	}
}
