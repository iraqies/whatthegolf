using Core;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000E7D")]
public class DestroyController : MonoBehaviour
{
	[Token(Token = "0x4004E5E")]
	[FieldOffset(Offset = "0x18")]
	private GolfBallController golfController;

	[Token(Token = "0x4004E5F")]
	[FieldOffset(Offset = "0x20")]
	private GolfBallShooterExperimental golfShooter;

	[Token(Token = "0x60043BC")]
	[Address(RVA = "0x18DA8CC", Offset = "0x18DA8CC", VA = "0x18DA8CC")]
	private void Start()
	{
	}

	[Token(Token = "0x60043BD")]
	[Address(RVA = "0x18DA94C", Offset = "0x18DA94C", VA = "0x18DA94C")]
	public void RemoveController()
	{
	}

	[Token(Token = "0x60043BE")]
	[Address(RVA = "0x18DA9D0", Offset = "0x18DA9D0", VA = "0x18DA9D0")]
	public DestroyController()
	{
	}
}
