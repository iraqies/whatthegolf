using System.Collections.Generic;
using Amazon.Runtime.Internal.Auth;
using Il2CppDummyDll;

namespace Amazon.CognitoIdentityProvider.Model
{
	[Token(Token = "0x2000103")]
	public class RespondToAuthChallengeRequest : AmazonCognitoIdentityProviderRequest
	{
		[Token(Token = "0x400026C")]
		[FieldOffset(Offset = "0x30")]
		private AnalyticsMetadataType _analyticsMetadata;

		[Token(Token = "0x400026D")]
		[FieldOffset(Offset = "0x38")]
		private ChallengeNameType _challengeName;

		[Token(Token = "0x400026E")]
		[FieldOffset(Offset = "0x40")]
		private Dictionary<string, string> _challengeResponses;

		[Token(Token = "0x400026F")]
		[FieldOffset(Offset = "0x48")]
		private string _clientId;

		[Token(Token = "0x4000270")]
		[FieldOffset(Offset = "0x50")]
		private Dictionary<string, string> _clientMetadata;

		[Token(Token = "0x4000271")]
		[FieldOffset(Offset = "0x58")]
		private string _session;

		[Token(Token = "0x4000272")]
		[FieldOffset(Offset = "0x60")]
		private UserContextDataType _userContextData;

		[Token(Token = "0x170001F9")]
		public AnalyticsMetadataType AnalyticsMetadata
		{
			[Token(Token = "0x60008EA")]
			[Address(RVA = "0x1145830", Offset = "0x1145830", VA = "0x1145830")]
			get
			{
				return null;
			}
			[Token(Token = "0x60008EB")]
			[Address(RVA = "0x1145838", Offset = "0x1145838", VA = "0x1145838")]
			set
			{
			}
		}

		[Token(Token = "0x170001FA")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x1FFC4", Offset = "0x1FFC4")]
		public ChallengeNameType ChallengeName
		{
			[Token(Token = "0x60008ED")]
			[Address(RVA = "0x1145850", Offset = "0x1145850", VA = "0x1145850")]
			get
			{
				return null;
			}
			[Token(Token = "0x60008EE")]
			[Address(RVA = "0x1145858", Offset = "0x1145858", VA = "0x1145858")]
			set
			{
			}
		}

		[Token(Token = "0x170001FB")]
		public Dictionary<string, string> ChallengeResponses
		{
			[Token(Token = "0x60008F0")]
			[Address(RVA = "0x11458DC", Offset = "0x11458DC", VA = "0x11458DC")]
			get
			{
				return null;
			}
			[Token(Token = "0x60008F1")]
			[Address(RVA = "0x11458E4", Offset = "0x11458E4", VA = "0x11458E4")]
			set
			{
			}
		}

		[Token(Token = "0x170001FC")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x1FFF8", Offset = "0x1FFF8")]
		public string ClientId
		{
			[Token(Token = "0x60008F3")]
			[Address(RVA = "0x1145948", Offset = "0x1145948", VA = "0x1145948")]
			get
			{
				return null;
			}
			[Token(Token = "0x60008F4")]
			[Address(RVA = "0x1145950", Offset = "0x1145950", VA = "0x1145950")]
			set
			{
			}
		}

		[Token(Token = "0x170001FD")]
		public Dictionary<string, string> ClientMetadata
		{
			[Token(Token = "0x60008F6")]
			[Address(RVA = "0x1145968", Offset = "0x1145968", VA = "0x1145968")]
			get
			{
				return null;
			}
			[Token(Token = "0x60008F7")]
			[Address(RVA = "0x1145970", Offset = "0x1145970", VA = "0x1145970")]
			set
			{
			}
		}

		[Token(Token = "0x170001FE")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x20048", Offset = "0x20048")]
		public string Session
		{
			[Token(Token = "0x60008F9")]
			[Address(RVA = "0x11459D4", Offset = "0x11459D4", VA = "0x11459D4")]
			get
			{
				return null;
			}
			[Token(Token = "0x60008FA")]
			[Address(RVA = "0x11459DC", Offset = "0x11459DC", VA = "0x11459DC")]
			set
			{
			}
		}

		[Token(Token = "0x170001FF")]
		public UserContextDataType UserContextData
		{
			[Token(Token = "0x60008FC")]
			[Address(RVA = "0x11459F4", Offset = "0x11459F4", VA = "0x11459F4")]
			get
			{
				return null;
			}
			[Token(Token = "0x60008FD")]
			[Address(RVA = "0x11459FC", Offset = "0x11459FC", VA = "0x11459FC")]
			set
			{
			}
		}

		[Token(Token = "0x60008EC")]
		[Address(RVA = "0x1145840", Offset = "0x1145840", VA = "0x1145840")]
		internal bool IsSetAnalyticsMetadata()
		{
			return default;
		}

		[Token(Token = "0x60008EF")]
		[Address(RVA = "0x1145860", Offset = "0x1145860", VA = "0x1145860")]
		internal bool IsSetChallengeName()
		{
			return default;
		}

		[Token(Token = "0x60008F2")]
		[Address(RVA = "0x11458EC", Offset = "0x11458EC", VA = "0x11458EC")]
		internal bool IsSetChallengeResponses()
		{
			return default;
		}

		[Token(Token = "0x60008F5")]
		[Address(RVA = "0x1145958", Offset = "0x1145958", VA = "0x1145958")]
		internal bool IsSetClientId()
		{
			return default;
		}

		[Token(Token = "0x60008F8")]
		[Address(RVA = "0x1145978", Offset = "0x1145978", VA = "0x1145978")]
		internal bool IsSetClientMetadata()
		{
			return default;
		}

		[Token(Token = "0x60008FB")]
		[Address(RVA = "0x11459E4", Offset = "0x11459E4", VA = "0x11459E4")]
		internal bool IsSetSession()
		{
			return default;
		}

		[Token(Token = "0x60008FE")]
		[Address(RVA = "0x1145A04", Offset = "0x1145A04", VA = "0x1145A04")]
		internal bool IsSetUserContextData()
		{
			return default;
		}

		[Token(Token = "0x60008FF")]
		[Address(RVA = "0x1145A14", Offset = "0x1145A14", VA = "0x1145A14", Slot = "13")]
		protected override AbstractAWSSigner CreateSigner()
		{
			return null;
		}

		[Token(Token = "0x6000900")]
		[Address(RVA = "0x1145A6C", Offset = "0x1145A6C", VA = "0x1145A6C")]
		public RespondToAuthChallengeRequest()
		{
		}
	}
}
