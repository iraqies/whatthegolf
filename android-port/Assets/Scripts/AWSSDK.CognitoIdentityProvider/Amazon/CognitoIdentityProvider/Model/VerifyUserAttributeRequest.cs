using Amazon.Runtime.Internal.Auth;
using Il2CppDummyDll;

namespace Amazon.CognitoIdentityProvider.Model
{
	[Token(Token = "0x2000150")]
	public class VerifyUserAttributeRequest : AmazonCognitoIdentityProviderRequest
	{
		[Token(Token = "0x4000367")]
		[FieldOffset(Offset = "0x30")]
		private string _accessToken;

		[Token(Token = "0x4000368")]
		[FieldOffset(Offset = "0x38")]
		private string _attributeName;

		[Token(Token = "0x4000369")]
		[FieldOffset(Offset = "0x40")]
		private string _code;

		[Token(Token = "0x170002F4")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x2207C", Offset = "0x2207C")]
		public string AccessToken
		{
			[Token(Token = "0x6000C64")]
			[Address(RVA = "0x117CAF4", Offset = "0x117CAF4", VA = "0x117CAF4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000C65")]
			[Address(RVA = "0x117CAFC", Offset = "0x117CAFC", VA = "0x117CAFC")]
			set
			{
			}
		}

		[Token(Token = "0x170002F5")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x220B0", Offset = "0x220B0")]
		public string AttributeName
		{
			[Token(Token = "0x6000C67")]
			[Address(RVA = "0x117CB14", Offset = "0x117CB14", VA = "0x117CB14")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000C68")]
			[Address(RVA = "0x117CB1C", Offset = "0x117CB1C", VA = "0x117CB1C")]
			set
			{
			}
		}

		[Token(Token = "0x170002F6")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x22100", Offset = "0x22100")]
		public string Code
		{
			[Token(Token = "0x6000C6A")]
			[Address(RVA = "0x117CB34", Offset = "0x117CB34", VA = "0x117CB34")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000C6B")]
			[Address(RVA = "0x117CB3C", Offset = "0x117CB3C", VA = "0x117CB3C")]
			set
			{
			}
		}

		[Token(Token = "0x6000C66")]
		[Address(RVA = "0x117CB04", Offset = "0x117CB04", VA = "0x117CB04")]
		internal bool IsSetAccessToken()
		{
			return default;
		}

		[Token(Token = "0x6000C69")]
		[Address(RVA = "0x117CB24", Offset = "0x117CB24", VA = "0x117CB24")]
		internal bool IsSetAttributeName()
		{
			return default;
		}

		[Token(Token = "0x6000C6C")]
		[Address(RVA = "0x117CB44", Offset = "0x117CB44", VA = "0x117CB44")]
		internal bool IsSetCode()
		{
			return default;
		}

		[Token(Token = "0x6000C6D")]
		[Address(RVA = "0x117CB54", Offset = "0x117CB54", VA = "0x117CB54", Slot = "13")]
		protected override AbstractAWSSigner CreateSigner()
		{
			return null;
		}

		[Token(Token = "0x6000C6E")]
		[Address(RVA = "0x117CBAC", Offset = "0x117CBAC", VA = "0x117CBAC")]
		public VerifyUserAttributeRequest()
		{
		}
	}
}
