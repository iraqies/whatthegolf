using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x200045A")]
public class AutoFailRigidbody2DCheck : AutoFailVelocityMultiple
{
	[Token(Token = "0x40017AF")]
	[FieldOffset(Offset = "0x30")]
	public Rigidbody2D[] rigidbodies;

	[Token(Token = "0x6001464")]
	[Address(RVA = "0x1514A7C", Offset = "0x1514A7C", VA = "0x1514A7C", Slot = "5")]
	public override float[] GetVelocities()
	{
		return null;
	}

	[Token(Token = "0x6001465")]
	[Address(RVA = "0x1514C24", Offset = "0x1514C24", VA = "0x1514C24")]
	public AutoFailRigidbody2DCheck()
	{
	}
}
