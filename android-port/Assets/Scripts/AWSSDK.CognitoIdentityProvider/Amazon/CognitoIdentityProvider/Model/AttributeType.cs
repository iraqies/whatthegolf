using Il2CppDummyDll;

namespace Amazon.CognitoIdentityProvider.Model
{
	[Token(Token = "0x2000068")]
	public class AttributeType
	{
		[Token(Token = "0x4000106")]
		[FieldOffset(Offset = "0x10")]
		private string _name;

		[Token(Token = "0x4000107")]
		[FieldOffset(Offset = "0x18")]
		private string _value;

		[Token(Token = "0x17000093")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x1C680", Offset = "0x1C680")]
		public string Name
		{
			[Token(Token = "0x60003BB")]
			[Address(RVA = "0x10DE638", Offset = "0x10DE638", VA = "0x10DE638")]
			get
			{
				return null;
			}
			[Token(Token = "0x60003BC")]
			[Address(RVA = "0x10DE640", Offset = "0x10DE640", VA = "0x10DE640")]
			set
			{
			}
		}

		[Token(Token = "0x17000094")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x1C6D0", Offset = "0x1C6D0")]
		public string Value
		{
			[Token(Token = "0x60003BE")]
			[Address(RVA = "0x10DE658", Offset = "0x10DE658", VA = "0x10DE658")]
			get
			{
				return null;
			}
			[Token(Token = "0x60003BF")]
			[Address(RVA = "0x10DE660", Offset = "0x10DE660", VA = "0x10DE660")]
			set
			{
			}
		}

		[Token(Token = "0x60003BD")]
		[Address(RVA = "0x10DE648", Offset = "0x10DE648", VA = "0x10DE648")]
		internal bool IsSetName()
		{
			return default;
		}

		[Token(Token = "0x60003C0")]
		[Address(RVA = "0x10DE668", Offset = "0x10DE668", VA = "0x10DE668")]
		internal bool IsSetValue()
		{
			return default;
		}

		[Token(Token = "0x60003C1")]
		[Address(RVA = "0x10DE678", Offset = "0x10DE678", VA = "0x10DE678")]
		public AttributeType()
		{
		}
	}
}
