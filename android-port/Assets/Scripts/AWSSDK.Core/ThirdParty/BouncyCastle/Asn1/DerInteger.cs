using Il2CppDummyDll;
using ThirdParty.BouncyCastle.Math;

namespace ThirdParty.BouncyCastle.Asn1
{
	[Token(Token = "0x2000010")]
	public class DerInteger : Asn1Object
	{
		[Token(Token = "0x400001E")]
		[FieldOffset(Offset = "0x10")]
		private readonly byte[] bytes;

		[Token(Token = "0x1700000E")]
		public byte[] Bytes
		{
			[Token(Token = "0x6000064")]
			[Address(RVA = "0x11F161C", Offset = "0x11F161C", VA = "0x11F161C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700000F")]
		public BigInteger Value
		{
			[Token(Token = "0x6000065")]
			[Address(RVA = "0x11F1624", Offset = "0x11F1624", VA = "0x11F1624")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000061")]
		[Address(RVA = "0x11F14D8", Offset = "0x11F14D8", VA = "0x11F14D8")]
		public DerInteger(int value)
		{
		}

		[Token(Token = "0x6000062")]
		[Address(RVA = "0x11F156C", Offset = "0x11F156C", VA = "0x11F156C")]
		public DerInteger(BigInteger value)
		{
		}

		[Token(Token = "0x6000063")]
		[Address(RVA = "0x11F15F0", Offset = "0x11F15F0", VA = "0x11F15F0")]
		public DerInteger(byte[] bytes)
		{
		}

		[Token(Token = "0x6000066")]
		[Address(RVA = "0x11F1690", Offset = "0x11F1690", VA = "0x11F1690", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
}
