using System.Collections.Generic;
using Il2CppDummyDll;

namespace Amazon.CognitoIdentityProvider.Model
{
	[Token(Token = "0x2000053")]
	public class AdminRespondToAuthChallengeRequest : AmazonCognitoIdentityProviderRequest
	{
		[Token(Token = "0x40000D8")]
		[FieldOffset(Offset = "0x30")]
		private AnalyticsMetadataType _analyticsMetadata;

		[Token(Token = "0x40000D9")]
		[FieldOffset(Offset = "0x38")]
		private ChallengeNameType _challengeName;

		[Token(Token = "0x40000DA")]
		[FieldOffset(Offset = "0x40")]
		private Dictionary<string, string> _challengeResponses;

		[Token(Token = "0x40000DB")]
		[FieldOffset(Offset = "0x48")]
		private string _clientId;

		[Token(Token = "0x40000DC")]
		[FieldOffset(Offset = "0x50")]
		private Dictionary<string, string> _clientMetadata;

		[Token(Token = "0x40000DD")]
		[FieldOffset(Offset = "0x58")]
		private ContextDataType _contextData;

		[Token(Token = "0x40000DE")]
		[FieldOffset(Offset = "0x60")]
		private string _session;

		[Token(Token = "0x40000DF")]
		[FieldOffset(Offset = "0x68")]
		private string _userPoolId;

		[Token(Token = "0x17000065")]
		public AnalyticsMetadataType AnalyticsMetadata
		{
			[Token(Token = "0x6000318")]
			[Address(RVA = "0x10B9338", Offset = "0x10B9338", VA = "0x10B9338")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000319")]
			[Address(RVA = "0x10B9340", Offset = "0x10B9340", VA = "0x10B9340")]
			set
			{
			}
		}

		[Token(Token = "0x17000066")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x1BDB0", Offset = "0x1BDB0")]
		public ChallengeNameType ChallengeName
		{
			[Token(Token = "0x600031B")]
			[Address(RVA = "0x10B9358", Offset = "0x10B9358", VA = "0x10B9358")]
			get
			{
				return null;
			}
			[Token(Token = "0x600031C")]
			[Address(RVA = "0x10B9360", Offset = "0x10B9360", VA = "0x10B9360")]
			set
			{
			}
		}

		[Token(Token = "0x17000067")]
		public Dictionary<string, string> ChallengeResponses
		{
			[Token(Token = "0x600031E")]
			[Address(RVA = "0x10B93E4", Offset = "0x10B93E4", VA = "0x10B93E4")]
			get
			{
				return null;
			}
			[Token(Token = "0x600031F")]
			[Address(RVA = "0x10B93EC", Offset = "0x10B93EC", VA = "0x10B93EC")]
			set
			{
			}
		}

		[Token(Token = "0x17000068")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x1BDE4", Offset = "0x1BDE4")]
		public string ClientId
		{
			[Token(Token = "0x6000321")]
			[Address(RVA = "0x10B9450", Offset = "0x10B9450", VA = "0x10B9450")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000322")]
			[Address(RVA = "0x10B9458", Offset = "0x10B9458", VA = "0x10B9458")]
			set
			{
			}
		}

		[Token(Token = "0x17000069")]
		public Dictionary<string, string> ClientMetadata
		{
			[Token(Token = "0x6000324")]
			[Address(RVA = "0x10B9470", Offset = "0x10B9470", VA = "0x10B9470")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000325")]
			[Address(RVA = "0x10B9478", Offset = "0x10B9478", VA = "0x10B9478")]
			set
			{
			}
		}

		[Token(Token = "0x1700006A")]
		public ContextDataType ContextData
		{
			[Token(Token = "0x6000327")]
			[Address(RVA = "0x10B94DC", Offset = "0x10B94DC", VA = "0x10B94DC")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000328")]
			[Address(RVA = "0x10B94E4", Offset = "0x10B94E4", VA = "0x10B94E4")]
			set
			{
			}
		}

		[Token(Token = "0x1700006B")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x1BE34", Offset = "0x1BE34")]
		public string Session
		{
			[Token(Token = "0x600032A")]
			[Address(RVA = "0x10B94FC", Offset = "0x10B94FC", VA = "0x10B94FC")]
			get
			{
				return null;
			}
			[Token(Token = "0x600032B")]
			[Address(RVA = "0x10B9504", Offset = "0x10B9504", VA = "0x10B9504")]
			set
			{
			}
		}

		[Token(Token = "0x1700006C")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x1BE7C", Offset = "0x1BE7C")]
		public string UserPoolId
		{
			[Token(Token = "0x600032D")]
			[Address(RVA = "0x10B951C", Offset = "0x10B951C", VA = "0x10B951C")]
			get
			{
				return null;
			}
			[Token(Token = "0x600032E")]
			[Address(RVA = "0x10B9524", Offset = "0x10B9524", VA = "0x10B9524")]
			set
			{
			}
		}

		[Token(Token = "0x600031A")]
		[Address(RVA = "0x10B9348", Offset = "0x10B9348", VA = "0x10B9348")]
		internal bool IsSetAnalyticsMetadata()
		{
			return default;
		}

		[Token(Token = "0x600031D")]
		[Address(RVA = "0x10B9368", Offset = "0x10B9368", VA = "0x10B9368")]
		internal bool IsSetChallengeName()
		{
			return default;
		}

		[Token(Token = "0x6000320")]
		[Address(RVA = "0x10B93F4", Offset = "0x10B93F4", VA = "0x10B93F4")]
		internal bool IsSetChallengeResponses()
		{
			return default;
		}

		[Token(Token = "0x6000323")]
		[Address(RVA = "0x10B9460", Offset = "0x10B9460", VA = "0x10B9460")]
		internal bool IsSetClientId()
		{
			return default;
		}

		[Token(Token = "0x6000326")]
		[Address(RVA = "0x10B9480", Offset = "0x10B9480", VA = "0x10B9480")]
		internal bool IsSetClientMetadata()
		{
			return default;
		}

		[Token(Token = "0x6000329")]
		[Address(RVA = "0x10B94EC", Offset = "0x10B94EC", VA = "0x10B94EC")]
		internal bool IsSetContextData()
		{
			return default;
		}

		[Token(Token = "0x600032C")]
		[Address(RVA = "0x10B950C", Offset = "0x10B950C", VA = "0x10B950C")]
		internal bool IsSetSession()
		{
			return default;
		}

		[Token(Token = "0x600032F")]
		[Address(RVA = "0x10B952C", Offset = "0x10B952C", VA = "0x10B952C")]
		internal bool IsSetUserPoolId()
		{
			return default;
		}

		[Token(Token = "0x6000330")]
		[Address(RVA = "0x10B953C", Offset = "0x10B953C", VA = "0x10B953C")]
		public AdminRespondToAuthChallengeRequest()
		{
		}
	}
}
