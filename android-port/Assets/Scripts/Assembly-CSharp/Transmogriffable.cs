using System;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000AD7")]
public class Transmogriffable : MonoBehaviour
{
	[Serializable]
	[Token(Token = "0x2000AD8")]
	public class TransmogrifSprites
	{
		[Token(Token = "0x4003C81")]
		[FieldOffset(Offset = "0x10")]
		public Sprite bright;

		[Token(Token = "0x4003C82")]
		[FieldOffset(Offset = "0x18")]
		public Sprite dark;

		[Token(Token = "0x60033D6")]
		[Address(RVA = "0x186BF68", Offset = "0x186BF68", VA = "0x186BF68")]
		public TransmogrifSprites()
		{
		}
	}

	[Token(Token = "0x4003C7D")]
	[FieldOffset(Offset = "0x18")]
	public Transmogrif.BALLSHAPES shape;

	[Token(Token = "0x4003C7E")]
	[FieldOffset(Offset = "0x20")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x506D8", Offset = "0x506D8")]
	private Action<Transmogriffable, Transmogrif> m_OnTransmogriffed;

	[Token(Token = "0x4003C7F")]
	[FieldOffset(Offset = "0x28")]
	public TransmogrifSprites sprites;

	[Token(Token = "0x4003C80")]
	[FieldOffset(Offset = "0x30")]
	public float nextTransmogrifTime;

	[Token(Token = "0x1400006E")]
	public event Action<Transmogriffable, Transmogrif> OnTransmogriffed
	{
		[Token(Token = "0x60033D0")]
		[Address(RVA = "0x172CBD4", Offset = "0x172CBD4", VA = "0x172CBD4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6A5E8", Offset = "0x6A5E8")]
		add
		{
		}
		[Token(Token = "0x60033D1")]
		[Address(RVA = "0x172CC78", Offset = "0x172CC78", VA = "0x172CC78")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6A5F8", Offset = "0x6A5F8")]
		remove
		{
		}
	}

	[Token(Token = "0x60033D2")]
	[Address(RVA = "0x172CD1C", Offset = "0x172CD1C", VA = "0x172CD1C")]
	public void Init()
	{
	}

	[Token(Token = "0x60033D3")]
	[Address(RVA = "0x172CD54", Offset = "0x172CD54", VA = "0x172CD54")]
	public void TransmogrifBall(Transmogriffable ball, Transmogrif grif)
	{
	}

	[Token(Token = "0x60033D4")]
	[Address(RVA = "0x172CDCC", Offset = "0x172CDCC", VA = "0x172CDCC")]
	private void OnTriggerEnter2D(Collider2D collision)
	{
	}

	[Token(Token = "0x60033D5")]
	[Address(RVA = "0x172CEE0", Offset = "0x172CEE0", VA = "0x172CEE0")]
	public Transmogriffable()
	{
	}
}
