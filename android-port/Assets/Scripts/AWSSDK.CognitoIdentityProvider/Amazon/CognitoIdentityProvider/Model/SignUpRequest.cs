using System.Collections.Generic;
using Amazon.Runtime.Internal.Auth;
using Il2CppDummyDll;

namespace Amazon.CognitoIdentityProvider.Model
{
	[Token(Token = "0x2000113")]
	public class SignUpRequest : AmazonCognitoIdentityProviderRequest
	{
		[Token(Token = "0x400029D")]
		[FieldOffset(Offset = "0x30")]
		private AnalyticsMetadataType _analyticsMetadata;

		[Token(Token = "0x400029E")]
		[FieldOffset(Offset = "0x38")]
		private string _clientId;

		[Token(Token = "0x400029F")]
		[FieldOffset(Offset = "0x40")]
		private Dictionary<string, string> _clientMetadata;

		[Token(Token = "0x40002A0")]
		[FieldOffset(Offset = "0x48")]
		private string _password;

		[Token(Token = "0x40002A1")]
		[FieldOffset(Offset = "0x50")]
		private string _secretHash;

		[Token(Token = "0x40002A2")]
		[FieldOffset(Offset = "0x58")]
		private List<AttributeType> _userAttributes;

		[Token(Token = "0x40002A3")]
		[FieldOffset(Offset = "0x60")]
		private UserContextDataType _userContextData;

		[Token(Token = "0x40002A4")]
		[FieldOffset(Offset = "0x68")]
		private string _username;

		[Token(Token = "0x40002A5")]
		[FieldOffset(Offset = "0x70")]
		private List<AttributeType> _validationData;

		[Token(Token = "0x1700022A")]
		public AnalyticsMetadataType AnalyticsMetadata
		{
			[Token(Token = "0x6000993")]
			[Address(RVA = "0x1153AD0", Offset = "0x1153AD0", VA = "0x1153AD0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000994")]
			[Address(RVA = "0x1153AD8", Offset = "0x1153AD8", VA = "0x1153AD8")]
			set
			{
			}
		}

		[Token(Token = "0x1700022B")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x204A4", Offset = "0x204A4")]
		public string ClientId
		{
			[Token(Token = "0x6000996")]
			[Address(RVA = "0x1153AF0", Offset = "0x1153AF0", VA = "0x1153AF0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000997")]
			[Address(RVA = "0x1153AF8", Offset = "0x1153AF8", VA = "0x1153AF8")]
			set
			{
			}
		}

		[Token(Token = "0x1700022C")]
		public Dictionary<string, string> ClientMetadata
		{
			[Token(Token = "0x6000999")]
			[Address(RVA = "0x1153B10", Offset = "0x1153B10", VA = "0x1153B10")]
			get
			{
				return null;
			}
			[Token(Token = "0x600099A")]
			[Address(RVA = "0x1153B18", Offset = "0x1153B18", VA = "0x1153B18")]
			set
			{
			}
		}

		[Token(Token = "0x1700022D")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x204F4", Offset = "0x204F4")]
		public string Password
		{
			[Token(Token = "0x600099C")]
			[Address(RVA = "0x1153B7C", Offset = "0x1153B7C", VA = "0x1153B7C")]
			get
			{
				return null;
			}
			[Token(Token = "0x600099D")]
			[Address(RVA = "0x1153B84", Offset = "0x1153B84", VA = "0x1153B84")]
			set
			{
			}
		}

		[Token(Token = "0x1700022E")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x20544", Offset = "0x20544")]
		public string SecretHash
		{
			[Token(Token = "0x600099F")]
			[Address(RVA = "0x1153B9C", Offset = "0x1153B9C", VA = "0x1153B9C")]
			get
			{
				return null;
			}
			[Token(Token = "0x60009A0")]
			[Address(RVA = "0x1153BA4", Offset = "0x1153BA4", VA = "0x1153BA4")]
			set
			{
			}
		}

		[Token(Token = "0x1700022F")]
		public List<AttributeType> UserAttributes
		{
			[Token(Token = "0x60009A2")]
			[Address(RVA = "0x1153BBC", Offset = "0x1153BBC", VA = "0x1153BBC")]
			get
			{
				return null;
			}
			[Token(Token = "0x60009A3")]
			[Address(RVA = "0x1153BC4", Offset = "0x1153BC4", VA = "0x1153BC4")]
			set
			{
			}
		}

		[Token(Token = "0x17000230")]
		public UserContextDataType UserContextData
		{
			[Token(Token = "0x60009A5")]
			[Address(RVA = "0x1153C24", Offset = "0x1153C24", VA = "0x1153C24")]
			get
			{
				return null;
			}
			[Token(Token = "0x60009A6")]
			[Address(RVA = "0x1153C2C", Offset = "0x1153C2C", VA = "0x1153C2C")]
			set
			{
			}
		}

		[Token(Token = "0x17000231")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x2058C", Offset = "0x2058C")]
		public string Username
		{
			[Token(Token = "0x60009A8")]
			[Address(RVA = "0x1153C44", Offset = "0x1153C44", VA = "0x1153C44")]
			get
			{
				return null;
			}
			[Token(Token = "0x60009A9")]
			[Address(RVA = "0x1153C4C", Offset = "0x1153C4C", VA = "0x1153C4C")]
			set
			{
			}
		}

		[Token(Token = "0x17000232")]
		public List<AttributeType> ValidationData
		{
			[Token(Token = "0x60009AB")]
			[Address(RVA = "0x1153C64", Offset = "0x1153C64", VA = "0x1153C64")]
			get
			{
				return null;
			}
			[Token(Token = "0x60009AC")]
			[Address(RVA = "0x1153C6C", Offset = "0x1153C6C", VA = "0x1153C6C")]
			set
			{
			}
		}

		[Token(Token = "0x6000995")]
		[Address(RVA = "0x1153AE0", Offset = "0x1153AE0", VA = "0x1153AE0")]
		internal bool IsSetAnalyticsMetadata()
		{
			return default;
		}

		[Token(Token = "0x6000998")]
		[Address(RVA = "0x1153B00", Offset = "0x1153B00", VA = "0x1153B00")]
		internal bool IsSetClientId()
		{
			return default;
		}

		[Token(Token = "0x600099B")]
		[Address(RVA = "0x1153B20", Offset = "0x1153B20", VA = "0x1153B20")]
		internal bool IsSetClientMetadata()
		{
			return default;
		}

		[Token(Token = "0x600099E")]
		[Address(RVA = "0x1153B8C", Offset = "0x1153B8C", VA = "0x1153B8C")]
		internal bool IsSetPassword()
		{
			return default;
		}

		[Token(Token = "0x60009A1")]
		[Address(RVA = "0x1153BAC", Offset = "0x1153BAC", VA = "0x1153BAC")]
		internal bool IsSetSecretHash()
		{
			return default;
		}

		[Token(Token = "0x60009A4")]
		[Address(RVA = "0x1153BCC", Offset = "0x1153BCC", VA = "0x1153BCC")]
		internal bool IsSetUserAttributes()
		{
			return default;
		}

		[Token(Token = "0x60009A7")]
		[Address(RVA = "0x1153C34", Offset = "0x1153C34", VA = "0x1153C34")]
		internal bool IsSetUserContextData()
		{
			return default;
		}

		[Token(Token = "0x60009AA")]
		[Address(RVA = "0x1153C54", Offset = "0x1153C54", VA = "0x1153C54")]
		internal bool IsSetUsername()
		{
			return default;
		}

		[Token(Token = "0x60009AD")]
		[Address(RVA = "0x1153C74", Offset = "0x1153C74", VA = "0x1153C74")]
		internal bool IsSetValidationData()
		{
			return default;
		}

		[Token(Token = "0x60009AE")]
		[Address(RVA = "0x1153CCC", Offset = "0x1153CCC", VA = "0x1153CCC", Slot = "13")]
		protected override AbstractAWSSigner CreateSigner()
		{
			return null;
		}

		[Token(Token = "0x60009AF")]
		[Address(RVA = "0x1153D24", Offset = "0x1153D24", VA = "0x1153D24")]
		public SignUpRequest()
		{
		}
	}
}
