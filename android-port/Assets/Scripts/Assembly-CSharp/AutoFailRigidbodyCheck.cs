using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x200045B")]
public class AutoFailRigidbodyCheck : AutoFailVelocityMultiple
{
	[Token(Token = "0x40017B0")]
	[FieldOffset(Offset = "0x30")]
	public Rigidbody[] rigidbodies;

	[Token(Token = "0x6001466")]
	[Address(RVA = "0x1514C4C", Offset = "0x1514C4C", VA = "0x1514C4C", Slot = "5")]
	public override float[] GetVelocities()
	{
		return null;
	}

	[Token(Token = "0x6001467")]
	[Address(RVA = "0x1514DFC", Offset = "0x1514DFC", VA = "0x1514DFC")]
	public AutoFailRigidbodyCheck()
	{
	}
}
