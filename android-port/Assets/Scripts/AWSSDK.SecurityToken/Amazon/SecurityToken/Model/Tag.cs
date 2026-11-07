using Il2CppDummyDll;

namespace Amazon.SecurityToken.Model
{
	[Token(Token = "0x2000031")]
	public class Tag
	{
		[Token(Token = "0x4000066")]
		[FieldOffset(Offset = "0x10")]
		private string _key;

		[Token(Token = "0x4000067")]
		[FieldOffset(Offset = "0x18")]
		private string _value;

		[Token(Token = "0x17000051")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x317CC", Offset = "0x317CC")]
		public string Key
		{
			[Token(Token = "0x6000188")]
			[Address(RVA = "0x12E692C", Offset = "0x12E692C", VA = "0x12E692C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000189")]
			[Address(RVA = "0x12E6934", Offset = "0x12E6934", VA = "0x12E6934")]
			set
			{
			}
		}

		[Token(Token = "0x17000052")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x3181C", Offset = "0x3181C")]
		public string Value
		{
			[Token(Token = "0x600018B")]
			[Address(RVA = "0x12E693C", Offset = "0x12E693C", VA = "0x12E693C")]
			get
			{
				return null;
			}
			[Token(Token = "0x600018C")]
			[Address(RVA = "0x12E6944", Offset = "0x12E6944", VA = "0x12E6944")]
			set
			{
			}
		}

		[Token(Token = "0x600018A")]
		[Address(RVA = "0x12D6A2C", Offset = "0x12D6A2C", VA = "0x12D6A2C")]
		internal bool IsSetKey()
		{
			return default;
		}

		[Token(Token = "0x600018D")]
		[Address(RVA = "0x12D6A3C", Offset = "0x12D6A3C", VA = "0x12D6A3C")]
		internal bool IsSetValue()
		{
			return default;
		}

		[Token(Token = "0x600018E")]
		[Address(RVA = "0x12E694C", Offset = "0x12E694C", VA = "0x12E694C")]
		public Tag()
		{
		}
	}
}
