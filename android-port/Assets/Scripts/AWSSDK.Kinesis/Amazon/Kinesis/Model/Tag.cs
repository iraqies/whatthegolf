using Il2CppDummyDll;

namespace Amazon.Kinesis.Model
{
	[Token(Token = "0x2000059")]
	public class Tag
	{
		[Token(Token = "0x40000B0")]
		[FieldOffset(Offset = "0x10")]
		private string _key;

		[Token(Token = "0x40000B1")]
		[FieldOffset(Offset = "0x18")]
		private string _value;

		[Token(Token = "0x1700009A")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x30748", Offset = "0x30748")]
		public string Key
		{
			[Token(Token = "0x60002CC")]
			[Address(RVA = "0x12CD6F8", Offset = "0x12CD6F8", VA = "0x12CD6F8")]
			get
			{
				return null;
			}
			[Token(Token = "0x60002CD")]
			[Address(RVA = "0x12CD700", Offset = "0x12CD700", VA = "0x12CD700")]
			set
			{
			}
		}

		[Token(Token = "0x1700009B")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x30798", Offset = "0x30798")]
		public string Value
		{
			[Token(Token = "0x60002CF")]
			[Address(RVA = "0x12CD718", Offset = "0x12CD718", VA = "0x12CD718")]
			get
			{
				return null;
			}
			[Token(Token = "0x60002D0")]
			[Address(RVA = "0x12CD720", Offset = "0x12CD720", VA = "0x12CD720")]
			set
			{
			}
		}

		[Token(Token = "0x60002CE")]
		[Address(RVA = "0x12CD708", Offset = "0x12CD708", VA = "0x12CD708")]
		internal bool IsSetKey()
		{
			return default;
		}

		[Token(Token = "0x60002D1")]
		[Address(RVA = "0x12CD728", Offset = "0x12CD728", VA = "0x12CD728")]
		internal bool IsSetValue()
		{
			return default;
		}

		[Token(Token = "0x60002D2")]
		[Address(RVA = "0x12CD738", Offset = "0x12CD738", VA = "0x12CD738")]
		public Tag()
		{
		}
	}
}
