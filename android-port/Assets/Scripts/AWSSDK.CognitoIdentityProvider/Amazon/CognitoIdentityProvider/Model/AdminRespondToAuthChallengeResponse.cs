using System.Collections.Generic;
using Amazon.Runtime;
using Il2CppDummyDll;

namespace Amazon.CognitoIdentityProvider.Model
{
	[Token(Token = "0x2000054")]
	public class AdminRespondToAuthChallengeResponse : AmazonWebServiceResponse
	{
		[Token(Token = "0x40000E0")]
		[FieldOffset(Offset = "0x28")]
		private AuthenticationResultType _authenticationResult;

		[Token(Token = "0x40000E1")]
		[FieldOffset(Offset = "0x30")]
		private ChallengeNameType _challengeName;

		[Token(Token = "0x40000E2")]
		[FieldOffset(Offset = "0x38")]
		private Dictionary<string, string> _challengeParameters;

		[Token(Token = "0x40000E3")]
		[FieldOffset(Offset = "0x40")]
		private string _session;

		[Token(Token = "0x1700006D")]
		public AuthenticationResultType AuthenticationResult
		{
			[Token(Token = "0x6000331")]
			[Address(RVA = "0x10BA7F4", Offset = "0x10BA7F4", VA = "0x10BA7F4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000332")]
			[Address(RVA = "0x10BA7FC", Offset = "0x10BA7FC", VA = "0x10BA7FC")]
			set
			{
			}
		}

		[Token(Token = "0x1700006E")]
		public ChallengeNameType ChallengeName
		{
			[Token(Token = "0x6000334")]
			[Address(RVA = "0x10BA814", Offset = "0x10BA814", VA = "0x10BA814")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000335")]
			[Address(RVA = "0x10BA81C", Offset = "0x10BA81C", VA = "0x10BA81C")]
			set
			{
			}
		}

		[Token(Token = "0x1700006F")]
		public Dictionary<string, string> ChallengeParameters
		{
			[Token(Token = "0x6000337")]
			[Address(RVA = "0x10BA8A0", Offset = "0x10BA8A0", VA = "0x10BA8A0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000338")]
			[Address(RVA = "0x10BA8A8", Offset = "0x10BA8A8", VA = "0x10BA8A8")]
			set
			{
			}
		}

		[Token(Token = "0x17000070")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x1BECC", Offset = "0x1BECC")]
		public string Session
		{
			[Token(Token = "0x600033A")]
			[Address(RVA = "0x10BA90C", Offset = "0x10BA90C", VA = "0x10BA90C")]
			get
			{
				return null;
			}
			[Token(Token = "0x600033B")]
			[Address(RVA = "0x10BA914", Offset = "0x10BA914", VA = "0x10BA914")]
			set
			{
			}
		}

		[Token(Token = "0x6000333")]
		[Address(RVA = "0x10BA804", Offset = "0x10BA804", VA = "0x10BA804")]
		internal bool IsSetAuthenticationResult()
		{
			return default;
		}

		[Token(Token = "0x6000336")]
		[Address(RVA = "0x10BA824", Offset = "0x10BA824", VA = "0x10BA824")]
		internal bool IsSetChallengeName()
		{
			return default;
		}

		[Token(Token = "0x6000339")]
		[Address(RVA = "0x10BA8B0", Offset = "0x10BA8B0", VA = "0x10BA8B0")]
		internal bool IsSetChallengeParameters()
		{
			return default;
		}

		[Token(Token = "0x600033C")]
		[Address(RVA = "0x10BA91C", Offset = "0x10BA91C", VA = "0x10BA91C")]
		internal bool IsSetSession()
		{
			return default;
		}

		[Token(Token = "0x600033D")]
		[Address(RVA = "0x10BA92C", Offset = "0x10BA92C", VA = "0x10BA92C")]
		public AdminRespondToAuthChallengeResponse()
		{
		}
	}
}
