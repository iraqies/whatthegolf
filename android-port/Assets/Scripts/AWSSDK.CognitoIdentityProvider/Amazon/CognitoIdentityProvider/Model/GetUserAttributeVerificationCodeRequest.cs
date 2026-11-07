using System.Collections.Generic;
using Amazon.Runtime.Internal.Auth;
using Il2CppDummyDll;

namespace Amazon.CognitoIdentityProvider.Model
{
	[Token(Token = "0x20000C3")]
	public class GetUserAttributeVerificationCodeRequest : AmazonCognitoIdentityProviderRequest
	{
		[Token(Token = "0x40001D9")]
		[FieldOffset(Offset = "0x30")]
		private string _accessToken;

		[Token(Token = "0x40001DA")]
		[FieldOffset(Offset = "0x38")]
		private string _attributeName;

		[Token(Token = "0x40001DB")]
		[FieldOffset(Offset = "0x40")]
		private Dictionary<string, string> _clientMetadata;

		[Token(Token = "0x17000166")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x1E6E4", Offset = "0x1E6E4")]
		public string AccessToken
		{
			[Token(Token = "0x60006AD")]
			[Address(RVA = "0x11209B8", Offset = "0x11209B8", VA = "0x11209B8")]
			get
			{
				return null;
			}
			[Token(Token = "0x60006AE")]
			[Address(RVA = "0x11209C0", Offset = "0x11209C0", VA = "0x11209C0")]
			set
			{
			}
		}

		[Token(Token = "0x17000167")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x1E718", Offset = "0x1E718")]
		public string AttributeName
		{
			[Token(Token = "0x60006B0")]
			[Address(RVA = "0x11209D8", Offset = "0x11209D8", VA = "0x11209D8")]
			get
			{
				return null;
			}
			[Token(Token = "0x60006B1")]
			[Address(RVA = "0x11209E0", Offset = "0x11209E0", VA = "0x11209E0")]
			set
			{
			}
		}

		[Token(Token = "0x17000168")]
		public Dictionary<string, string> ClientMetadata
		{
			[Token(Token = "0x60006B3")]
			[Address(RVA = "0x11209F8", Offset = "0x11209F8", VA = "0x11209F8")]
			get
			{
				return null;
			}
			[Token(Token = "0x60006B4")]
			[Address(RVA = "0x1120A00", Offset = "0x1120A00", VA = "0x1120A00")]
			set
			{
			}
		}

		[Token(Token = "0x60006AF")]
		[Address(RVA = "0x11209C8", Offset = "0x11209C8", VA = "0x11209C8")]
		internal bool IsSetAccessToken()
		{
			return default;
		}

		[Token(Token = "0x60006B2")]
		[Address(RVA = "0x11209E8", Offset = "0x11209E8", VA = "0x11209E8")]
		internal bool IsSetAttributeName()
		{
			return default;
		}

		[Token(Token = "0x60006B5")]
		[Address(RVA = "0x1120A08", Offset = "0x1120A08", VA = "0x1120A08")]
		internal bool IsSetClientMetadata()
		{
			return default;
		}

		[Token(Token = "0x60006B6")]
		[Address(RVA = "0x1120A64", Offset = "0x1120A64", VA = "0x1120A64", Slot = "13")]
		protected override AbstractAWSSigner CreateSigner()
		{
			return null;
		}

		[Token(Token = "0x60006B7")]
		[Address(RVA = "0x1120ABC", Offset = "0x1120ABC", VA = "0x1120ABC")]
		public GetUserAttributeVerificationCodeRequest()
		{
		}
	}
}
