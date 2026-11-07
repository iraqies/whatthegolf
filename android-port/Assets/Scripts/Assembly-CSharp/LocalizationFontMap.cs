using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20004E9")]
public class LocalizationFontMap : ScriptableObject
{
	[Token(Token = "0x40019A1")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private List<FontMapEntry> m_Entries;

	[Token(Token = "0x1700027E")]
	public List<FontMapEntry> entries
	{
		[Token(Token = "0x60016A3")]
		[Address(RVA = "0x153D76C", Offset = "0x153D76C", VA = "0x153D76C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60016A4")]
	[Address(RVA = "0x153D774", Offset = "0x153D774", VA = "0x153D774")]
	public LocalizationFontMap()
	{
	}
}
