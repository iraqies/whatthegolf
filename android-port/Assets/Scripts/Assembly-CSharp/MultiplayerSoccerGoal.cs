using Core;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x200012C")]
public class MultiplayerSoccerGoal : MonoBehaviour
{
	[Token(Token = "0x4000533")]
	[FieldOffset(Offset = "0x18")]
	public GolfBallController OpponentController;

	[Token(Token = "0x4000534")]
	[FieldOffset(Offset = "0x20")]
	public GameObject Football;

	[Token(Token = "0x6000523")]
	[Address(RVA = "0x15847D8", Offset = "0x15847D8", VA = "0x15847D8")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x6000524")]
	[Address(RVA = "0x15848D0", Offset = "0x15848D0", VA = "0x15848D0")]
	public MultiplayerSoccerGoal()
	{
	}
}
