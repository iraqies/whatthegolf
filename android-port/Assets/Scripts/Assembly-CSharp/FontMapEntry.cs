using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.AddressableAssets;

[Serializable]
[Token(Token = "0x20004EA")]
public class FontMapEntry
{
	[Token(Token = "0x40019A2")]
	[FieldOffset(Offset = "0x10")]
	[SerializeField]
	private string m_Name;

	[Token(Token = "0x40019A3")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private AssetReference m_FontCollectionAssetReference;

	[Token(Token = "0x40019A4")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private List<string> m_CharSets;

	[Token(Token = "0x40019A5")]
	[FieldOffset(Offset = "0x28")]
	private LocalizationFontCollection loadedFontCollection;

	[Token(Token = "0x60016A5")]
	[Address(RVA = "0x14714B4", Offset = "0x14714B4", VA = "0x14714B4")]
	public FontMapEntry()
	{
	}
}
