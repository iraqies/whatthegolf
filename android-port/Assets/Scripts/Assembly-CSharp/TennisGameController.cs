using Il2CppDummyDll;
using TennisGolf;
using UnityEngine;

[Token(Token = "0x2000EB1")]
public class TennisGameController : MonoBehaviour
{
	[Token(Token = "0x2000EB2")]
	private enum LastHitState
	{
		[Token(Token = "0x4004F61")]
		NONE = 0,
		[Token(Token = "0x4004F62")]
		PLAYER_SIDE = 1,
		[Token(Token = "0x4004F63")]
		OPPONENT_SIDE = 2,
		[Token(Token = "0x4004F64")]
		PLAYER = 3,
		[Token(Token = "0x4004F65")]
		OPPONENT = 4,
		[Token(Token = "0x4004F66")]
		OOB = 5
	}

	[Token(Token = "0x4004F59")]
	[FieldOffset(Offset = "0x18")]
	private LastHitState lastHitState;

	[Token(Token = "0x4004F5A")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private string PlayerPlayerTag;

	[Token(Token = "0x4004F5B")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private string OpponentPlayerTag;

	[Token(Token = "0x4004F5C")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private string PlayerSideTag;

	[Token(Token = "0x4004F5D")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	private string OppenentSideTag;

	[Token(Token = "0x4004F5E")]
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	private TennisPlayer originalTennisScript;

	[Token(Token = "0x4004F5F")]
	[FieldOffset(Offset = "0x48")]
	private bool gameOver;

	[Token(Token = "0x600449D")]
	[Address(RVA = "0x16F97D0", Offset = "0x16F97D0", VA = "0x16F97D0")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x600449E")]
	[Address(RVA = "0x16F9868", Offset = "0x16F9868", VA = "0x16F9868")]
	private void CheckTag(string tag)
	{
	}

	[Token(Token = "0x600449F")]
	[Address(RVA = "0x16F9CB4", Offset = "0x16F9CB4", VA = "0x16F9CB4")]
	private void OnCollisionEnter(Collision other)
	{
	}

	[Token(Token = "0x60044A0")]
	[Address(RVA = "0x16F9B34", Offset = "0x16F9B34", VA = "0x16F9B34")]
	private void Loose()
	{
	}

	[Token(Token = "0x60044A1")]
	[Address(RVA = "0x16F9C0C", Offset = "0x16F9C0C", VA = "0x16F9C0C")]
	private void Win()
	{
	}

	[Token(Token = "0x60044A2")]
	[Address(RVA = "0x16F9D58", Offset = "0x16F9D58", VA = "0x16F9D58")]
	public TennisGameController()
	{
	}
}
