using Core;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20007A8")]
public class BallDirection : MonoBehaviour
{
	[Token(Token = "0x4002879")]
	[FieldOffset(Offset = "0x18")]
	public GolfBallController ball;

	[Token(Token = "0x400287A")]
	[FieldOffset(Offset = "0x20")]
	private Rigidbody rigidBody;

	[Token(Token = "0x400287B")]
	[FieldOffset(Offset = "0x28")]
	public float directionForce;

	[Token(Token = "0x6002316")]
	[Address(RVA = "0x1518BD8", Offset = "0x1518BD8", VA = "0x1518BD8")]
	private void Start()
	{
	}

	[Token(Token = "0x6002317")]
	[Address(RVA = "0x1518CAC", Offset = "0x1518CAC", VA = "0x1518CAC")]
	private void Ball_OnShoot(Vector3 direction)
	{
	}

	[Token(Token = "0x6002318")]
	[Address(RVA = "0x1518D40", Offset = "0x1518D40", VA = "0x1518D40")]
	public BallDirection()
	{
	}
}
