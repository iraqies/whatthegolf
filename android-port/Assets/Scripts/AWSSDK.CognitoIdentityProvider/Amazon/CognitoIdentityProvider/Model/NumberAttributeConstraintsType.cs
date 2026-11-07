using Il2CppDummyDll;

namespace Amazon.CognitoIdentityProvider.Model
{
	[Token(Token = "0x20000F7")]
	public class NumberAttributeConstraintsType
	{
		[Token(Token = "0x400024E")]
		[FieldOffset(Offset = "0x10")]
		private string _maxValue;

		[Token(Token = "0x400024F")]
		[FieldOffset(Offset = "0x18")]
		private string _minValue;

		[Token(Token = "0x170001DB")]
		public string MaxValue
		{
			[Token(Token = "0x6000877")]
			[Address(RVA = "0x113F23C", Offset = "0x113F23C", VA = "0x113F23C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000878")]
			[Address(RVA = "0x113F244", Offset = "0x113F244", VA = "0x113F244")]
			set
			{
			}
		}

		[Token(Token = "0x170001DC")]
		public string MinValue
		{
			[Token(Token = "0x600087A")]
			[Address(RVA = "0x113F25C", Offset = "0x113F25C", VA = "0x113F25C")]
			get
			{
				return null;
			}
			[Token(Token = "0x600087B")]
			[Address(RVA = "0x113F264", Offset = "0x113F264", VA = "0x113F264")]
			set
			{
			}
		}

		[Token(Token = "0x6000879")]
		[Address(RVA = "0x113F24C", Offset = "0x113F24C", VA = "0x113F24C")]
		internal bool IsSetMaxValue()
		{
			return default;
		}

		[Token(Token = "0x600087C")]
		[Address(RVA = "0x113F26C", Offset = "0x113F26C", VA = "0x113F26C")]
		internal bool IsSetMinValue()
		{
			return default;
		}

		[Token(Token = "0x600087D")]
		[Address(RVA = "0x113F27C", Offset = "0x113F27C", VA = "0x113F27C")]
		public NumberAttributeConstraintsType()
		{
		}
	}
}
