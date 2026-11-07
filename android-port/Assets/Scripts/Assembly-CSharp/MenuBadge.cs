using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20001B4")]
public class MenuBadge : MonoBehaviour
{
	[Token(Token = "0x40007B1")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private TextMeshProLocalized _titleLabel;

	[Token(Token = "0x17000105")]
	public string text
	{
		[Token(Token = "0x6000793")]
		[Address(RVA = "0x1560DD8", Offset = "0x1560DD8", VA = "0x1560DD8")]
		set
		{
		}
	}

	[Token(Token = "0x17000106")]
	public bool visible
	{
		[Token(Token = "0x6000794")]
		[Address(RVA = "0x1560DF4", Offset = "0x1560DF4", VA = "0x1560DF4")]
		set
		{
		}
	}

	[Token(Token = "0x6000795")]
	[Address(RVA = "0x1560E28", Offset = "0x1560E28", VA = "0x1560E28")]
	public MenuBadge()
	{
	}
}
