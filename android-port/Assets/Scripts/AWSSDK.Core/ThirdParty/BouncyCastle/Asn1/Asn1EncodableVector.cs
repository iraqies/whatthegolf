using System.Collections;
using Il2CppDummyDll;

namespace ThirdParty.BouncyCastle.Asn1
{
	[Token(Token = "0x200000C")]
	[Attribute(Name = "DefaultMemberAttribute", RVA = "0x25608", Offset = "0x25608")]
	public class Asn1EncodableVector : IEnumerable
	{
		[Token(Token = "0x4000019")]
		[FieldOffset(Offset = "0x10")]
		private IList v;

		// C# has no syntax for parameterized property 'Item'.
		// Its 'property:' attributes below are ignored by the compiler (CS0657).
		[property: Token(Token = "0x17000008")]
		[Token(Token = "0x6000043")]
		[Address(RVA = "0x11CFDCC", Offset = "0x11CFDCC", VA = "0x11CFDCC")]
		public Asn1Encodable get_Item(int index)
		{
			return null;
		}

		[Token(Token = "0x17000009")]
		[Attribute(Name = "ObsoleteAttribute", RVA = "0x2C2EC", Offset = "0x2C2EC")]
		public int Size
		{
			[Token(Token = "0x6000045")]
			[Address(RVA = "0x11CFEF8", Offset = "0x11CFEF8", VA = "0x11CFEF8")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x1700000A")]
		public int Count
		{
			[Token(Token = "0x6000046")]
			[Address(RVA = "0x11CFFB0", Offset = "0x11CFFB0", VA = "0x11CFFB0")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x600003F")]
		[Address(RVA = "0x11CF690", Offset = "0x11CF690", VA = "0x11CF690")]
		public static Asn1EncodableVector FromEnumerable(IEnumerable e)
		{
			return null;
		}

		[Token(Token = "0x6000040")]
		[Address(RVA = "0x11CFB34", Offset = "0x11CFB34", VA = "0x11CFB34")]
		public Asn1EncodableVector(params Asn1Encodable[] v)
		{
		}

		[Token(Token = "0x6000041")]
		[Address(RVA = "0x11CFB74", Offset = "0x11CFB74", VA = "0x11CFB74")]
		public void Add(params Asn1Encodable[] objs)
		{
		}

		[Token(Token = "0x6000042")]
		[Address(RVA = "0x11CFCA0", Offset = "0x11CFCA0", VA = "0x11CFCA0")]
		public void AddOptional(params Asn1Encodable[] objs)
		{
		}

		[Token(Token = "0x6000044")]
		[Address(RVA = "0x11CFEF4", Offset = "0x11CFEF4", VA = "0x11CFEF4")]
		[Attribute(Name = "ObsoleteAttribute", RVA = "0x27CE8", Offset = "0x27CE8")]
		public Asn1Encodable Get(int index)
		{
			return null;
		}

		[Token(Token = "0x6000047")]
		[Address(RVA = "0x11D0068", Offset = "0x11D0068", VA = "0x11D0068", Slot = "4")]
		public IEnumerator GetEnumerator()
		{
			return null;
		}
	}
}
