using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x200025C")]
public class ConstrainPosition : MonoBehaviour
{
	[Token(Token = "0x4000C33")]
	[FieldOffset(Offset = "0x18")]
	public bool constrainX;

	[Token(Token = "0x4000C34")]
	[FieldOffset(Offset = "0x19")]
	public bool constrainY;

	[Token(Token = "0x4000C35")]
	[FieldOffset(Offset = "0x1A")]
	public bool constrainZ;

	[Token(Token = "0x4000C36")]
	[FieldOffset(Offset = "0x1C")]
	public float minimumX;

	[Token(Token = "0x4000C37")]
	[FieldOffset(Offset = "0x20")]
	public float maximumX;

	[Token(Token = "0x4000C38")]
	[FieldOffset(Offset = "0x24")]
	public float minimumY;

	[Token(Token = "0x4000C39")]
	[FieldOffset(Offset = "0x28")]
	public float maximumY;

	[Token(Token = "0x4000C3A")]
	[FieldOffset(Offset = "0x2C")]
	public float minimumZ;

	[Token(Token = "0x4000C3B")]
	[FieldOffset(Offset = "0x30")]
	public float maximumZ;

	[Token(Token = "0x6000A9F")]
	[Address(RVA = "0x18AD5E0", Offset = "0x18AD5E0", VA = "0x18AD5E0")]
	private void Start()
	{
	}

	[Token(Token = "0x6000AA0")]
	[Address(RVA = "0x18AD5E4", Offset = "0x18AD5E4", VA = "0x18AD5E4")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x6000AA1")]
	[Address(RVA = "0x18AD884", Offset = "0x18AD884", VA = "0x18AD884")]
	public ConstrainPosition()
	{
	}
}
