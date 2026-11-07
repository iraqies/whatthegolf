using System;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20008B9")]
public class ButtonSelectInfo : MonoBehaviour
{
	[Token(Token = "0x4002FDB")]
	[FieldOffset(Offset = "0x18")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4F69C", Offset = "0x4F69C")]
	private Action m_OnSelected;

	[Token(Token = "0x14000038")]
	public event Action OnSelected
	{
		[Token(Token = "0x600283A")]
		[Address(RVA = "0x17DA048", Offset = "0x17DA048", VA = "0x17DA048")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x670C4", Offset = "0x670C4")]
		add
		{
		}
		[Token(Token = "0x600283B")]
		[Address(RVA = "0x17DA0EC", Offset = "0x17DA0EC", VA = "0x17DA0EC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x670D4", Offset = "0x670D4")]
		remove
		{
		}
	}

	[Token(Token = "0x600283C")]
	[Address(RVA = "0x17DA190", Offset = "0x17DA190", VA = "0x17DA190")]
	public void Select()
	{
	}

	[Token(Token = "0x600283D")]
	[Address(RVA = "0x17DA1A4", Offset = "0x17DA1A4", VA = "0x17DA1A4")]
	public ButtonSelectInfo()
	{
	}
}
