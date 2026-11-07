using System.Collections.Generic;
using Amazon.Runtime.Internal.Auth;
using Il2CppDummyDll;

namespace Amazon.CognitoIdentityProvider.Model
{
	[Token(Token = "0x2000076")]
	public class ConfirmForgotPasswordRequest : AmazonCognitoIdentityProviderRequest
	{
		[Token(Token = "0x4000126")]
		[FieldOffset(Offset = "0x30")]
		private AnalyticsMetadataType _analyticsMetadata;

		[Token(Token = "0x4000127")]
		[FieldOffset(Offset = "0x38")]
		private string _clientId;

		[Token(Token = "0x4000128")]
		[FieldOffset(Offset = "0x40")]
		private Dictionary<string, string> _clientMetadata;

		[Token(Token = "0x4000129")]
		[FieldOffset(Offset = "0x48")]
		private string _confirmationCode;

		[Token(Token = "0x400012A")]
		[FieldOffset(Offset = "0x50")]
		private string _password;

		[Token(Token = "0x400012B")]
		[FieldOffset(Offset = "0x58")]
		private string _secretHash;

		[Token(Token = "0x400012C")]
		[FieldOffset(Offset = "0x60")]
		private UserContextDataType _userContextData;

		[Token(Token = "0x400012D")]
		[FieldOffset(Offset = "0x68")]
		private string _username;

		[Token(Token = "0x170000B3")]
		public AnalyticsMetadataType AnalyticsMetadata
		{
			[Token(Token = "0x6000436")]
			[Address(RVA = "0x10E6928", Offset = "0x10E6928", VA = "0x10E6928")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000437")]
			[Address(RVA = "0x10E6930", Offset = "0x10E6930", VA = "0x10E6930")]
			set
			{
			}
		}

		[Token(Token = "0x170000B4")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x1C958", Offset = "0x1C958")]
		public string ClientId
		{
			[Token(Token = "0x6000439")]
			[Address(RVA = "0x10E6948", Offset = "0x10E6948", VA = "0x10E6948")]
			get
			{
				return null;
			}
			[Token(Token = "0x600043A")]
			[Address(RVA = "0x10E6950", Offset = "0x10E6950", VA = "0x10E6950")]
			set
			{
			}
		}

		[Token(Token = "0x170000B5")]
		public Dictionary<string, string> ClientMetadata
		{
			[Token(Token = "0x600043C")]
			[Address(RVA = "0x10E6968", Offset = "0x10E6968", VA = "0x10E6968")]
			get
			{
				return null;
			}
			[Token(Token = "0x600043D")]
			[Address(RVA = "0x10E6970", Offset = "0x10E6970", VA = "0x10E6970")]
			set
			{
			}
		}

		[Token(Token = "0x170000B6")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x1C9A8", Offset = "0x1C9A8")]
		public string ConfirmationCode
		{
			[Token(Token = "0x600043F")]
			[Address(RVA = "0x10E69D4", Offset = "0x10E69D4", VA = "0x10E69D4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000440")]
			[Address(RVA = "0x10E69DC", Offset = "0x10E69DC", VA = "0x10E69DC")]
			set
			{
			}
		}

		[Token(Token = "0x170000B7")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x1C9F8", Offset = "0x1C9F8")]
		public string Password
		{
			[Token(Token = "0x6000442")]
			[Address(RVA = "0x10E69F4", Offset = "0x10E69F4", VA = "0x10E69F4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000443")]
			[Address(RVA = "0x10E69FC", Offset = "0x10E69FC", VA = "0x10E69FC")]
			set
			{
			}
		}

		[Token(Token = "0x170000B8")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x1CA48", Offset = "0x1CA48")]
		public string SecretHash
		{
			[Token(Token = "0x6000445")]
			[Address(RVA = "0x10E6A14", Offset = "0x10E6A14", VA = "0x10E6A14")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000446")]
			[Address(RVA = "0x10E6A1C", Offset = "0x10E6A1C", VA = "0x10E6A1C")]
			set
			{
			}
		}

		[Token(Token = "0x170000B9")]
		public UserContextDataType UserContextData
		{
			[Token(Token = "0x6000448")]
			[Address(RVA = "0x10E6A34", Offset = "0x10E6A34", VA = "0x10E6A34")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000449")]
			[Address(RVA = "0x10E6A3C", Offset = "0x10E6A3C", VA = "0x10E6A3C")]
			set
			{
			}
		}

		[Token(Token = "0x170000BA")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x1CA90", Offset = "0x1CA90")]
		public string Username
		{
			[Token(Token = "0x600044B")]
			[Address(RVA = "0x10E6A54", Offset = "0x10E6A54", VA = "0x10E6A54")]
			get
			{
				return null;
			}
			[Token(Token = "0x600044C")]
			[Address(RVA = "0x10E6A5C", Offset = "0x10E6A5C", VA = "0x10E6A5C")]
			set
			{
			}
		}

		[Token(Token = "0x6000438")]
		[Address(RVA = "0x10E6938", Offset = "0x10E6938", VA = "0x10E6938")]
		internal bool IsSetAnalyticsMetadata()
		{
			return default;
		}

		[Token(Token = "0x600043B")]
		[Address(RVA = "0x10E6958", Offset = "0x10E6958", VA = "0x10E6958")]
		internal bool IsSetClientId()
		{
			return default;
		}

		[Token(Token = "0x600043E")]
		[Address(RVA = "0x10E6978", Offset = "0x10E6978", VA = "0x10E6978")]
		internal bool IsSetClientMetadata()
		{
			return default;
		}

		[Token(Token = "0x6000441")]
		[Address(RVA = "0x10E69E4", Offset = "0x10E69E4", VA = "0x10E69E4")]
		internal bool IsSetConfirmationCode()
		{
			return default;
		}

		[Token(Token = "0x6000444")]
		[Address(RVA = "0x10E6A04", Offset = "0x10E6A04", VA = "0x10E6A04")]
		internal bool IsSetPassword()
		{
			return default;
		}

		[Token(Token = "0x6000447")]
		[Address(RVA = "0x10E6A24", Offset = "0x10E6A24", VA = "0x10E6A24")]
		internal bool IsSetSecretHash()
		{
			return default;
		}

		[Token(Token = "0x600044A")]
		[Address(RVA = "0x10E6A44", Offset = "0x10E6A44", VA = "0x10E6A44")]
		internal bool IsSetUserContextData()
		{
			return default;
		}

		[Token(Token = "0x600044D")]
		[Address(RVA = "0x10E6A64", Offset = "0x10E6A64", VA = "0x10E6A64")]
		internal bool IsSetUsername()
		{
			return default;
		}

		[Token(Token = "0x600044E")]
		[Address(RVA = "0x10E6A74", Offset = "0x10E6A74", VA = "0x10E6A74", Slot = "13")]
		protected override AbstractAWSSigner CreateSigner()
		{
			return null;
		}

		[Token(Token = "0x600044F")]
		[Address(RVA = "0x10E6ACC", Offset = "0x10E6ACC", VA = "0x10E6ACC")]
		public ConfirmForgotPasswordRequest()
		{
		}
	}
}
