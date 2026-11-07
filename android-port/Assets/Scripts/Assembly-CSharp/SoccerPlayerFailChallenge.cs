using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000464")]
public class SoccerPlayerFailChallenge : MonoBehaviour
{
	[Token(Token = "0x40017C5")]
	[FieldOffset(Offset = "0x18")]
	public Challenge ChallengeToFail;

	[Token(Token = "0x40017C6")]
	[FieldOffset(Offset = "0x20")]
	public List<SoccerPlayer> Players;

	[Token(Token = "0x600147B")]
	[Address(RVA = "0x16BF9A4", Offset = "0x16BF9A4", VA = "0x16BF9A4")]
	private void Start()
	{
	}

	[Token(Token = "0x600147C")]
	[Address(RVA = "0x16BFBE4", Offset = "0x16BFBE4", VA = "0x16BFBE4")]
	private void OnKick()
	{
	}

	[Token(Token = "0x600147D")]
	[Address(RVA = "0x16BFC00", Offset = "0x16BFC00", VA = "0x16BFC00")]
	public SoccerPlayerFailChallenge()
	{
	}
}
