using Il2CppDummyDll;

namespace Amazon.CognitoIdentityProvider.Model
{
	[Token(Token = "0x200011F")]
	public class StringAttributeConstraintsType
	{
		[Token(Token = "0x40002B8")]
		[FieldOffset(Offset = "0x10")]
		private string _maxLength;

		[Token(Token = "0x40002B9")]
		[FieldOffset(Offset = "0x18")]
		private string _minLength;

		[Token(Token = "0x17000245")]
		public string MaxLength
		{
			[Token(Token = "0x60009F5")]
			[Address(RVA = "0x115AD7C", Offset = "0x115AD7C", VA = "0x115AD7C")]
			get
			{
				return null;
			}
			[Token(Token = "0x60009F6")]
			[Address(RVA = "0x115AD84", Offset = "0x115AD84", VA = "0x115AD84")]
			set
			{
			}
		}

		[Token(Token = "0x17000246")]
		public string MinLength
		{
			[Token(Token = "0x60009F8")]
			[Address(RVA = "0x115AD9C", Offset = "0x115AD9C", VA = "0x115AD9C")]
			get
			{
				return null;
			}
			[Token(Token = "0x60009F9")]
			[Address(RVA = "0x115ADA4", Offset = "0x115ADA4", VA = "0x115ADA4")]
			set
			{
			}
		}

		[Token(Token = "0x60009F7")]
		[Address(RVA = "0x115AD8C", Offset = "0x115AD8C", VA = "0x115AD8C")]
		internal bool IsSetMaxLength()
		{
			return default;
		}

		[Token(Token = "0x60009FA")]
		[Address(RVA = "0x115ADAC", Offset = "0x115ADAC", VA = "0x115ADAC")]
		internal bool IsSetMinLength()
		{
			return default;
		}

		[Token(Token = "0x60009FB")]
		[Address(RVA = "0x115ADBC", Offset = "0x115ADBC", VA = "0x115ADBC")]
		public StringAttributeConstraintsType()
		{
		}
	}
}
