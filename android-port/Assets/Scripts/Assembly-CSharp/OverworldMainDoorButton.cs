using System;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000A0F")]
public class OverworldMainDoorButton : MonoBehaviour
{
	[Token(Token = "0x400377E")]
	[FieldOffset(Offset = "0x18")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x501E4", Offset = "0x501E4")]
	private Action<OverworldBall2D> m_OnHitWhenInactive;

	[Token(Token = "0x400377F")]
	[FieldOffset(Offset = "0x20")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x501F4", Offset = "0x501F4")]
	private Action<OverworldBall2D> m_OnHitWhenActive;

	[Token(Token = "0x4003780")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private SpriteRenderer spriteRenderer;

	[Token(Token = "0x4003781")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private Sprite inactiveSprite;

	[Token(Token = "0x4003782")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	private Sprite activeSprite;

	[Token(Token = "0x4003783")]
	[FieldOffset(Offset = "0x40")]
	private bool isActive;

	[Token(Token = "0x170004E5")]
	public bool IsActive
	{
		[Token(Token = "0x6002FBA")]
		[Address(RVA = "0x15BD868", Offset = "0x15BD868", VA = "0x15BD868")]
		set
		{
		}
	}

	[Token(Token = "0x1400005F")]
	public event Action<OverworldBall2D> OnHitWhenInactive
	{
		[Token(Token = "0x6002FB5")]
		[Address(RVA = "0x15BD490", Offset = "0x15BD490", VA = "0x15BD490")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x68FA8", Offset = "0x68FA8")]
		add
		{
		}
		[Token(Token = "0x6002FB6")]
		[Address(RVA = "0x15BD534", Offset = "0x15BD534", VA = "0x15BD534")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x68FB8", Offset = "0x68FB8")]
		remove
		{
		}
	}

	[Token(Token = "0x14000060")]
	public event Action<OverworldBall2D> OnHitWhenActive
	{
		[Token(Token = "0x6002FB7")]
		[Address(RVA = "0x15BD5D8", Offset = "0x15BD5D8", VA = "0x15BD5D8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x68FC8", Offset = "0x68FC8")]
		add
		{
		}
		[Token(Token = "0x6002FB8")]
		[Address(RVA = "0x15BD67C", Offset = "0x15BD67C", VA = "0x15BD67C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x68FD8", Offset = "0x68FD8")]
		remove
		{
		}
	}

	[Token(Token = "0x6002FB9")]
	[Address(RVA = "0x15BD720", Offset = "0x15BD720", VA = "0x15BD720")]
	private void OnCollisionEnter2D(Collision2D collision)
	{
	}

	[Token(Token = "0x6002FBB")]
	[Address(RVA = "0x15BD8A0", Offset = "0x15BD8A0", VA = "0x15BD8A0")]
	private void Refresh()
	{
	}

	[Token(Token = "0x6002FBC")]
	[Address(RVA = "0x15BD8D8", Offset = "0x15BD8D8", VA = "0x15BD8D8")]
	public OverworldMainDoorButton()
	{
	}
}
