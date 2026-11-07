using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000010")]
public class AddressableLabels : MonoBehaviour
{
	[Token(Token = "0x2000011")]
	public enum AddressableLabel
	{
		[Token(Token = "0x4000037")]
		ONLOAD = 0,
		[Token(Token = "0x4000038")]
		MENU = 1,
		[Token(Token = "0x4000039")]
		MAIN = 2,
		[Token(Token = "0x400003A")]
		SPORTY = 3,
		[Token(Token = "0x400003B")]
		HOLE = 4,
		[Token(Token = "0x400003C")]
		WINTER = 5,
		[Token(Token = "0x400003D")]
		MAIN_MID = 6,
		[Token(Token = "0x400003E")]
		MAIN_LATE = 7
	}

	[Token(Token = "0x4000035")]
	[FieldOffset(Offset = "0x18")]
	public AddressableLabel label;

	[Token(Token = "0x6000046")]
	[Address(RVA = "0x1408C18", Offset = "0x1408C18", VA = "0x1408C18")]
	public AddressableLabels()
	{
	}
}
