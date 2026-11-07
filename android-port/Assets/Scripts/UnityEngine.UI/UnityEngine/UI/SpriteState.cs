using System;
using Il2CppDummyDll;

namespace UnityEngine.UI
{
	[Serializable]
	[Token(Token = "0x2000063")]
	public struct SpriteState : IEquatable<SpriteState>
	{
		[Token(Token = "0x400020A")]
		[FieldOffset(Offset = "0x0")]
		[SerializeField]
		private Sprite m_HighlightedSprite;

		[Token(Token = "0x400020B")]
		[FieldOffset(Offset = "0x8")]
		[SerializeField]
		private Sprite m_PressedSprite;

		[Token(Token = "0x400020C")]
		[FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x1F8330", Offset = "0x1F8330")]
		[SerializeField]
		private Sprite m_SelectedSprite;

		[Token(Token = "0x400020D")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Sprite m_DisabledSprite;

		[Token(Token = "0x1700012E")]
		public Sprite highlightedSprite
		{
			[Token(Token = "0x6000458")]
			[Address(RVA = "0x2C3C550", Offset = "0x2C3C550", VA = "0x2C3C550")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700012F")]
		public Sprite pressedSprite
		{
			[Token(Token = "0x6000459")]
			[Address(RVA = "0x2C3C558", Offset = "0x2C3C558", VA = "0x2C3C558")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000130")]
		public Sprite selectedSprite
		{
			[Token(Token = "0x600045A")]
			[Address(RVA = "0x2C3C560", Offset = "0x2C3C560", VA = "0x2C3C560")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000131")]
		public Sprite disabledSprite
		{
			[Token(Token = "0x600045B")]
			[Address(RVA = "0x2C3C568", Offset = "0x2C3C568", VA = "0x2C3C568")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600045C")]
		[Address(RVA = "0x2C3C570", Offset = "0x2C3C570", VA = "0x2C3C570", Slot = "4")]
		public bool Equals(SpriteState other)
		{
			return default;
		}
	}
}
