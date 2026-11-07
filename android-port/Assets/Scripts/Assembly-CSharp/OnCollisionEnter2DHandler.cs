using System;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000AAC")]
public class OnCollisionEnter2DHandler : MonoBehaviour
{
	[Token(Token = "0x4003B5E")]
	[FieldOffset(Offset = "0x18")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x505E8", Offset = "0x505E8")]
	private Action<Collision2D> m_OnCollisionEnter2DEvent;

	[Token(Token = "0x14000069")]
	public event Action<Collision2D> OnCollisionEnter2DEvent
	{
		[Token(Token = "0x60032F8")]
		[Address(RVA = "0x1599410", Offset = "0x1599410", VA = "0x1599410")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6A174", Offset = "0x6A174")]
		add
		{
		}
		[Token(Token = "0x60032F9")]
		[Address(RVA = "0x15994B4", Offset = "0x15994B4", VA = "0x15994B4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6A184", Offset = "0x6A184")]
		remove
		{
		}
	}

	[Token(Token = "0x60032FA")]
	[Address(RVA = "0x1599558", Offset = "0x1599558", VA = "0x1599558")]
	public void OnCollisionEnter2D(Collision2D other)
	{
	}

	[Token(Token = "0x60032FB")]
	[Address(RVA = "0x15995C8", Offset = "0x15995C8", VA = "0x15995C8")]
	public OnCollisionEnter2DHandler()
	{
	}
}
