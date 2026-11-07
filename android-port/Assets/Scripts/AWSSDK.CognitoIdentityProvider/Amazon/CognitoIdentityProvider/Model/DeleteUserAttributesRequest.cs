using System.Collections.Generic;
using Amazon.Runtime.Internal.Auth;
using Il2CppDummyDll;

namespace Amazon.CognitoIdentityProvider.Model
{
	[Token(Token = "0x2000090")]
	public class DeleteUserAttributesRequest : AmazonCognitoIdentityProviderRequest
	{
		[Token(Token = "0x4000183")]
		[FieldOffset(Offset = "0x30")]
		private string _accessToken;

		[Token(Token = "0x4000184")]
		[FieldOffset(Offset = "0x38")]
		private List<string> _userAttributeNames;

		[Token(Token = "0x17000110")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x1D920", Offset = "0x1D920")]
		public string AccessToken
		{
			[Token(Token = "0x6000569")]
			[Address(RVA = "0x10FE104", Offset = "0x10FE104", VA = "0x10FE104")]
			get
			{
				return null;
			}
			[Token(Token = "0x600056A")]
			[Address(RVA = "0x10FE10C", Offset = "0x10FE10C", VA = "0x10FE10C")]
			set
			{
			}
		}

		[Token(Token = "0x17000111")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x1D954", Offset = "0x1D954")]
		public List<string> UserAttributeNames
		{
			[Token(Token = "0x600056C")]
			[Address(RVA = "0x10FE124", Offset = "0x10FE124", VA = "0x10FE124")]
			get
			{
				return null;
			}
			[Token(Token = "0x600056D")]
			[Address(RVA = "0x10FE12C", Offset = "0x10FE12C", VA = "0x10FE12C")]
			set
			{
			}
		}

		[Token(Token = "0x600056B")]
		[Address(RVA = "0x10FE114", Offset = "0x10FE114", VA = "0x10FE114")]
		internal bool IsSetAccessToken()
		{
			return default;
		}

		[Token(Token = "0x600056E")]
		[Address(RVA = "0x10FE134", Offset = "0x10FE134", VA = "0x10FE134")]
		internal bool IsSetUserAttributeNames()
		{
			return default;
		}

		[Token(Token = "0x600056F")]
		[Address(RVA = "0x10FE18C", Offset = "0x10FE18C", VA = "0x10FE18C", Slot = "13")]
		protected override AbstractAWSSigner CreateSigner()
		{
			return null;
		}

		[Token(Token = "0x6000570")]
		[Address(RVA = "0x10FE1E4", Offset = "0x10FE1E4", VA = "0x10FE1E4")]
		public DeleteUserAttributesRequest()
		{
		}
	}
}
