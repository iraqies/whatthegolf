using System.Collections.Generic;
using Amazon.Runtime;
using Il2CppDummyDll;

namespace Amazon.CognitoIdentityProvider.Model
{
	[Token(Token = "0x2000104")]
	public class RespondToAuthChallengeResponse : AmazonWebServiceResponse
	{
		[Token(Token = "0x4000273")]
		[FieldOffset(Offset = "0x28")]
		private AuthenticationResultType _authenticationResult;

		[Token(Token = "0x4000274")]
		[FieldOffset(Offset = "0x30")]
		private ChallengeNameType _challengeName;

		[Token(Token = "0x4000275")]
		[FieldOffset(Offset = "0x38")]
		private Dictionary<string, string> _challengeParameters;

		[Token(Token = "0x4000276")]
		[FieldOffset(Offset = "0x40")]
		private string _session;

		[Token(Token = "0x17000200")]
		public AuthenticationResultType AuthenticationResult
		{
			[Token(Token = "0x6000901")]
			[Address(RVA = "0x1146CB8", Offset = "0x1146CB8", VA = "0x1146CB8")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000902")]
			[Address(RVA = "0x1146CC0", Offset = "0x1146CC0", VA = "0x1146CC0")]
			set
			{
			}
		}

		[Token(Token = "0x17000201")]
		public ChallengeNameType ChallengeName
		{
			[Token(Token = "0x6000904")]
			[Address(RVA = "0x1146CD8", Offset = "0x1146CD8", VA = "0x1146CD8")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000905")]
			[Address(RVA = "0x1146CE0", Offset = "0x1146CE0", VA = "0x1146CE0")]
			set
			{
			}
		}

		[Token(Token = "0x17000202")]
		public Dictionary<string, string> ChallengeParameters
		{
			[Token(Token = "0x6000907")]
			[Address(RVA = "0x1146D64", Offset = "0x1146D64", VA = "0x1146D64")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000908")]
			[Address(RVA = "0x1146D6C", Offset = "0x1146D6C", VA = "0x1146D6C")]
			set
			{
			}
		}

		[Token(Token = "0x17000203")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x20090", Offset = "0x20090")]
		public string Session
		{
			[Token(Token = "0x600090A")]
			[Address(RVA = "0x1146DD0", Offset = "0x1146DD0", VA = "0x1146DD0")]
			get
			{
				return null;
			}
			[Token(Token = "0x600090B")]
			[Address(RVA = "0x1146DD8", Offset = "0x1146DD8", VA = "0x1146DD8")]
			set
			{
			}
		}

		[Token(Token = "0x6000903")]
		[Address(RVA = "0x1146CC8", Offset = "0x1146CC8", VA = "0x1146CC8")]
		internal bool IsSetAuthenticationResult()
		{
			return default;
		}

		[Token(Token = "0x6000906")]
		[Address(RVA = "0x1146CE8", Offset = "0x1146CE8", VA = "0x1146CE8")]
		internal bool IsSetChallengeName()
		{
			return default;
		}

		[Token(Token = "0x6000909")]
		[Address(RVA = "0x1146D74", Offset = "0x1146D74", VA = "0x1146D74")]
		internal bool IsSetChallengeParameters()
		{
			return default;
		}

		[Token(Token = "0x600090C")]
		[Address(RVA = "0x1146DE0", Offset = "0x1146DE0", VA = "0x1146DE0")]
		internal bool IsSetSession()
		{
			return default;
		}

		[Token(Token = "0x600090D")]
		[Address(RVA = "0x1146DF0", Offset = "0x1146DF0", VA = "0x1146DF0")]
		public RespondToAuthChallengeResponse()
		{
		}
	}
}
