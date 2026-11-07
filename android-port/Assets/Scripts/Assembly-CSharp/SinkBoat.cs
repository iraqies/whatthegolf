using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000683")]
public class SinkBoat : MonoBehaviour
{
	[Token(Token = "0x40021CE")]
	[FieldOffset(Offset = "0x18")]
	public Animator Tentacle;

	[Token(Token = "0x40021CF")]
	[FieldOffset(Offset = "0x20")]
	public Vector3 SinkDirection;

	[Token(Token = "0x40021D0")]
	[FieldOffset(Offset = "0x2C")]
	public float InitialWaitTime;

	[Token(Token = "0x40021D1")]
	[FieldOffset(Offset = "0x30")]
	public float MoveTime;

	[Token(Token = "0x40021D2")]
	[FieldOffset(Offset = "0x34")]
	public float WaitTimeBeforeTransition;

	[Token(Token = "0x40021D3")]
	[FieldOffset(Offset = "0x38")]
	public float AngularVelocity;

	[Token(Token = "0x6001DCC")]
	[Address(RVA = "0x16B3370", Offset = "0x16B3370", VA = "0x16B3370")]
	public SinkBoat()
	{
	}
}
