using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000782")]
public class HoleInOneTransition : MonoBehaviour
{
	[Token(Token = "0x2000783")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x414D0", Offset = "0x414D0")]
	private sealed class _003C_003Ec__DisplayClass12_0
	{
		[Token(Token = "0x40027BE")]
		[FieldOffset(Offset = "0x10")]
		public HoleInOneTransition _003C_003E4__this;

		[Token(Token = "0x40027BF")]
		[FieldOffset(Offset = "0x18")]
		public Action onClear;

		[Token(Token = "0x6002287")]
		[Address(RVA = "0x17BD9E8", Offset = "0x17BD9E8", VA = "0x17BD9E8")]
		public _003C_003Ec__DisplayClass12_0()
		{
		}

		[Token(Token = "0x6002288")]
		[Address(RVA = "0x17BD9F0", Offset = "0x17BD9F0", VA = "0x17BD9F0")]
		internal void _003CStarTransition_003Eb__0(float t)
		{
		}

		[Token(Token = "0x6002289")]
		[Address(RVA = "0x17BDA4C", Offset = "0x17BDA4C", VA = "0x17BDA4C")]
		internal void _003CStarTransition_003Eb__1()
		{
		}

		[Token(Token = "0x600228A")]
		[Address(RVA = "0x17BDA68", Offset = "0x17BDA68", VA = "0x17BDA68")]
		internal void _003CStarTransition_003Eb__2(AudioSource s)
		{
		}

		[Token(Token = "0x600228B")]
		[Address(RVA = "0x17BDA94", Offset = "0x17BDA94", VA = "0x17BDA94")]
		internal void _003CStarTransition_003Eb__3(AudioSource s)
		{
		}
	}

	[Token(Token = "0x2000784")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x414E0", Offset = "0x414E0")]
	private sealed class _003C_003Ec__DisplayClass13_0
	{
		[Token(Token = "0x40027C0")]
		[FieldOffset(Offset = "0x10")]
		public HoleInOneTransition _003C_003E4__this;

		[Token(Token = "0x40027C1")]
		[FieldOffset(Offset = "0x18")]
		public Action onCompleted;

		[Token(Token = "0x600228C")]
		[Address(RVA = "0x17BDAC0", Offset = "0x17BDAC0", VA = "0x17BDAC0")]
		public _003C_003Ec__DisplayClass13_0()
		{
		}

		[Token(Token = "0x600228D")]
		[Address(RVA = "0x17BDAC8", Offset = "0x17BDAC8", VA = "0x17BDAC8")]
		internal void _003CEndTransition_003Eb__0(float s)
		{
		}

		[Token(Token = "0x600228E")]
		[Address(RVA = "0x17BDB70", Offset = "0x17BDB70", VA = "0x17BDB70")]
		internal void _003CEndTransition_003Eb__1()
		{
		}

		[Token(Token = "0x600228F")]
		[Address(RVA = "0x17BDB8C", Offset = "0x17BDB8C", VA = "0x17BDB8C")]
		internal void _003CEndTransition_003Eb__2()
		{
		}
	}

	[Token(Token = "0x40027B4")]
	[FieldOffset(Offset = "0x18")]
	public AudioClip sfxWin;

	[Token(Token = "0x40027B5")]
	[FieldOffset(Offset = "0x20")]
	public AudioClip sfxLost;

	[Token(Token = "0x40027B6")]
	[FieldOffset(Offset = "0x28")]
	public float volume;

	[Token(Token = "0x40027B7")]
	[FieldOffset(Offset = "0x2C")]
	public Color winColor;

	[Token(Token = "0x40027B8")]
	[FieldOffset(Offset = "0x3C")]
	public Color loseColor;

	[Token(Token = "0x40027B9")]
	[FieldOffset(Offset = "0x4C")]
	public float inScale;

	[Token(Token = "0x40027BA")]
	[FieldOffset(Offset = "0x50")]
	public float outScale;

	[Token(Token = "0x40027BB")]
	[FieldOffset(Offset = "0x58")]
	public SpriteRenderer endCoverSprite;

	[Token(Token = "0x40027BC")]
	[FieldOffset(Offset = "0x60")]
	private List<SpriteRenderer> sprites;

	[Token(Token = "0x40027BD")]
	[FieldOffset(Offset = "0x68")]
	private Vector3 basePosition;

	[Token(Token = "0x6002282")]
	[Address(RVA = "0x14CF5E8", Offset = "0x14CF5E8", VA = "0x14CF5E8")]
	public void InstantIn()
	{
	}

	[Token(Token = "0x6002283")]
	[Address(RVA = "0x14CF7D8", Offset = "0x14CF7D8", VA = "0x14CF7D8")]
	private void Awake()
	{
	}

	[Token(Token = "0x6002284")]
	[Address(RVA = "0x14CF98C", Offset = "0x14CF98C", VA = "0x14CF98C")]
	public void StarTransition(Vector3 pos, bool isWon, Action onClear)
	{
	}

	[Token(Token = "0x6002285")]
	[Address(RVA = "0x14CFDDC", Offset = "0x14CFDDC", VA = "0x14CFDDC")]
	public void EndTransition(Vector3 pos, Action onCompleted)
	{
	}

	[Token(Token = "0x6002286")]
	[Address(RVA = "0x14CFFC0", Offset = "0x14CFFC0", VA = "0x14CFFC0")]
	public HoleInOneTransition()
	{
	}
}
