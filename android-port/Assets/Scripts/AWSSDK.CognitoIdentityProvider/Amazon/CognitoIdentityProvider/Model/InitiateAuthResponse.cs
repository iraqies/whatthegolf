using System.Collections.Generic;
using Amazon.Runtime;
using Il2CppDummyDll;

namespace Amazon.CognitoIdentityProvider.Model
{
	[Token(Token = "0x20000D0")]
	public class InitiateAuthResponse : AmazonWebServiceResponse
	{
		[Token(Token = "0x40001FF")]
		[FieldOffset(Offset = "0x28")]
		private AuthenticationResultType _authenticationResult;

		[Token(Token = "0x4000200")]
		[FieldOffset(Offset = "0x30")]
		private ChallengeNameType _challengeName;

		[Token(Token = "0x4000201")]
		[FieldOffset(Offset = "0x38")]
		private Dictionary<string, string> _challengeParameters;

		[Token(Token = "0x4000202")]
		[FieldOffset(Offset = "0x40")]
		private string _session;

		[Token(Token = "0x1700018C")]
		public AuthenticationResultType AuthenticationResult
		{
			[Token(Token = "0x6000733")]
			[Address(RVA = "0x1129AFC", Offset = "0x1129AFC", VA = "0x1129AFC")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000734")]
			[Address(RVA = "0x1129B04", Offset = "0x1129B04", VA = "0x1129B04")]
			set
			{
			}
		}

		[Token(Token = "0x1700018D")]
		public ChallengeNameType ChallengeName
		{
			[Token(Token = "0x6000736")]
			[Address(RVA = "0x1129B1C", Offset = "0x1129B1C", VA = "0x1129B1C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000737")]
			[Address(RVA = "0x1129B24", Offset = "0x1129B24", VA = "0x1129B24")]
			set
			{
			}
		}

		[Token(Token = "0x1700018E")]
		public Dictionary<string, string> ChallengeParameters
		{
			[Token(Token = "0x6000739")]
			[Address(RVA = "0x1129BA8", Offset = "0x1129BA8", VA = "0x1129BA8")]
			get
			{
				return null;
			}
			[Token(Token = "0x600073A")]
			[Address(RVA = "0x1129BB0", Offset = "0x1129BB0", VA = "0x1129BB0")]
			set
			{
			}
		}

		[Token(Token = "0x1700018F")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x1EB48", Offset = "0x1EB48")]
		public string Session
		{
			[Token(Token = "0x600073C")]
			[Address(RVA = "0x1129C14", Offset = "0x1129C14", VA = "0x1129C14")]
			get
			{
				return null;
			}
			[Token(Token = "0x600073D")]
			[Address(RVA = "0x1129C1C", Offset = "0x1129C1C", VA = "0x1129C1C")]
			set
			{
			}
		}

		[Token(Token = "0x6000735")]
		[Address(RVA = "0x1129B0C", Offset = "0x1129B0C", VA = "0x1129B0C")]
		internal bool IsSetAuthenticationResult()
		{
			return default;
		}

		[Token(Token = "0x6000738")]
		[Address(RVA = "0x1129B2C", Offset = "0x1129B2C", VA = "0x1129B2C")]
		internal bool IsSetChallengeName()
		{
			return default;
		}

		[Token(Token = "0x600073B")]
		[Address(RVA = "0x1129BB8", Offset = "0x1129BB8", VA = "0x1129BB8")]
		internal bool IsSetChallengeParameters()
		{
			return default;
		}

		[Token(Token = "0x600073E")]
		[Address(RVA = "0x1129C24", Offset = "0x1129C24", VA = "0x1129C24")]
		internal bool IsSetSession()
		{
			return default;
		}

		[Token(Token = "0x600073F")]
		[Address(RVA = "0x1129C34", Offset = "0x1129C34", VA = "0x1129C34")]
		public InitiateAuthResponse()
		{
		}
	}
}
