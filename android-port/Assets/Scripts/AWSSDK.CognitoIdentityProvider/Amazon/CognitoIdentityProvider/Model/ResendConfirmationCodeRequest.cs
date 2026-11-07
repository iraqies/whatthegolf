using System.Collections.Generic;
using Amazon.Runtime.Internal.Auth;
using Il2CppDummyDll;

namespace Amazon.CognitoIdentityProvider.Model
{
	[Token(Token = "0x20000FE")]
	public class ResendConfirmationCodeRequest : AmazonCognitoIdentityProviderRequest
	{
		[Token(Token = "0x400025F")]
		[FieldOffset(Offset = "0x30")]
		private AnalyticsMetadataType _analyticsMetadata;

		[Token(Token = "0x4000260")]
		[FieldOffset(Offset = "0x38")]
		private string _clientId;

		[Token(Token = "0x4000261")]
		[FieldOffset(Offset = "0x40")]
		private Dictionary<string, string> _clientMetadata;

		[Token(Token = "0x4000262")]
		[FieldOffset(Offset = "0x48")]
		private string _secretHash;

		[Token(Token = "0x4000263")]
		[FieldOffset(Offset = "0x50")]
		private UserContextDataType _userContextData;

		[Token(Token = "0x4000264")]
		[FieldOffset(Offset = "0x58")]
		private string _username;

		[Token(Token = "0x170001EC")]
		public AnalyticsMetadataType AnalyticsMetadata
		{
			[Token(Token = "0x60008B9")]
			[Address(RVA = "0x11428F4", Offset = "0x11428F4", VA = "0x11428F4")]
			get
			{
				return null;
			}
			[Token(Token = "0x60008BA")]
			[Address(RVA = "0x11428FC", Offset = "0x11428FC", VA = "0x11428FC")]
			set
			{
			}
		}

		[Token(Token = "0x170001ED")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x1FD2C", Offset = "0x1FD2C")]
		public string ClientId
		{
			[Token(Token = "0x60008BC")]
			[Address(RVA = "0x1142914", Offset = "0x1142914", VA = "0x1142914")]
			get
			{
				return null;
			}
			[Token(Token = "0x60008BD")]
			[Address(RVA = "0x114291C", Offset = "0x114291C", VA = "0x114291C")]
			set
			{
			}
		}

		[Token(Token = "0x170001EE")]
		public Dictionary<string, string> ClientMetadata
		{
			[Token(Token = "0x60008BF")]
			[Address(RVA = "0x1142934", Offset = "0x1142934", VA = "0x1142934")]
			get
			{
				return null;
			}
			[Token(Token = "0x60008C0")]
			[Address(RVA = "0x114293C", Offset = "0x114293C", VA = "0x114293C")]
			set
			{
			}
		}

		[Token(Token = "0x170001EF")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x1FD7C", Offset = "0x1FD7C")]
		public string SecretHash
		{
			[Token(Token = "0x60008C2")]
			[Address(RVA = "0x11429A0", Offset = "0x11429A0", VA = "0x11429A0")]
			get
			{
				return null;
			}
			[Token(Token = "0x60008C3")]
			[Address(RVA = "0x11429A8", Offset = "0x11429A8", VA = "0x11429A8")]
			set
			{
			}
		}

		[Token(Token = "0x170001F0")]
		public UserContextDataType UserContextData
		{
			[Token(Token = "0x60008C5")]
			[Address(RVA = "0x11429C0", Offset = "0x11429C0", VA = "0x11429C0")]
			get
			{
				return null;
			}
			[Token(Token = "0x60008C6")]
			[Address(RVA = "0x11429C8", Offset = "0x11429C8", VA = "0x11429C8")]
			set
			{
			}
		}

		[Token(Token = "0x170001F1")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x1FDC4", Offset = "0x1FDC4")]
		public string Username
		{
			[Token(Token = "0x60008C8")]
			[Address(RVA = "0x11429E0", Offset = "0x11429E0", VA = "0x11429E0")]
			get
			{
				return null;
			}
			[Token(Token = "0x60008C9")]
			[Address(RVA = "0x11429E8", Offset = "0x11429E8", VA = "0x11429E8")]
			set
			{
			}
		}

		[Token(Token = "0x60008BB")]
		[Address(RVA = "0x1142904", Offset = "0x1142904", VA = "0x1142904")]
		internal bool IsSetAnalyticsMetadata()
		{
			return default;
		}

		[Token(Token = "0x60008BE")]
		[Address(RVA = "0x1142924", Offset = "0x1142924", VA = "0x1142924")]
		internal bool IsSetClientId()
		{
			return default;
		}

		[Token(Token = "0x60008C1")]
		[Address(RVA = "0x1142944", Offset = "0x1142944", VA = "0x1142944")]
		internal bool IsSetClientMetadata()
		{
			return default;
		}

		[Token(Token = "0x60008C4")]
		[Address(RVA = "0x11429B0", Offset = "0x11429B0", VA = "0x11429B0")]
		internal bool IsSetSecretHash()
		{
			return default;
		}

		[Token(Token = "0x60008C7")]
		[Address(RVA = "0x11429D0", Offset = "0x11429D0", VA = "0x11429D0")]
		internal bool IsSetUserContextData()
		{
			return default;
		}

		[Token(Token = "0x60008CA")]
		[Address(RVA = "0x11429F0", Offset = "0x11429F0", VA = "0x11429F0")]
		internal bool IsSetUsername()
		{
			return default;
		}

		[Token(Token = "0x60008CB")]
		[Address(RVA = "0x1142A00", Offset = "0x1142A00", VA = "0x1142A00", Slot = "13")]
		protected override AbstractAWSSigner CreateSigner()
		{
			return null;
		}

		[Token(Token = "0x60008CC")]
		[Address(RVA = "0x1142A58", Offset = "0x1142A58", VA = "0x1142A58")]
		public ResendConfirmationCodeRequest()
		{
		}
	}
}
