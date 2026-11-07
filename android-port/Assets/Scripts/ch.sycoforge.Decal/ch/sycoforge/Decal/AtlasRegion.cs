using System;
using Il2CppDummyDll;
using UnityEngine;

namespace ch.sycoforge.Decal
{
	[Serializable]
	[Token(Token = "0x2000002")]
	public class AtlasRegion
	{
		[Token(Token = "0x4000001")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private string name;

		[Token(Token = "0x4000002")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Rect region;

		[Token(Token = "0x17000001")]
		public Rect Region
		{
			[Token(Token = "0x6000001")]
			[Address(RVA = "0x2C55B58", Offset = "0x2C55B58", VA = "0x2C55B58")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000002")]
		public float AspectRatio
		{
			[Token(Token = "0x6000002")]
			[Address(RVA = "0x2C55B64", Offset = "0x2C55B64", VA = "0x2C55B64")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x6000003")]
		[Address(RVA = "0x2C55BBC", Offset = "0x2C55BBC", VA = "0x2C55BBC", Slot = "0")]
		public override bool Equals(object other)
		{
			return default;
		}

		[Token(Token = "0x6000004")]
		[Address(RVA = "0x2C55C54", Offset = "0x2C55C54", VA = "0x2C55C54", Slot = "4")]
		public virtual bool Equals(AtlasRegion other)
		{
			return default;
		}

		[Token(Token = "0x6000005")]
		[Address(RVA = "0x2C55C88", Offset = "0x2C55C88", VA = "0x2C55C88", Slot = "2")]
		public override int GetHashCode()
		{
			return default;
		}

		[Token(Token = "0x6000006")]
		[Address(RVA = "0x2C55C90", Offset = "0x2C55C90", VA = "0x2C55C90")]
		public AtlasRegion()
		{
		}
	}
}
