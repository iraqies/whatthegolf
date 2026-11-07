using Il2CppDummyDll;

namespace Amazon.CognitoIdentityProvider.Model
{
	[Token(Token = "0x200009C")]
	public class DescribeResourceServerRequest : AmazonCognitoIdentityProviderRequest
	{
		[Token(Token = "0x400018E")]
		[FieldOffset(Offset = "0x30")]
		private string _identifier;

		[Token(Token = "0x400018F")]
		[FieldOffset(Offset = "0x38")]
		private string _userPoolId;

		[Token(Token = "0x1700011B")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x1DC20", Offset = "0x1DC20")]
		public string Identifier
		{
			[Token(Token = "0x6000598")]
			[Address(RVA = "0x1106268", Offset = "0x1106268", VA = "0x1106268")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000599")]
			[Address(RVA = "0x1106270", Offset = "0x1106270", VA = "0x1106270")]
			set
			{
			}
		}

		[Token(Token = "0x1700011C")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x1DC70", Offset = "0x1DC70")]
		public string UserPoolId
		{
			[Token(Token = "0x600059B")]
			[Address(RVA = "0x1106288", Offset = "0x1106288", VA = "0x1106288")]
			get
			{
				return null;
			}
			[Token(Token = "0x600059C")]
			[Address(RVA = "0x1106290", Offset = "0x1106290", VA = "0x1106290")]
			set
			{
			}
		}

		[Token(Token = "0x600059A")]
		[Address(RVA = "0x1106278", Offset = "0x1106278", VA = "0x1106278")]
		internal bool IsSetIdentifier()
		{
			return default;
		}

		[Token(Token = "0x600059D")]
		[Address(RVA = "0x1106298", Offset = "0x1106298", VA = "0x1106298")]
		internal bool IsSetUserPoolId()
		{
			return default;
		}

		[Token(Token = "0x600059E")]
		[Address(RVA = "0x11062A8", Offset = "0x11062A8", VA = "0x11062A8")]
		public DescribeResourceServerRequest()
		{
		}
	}
}
