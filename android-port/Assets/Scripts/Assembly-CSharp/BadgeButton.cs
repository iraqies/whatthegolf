using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000182")]
public class BadgeButton : MainMenu2Button
{
	[Token(Token = "0x40006E5")]
	[FieldOffset(Offset = "0x110")]
	[SerializeField]
	private TextMeshProLocalized _titleLabel;

	[Token(Token = "0x170000E6")]
	public string title
	{
		[Token(Token = "0x60006A6")]
		[Address(RVA = "0x1516C54", Offset = "0x1516C54", VA = "0x1516C54")]
		set
		{
		}
	}

	[Token(Token = "0x60006A7")]
	[Address(RVA = "0x1516C70", Offset = "0x1516C70", VA = "0x1516C70")]
	public BadgeButton()
	{
	}
}
