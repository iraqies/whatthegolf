using System.Collections.Generic;
using Amazon.Runtime.Internal.Auth;
using Il2CppDummyDll;

namespace Amazon.CognitoIdentityProvider.Model
{
	[Token(Token = "0x20000B5")]
	public class ForgotPasswordRequest : AmazonCognitoIdentityProviderRequest
	{
		[Token(Token = "0x40001C1")]
		[FieldOffset(Offset = "0x30")]
		private AnalyticsMetadataType _analyticsMetadata;

		[Token(Token = "0x40001C2")]
		[FieldOffset(Offset = "0x38")]
		private string _clientId;

		[Token(Token = "0x40001C3")]
		[FieldOffset(Offset = "0x40")]
		private Dictionary<string, string> _clientMetadata;

		[Token(Token = "0x40001C4")]
		[FieldOffset(Offset = "0x48")]
		private string _secretHash;

		[Token(Token = "0x40001C5")]
		[FieldOffset(Offset = "0x50")]
		private UserContextDataType _userContextData;

		[Token(Token = "0x40001C6")]
		[FieldOffset(Offset = "0x58")]
		private string _username;

		[Token(Token = "0x1700014E")]
		public AnalyticsMetadataType AnalyticsMetadata
		{
			[Token(Token = "0x6000656")]
			[Address(RVA = "0x11152D4", Offset = "0x11152D4", VA = "0x11152D4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000657")]
			[Address(RVA = "0x11152DC", Offset = "0x11152DC", VA = "0x11152DC")]
			set
			{
			}
		}

		[Token(Token = "0x1700014F")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x1E250", Offset = "0x1E250")]
		public string ClientId
		{
			[Token(Token = "0x6000659")]
			[Address(RVA = "0x11152F4", Offset = "0x11152F4", VA = "0x11152F4")]
			get
			{
				return null;
			}
			[Token(Token = "0x600065A")]
			[Address(RVA = "0x11152FC", Offset = "0x11152FC", VA = "0x11152FC")]
			set
			{
			}
		}

		[Token(Token = "0x17000150")]
		public Dictionary<string, string> ClientMetadata
		{
			[Token(Token = "0x600065C")]
			[Address(RVA = "0x1115314", Offset = "0x1115314", VA = "0x1115314")]
			get
			{
				return null;
			}
			[Token(Token = "0x600065D")]
			[Address(RVA = "0x111531C", Offset = "0x111531C", VA = "0x111531C")]
			set
			{
			}
		}

		[Token(Token = "0x17000151")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x1E2A0", Offset = "0x1E2A0")]
		public string SecretHash
		{
			[Token(Token = "0x600065F")]
			[Address(RVA = "0x1115380", Offset = "0x1115380", VA = "0x1115380")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000660")]
			[Address(RVA = "0x1115388", Offset = "0x1115388", VA = "0x1115388")]
			set
			{
			}
		}

		[Token(Token = "0x17000152")]
		public UserContextDataType UserContextData
		{
			[Token(Token = "0x6000662")]
			[Address(RVA = "0x11153A0", Offset = "0x11153A0", VA = "0x11153A0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000663")]
			[Address(RVA = "0x11153A8", Offset = "0x11153A8", VA = "0x11153A8")]
			set
			{
			}
		}

		[Token(Token = "0x17000153")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x1E2E8", Offset = "0x1E2E8")]
		public string Username
		{
			[Token(Token = "0x6000665")]
			[Address(RVA = "0x11153C0", Offset = "0x11153C0", VA = "0x11153C0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000666")]
			[Address(RVA = "0x11153C8", Offset = "0x11153C8", VA = "0x11153C8")]
			set
			{
			}
		}

		[Token(Token = "0x6000658")]
		[Address(RVA = "0x11152E4", Offset = "0x11152E4", VA = "0x11152E4")]
		internal bool IsSetAnalyticsMetadata()
		{
			return default;
		}

		[Token(Token = "0x600065B")]
		[Address(RVA = "0x1115304", Offset = "0x1115304", VA = "0x1115304")]
		internal bool IsSetClientId()
		{
			return default;
		}

		[Token(Token = "0x600065E")]
		[Address(RVA = "0x1115324", Offset = "0x1115324", VA = "0x1115324")]
		internal bool IsSetClientMetadata()
		{
			return default;
		}

		[Token(Token = "0x6000661")]
		[Address(RVA = "0x1115390", Offset = "0x1115390", VA = "0x1115390")]
		internal bool IsSetSecretHash()
		{
			return default;
		}

		[Token(Token = "0x6000664")]
		[Address(RVA = "0x11153B0", Offset = "0x11153B0", VA = "0x11153B0")]
		internal bool IsSetUserContextData()
		{
			return default;
		}

		[Token(Token = "0x6000667")]
		[Address(RVA = "0x11153D0", Offset = "0x11153D0", VA = "0x11153D0")]
		internal bool IsSetUsername()
		{
			return default;
		}

		[Token(Token = "0x6000668")]
		[Address(RVA = "0x11153E0", Offset = "0x11153E0", VA = "0x11153E0", Slot = "13")]
		protected override AbstractAWSSigner CreateSigner()
		{
			return null;
		}

		[Token(Token = "0x6000669")]
		[Address(RVA = "0x1115438", Offset = "0x1115438", VA = "0x1115438")]
		public ForgotPasswordRequest()
		{
		}
	}
}
