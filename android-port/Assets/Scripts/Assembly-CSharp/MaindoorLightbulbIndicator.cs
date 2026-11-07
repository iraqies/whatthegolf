using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000974")]
public class MaindoorLightbulbIndicator : MonoBehaviour
{
	[Token(Token = "0x2000975")]
	public enum States
	{
		[Token(Token = "0x40033E4")]
		ON = 0,
		[Token(Token = "0x40033E5")]
		OFF = 1,
		[Token(Token = "0x40033E6")]
		CROWN = 2
	}

	[Token(Token = "0x40033E2")]
	[FieldOffset(Offset = "0x18")]
	public States state;

	[Token(Token = "0x6002C25")]
	[Address(RVA = "0x1559FD4", Offset = "0x1559FD4", VA = "0x1559FD4")]
	public MaindoorLightbulbIndicator()
	{
	}
}
