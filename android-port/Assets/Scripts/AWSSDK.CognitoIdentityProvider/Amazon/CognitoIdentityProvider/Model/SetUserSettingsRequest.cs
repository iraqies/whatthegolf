using System.Collections.Generic;
using Amazon.Runtime.Internal.Auth;
using Il2CppDummyDll;

namespace Amazon.CognitoIdentityProvider.Model
{
	[Token(Token = "0x2000111")]
	public class SetUserSettingsRequest : AmazonCognitoIdentityProviderRequest
	{
		[Token(Token = "0x400029B")]
		[FieldOffset(Offset = "0x30")]
		private string _accessToken;

		[Token(Token = "0x400029C")]
		[FieldOffset(Offset = "0x38")]
		private List<MFAOptionType> _mfaOptions;

		[Token(Token = "0x17000228")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x2043C", Offset = "0x2043C")]
		public string AccessToken
		{
			[Token(Token = "0x600098A")]
			[Address(RVA = "0x1152278", Offset = "0x1152278", VA = "0x1152278")]
			get
			{
				return null;
			}
			[Token(Token = "0x600098B")]
			[Address(RVA = "0x1152280", Offset = "0x1152280", VA = "0x1152280")]
			set
			{
			}
		}

		[Token(Token = "0x17000229")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x20470", Offset = "0x20470")]
		public List<MFAOptionType> MFAOptions
		{
			[Token(Token = "0x600098D")]
			[Address(RVA = "0x1152298", Offset = "0x1152298", VA = "0x1152298")]
			get
			{
				return null;
			}
			[Token(Token = "0x600098E")]
			[Address(RVA = "0x11522A0", Offset = "0x11522A0", VA = "0x11522A0")]
			set
			{
			}
		}

		[Token(Token = "0x600098C")]
		[Address(RVA = "0x1152288", Offset = "0x1152288", VA = "0x1152288")]
		internal bool IsSetAccessToken()
		{
			return default;
		}

		[Token(Token = "0x600098F")]
		[Address(RVA = "0x11522A8", Offset = "0x11522A8", VA = "0x11522A8")]
		internal bool IsSetMFAOptions()
		{
			return default;
		}

		[Token(Token = "0x6000990")]
		[Address(RVA = "0x1152300", Offset = "0x1152300", VA = "0x1152300", Slot = "13")]
		protected override AbstractAWSSigner CreateSigner()
		{
			return null;
		}

		[Token(Token = "0x6000991")]
		[Address(RVA = "0x1152358", Offset = "0x1152358", VA = "0x1152358")]
		public SetUserSettingsRequest()
		{
		}
	}
}
