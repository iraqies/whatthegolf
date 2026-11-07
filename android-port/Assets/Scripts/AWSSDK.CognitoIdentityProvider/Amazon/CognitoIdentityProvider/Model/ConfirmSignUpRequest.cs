using System.Collections.Generic;
using Amazon.Runtime.Internal.Auth;
using Il2CppDummyDll;

namespace Amazon.CognitoIdentityProvider.Model
{
	[Token(Token = "0x2000078")]
	public class ConfirmSignUpRequest : AmazonCognitoIdentityProviderRequest
	{
		[Token(Token = "0x400012E")]
		[FieldOffset(Offset = "0x30")]
		private AnalyticsMetadataType _analyticsMetadata;

		[Token(Token = "0x400012F")]
		[FieldOffset(Offset = "0x38")]
		private string _clientId;

		[Token(Token = "0x4000130")]
		[FieldOffset(Offset = "0x40")]
		private Dictionary<string, string> _clientMetadata;

		[Token(Token = "0x4000131")]
		[FieldOffset(Offset = "0x48")]
		private string _confirmationCode;

		[Token(Token = "0x4000132")]
		[FieldOffset(Offset = "0x50")]
		private bool? _forceAliasCreation;

		[Token(Token = "0x4000133")]
		[FieldOffset(Offset = "0x58")]
		private string _secretHash;

		[Token(Token = "0x4000134")]
		[FieldOffset(Offset = "0x60")]
		private UserContextDataType _userContextData;

		[Token(Token = "0x4000135")]
		[FieldOffset(Offset = "0x68")]
		private string _username;

		[Token(Token = "0x170000BB")]
		public AnalyticsMetadataType AnalyticsMetadata
		{
			[Token(Token = "0x6000451")]
			[Address(RVA = "0x10E8BEC", Offset = "0x10E8BEC", VA = "0x10E8BEC")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000452")]
			[Address(RVA = "0x10E8BF4", Offset = "0x10E8BF4", VA = "0x10E8BF4")]
			set
			{
			}
		}

		[Token(Token = "0x170000BC")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x1CAE0", Offset = "0x1CAE0")]
		public string ClientId
		{
			[Token(Token = "0x6000454")]
			[Address(RVA = "0x10E8C0C", Offset = "0x10E8C0C", VA = "0x10E8C0C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000455")]
			[Address(RVA = "0x10E8C14", Offset = "0x10E8C14", VA = "0x10E8C14")]
			set
			{
			}
		}

		[Token(Token = "0x170000BD")]
		public Dictionary<string, string> ClientMetadata
		{
			[Token(Token = "0x6000457")]
			[Address(RVA = "0x10E8C2C", Offset = "0x10E8C2C", VA = "0x10E8C2C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000458")]
			[Address(RVA = "0x10E8C34", Offset = "0x10E8C34", VA = "0x10E8C34")]
			set
			{
			}
		}

		[Token(Token = "0x170000BE")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x1CB30", Offset = "0x1CB30")]
		public string ConfirmationCode
		{
			[Token(Token = "0x600045A")]
			[Address(RVA = "0x10E8C98", Offset = "0x10E8C98", VA = "0x10E8C98")]
			get
			{
				return null;
			}
			[Token(Token = "0x600045B")]
			[Address(RVA = "0x10E8CA0", Offset = "0x10E8CA0", VA = "0x10E8CA0")]
			set
			{
			}
		}

		[Token(Token = "0x170000BF")]
		public bool ForceAliasCreation
		{
			[Token(Token = "0x600045D")]
			[Address(RVA = "0x10E8CB8", Offset = "0x10E8CB8", VA = "0x10E8CB8")]
			get
			{
				return default;
			}
			[Token(Token = "0x600045E")]
			[Address(RVA = "0x10E8CF8", Offset = "0x10E8CF8", VA = "0x10E8CF8")]
			set
			{
			}
		}

		[Token(Token = "0x170000C0")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x1CB80", Offset = "0x1CB80")]
		public string SecretHash
		{
			[Token(Token = "0x6000460")]
			[Address(RVA = "0x10E8DAC", Offset = "0x10E8DAC", VA = "0x10E8DAC")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000461")]
			[Address(RVA = "0x10E8DB4", Offset = "0x10E8DB4", VA = "0x10E8DB4")]
			set
			{
			}
		}

		[Token(Token = "0x170000C1")]
		public UserContextDataType UserContextData
		{
			[Token(Token = "0x6000463")]
			[Address(RVA = "0x10E8DCC", Offset = "0x10E8DCC", VA = "0x10E8DCC")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000464")]
			[Address(RVA = "0x10E8DD4", Offset = "0x10E8DD4", VA = "0x10E8DD4")]
			set
			{
			}
		}

		[Token(Token = "0x170000C2")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x1CBC8", Offset = "0x1CBC8")]
		public string Username
		{
			[Token(Token = "0x6000466")]
			[Address(RVA = "0x10E8DEC", Offset = "0x10E8DEC", VA = "0x10E8DEC")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000467")]
			[Address(RVA = "0x10E8DF4", Offset = "0x10E8DF4", VA = "0x10E8DF4")]
			set
			{
			}
		}

		[Token(Token = "0x6000453")]
		[Address(RVA = "0x10E8BFC", Offset = "0x10E8BFC", VA = "0x10E8BFC")]
		internal bool IsSetAnalyticsMetadata()
		{
			return default;
		}

		[Token(Token = "0x6000456")]
		[Address(RVA = "0x10E8C1C", Offset = "0x10E8C1C", VA = "0x10E8C1C")]
		internal bool IsSetClientId()
		{
			return default;
		}

		[Token(Token = "0x6000459")]
		[Address(RVA = "0x10E8C3C", Offset = "0x10E8C3C", VA = "0x10E8C3C")]
		internal bool IsSetClientMetadata()
		{
			return default;
		}

		[Token(Token = "0x600045C")]
		[Address(RVA = "0x10E8CA8", Offset = "0x10E8CA8", VA = "0x10E8CA8")]
		internal bool IsSetConfirmationCode()
		{
			return default;
		}

		[Token(Token = "0x600045F")]
		[Address(RVA = "0x10E8D6C", Offset = "0x10E8D6C", VA = "0x10E8D6C")]
		internal bool IsSetForceAliasCreation()
		{
			return default;
		}

		[Token(Token = "0x6000462")]
		[Address(RVA = "0x10E8DBC", Offset = "0x10E8DBC", VA = "0x10E8DBC")]
		internal bool IsSetSecretHash()
		{
			return default;
		}

		[Token(Token = "0x6000465")]
		[Address(RVA = "0x10E8DDC", Offset = "0x10E8DDC", VA = "0x10E8DDC")]
		internal bool IsSetUserContextData()
		{
			return default;
		}

		[Token(Token = "0x6000468")]
		[Address(RVA = "0x10E8DFC", Offset = "0x10E8DFC", VA = "0x10E8DFC")]
		internal bool IsSetUsername()
		{
			return default;
		}

		[Token(Token = "0x6000469")]
		[Address(RVA = "0x10E8E0C", Offset = "0x10E8E0C", VA = "0x10E8E0C", Slot = "13")]
		protected override AbstractAWSSigner CreateSigner()
		{
			return null;
		}

		[Token(Token = "0x600046A")]
		[Address(RVA = "0x10E8E64", Offset = "0x10E8E64", VA = "0x10E8E64")]
		public ConfirmSignUpRequest()
		{
		}
	}
}
