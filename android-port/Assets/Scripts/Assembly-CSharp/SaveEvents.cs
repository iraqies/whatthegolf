using System;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000B4E")]
public class SaveEvents : MonoBehaviour
{
	[Token(Token = "0x4003ED7")]
	[FieldOffset(Offset = "0x18")]
	public Vector3 lastSavePosition;

	[Token(Token = "0x4003ED8")]
	[FieldOffset(Offset = "0x28")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x509B8", Offset = "0x509B8")]
	private Action<SaveSpot> m_OnEnterSaveSpot;

	[Token(Token = "0x14000071")]
	public event Action<SaveSpot> OnEnterSaveSpot
	{
		[Token(Token = "0x60035B4")]
		[Address(RVA = "0x166AAC8", Offset = "0x166AAC8", VA = "0x166AAC8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6A9D8", Offset = "0x6A9D8")]
		add
		{
		}
		[Token(Token = "0x60035B5")]
		[Address(RVA = "0x166B820", Offset = "0x166B820", VA = "0x166B820")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6A9E8", Offset = "0x6A9E8")]
		remove
		{
		}
	}

	[Token(Token = "0x60035B6")]
	[Address(RVA = "0x166B8C4", Offset = "0x166B8C4", VA = "0x166B8C4")]
	private void OnTriggerEnter2D(Collider2D collision)
	{
	}

	[Token(Token = "0x60035B7")]
	[Address(RVA = "0x166BA04", Offset = "0x166BA04", VA = "0x166BA04")]
	public SaveEvents()
	{
	}
}
