using Il2CppDummyDll;

namespace Amazon.CognitoIdentityProvider.Model
{
	[Token(Token = "0x20000FC")]
	public class ProviderUserIdentifierType
	{
		[Token(Token = "0x400025A")]
		[FieldOffset(Offset = "0x10")]
		private string _providerAttributeName;

		[Token(Token = "0x400025B")]
		[FieldOffset(Offset = "0x18")]
		private string _providerAttributeValue;

		[Token(Token = "0x400025C")]
		[FieldOffset(Offset = "0x20")]
		private string _providerName;

		[Token(Token = "0x170001E7")]
		public string ProviderAttributeName
		{
			[Token(Token = "0x60008A8")]
			[Address(RVA = "0x1141BCC", Offset = "0x1141BCC", VA = "0x1141BCC")]
			get
			{
				return null;
			}
			[Token(Token = "0x60008A9")]
			[Address(RVA = "0x1141BD4", Offset = "0x1141BD4", VA = "0x1141BD4")]
			set
			{
			}
		}

		[Token(Token = "0x170001E8")]
		public string ProviderAttributeValue
		{
			[Token(Token = "0x60008AB")]
			[Address(RVA = "0x1141BEC", Offset = "0x1141BEC", VA = "0x1141BEC")]
			get
			{
				return null;
			}
			[Token(Token = "0x60008AC")]
			[Address(RVA = "0x1141BF4", Offset = "0x1141BF4", VA = "0x1141BF4")]
			set
			{
			}
		}

		[Token(Token = "0x170001E9")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x1FC60", Offset = "0x1FC60")]
		public string ProviderName
		{
			[Token(Token = "0x60008AE")]
			[Address(RVA = "0x1141C0C", Offset = "0x1141C0C", VA = "0x1141C0C")]
			get
			{
				return null;
			}
			[Token(Token = "0x60008AF")]
			[Address(RVA = "0x1141C14", Offset = "0x1141C14", VA = "0x1141C14")]
			set
			{
			}
		}

		[Token(Token = "0x60008AA")]
		[Address(RVA = "0x1141BDC", Offset = "0x1141BDC", VA = "0x1141BDC")]
		internal bool IsSetProviderAttributeName()
		{
			return default;
		}

		[Token(Token = "0x60008AD")]
		[Address(RVA = "0x1141BFC", Offset = "0x1141BFC", VA = "0x1141BFC")]
		internal bool IsSetProviderAttributeValue()
		{
			return default;
		}

		[Token(Token = "0x60008B0")]
		[Address(RVA = "0x1141C1C", Offset = "0x1141C1C", VA = "0x1141C1C")]
		internal bool IsSetProviderName()
		{
			return default;
		}

		[Token(Token = "0x60008B1")]
		[Address(RVA = "0x1141C2C", Offset = "0x1141C2C", VA = "0x1141C2C")]
		public ProviderUserIdentifierType()
		{
		}
	}
}
