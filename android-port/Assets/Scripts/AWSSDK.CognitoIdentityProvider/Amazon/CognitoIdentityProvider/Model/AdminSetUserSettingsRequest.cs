using System.Collections.Generic;
using Il2CppDummyDll;

namespace Amazon.CognitoIdentityProvider.Model
{
	[Token(Token = "0x2000059")]
	public class AdminSetUserSettingsRequest : AmazonCognitoIdentityProviderRequest
	{
		[Token(Token = "0x40000EC")]
		[FieldOffset(Offset = "0x30")]
		private List<MFAOptionType> _mfaOptions;

		[Token(Token = "0x40000ED")]
		[FieldOffset(Offset = "0x38")]
		private string _username;

		[Token(Token = "0x40000EE")]
		[FieldOffset(Offset = "0x40")]
		private string _userPoolId;

		[Token(Token = "0x17000079")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x1C0A4", Offset = "0x1C0A4")]
		public List<MFAOptionType> MFAOptions
		{
			[Token(Token = "0x600035A")]
			[Address(RVA = "0x10BF1B4", Offset = "0x10BF1B4", VA = "0x10BF1B4")]
			get
			{
				return null;
			}
			[Token(Token = "0x600035B")]
			[Address(RVA = "0x10BF1BC", Offset = "0x10BF1BC", VA = "0x10BF1BC")]
			set
			{
			}
		}

		[Token(Token = "0x1700007A")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x1C0D8", Offset = "0x1C0D8")]
		public string Username
		{
			[Token(Token = "0x600035D")]
			[Address(RVA = "0x10BF21C", Offset = "0x10BF21C", VA = "0x10BF21C")]
			get
			{
				return null;
			}
			[Token(Token = "0x600035E")]
			[Address(RVA = "0x10BF224", Offset = "0x10BF224", VA = "0x10BF224")]
			set
			{
			}
		}

		[Token(Token = "0x1700007B")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x1C128", Offset = "0x1C128")]
		public string UserPoolId
		{
			[Token(Token = "0x6000360")]
			[Address(RVA = "0x10BF23C", Offset = "0x10BF23C", VA = "0x10BF23C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000361")]
			[Address(RVA = "0x10BF244", Offset = "0x10BF244", VA = "0x10BF244")]
			set
			{
			}
		}

		[Token(Token = "0x600035C")]
		[Address(RVA = "0x10BF1C4", Offset = "0x10BF1C4", VA = "0x10BF1C4")]
		internal bool IsSetMFAOptions()
		{
			return default;
		}

		[Token(Token = "0x600035F")]
		[Address(RVA = "0x10BF22C", Offset = "0x10BF22C", VA = "0x10BF22C")]
		internal bool IsSetUsername()
		{
			return default;
		}

		[Token(Token = "0x6000362")]
		[Address(RVA = "0x10BF24C", Offset = "0x10BF24C", VA = "0x10BF24C")]
		internal bool IsSetUserPoolId()
		{
			return default;
		}

		[Token(Token = "0x6000363")]
		[Address(RVA = "0x10BF25C", Offset = "0x10BF25C", VA = "0x10BF25C")]
		public AdminSetUserSettingsRequest()
		{
		}
	}
}
