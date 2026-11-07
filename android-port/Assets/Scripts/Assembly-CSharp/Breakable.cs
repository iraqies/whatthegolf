using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000BC3")]
public class Breakable : MonoBehaviour
{
	[Token(Token = "0x400418A")]
	[FieldOffset(Offset = "0x18")]
	public Rigidbody[] pieces;

	[Token(Token = "0x400418B")]
	[FieldOffset(Offset = "0x20")]
	public float breakThreshold;

	[Token(Token = "0x400418C")]
	[FieldOffset(Offset = "0x24")]
	public float breakExplosionRadius;

	[Token(Token = "0x400418D")]
	[FieldOffset(Offset = "0x28")]
	public float breakExplosionForceFactor;

	[Token(Token = "0x60038AD")]
	[Address(RVA = "0x170620C", Offset = "0x170620C", VA = "0x170620C")]
	private void OnCollisionEnter(Collision collision)
	{
	}

	[Token(Token = "0x60038AE")]
	[Address(RVA = "0x1706428", Offset = "0x1706428", VA = "0x1706428")]
	public Breakable()
	{
	}
}
