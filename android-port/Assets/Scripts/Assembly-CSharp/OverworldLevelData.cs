using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Serializable]
[Token(Token = "0x20004C4")]
public class OverworldLevelData : ScriptableObject
{
	[Token(Token = "0x20004C5")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3FE24", Offset = "0x3FE24")]
	private sealed class _003C_003Ec__DisplayClass2_0
	{
		[Token(Token = "0x40018F2")]
		[FieldOffset(Offset = "0x10")]
		public string name;

		[Token(Token = "0x60015FB")]
		[Address(RVA = "0x1812600", Offset = "0x1812600", VA = "0x1812600")]
		public _003C_003Ec__DisplayClass2_0()
		{
		}

		[Token(Token = "0x60015FC")]
		[Address(RVA = "0x1812608", Offset = "0x1812608", VA = "0x1812608")]
		internal bool _003CFindSection_003Eb__0(OverworldLevelSection s)
		{
			return default;
		}
	}

	[Token(Token = "0x40018F0")]
	[FieldOffset(Offset = "0x18")]
	public List<OverworldLevelSection> Sections;

	[Token(Token = "0x40018F1")]
	[FieldOffset(Offset = "0x20")]
	public List<Sprite> SectionImages;

	[Token(Token = "0x60015F8")]
	[Address(RVA = "0x15BA98C", Offset = "0x15BA98C", VA = "0x15BA98C")]
	public OverworldLevelSection FindSection(string name)
	{
		return null;
	}

	[Token(Token = "0x60015F9")]
	[Address(RVA = "0x15BAA80", Offset = "0x15BAA80", VA = "0x15BAA80")]
	public void CacheCurrentState()
	{
	}

	[Token(Token = "0x60015FA")]
	[Address(RVA = "0x15BAC10", Offset = "0x15BAC10", VA = "0x15BAC10")]
	public OverworldLevelData()
	{
	}
}
