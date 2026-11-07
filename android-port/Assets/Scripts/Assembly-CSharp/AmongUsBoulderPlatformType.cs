using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000DFF")]
public class AmongUsBoulderPlatformType : MonoBehaviour
{
	[Token(Token = "0x2000E00")]
	public enum PlatformDirection
	{
		[Token(Token = "0x4004C31")]
		Left = 0,
		[Token(Token = "0x4004C32")]
		Right = 1,
		[Token(Token = "0x4004C33")]
		Down = 2
	}

	[Token(Token = "0x4004C2F")]
	[FieldOffset(Offset = "0x18")]
	public PlatformDirection platformDirection;

	[Token(Token = "0x60041E3")]
	[Address(RVA = "0x140F064", Offset = "0x140F064", VA = "0x140F064")]
	public AmongUsBoulderPlatformType()
	{
	}
}
