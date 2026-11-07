using Il2CppDummyDll;

[Token(Token = "0x200045C")]
public abstract class AutoFailVelocityMultiple : AutoFailBase
{
	[Token(Token = "0x40017B1")]
	[FieldOffset(Offset = "0x2C")]
	public float velocityThreshold;

	[Token(Token = "0x6001468")]
	public abstract float[] GetVelocities();

	[Token(Token = "0x6001469")]
	[Address(RVA = "0x1514E10", Offset = "0x1514E10", VA = "0x1514E10")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x600146A")]
	[Address(RVA = "0x1514C38", Offset = "0x1514C38", VA = "0x1514C38")]
	protected AutoFailVelocityMultiple()
	{
	}
}
