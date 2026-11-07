using Core;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000256")]
public class SetRBKinematicUntilShoot : MonoBehaviour
{
	[Token(Token = "0x4000BF9")]
	[FieldOffset(Offset = "0x18")]
	private Rigidbody rb;

	[Token(Token = "0x4000BFA")]
	[FieldOffset(Offset = "0x20")]
	private GolfBallController controller;

	[Token(Token = "0x6000A7F")]
	[Address(RVA = "0x168E894", Offset = "0x168E894", VA = "0x168E894")]
	private void Start()
	{
	}

	[Token(Token = "0x6000A80")]
	[Address(RVA = "0x168E9A8", Offset = "0x168E9A8", VA = "0x168E9A8")]
	private void OnShoot(Vector3 obj)
	{
	}

	[Token(Token = "0x6000A81")]
	[Address(RVA = "0x168EA24", Offset = "0x168EA24", VA = "0x168EA24")]
	public SetRBKinematicUntilShoot()
	{
	}
}
