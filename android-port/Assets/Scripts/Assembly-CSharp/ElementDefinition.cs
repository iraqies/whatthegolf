using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x200007A")]
public class ElementDefinition : ScriptableObject
{
	[Token(Token = "0x40001DF")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private int m_Id;

	[Token(Token = "0x40001E0")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private Sprite m_Icon;

	[Token(Token = "0x17000053")]
	public int id
	{
		[Token(Token = "0x6000204")]
		[Address(RVA = "0x143D21C", Offset = "0x143D21C", VA = "0x143D21C")]
		get
		{
			return default;
		}
		[Token(Token = "0x6000205")]
		[Address(RVA = "0x143D224", Offset = "0x143D224", VA = "0x143D224")]
		set
		{
		}
	}

	[Token(Token = "0x17000054")]
	public Sprite icon
	{
		[Token(Token = "0x6000206")]
		[Address(RVA = "0x143D22C", Offset = "0x143D22C", VA = "0x143D22C")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000207")]
		[Address(RVA = "0x143D234", Offset = "0x143D234", VA = "0x143D234")]
		set
		{
		}
	}

	[Token(Token = "0x6000208")]
	[Address(RVA = "0x143D23C", Offset = "0x143D23C", VA = "0x143D23C")]
	public ElementDefinition()
	{
	}
}
