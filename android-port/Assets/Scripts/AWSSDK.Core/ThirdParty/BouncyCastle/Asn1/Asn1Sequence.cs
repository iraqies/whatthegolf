using System.Collections;
using Il2CppDummyDll;

namespace ThirdParty.BouncyCastle.Asn1
{
	[Token(Token = "0x200000F")]
	[Attribute(Name = "DefaultMemberAttribute", RVA = "0x25640", Offset = "0x25640")]
	public abstract class Asn1Sequence : Asn1Object, IEnumerable
	{
		[Token(Token = "0x400001D")]
		[FieldOffset(Offset = "0x10")]
		private readonly IList seq;

		// C# has no syntax for parameterized property 'Item'.
		// Its 'property:' attributes below are ignored by the compiler (CS0657).
		[property: Token(Token = "0x1700000B")]
		[Token(Token = "0x600005B")]
		[Address(RVA = "0x11D0F74", Offset = "0x11D0F74", VA = "0x11D0F74", Slot = "7")]
		public virtual Asn1Encodable get_Item(int index)
		{
			return null;
		}

		[Token(Token = "0x1700000C")]
		[Attribute(Name = "ObsoleteAttribute", RVA = "0x2C324", Offset = "0x2C324")]
		public int Size
		{
			[Token(Token = "0x600005D")]
			[Address(RVA = "0x11D10A8", Offset = "0x11D10A8", VA = "0x11D10A8")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x1700000D")]
		public virtual int Count
		{
			[Token(Token = "0x600005E")]
			[Address(RVA = "0x11D10B4", Offset = "0x11D10B4", VA = "0x11D10B4", Slot = "8")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x6000058")]
		[Address(RVA = "0x11D0E7C", Offset = "0x11D0E7C", VA = "0x11D0E7C")]
		protected internal Asn1Sequence(int capacity)
		{
		}

		[Token(Token = "0x6000059")]
		[Address(RVA = "0x11D0EB4", Offset = "0x11D0EB4", VA = "0x11D0EB4", Slot = "6")]
		public virtual IEnumerator GetEnumerator()
		{
			return null;
		}

		[Token(Token = "0x600005A")]
		[Address(RVA = "0x11D0F68", Offset = "0x11D0F68", VA = "0x11D0F68")]
		[Attribute(Name = "ObsoleteAttribute", RVA = "0x27D20", Offset = "0x27D20")]
		public IEnumerator GetObjects()
		{
			return null;
		}

		[Token(Token = "0x600005C")]
		[Address(RVA = "0x11D109C", Offset = "0x11D109C", VA = "0x11D109C")]
		[Attribute(Name = "ObsoleteAttribute", RVA = "0x27D58", Offset = "0x27D58")]
		public Asn1Encodable GetObjectAt(int index)
		{
			return null;
		}

		[Token(Token = "0x600005F")]
		[Address(RVA = "0x11D116C", Offset = "0x11D116C", VA = "0x11D116C")]
		private Asn1Encodable GetCurrent(IEnumerator e)
		{
			return null;
		}

		[Token(Token = "0x6000060")]
		[Address(RVA = "0x11D1284", Offset = "0x11D1284", VA = "0x11D1284")]
		protected internal void AddObject(Asn1Encodable obj)
		{
		}
	}
}
